using ExamManager.Domain.DomainModel;
using ExamManager.Domain.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace ExamManager.Repository
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Predmet> Predmeti { get; set; }
        public virtual DbSet<PredmetOdStudiskaPrograma> PredmetiOdStudiskaPrograma { get; set; }
        public virtual DbSet<Prostorija> Prostorii { get; set; }
        public virtual DbSet<Sproveduvac> Sproveduvaci { get; set; }
        public virtual DbSet<Student> Studenti { get; set; }
        public virtual DbSet<StudentPolagaPredmet> StudentiPolagaatPredmeti { get; set; }
        public virtual DbSet<StudiskaPrograma> StudiskiProgrami { get; set; }
        public virtual DbSet<StudiskiCiklus> StudickiCiklusi { get; set; }
        public virtual DbSet<Termin> Termini { get; set; }

        protected override void OnModelCreating(ModelBuilder builder){
            base.OnModelCreating(builder);

            builder.Entity<Predmet>()
                .Property(z => z.Id)
                .ValueGeneratedOnAdd();

            builder.Entity<Predmet>()
                .HasOne(z => z.StudiskiCiklus)
                .WithMany(z => z.PredmetiOdStudiskiCiklus)
                .HasForeignKey(z => z.StudiskiCiklusId);

            builder.Entity<Prostorija>()
                .Property(z => z.Id)
                .ValueGeneratedOnAdd();

            builder.Entity<Sproveduvac>()
                .Property(z=>z.Id)
                .ValueGeneratedOnAdd();

            builder.Entity<Student>()
                .Property(z=>z.BrojNaIndeks)
                .ValueGeneratedOnAdd();

            builder.Entity<Student>()
                .HasOne(z => z.StudentPolagaVoTermin)
                .WithMany(z => z.StudentiPolagaatVoTermin)
                .HasForeignKey(z => z.TerminId);

            builder.Entity<StudiskaPrograma>()
                .Property(z=>z.Id)
                .ValueGeneratedOnAdd();

            builder.Entity<StudiskiCiklus>()
                .Property(z=>z.CiklusNaStudii)
                .ValueGeneratedOnAdd();

            builder.Entity<Termin>()
                .Property(z=>z.Id)
                .ValueGeneratedOnAdd();

            builder.Entity<Termin>()
                .HasOne(z => z.TerminVoKojSePolagaPredmet)
                .WithMany(z => z.PredmetSePolagaVoTermini)
                .HasForeignKey(z => z.PredmetId);

            builder.Entity<Termin>()
                .HasOne(z => z.DezurenSproveduvacVoTermin)
                .WithOne(z => z.SproveduvacDezuraVoTermin)
               .HasForeignKey<Termin>(z => z.SproveduvacId);

            builder.Entity<Termin>()
                .HasOne(z => z.TerminSeRealiziraVoProstija)
                .WithMany(z => z.ProstijaVoKojaSeRealiziraTermin)
                .HasForeignKey(z => z.ProstorijaId);

            builder.Entity<PredmetOdStudiskaPrograma>()
                .HasKey(z => new { z.PredmetId, z.StudiskaProgramaId });

            builder.Entity<PredmetOdStudiskaPrograma>()
                .HasOne(z => z.StudiskaPrograma)
                .WithMany(z => z.PredmetiOdStudiskaPrograma)
                .HasForeignKey(z => z.StudiskaProgramaId);

            builder.Entity<PredmetOdStudiskaPrograma>()
                .HasOne(z => z.Predmet)
                .WithMany(z => z.PredmetOdStudiskiProgrami)
                .HasForeignKey(z => z.PredmetId);

            builder.Entity<StudentPolagaPredmet>()
                .HasKey(z => new { z.BrojNaIndeks, z.PredmetId });

            builder.Entity<StudentPolagaPredmet>()
                .HasOne(z => z.Student)
                .WithMany(z => z.StudentPolagaPredmeti)
                .HasForeignKey(z => z.BrojNaIndeks);

            builder.Entity<StudentPolagaPredmet>()
                .HasOne(z => z.Predmet)
                .WithMany(z => z.StudentiKoiPolagaatPredmet)
                .HasForeignKey(z => z.PredmetId);
        }


    }
}
