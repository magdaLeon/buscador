﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebDbApp.Miscellaneous;

#nullable disable

namespace WebDbApp2.Migrations
{
    [DbContext(typeof(DataAccess))]
    partial class DataAccessModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.8");

            modelBuilder.Entity("Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<int?>("MateriaId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("Models.Decanato", b =>
                {
                    b.Property<int>("DecanatoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<int>("NivelId")
                        .HasColumnType("INTEGER");

                    b.HasKey("DecanatoId");

                    b.HasIndex("NivelId");

                    b.ToTable("Decanato");

                    b.HasData(
                        new
                        {
                            DecanatoId = 1,
                            Descripcion = "DCyT",
                            NivelId = 1
                        });
                });

            modelBuilder.Entity("Models.Departamento", b =>
                {
                    b.Property<int>("DeptoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("DecanatoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.HasKey("DeptoId");

                    b.HasIndex("DecanatoId");

                    b.ToTable("Departamento");

                    b.HasData(
                        new
                        {
                            DeptoId = 1,
                            DecanatoId = 1,
                            Descripcion = "Ciencias Computacionales"
                        });
                });

            modelBuilder.Entity("Models.Materia", b =>
                {
                    b.Property<int>("MateriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CodigoClase")
                        .HasColumnType("TEXT");

                    b.Property<string>("Creditos")
                        .HasColumnType("TEXT");

                    b.Property<string>("CursosASU")
                        .HasColumnType("TEXT");

                    b.Property<int>("DepartamentoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<string>("FechaActualizacion")
                        .HasColumnType("TEXT");

                    b.Property<string>("FechaIni")
                        .HasColumnType("TEXT");

                    b.Property<string>("NivelASU")
                        .HasColumnType("TEXT");

                    b.Property<string>("ObjetivoAprend")
                        .HasColumnType("TEXT");

                    b.Property<string>("Term")
                        .HasColumnType("TEXT");

                    b.Property<string>("UrlCurso")
                        .HasColumnType("TEXT");

                    b.Property<string>("UrlDownload")
                        .HasColumnType("TEXT");

                    b.Property<string>("Version")
                        .HasColumnType("TEXT");

                    b.HasKey("MateriaId");

                    b.HasIndex("DepartamentoId");

                    b.ToTable("Materia");

                    b.HasData(
                        new
                        {
                            MateriaId = 1,
                            DepartamentoId = 1,
                            Descripcion = "Redes I"
                        });
                });

            modelBuilder.Entity("Models.NivelAcademico", b =>
                {
                    b.Property<int>("NivelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.HasKey("NivelId");

                    b.ToTable("NivelAcademico");

                    b.HasData(
                        new
                        {
                            NivelId = 1,
                            Descripcion = "EDUCACION BASICA"
                        },
                        new
                        {
                            NivelId = 2,
                            Descripcion = "EDUCACION MEDIA"
                        },
                        new
                        {
                            NivelId = 3,
                            Descripcion = "EDUCACION SUPERIOR"
                        });
                });

            modelBuilder.Entity("Models.Decanato", b =>
                {
                    b.HasOne("Models.NivelAcademico", "NivelAcademico")
                        .WithMany("Decanatos")
                        .HasForeignKey("NivelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NivelAcademico");
                });

            modelBuilder.Entity("Models.Departamento", b =>
                {
                    b.HasOne("Models.Decanato", "Decanato")
                        .WithMany("Departamentos")
                        .HasForeignKey("DecanatoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Decanato");
                });

            modelBuilder.Entity("Models.Materia", b =>
                {
                    b.HasOne("Models.Departamento", "Depto")
                        .WithMany("Materias")
                        .HasForeignKey("DepartamentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Depto");
                });

            modelBuilder.Entity("Models.Decanato", b =>
                {
                    b.Navigation("Departamentos");
                });

            modelBuilder.Entity("Models.Departamento", b =>
                {
                    b.Navigation("Materias");
                });

            modelBuilder.Entity("Models.NivelAcademico", b =>
                {
                    b.Navigation("Decanatos");
                });
#pragma warning restore 612, 618
        }
    }
}
