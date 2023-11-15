﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using occurrensBackend.Entities;

#nullable disable

namespace occurrensBackend.Migrations
{
    [DbContext(typeof(DatabaseDbContext))]
    partial class DatabaseDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("occurrensBackend.Entities.DatabaseEntities.Address", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Apartament_number")
                        .HasColumnType("text");

                    b.Property<string>("Building_number")
                        .IsRequired()
                        .HasColumnType("text");

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

                    b.Property<string>("Town")
                        .IsRequired()
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

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Id_disease")
                        .HasColumnType("integer");

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

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Secont_name")
                        .HasColumnType("text");

                    b.Property<int>("Telephon_number")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("occurrensBackend.Entities.DatabaseEntities.Is_opened", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("AddressId")
                        .IsRequired()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("AddressId1")
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

                    b.HasIndex("AddressId")
                        .IsUnique();

                    b.HasIndex("AddressId1");

                    b.ToTable("Is_opened");
                });

            modelBuilder.Entity("occurrensBackend.Entities.DatabaseEntities.Patient", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("Acceptation")
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

                    b.Property<int>("Pesel")
                        .HasColumnType("integer");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Secont_name")
                        .HasColumnType("text");

                    b.Property<int>("Telephon_number")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("occurrensBackend.Entities.DatabaseEntities.Spetialization", b =>
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

                    b.ToTable("Spetializations");
                });

            modelBuilder.Entity("occurrensBackend.Entities.DatabaseEntities.Visits", b =>
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
                        .WithOne("Is_opened")
                        .HasForeignKey("occurrensBackend.Entities.DatabaseEntities.Is_opened", "AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("occurrensBackend.Entities.DatabaseEntities.Address", null)
                        .WithMany("is_opened")
                        .HasForeignKey("AddressId1");

                    b.Navigation("Address");
                });

            modelBuilder.Entity("occurrensBackend.Entities.DatabaseEntities.Spetialization", b =>
                {
                    b.HasOne("occurrensBackend.Entities.DatabaseEntities.Doctor", "Doctor")
                        .WithMany("spetializations")
                        .HasForeignKey("DoctorId");

                    b.Navigation("Doctor");
                });

            modelBuilder.Entity("occurrensBackend.Entities.DatabaseEntities.Visits", b =>
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
                    b.Navigation("Is_opened")
                        .IsRequired();

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
