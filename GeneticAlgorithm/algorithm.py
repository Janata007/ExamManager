import requests
import random as rnd
import pandas as pd
import numpy as np
import warnings
import itertools

requests.packages.urllib3.disable_warnings()
warnings.filterwarnings("ignore")


def run_algorithm():
    global ROOMS, EXAMS, STUDENTS_EXAMS, TEACHERS, TIMESLOTS, TOTALCOURSES

    ROOMS = get_rooms()
    EXAMS = get_exams()
    TOTALCOURSES = len(EXAMS)
    STUDENTS_EXAMS = get_students_and_exams()
    TEACHERS = get_teachers()
    TIMESLOTS = get_time_slots()

    best_chromosome = GeneticAlgorithm()
    return {'schedule': [gene.get_dictionary() for gene in best_chromosome.genes]}


# from the main app we get list of rooms with roomId and capacity
def get_rooms():
    roomResponse = requests.get('https://localhost:44307/api/getProstorii', verify=False)
    return pd.json_normalize(roomResponse.json())


# from the main app we get list of exams with examId,courseId and duration of 1 exam
def get_exams():
    examResponse = requests.get('https://localhost:44307/api/getIspiti', verify=False)
    return pd.json_normalize(examResponse.json())


# from the main app we get list of students and the exams they are taking
def get_students_and_exams():
    studentExamResponse = requests.get('https://localhost:44307/api/getStudentPredmeti', verify=False)
    return pd.json_normalize(studentExamResponse.json())


# from the main app we get a list of all teachers
def get_teachers():
    teachersResponse = requests.get('https://localhost:44307/api/GetAllSproveduvaci', verify=False)
    return teachersResponse.json()


# from the main app for each examId we get a list of time slots with start time
def get_time_slots():
    terminiResponse = requests.get('https://localhost:44307/api/getTerminiZaIspiti', verify=False)
    return pd.json_normalize(terminiResponse.json())


# function used to get all the students that are taking the exam
def get_students_that_take_course(ispitId):
    courseId = get_course_code_for_exam_id(ispitId)
    return STUDENTS_EXAMS.loc[STUDENTS_EXAMS['kodNaPredmet'] == courseId].iloc[:, -1].values.tolist()


# function used to convert course code to examId
def get_exam_for_course_code(kodNaPredmet):
    return EXAMS.loc[EXAMS['kodNaPredmet'] == kodNaPredmet]['ispitId'].values[0]


# opposite function of the previously defined, used to convert examId to course code
def get_course_code_for_exam_id(ispitId):
    return EXAMS.loc[EXAMS['ispitId'] == ispitId]['kodNaPredmet'].values[0]


# function used to get all examId that are taken by specific student
def get_exams_for_student(studentId):
    codes = STUDENTS_EXAMS.loc[STUDENTS_EXAMS['brojNaIndeks'] == studentId]['kodNaPredmet'].values.tolist()
    studentCourses = []
    for code in codes:
        studentCourses.append(get_exam_for_course_code(code))
    return codes


# function used for getting random exam for genes
def get_random_exam():
    exam = EXAMS.sample()
    return exam['ispitId'].values[0], exam['vremetraenje'].values[0]


# function used to get a random start time slot for an exam with examId
def get_random_time_slot_for_exam(examId):
    slots = TIMESLOTS.loc[TIMESLOTS['ispitId'] == examId]['termini'].values[0]
    return rnd.choice(slots)


# function used for getting random room for genes
def get_random_room():
    return ROOMS.sample()['prostorija'].values[0]


# function used for getting random teacherId for genes
def get_random_teacher():
    return rnd.choice(TEACHERS)


# function used for getting capacity of a room with roomId
def get_room_capacity(roomId):
    return ROOMS.loc[ROOMS['prostorija'] == roomId].iloc[0, 1]


# function used for getting random students that are taking the exam with examId in roomId
def get_random_students_for_exam(examId, roomId):
    student_in_course = get_students_that_take_course(examId)
    capacity = get_room_capacity(roomId)
    if len(student_in_course) < capacity:
        capacity = len(student_in_course)
    return np.array(rnd.sample(student_in_course, capacity))


# Each chromosome is made up of many genes. As a gene we are using ExamId (IspitId), Room (ImeNaProstorija),
# Timeslot (PocetokNaPolaganje), duration (VremetrenjeNaIspitVoMinuti) which will be used for calculating end time
# for exam, TeacherId (SproveduvacId), Students (Studenti)
# Gene(examId, timeslot, duration, roomId, teacherId, students)
class Gene:
    def __init__(self, examId=None, timeSlot=None, duration=None, roomId=None, teacherId=None, students=None):
        if examId is None:
            examId, duration = get_random_exam()
        if timeSlot is None:
            timeSlot = get_random_time_slot_for_exam(examId)
        if roomId is None:
            roomId = get_random_room()
        if teacherId is None:
            teacherId = get_random_teacher()
        if students is None:
            students = get_random_students_for_exam(examId, roomId)


        self.examId = examId
        self.duration = duration
        self.timeSlot = timeSlot
        self.roomId = roomId
        self.teacherId = teacherId
        self.students = students


    def __repr__(self):
        return (
                "Gene[" +
                "examId=" + str(self.examId) + ", " +
                "duration=" + str(self.duration) + ", " +
                "timeSlot=" + str(self.timeSlot) + ", " +
                "roomId=" + str(self.roomId) + ", " +
                "teacherId=" + str(self.teacherId) + ", " +
                "students=" + str(len(self.students)) +
                "]"
        )

    def get_dictionary(self):
        dictionary = {'examId': self.examId, 'duration': int(self.duration), 'timeSlot': self.timeSlot,
                      'roomId': self.roomId, 'teacherId': self.teacherId, 'students': self.students.tolist()}
        return dictionary


# Chromosome is an array of genes. In this case chromosome represents the timetable we are generating
# For each chromosome we have array of genes, fitness value which is used for evaluating the chromosome and number
# which is used for the number of elements in the array of genes
class Chromosome:
    def __init__(self, genes=None, fitness_val=None, num=None):
        if num is None:
            num = rnd.randint(TOTALCOURSES, TOTALCOURSES * 3)
        if genes is None:
            genes = [Gene() for _ in range(0, num)]
        if fitness_val is None:
            fitness_val = 0

        self.genes = np.array(genes)
        self.fitness_val = fitness_val

    def __repr__(self):
        return (
                "Chromosome[" +
                "Genes=" + str(len(self.genes)) + ", " +
                "Fitness=" + str(self.fitness_val) +
                "]"
        )

    # get all rooms in chromosome
    def get_rooms(self):
        return np.array([gene.roomId for gene in self.genes])

    # get all timeslots in chromosome
    def get_timeslots(self):
        return np.array([gene.timeSlot for gene in self.genes])

    # get all duration of exams in chromosome
    def get_duration(self):
        return np.array([gene.duration for gene in self.genes])

    # get all teachers on duty for exams in chromosome
    def get_teachers(self):
        return np.array([gene.teacherId for gene in self.genes])

    # length of genes
    def size(self):
        return len(self.genes)

    # printing the genes for the best chromosome
    def printGenes(self):
        for gene in self.genes:
            print(gene.__repr__())


# Population is class that contains many chromosomes on which we will apply genetic algorithm
# For each population we have it's size and array of chromosomes with that length
class Population:
    def __init__(self, chromosomes=None, size=None):
        if size is None:
            size = 3
        if chromosomes is None:
            chromosomes = [Chromosome() for _ in range(size)]

        self.chromosomes = np.array(chromosomes)

    def __repr__(self):
        return (
                "Population[" +
                "size=" + str(len(self.chromosomes)) + ", " +
                "best=" +
                str(self.get_best()) + ", " +
                "Chromosomes=\n" +
                "\n".join([str(chrom) for chrom in self.chromosomes]) +
                "]"
        )

    def get_best(self):
        return max(self.chromosomes, key=lambda chrom: chrom.fitness_val)


# Next we are defining the constraints
# There should be only one exam in a room in a give time
def one_room_have_one_exam(chromosome):
    rooms = chromosome.get_rooms()
    timeslots = chromosome.get_timeslots()

    timeSlotRooms = [(slot, room) for slot, room in zip(timeslots, rooms)]

    # unique slot room and there counts
    _, counts = np.unique(timeSlotRooms, axis=0, return_counts=True)

    # counting of duplicate exams in one slot and one room
    conflicts = sum(counts) - len(counts)

    return conflicts


# Students should not have overlapping exams
def student_one_exam_at_a_time(chromosome):
    duplicateExams = 0  # multiple exam of students at a time

    for i in range(len(chromosome.genes)):
        for student in chromosome.genes[i].students:
            for gene in chromosome.genes:
                if gene != chromosome.genes[i] and gene.timeSlot == chromosome.genes[i].timeSlot:
                    if student in gene.students:
                        duplicateExams += 1

    return duplicateExams


# One teacher should be on duty for one exam at give time
def one_teacher_has_one_exam(chromosome):
    teachers = chromosome.get_teachers()
    timeslots = chromosome.get_timeslots()

    timeSlotTeachers = [(slot, teacher) for slot, teacher in zip(timeslots, teachers)]

    _, counts = np.unique(timeSlotTeachers, axis=0, return_counts=True)

    conflicts = sum(counts) - len(counts)

    return conflicts


# Array that is used for the constraints. For each constraint we have it's name which corresponds to the name of the
# function defined above, detail/description, next is it function, the weight of the number of conflicts used for
# fitness value calculation, limit of the value of conflicts, after the limit is reached we should mutate the field
# and last we have the field that should be mutated, given the limit is reached.
CONSTRAINTS = [
    {
        # A room can only have one Course at given time
        "name": "one_room_have_one_exam",
        "detail": "One room should have only one paper at a time",
        "function": one_room_have_one_exam,
        "weight": 10,
        "limit": 3,
        "fields": [
            "roomId"
        ]
    },
    {
        # A student can't have more than one exam at a time

        "name": "student_one_exam_at_a_time",
        "detail": "One student should have one exam at a time",
        "function": student_one_exam_at_a_time,
        "weight": 10,
        "limit": 10,
        "fields": [
            "students"
        ]
    },
    {
        # A teacher can be on duty in one room at given time
        "name": "one_teacher_has_one_exam",
        "detail": "One teacher should be on duty at a time",
        "function": one_teacher_has_one_exam,
        "weight": 10,
        "limit": 5,
        "fields": [
            "teacherId"
        ]
    }
]


# Function used for calculating the fitness of the chromosome
def calculate_fitness(chromosome):
    mutate_fields = []  # field that requires mutation
    score = 0

    # Checking the constraints for the chromosome
    for constraint in CONSTRAINTS:
        conflicts = constraint['function'](chromosome)
        # adding the score
        score += conflicts * constraint['weight']

        # adding the fields that requires mutation if the number of conflicts is greater than the limit
        if conflicts > constraint['limit'] and constraint['fields'] not in mutate_fields:
            mutate_fields += constraint['fields']

    # Assigning the calculated fitness to the chromosome
    # range is 0-1. 0 being the lowest and 1 means the perfect
    actualFitness = 1 / (1.0 * score + 1)
    chromosome.fitness_val = actualFitness

    return actualFitness, mutate_fields


# Next we continue with implementation of the Genetic algorithm
# First we are defining the type of selection we will use, Roulette Wheel Selection used for selecting the best parents
def roulette_wheel_selection(population):
    population_fitness = sum([chromosome.fitness_val for chromosome in population.chromosomes])
    chromosome_probabilities = [chromosome.fitness_val / population_fitness for chromosome in population.chromosomes]
    return np.random.choice(population.chromosomes, size=2, replace=False, p=chromosome_probabilities)


# Next is the crossover function
# Single point crossover between two chromosomes.
def one_point_crossover(one, two):
    random_point = rnd.randint(1, min(one.size(), two.size()) - 1)
    return (Chromosome(genes=np.concatenate((one.genes[:random_point], two.genes[random_point:]))),
            Chromosome(genes=np.concatenate((two.genes[:random_point], one.genes[random_point:]))))


# Function for crossover
def crossover(one, two, iter=None):
    if iter is None:
        iter = rnd.randint(2, 10)

    return np.array(
        [child for _ in range(iter)
         for child in one_point_crossover(one, two)] + [one, two]
    )


# Next step is mutating the genes and chromosomes
# But first we are altering the gene. We have 2 choices, creating a new gene and returning it
# Or we can make a new gene and mutate the fields on the old gene
def alter_gene(gene, mutate_fields):
    new_gene = Gene()
    # If true, return the new gene, else mutate the fields on the old gene and return it
    if rnd.randint(0, 1):
        gene = new_gene
    else:
        for field in mutate_fields:
            setattr(gene, field, getattr(new_gene, field))

    return gene


# Altering the chromosome next. Again we have 2 choices, delete some genes from the chromosome or create new chromosome
def alter_chromosome(chromosome):
    # If true, delete some random gene, else return new chromosome
    if rnd.randint(0, 1):
        chromosome = np.delete(chromosome.genes, rnd.randint(0, chromosome.size() - 1))
    else:
        chromosome = Chromosome()

    return chromosome


# Function for mutating. We are using random for generating true or false. If the value is true we are altering gene
# at random index in the chromosome, if the value is false, we are altering the chromosome
def mutate_chromosome(chromosome, mutate_fields):
    if rnd.randint(0, 1):
        index = rnd.randint(0, chromosome.size() - 1)
        chromosome.genes[index] = alter_gene(chromosome.genes[index], mutate_fields)
    else:
        chromosome = alter_chromosome(chromosome)

    return chromosome


# Finally we are writing the function that represents the Genetic Algorithm. It has the population that we will mutate
# the number of generations (random number between 10 and 20), mutation_probability decimal number from 0 to 1
def GeneticAlgorithm(population=None, generations=None, mutation_probability=None):
    if generations is None:
        generations = rnd.randint(10, 20)
    if mutation_probability is None:
        mutation_probability = rnd.random()  # [0,1)
    if population is None:
        population = Population(size=3)

    # Calculating fitness
    for chromosome in population.chromosomes:
        calculate_fitness(chromosome)
    # storing the best chromosome
    best_chromosome = None

    # Genetic Algorithm loop
    for generation in range(generations):

        # Selecting parents through roulette wheel selection
        parents = roulette_wheel_selection(population)

        # Applying crossover
        crossover_population = Population(chromosomes=crossover(parents[0], parents[1], iter=5))
        # Calculating fitness and mutation
        for chromosome in crossover_population.chromosomes:
            _, mutate_fields = calculate_fitness(chromosome)
            if rnd.random() < mutation_probability:  # mutation
                chromosome = mutate_chromosome(chromosome, mutate_fields)

        # Finding the fittest candidate
        current_best = crossover_population.get_best()
        if best_chromosome is None:
            best_chromosome = current_best
        elif current_best.fitness_val > best_chromosome.fitness_val:
            best_chromosome = current_best

    return best_chromosome
