using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamManager.Repository.Migrations
{
    public partial class initPredmeti : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Predmeti",
                columns: new[] { "KodNaPredmet", "ImeNaPredmet", "Semestar", "StudiskiCiklusId" },
                values: new object[,]
                {
                    { "F18L1W005", "Бизнис и менаџмент", 0, "Додипломски" },
                    { "F18L3S153", "Процесна роботика", 1, "Додипломски" },
                    { "F18L3S166", "Учење на далечина", 1, "Додипломски" },
                    { "F18L3W064", "Дистрибуирани системи", 0, "Додипломски" },
                    { "F18L3W068", "Пресметување во облак", 0, "Додипломски" },
                    { "F18L3W074", "Администрација на бази на податоци", 0, "Додипломски" },
                    { "F18L3W075", "Анализа и дизајн на ИС", 0, "Додипломски" },
                    { "F18L3W079", "Веб базирани системи", 0, "Додипломски" },
                    { "F18L3S163", "Статистичко моделирање", 1, "Додипломски" },
                    { "F18L3W085", "Вовед во биоинформатиката", 0, "Додипломски" },
                    { "F18L3W092", "Дигитална постпродукција", 0, "Додипломски" },
                    { "F18L3W098", "Дистрибуирано складирање на податоци", 0, "Додипломски" },
                    { "F18L3W103", "Имплементација на системи со слободен и отворен код", 0, "Додипломски" },
                    { "F18L3W105", "Иновации во ИКТ", 0, "Додипломски" },
                    { "F18L3W123", "Машинска визија", 0, "Додипломски" },
                    { "F18L3W126", "Методологија на истражувањето во ИКТ", 0, "Додипломски" },
                    { "F18L3W128", "Мобилни информациски системи", 0, "Додипломски" },
                    { "F18L3W088", "Вовед во паметни градови", 0, "Додипломски" },
                    { "F18L3S158", "Современи компјутерски архитектури", 1, "Додипломски" },
                    { "F18L3S047", "Процесирање на сигналите", 1, "Додипломски" },
                    { "F18L3S150", "Податочно рударство", 1, "Додипломски" },
                    { "F18L3S025", "Електронска и мобилна трговија", 1, "Додипломски" },
                    { "F18L3S111", "Инфраструктурно програмирање", 1, "Додипломски" },
                    { "F18L3S118", "Континуирана интеграција и испорака", 1, "Додипломски" },
                    { "F18L3S122", "Криптографија", 1, "Додипломски" },
                    { "F18L3S125", "Мерење и анализа на интернет сообраќај", 1, "Додипломски" },
                    { "F18L3S135", "Мултимедиски системи", 1, "Додипломски" },
                    { "F18L3S155", "Сервисно ориентирани архитектури", 1, "Додипломски" },
                    { "F18L3S159", "Софтверски дефинирана безбедност", 1, "Додипломски" },
                    { "F18L3S056", "Персонализирано учење", 1, "Додипломски" },
                    { "F18L3S071", "Психологија на училишна возраст", 1, "Додипломски" },
                    { "F18L3S057", "Работа со надарени ученици", 1, "Додипломски" },
                    { "F18L3S094", "Дигитални библиотеки", 1, "Додипломски" },
                    { "F18L3S019", "Софтверски квалитет и тестирање", 1, "Додипломски" },
                    { "F18L3S036", "Машинско учење", 1, "Додипломски" },
                    { "F18L3S039", "Формални јазици и автомати", 1, "Додипломски" },
                    { "F18L3S012", "Интегрирани системи", 1, "Додипломски" },
                    { "F18L3S149", "Паралелно програмирање", 1, "Додипломски" },
                    { "F18L3W129", "Мобилни платформи и програмирање", 0, "Додипломски" },
                    { "F18L3S010", "Дизајн на интеракцијата човек-компјутер", 1, "Додипломски" },
                    { "F18L3W133", "Мрежна и мобилна форензика", 0, "Додипломски" },
                    { "F18L3W108", "Интернет на нештата", 0, "Додипломски" },
                    { "F18L3S107", "Интелигентни системи", 1, "Додипломски" },
                    { "F18L3S127", "Мобилни апликации", 1, "Додипломски" },
                    { "F18L3S130", "Моделирање и менаџирање на бизнис процеси", 1, "Додипломски" },
                    { "F18L3S132", "Модерни трендови во роботика", 1, "Додипломски" },
                    { "F18L3S138", "Напредни бази на податоци", 1, "Додипломски" },
                    { "F18L3S139", "Напредни теми од криптографија", 1, "Додипломски" },
                    { "F18L3S141", "Неструктурирани бази на податоци", 1, "Додипломски" },
                    { "F18L3S101", "Етичко хакирање", 1, "Додипломски" },
                    { "F18L3S028", "Претприемништво", 1, "Додипломски" },
                    { "F18L3S022", "Управување со ИКТ проекти", 1, "Додипломски" },
                    { "F18L3S083", "Виртуелна реалност", 1, "Додипломски" },
                    { "F18L3S086", "Вовед во когнитивни науки", 1, "Додипломски" },
                    { "F18L3S113", "Компјутерска анимација", 1, "Додипломски" },
                    { "F18L3S07", "Биолошки инспирирано пресметување", 1, "Додипломски" },
                    { "F18L3S102", "ИКТ за развој", 1, "Додипломски" },
                    { "F18L3S106", "Интелигентни информациски системи", 1, "Додипломски" },
                    { "F18L3S157", "Складови на податоци и аналитичка обработка", 1, "Додипломски" },
                    { "F18L3S091", "Географски информациски системи", 1, "Додипломски" },
                    { "F18L3S080", "Веб пребарувачки системи", 1, "Додипломски" },
                    { "F18L3S121", "Блоковски вериги и криптовалути", 1, "Додипломски" },
                    { "F18L3W137", "Напредна интеракција човек компјутер", 0, "Додипломски" },
                    { "F18L3W152", "Програмирање на видео игри", 0, "Додипломски" },
                    { "F18L3W161", "Социјални мрежи и медиуми", 0, "Додипломски" },
                    { "F18L3W038", "Програмски парадигми", 0, "Додипломски" },
                    { "F18L3W072", "Автономна роботика", 0, "Додипломски" },
                    { "F18L3W076", "Вовед во анализа на временските серии", 0, "Додипломски" },
                    { "F18L3W089", "Вовед во препознавање на облици", 0, "Додипломски" },
                    { "F18L3W131", "Моделирање и симулација", 0, "Додипломски" },
                    { "F18L3W142", "Обработка на природните јазици", 0, "Додипломски" },
                    { "F18L3W144", "Операциони истражувања", 0, "Додипломски" },
                    { "F18L3W154", "Рударење на масивни податоци", 0, "Додипломски" },
                    { "F18L3W156", "Системи за поддршка при одлучувањето", 0, "Додипломски" },
                    { "F18L3W117", "Компјутерски поддржано производство", 0, "Додипломски" },
                    { "F18L3W027", "Менаџмент информациски системи", 0, "Додипломски" },
                    { "F18L3W048", "Софтвер за вградливи системи", 0, "Додипломски" },
                    { "F18L3W160", "Софтверски дефинирани мрежи", 0, "Додипломски" },
                    { "F18L3S063", "Дизајн на компјутерски мрежи", 1, "Додипломски" },
                    { "F18L3W145", "Оптички мрежи", 0, "Додипломски" },
                    { "F18L3S151", "Пресметковна биологија", 1, "Додипломски" },
                    { "F18L3S093", "Дигитална форензика", 1, "Додипломски" },
                    { "F18L3S040", "Вградливи микропроцесорски системи", 1, "Додипломски" },
                    { "F18L1S003", "Архитектура и организација на компјутери", 1, "Додипломски" },
                    { "F18L1S146", "Основи на веб дизајн", 1, "Додипломски" },
                    { "F18L2W014", "Компјутерски мрежи и безбедност", 0, "Додипломски" },
                    { "F18L2W001", "Алгоритми и податочни структури", 0, "Додипломски" },
                    { "F18L3W055", "Мултимедијални технологии", 0, "Додипломски" },
                    { "F18L2W046", "Компјутерски мрежи", 0, "Додипломски" },
                    { "F18L2W067", "Основи на теоријата на информации", 0, "Додипломски" },
                    { "F18L1S052", "ИТ системи за учење", 1, "Додипломски" },
                    { "F18L2W104", "Инженерска математика", 0, "Додипломски" },
                    { "F18L2W140", "Напредно програмирање", 0, "Додипломски" },
                    { "F18L2W006", "Веројатност и статистика", 0, "Додипломски" },
                    { "F18L2W096", "Дигитизација", 0, "Додипломски" },
                    { "F18L2W167", "Шаблони за дизајн на кориснички интерфејси", 0, "Додипломски" },
                    { "F18L2W147", "Основи на комуникациски системи", 0, "Додипломски" },
                    { "F18L2S100", "Економија за ИКТ инженери", 0, "Додипломски" },
                    { "F18L2W165", "Управување со техничката поддршка", 0, "Додипломски" },
                    { "F18L2W109", "Интернет програмирање на клиентска страна", 0, "Додипломски" },
                    { "F18L1S015", "Објектно ориентирана анализа и дизајн", 1, "Додипломски" },
                    { "F18L1S026", "Маркетинг", 1, "Додипломски" },
                    { "F18L1S120", "Креативни вештини за решавање проблеми", 1, "Додипломски" },
                    { "F18L1W007", "Вовед во компјутерските науки", 0, "Додипломски" },
                    { "F18L1S013", "Калкулус", 0, "Додипломски" },
                    { "F18L1W018", "Професионални вештини", 0, "Додипломски" },
                    { "F18L1W020", "Структурно програмирање", 0, "Додипломски" },
                    { "F18L1W031", "Дискретни структури 1", 0, "Додипломски" },
                    { "F18L1W033", "Калкулус 1", 0, "Додипломски" },
                    { "F18L1W041", "Дизајн на дигитални кола", 0, "Додипломски" },
                    { "F18L1W049", "Физика", 0, "Додипломски" },
                    { "F18L1W070", "Педагогија", 0, "Додипломски" },
                    { "F18L1W011", "Дискретна математика", 1, "Додипломски" },
                    { "F18L1S045", "Компјутерски архитектури", 1, "Додипломски" },
                    { "F18L1S016", "Објектно-ориентирано програмирање", 1, "Додипломски" },
                    { "F18L1S066", "Основи на сајбер безбедноста", 1, "Додипломски" },
                    { "F18L1S023", "Бизнис статистика", 1, "Додипломски" },
                    { "F18L1S032", "Дискретни структури 2", 1, "Додипломски" },
                    { "F18L1S034", "Калкулус 2", 1, "Додипломски" },
                    { "F18L1S116", "Компјутерски компоненти", 1, "Додипломски" },
                    { "F18L2S061", "Безжични и мобилни системи", 1, "Додипломски" },
                    { "F18L3S087", "Вовед во мрежна наука", 1, "Додипломски" },
                    { "F18L2S017", "Оперативни системи", 1, "Додипломски" },
                    { "F18L2S082", "Визуелно програмирање", 1, "Додипломски" },
                    { "F18L3W008", "Вовед во науката за податоци", 0, "Додипломски" },
                    { "F18L3W043", "Информациска безбедност", 0, "Додипломски" },
                    { "F18L3W053", "Компјутерска етика", 0, "Додипломски" },
                    { "F18L3W115", "Компјутерски звук, говор и музика", 0, "Додипломски" },
                    { "F18L3W035", "Линеарна алгебра и примени", 0, "Додипломски" },
                    { "F18L3W134", "Мултимедиски мрежи", 0, "Додипломски" },
                    { "F18L3W148", "Основи на роботиката", 0, "Додипломски" },
                    { "F18L3W081", "Визуелизација", 0, "Додипломски" },
                    { "F18L3W050", "Дизајн на образовен софтвер", 0, "Додипломски" },
                    { "F18L3W044", "Компјутерска електроника", 0, "Додипломски" },
                    { "F18L3W136", "Напреден веб дизајн", 0, "Додипломски" },
                    { "F18L3W037", "Паралелно и дистрибуирано процесирање", 0, "Додипломски" },
                    { "F18L3S059", "Администрација на мрежи", 1, "Додипломски" },
                    { "F18L3S062", "Виртуелизација", 1, "Додипломски" },
                    { "F18L3S073", "Агентно-базирани системи", 1, "Додипломски" },
                    { "F18L3S077", "Безжични мултимедиски системи", 1, "Додипломски" },
                    { "F18L3W009", "Дизајн и архитектура на софтвер", 0, "Додипломски" },
                    { "F18L3W024", "Веб програмирање", 0, "Додипломски" },
                    { "F18L3W065", "Мрежна безбедност", 0, "Додипломски" },
                    { "F18L3W004", "Бази на податоци", 0, "Додипломски" },
                    { "F18L2S084", "Вовед во екоинформатиката", 1, "Додипломски" },
                    { "F18L2S090", "Вовед во случајни процеси", 1, "Додипломски" },
                    { "F18L2S110", "Интернет технологии", 1, "Додипломски" },
                    { "F18L2S124", "Медиуми и комуникации", 1, "Додипломски" },
                    { "F18L2S143", "Одржливи и енергетски ефикасни компјутерски системи", 1, "Додипломски" },
                    { "F18L2S097", "Дизајн на алгоритми", 1, "Додипломски" },
                    { "F18L2S099", "Е-влада", 1, "Додипломски" },
                    { "F18L2S042", "Електрични кола", 1, "Додипломски" },
                    { "F18L2S114", "Компјутерска графика", 1, "Додипломски" },
                    { "F18L3S162", "Споделување и пресметување во толпа", 1, "Додипломски" },
                    { "F18L2S051", "ИКТ во образованието", 1, "Додипломски" },
                    { "F18L2S002", "Анализа на софтверските барања", 1, "Додипломски" },
                    { "F18L2S095", "Дигитално процесирање на слика", 1, "Додипломски" },
                    { "F18L2S164", "Теорија на информации со дигитални комуникации", 1, "Додипломски" },
                    { "F18L2S119", "Концепти на информатичко општество", 1, "Додипломски" },
                    { "F18L2S029", "Софтверско инженерство", 1, "Додипломски" },
                    { "F18L3W060", "Администрација на системи", 0, "Додипломски" },
                    { "F18L2S030", "Вештачка интелигенција", 1, "Додипломски" },
                    { "F18L3S112", "Програмски јазици и компајлери", 1, "Додипломски" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L1S003");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L1S013");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L1S015");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L1S016");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L1S023");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L1S026");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L1S032");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L1S034");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L1S045");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L1S052");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L1S066");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L1S116");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L1S120");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L1S146");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L1W005");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L1W007");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L1W011");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L1W018");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L1W020");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L1W031");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L1W033");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L1W041");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L1W049");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L1W070");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L2S002");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L2S017");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L2S029");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L2S030");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L2S042");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L2S051");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L2S061");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L2S082");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L2S084");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L2S090");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L2S095");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L2S097");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L2S099");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L2S100");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L2S110");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L2S114");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L2S119");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L2S124");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L2S143");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L2S164");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L2W001");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L2W006");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L2W014");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L2W046");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L2W067");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L2W096");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L2W104");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L2W109");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L2W140");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L2W147");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L2W165");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L2W167");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3S010");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3S012");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3S019");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3S022");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3S025");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3S028");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3S036");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3S039");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3S040");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3S047");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3S056");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3S057");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3S059");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3S062");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3S063");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3S07");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3S071");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3S073");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3S077");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3S080");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3S083");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3S086");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3S087");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3S091");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3S093");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3S094");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3S101");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3S102");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3S106");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3S107");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3S111");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3S112");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3S113");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3S118");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3S121");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3S122");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3S125");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3S127");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3S130");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3S132");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3S135");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3S138");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3S139");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3S141");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3S149");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3S150");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3S151");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3S153");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3S155");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3S157");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3S158");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3S159");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3S162");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3S163");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3S166");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3W004");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3W008");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3W009");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3W024");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3W027");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3W035");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3W037");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3W038");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3W043");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3W044");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3W048");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3W050");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3W053");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3W055");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3W060");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3W064");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3W065");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3W068");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3W072");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3W074");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3W075");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3W076");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3W079");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3W081");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3W085");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3W088");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3W089");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3W092");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3W098");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3W103");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3W105");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3W108");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3W115");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3W117");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3W123");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3W126");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3W128");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3W129");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3W131");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3W133");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3W134");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3W136");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3W137");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3W142");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3W144");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3W145");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3W148");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3W152");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3W154");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3W156");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3W160");

            migrationBuilder.DeleteData(
                table: "Predmeti",
                keyColumn: "KodNaPredmet",
                keyValue: "F18L3W161");
        }
    }
}
