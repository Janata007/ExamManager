﻿// <auto-generated />
using System;
using ExamManager.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ExamManager.Repository.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210908201054_initStudiskiCiklusStudiskaPrograma")]
    partial class initStudiskiCiklusStudiskaPrograma
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ExamManager.Domain.DomainModel.Ispit", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("BrojNaTermin")
                        .HasColumnType("int");

                    b.Property<string>("KodNaPredmet")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("PolaganjeDo")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("PolaganjeOd")
                        .HasColumnType("datetime2");

                    b.Property<int>("VremetraenjeNaTerminVoMinuti")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KodNaPredmet");

                    b.ToTable("Ispiti");
                });

            modelBuilder.Entity("ExamManager.Domain.DomainModel.Predmet", b =>
                {
                    b.Property<string>("KodNaPredmet")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ImeNaPredmet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Semestar")
                        .HasColumnType("int");

                    b.Property<string>("StudiskiCiklusId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("KodNaPredmet");

                    b.HasIndex("StudiskiCiklusId");

                    b.ToTable("Predmeti");
                });

            modelBuilder.Entity("ExamManager.Domain.DomainModel.PredmetOdStudiskaPrograma", b =>
                {
                    b.Property<string>("KodNaPredmet")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ImeNaStudiskaPrograma")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("KodNaPredmet", "ImeNaStudiskaPrograma");

                    b.HasIndex("ImeNaStudiskaPrograma");

                    b.ToTable("PredmetiOdStudiskaPrograma");
                });

            modelBuilder.Entity("ExamManager.Domain.DomainModel.Prostorija", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Kapacitet")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Prostorii");
                });

            modelBuilder.Entity("ExamManager.Domain.DomainModel.Sproveduvac", b =>
                {
                    b.Property<string>("SproveduvacId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ImePrezime")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SproveduvacId");

                    b.ToTable("Sproveduvaci");
                });

            modelBuilder.Entity("ExamManager.Domain.DomainModel.Student", b =>
                {
                    b.Property<int>("BrojNaIndeks")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImePrezime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("TerminId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("BrojNaIndeks");

                    b.HasIndex("TerminId");

                    b.ToTable("Studenti");
                });

            modelBuilder.Entity("ExamManager.Domain.DomainModel.StudentPolagaPredmet", b =>
                {
                    b.Property<int>("BrojNaIndeks")
                        .HasColumnType("int");

                    b.Property<string>("KodNaPredmet")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("BrojNaIndeks", "KodNaPredmet");

                    b.HasIndex("KodNaPredmet");

                    b.ToTable("StudentiPolagaatPredmeti");
                });

            modelBuilder.Entity("ExamManager.Domain.DomainModel.StudiskaPrograma", b =>
                {
                    b.Property<string>("ImeNaStudiskaPrograma")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ImeNaStudiskaPrograma");

                    b.ToTable("StudiskiProgrami");

                    b.HasData(
                        new
                        {
                            ImeNaStudiskaPrograma = "Интернет мрежи и безбедност"
                        },
                        new
                        {
                            ImeNaStudiskaPrograma = "Компјутерска едукација"
                        },
                        new
                        {
                            ImeNaStudiskaPrograma = "Компјутерски науки"
                        },
                        new
                        {
                            ImeNaStudiskaPrograma = "Компјутерско инженерство"
                        },
                        new
                        {
                            ImeNaStudiskaPrograma = "Примена на информациски технологии"
                        },
                        new
                        {
                            ImeNaStudiskaPrograma = "Софтверско инженерство и информациски системи"
                        },
                        new
                        {
                            ImeNaStudiskaPrograma = "Software engineering and information systems"
                        },
                        new
                        {
                            ImeNaStudiskaPrograma = "Професионални студии по информатички технологии"
                        },
                        new
                        {
                            ImeNaStudiskaPrograma = "Професионални студии по информатика"
                        },
                        new
                        {
                            ImeNaStudiskaPrograma = "Академски студии по информатика"
                        },
                        new
                        {
                            ImeNaStudiskaPrograma = "Информатика и компјутерско инженерство"
                        },
                        new
                        {
                            ImeNaStudiskaPrograma = "Компјутерска едукација-стара"
                        },
                        new
                        {
                            ImeNaStudiskaPrograma = "Мрежни технологии"
                        },
                        new
                        {
                            ImeNaStudiskaPrograma = "Примена на е-технологии"
                        },
                        new
                        {
                            ImeNaStudiskaPrograma = "Компјутерски науки и инженерство"
                        });
                });

            modelBuilder.Entity("ExamManager.Domain.DomainModel.StudiskiCiklus", b =>
                {
                    b.Property<string>("CiklusNaStudii")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("CiklusNaStudii");

                    b.ToTable("StudickiCiklusi");

                    b.HasData(
                        new
                        {
                            CiklusNaStudii = "Додипломски"
                        },
                        new
                        {
                            CiklusNaStudii = "Магистерски"
                        },
                        new
                        {
                            CiklusNaStudii = "Докторски"
                        });
                });

            modelBuilder.Entity("ExamManager.Domain.DomainModel.Termin", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ispitId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProstorijaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SproveduvacId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("VremeNaZapocnuvanje")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("VremeNaZavrshuvanje")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ispitId");

                    b.HasIndex("ProstorijaId");

                    b.HasIndex("SproveduvacId")
                        .IsUnique()
                        .HasFilter("[SproveduvacId] IS NOT NULL");

                    b.ToTable("Termini");
                });

            modelBuilder.Entity("ExamManager.Domain.Identity.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ExamManager.Domain.DomainModel.Ispit", b =>
                {
                    b.HasOne("ExamManager.Domain.DomainModel.Predmet", "IspitPoPredmet")
                        .WithMany("IspitiPoPredmet")
                        .HasForeignKey("KodNaPredmet");
                });

            modelBuilder.Entity("ExamManager.Domain.DomainModel.Predmet", b =>
                {
                    b.HasOne("ExamManager.Domain.DomainModel.StudiskiCiklus", "StudiskiCiklus")
                        .WithMany("PredmetiOdStudiskiCiklus")
                        .HasForeignKey("StudiskiCiklusId");
                });

            modelBuilder.Entity("ExamManager.Domain.DomainModel.PredmetOdStudiskaPrograma", b =>
                {
                    b.HasOne("ExamManager.Domain.DomainModel.StudiskaPrograma", "StudiskaPrograma")
                        .WithMany("PredmetiOdStudiskaPrograma")
                        .HasForeignKey("ImeNaStudiskaPrograma")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExamManager.Domain.DomainModel.Predmet", "Predmet")
                        .WithMany("PredmetOdStudiskiProgrami")
                        .HasForeignKey("KodNaPredmet")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ExamManager.Domain.DomainModel.Student", b =>
                {
                    b.HasOne("ExamManager.Domain.DomainModel.Termin", "StudentPolagaVoTermin")
                        .WithMany("StudentiPolagaatVoTermin")
                        .HasForeignKey("TerminId");
                });

            modelBuilder.Entity("ExamManager.Domain.DomainModel.StudentPolagaPredmet", b =>
                {
                    b.HasOne("ExamManager.Domain.DomainModel.Student", "Student")
                        .WithMany("StudentPolagaPredmeti")
                        .HasForeignKey("BrojNaIndeks")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExamManager.Domain.DomainModel.Predmet", "Predmet")
                        .WithMany("StudentiKoiPolagaatPredmet")
                        .HasForeignKey("KodNaPredmet")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ExamManager.Domain.DomainModel.Termin", b =>
                {
                    b.HasOne("ExamManager.Domain.DomainModel.Ispit", "TerminVoKojSePolagaIspit")
                        .WithMany("IspitSePolagaVoTermini")
                        .HasForeignKey("ispitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExamManager.Domain.DomainModel.Prostorija", "TerminSeRealiziraVoProstija")
                        .WithMany("ProstijaVoKojaSeRealiziraTermin")
                        .HasForeignKey("ProstorijaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExamManager.Domain.DomainModel.Sproveduvac", "DezurenSproveduvacVoTermin")
                        .WithOne("SproveduvacDezuraVoTermin")
                        .HasForeignKey("ExamManager.Domain.DomainModel.Termin", "SproveduvacId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ExamManager.Domain.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ExamManager.Domain.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExamManager.Domain.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ExamManager.Domain.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
