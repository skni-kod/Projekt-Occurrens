﻿// <auto-generated />
using System;
using Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(OccurrensDbContext))]
    partial class OccurrensDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("occurrensBackend.Entities.DatabaseEntities.Address", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int?>("Apartament_number")
                        .HasColumnType("integer");

                    b.Property<int>("Building_number")
                        .HasColumnType("integer");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("DoctorId")
                        .HasColumnType("uuid");

                    b.Property<string>("Postal_code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Street")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("occurrensBackend.Entities.DatabaseEntities.Disease", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("CreatedByDoctor")
                        .HasColumnType("uuid");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Medicines")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("PatientId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("PatientId");

                    b.ToTable("Diseases");
                });

            modelBuilder.Entity("occurrensBackend.Entities.DatabaseEntities.Doctor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("Acception")
                        .HasColumnType("boolean");

                    b.Property<DateOnly>("Date_of_birth")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Last_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PasswordResetToken")
                        .HasColumnType("text");

                    b.Property<decimal>("Pesel")
                        .HasColumnType("numeric");

                    b.Property<DateTime?>("ResetTokenExpires")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Secont_name")
                        .HasColumnType("text");

                    b.Property<int>("Telephon_number")
                        .HasColumnType("integer");

                    b.Property<string>("VerificationToken")
                        .HasColumnType("text");

                    b.Property<DateTime?>("VerifiedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("Pesel")
                        .IsUnique();

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("occurrensBackend.Entities.DatabaseEntities.Is_opened", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("AddressId")
                        .HasColumnType("uuid");

                    b.Property<string>("Fridady")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Monday")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Saturday")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Sunday")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Thursday")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Tuesday")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Wednesday")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("IsOpeneds");
                });

            modelBuilder.Entity("occurrensBackend.Entities.DatabaseEntities.Patient", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("Acception")
                        .HasColumnType("boolean");

                    b.Property<DateOnly>("Date_of_birth")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Last_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PasswordResetToken")
                        .HasColumnType("text");

                    b.Property<decimal>("Pesel")
                        .HasColumnType("numeric");

                    b.Property<DateTime?>("ResetTokenExpires")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Secont_name")
                        .HasColumnType("text");

                    b.Property<int>("Telephon_number")
                        .HasColumnType("integer");

                    b.Property<string>("VerificationToken")
                        .HasColumnType("text");

                    b.Property<DateTime?>("VerifiedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("Pesel")
                        .IsUnique();

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("occurrensBackend.Entities.DatabaseEntities.Specialization", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("DoctorId")
                        .HasColumnType("uuid");

                    b.Property<string>("Specjalization")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.ToTable("Specializations");
                });

            modelBuilder.Entity("occurrensBackend.Entities.DatabaseEntities.Visit", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateOnly?>("Date")
                        .HasColumnType("date");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("DoctorId")
                        .HasColumnType("uuid");

                    b.Property<bool>("Is_estabilished")
                        .HasColumnType("boolean");

                    b.Property<Guid?>("PatientId")
                        .HasColumnType("uuid");

                    b.Property<TimeOnly?>("Time")
                        .HasColumnType("time without time zone");

                    b.Property<float?>("price")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId");

                    b.ToTable("Visits");
                });

            modelBuilder.Entity("occurrensBackend.Entities.DatabaseEntities.Address", b =>
                {
                    b.HasOne("occurrensBackend.Entities.DatabaseEntities.Doctor", "Doctor")
                        .WithMany("addresses")
                        .HasForeignKey("DoctorId");

                    b.Navigation("Doctor");
                });

            modelBuilder.Entity("occurrensBackend.Entities.DatabaseEntities.Disease", b =>
                {
                    b.HasOne("occurrensBackend.Entities.DatabaseEntities.Patient", "Patient")
                        .WithMany("diseases")
                        .HasForeignKey("PatientId");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("occurrensBackend.Entities.DatabaseEntities.Is_opened", b =>
                {
                    b.HasOne("occurrensBackend.Entities.DatabaseEntities.Address", "Address")
                        .WithMany("is_opened")
                        .HasForeignKey("AddressId");

                    b.Navigation("Address");
                });

            modelBuilder.Entity("occurrensBackend.Entities.DatabaseEntities.Specialization", b =>
                {
                    b.HasOne("occurrensBackend.Entities.DatabaseEntities.Doctor", "Doctor")
                        .WithMany("spetializations")
                        .HasForeignKey("DoctorId");

                    b.Navigation("Doctor");
                });

            modelBuilder.Entity("occurrensBackend.Entities.DatabaseEntities.Visit", b =>
                {
                    b.HasOne("occurrensBackend.Entities.DatabaseEntities.Doctor", "Doctor")
                        .WithMany("visits")
                        .HasForeignKey("DoctorId");

                    b.HasOne("occurrensBackend.Entities.DatabaseEntities.Patient", "Patient")
                        .WithMany("visits")
                        .HasForeignKey("PatientId");

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("occurrensBackend.Entities.DatabaseEntities.Address", b =>
                {
                    b.Navigation("is_opened");
                });

            modelBuilder.Entity("occurrensBackend.Entities.DatabaseEntities.Doctor", b =>
                {
                    b.Navigation("addresses");

                    b.Navigation("spetializations");

                    b.Navigation("visits");
                });

            modelBuilder.Entity("occurrensBackend.Entities.DatabaseEntities.Patient", b =>
                {
                    b.Navigation("diseases");

                    b.Navigation("visits");
                });
#pragma warning restore 612, 618
        }
    }
}
