﻿// <auto-generated />
using System;
using MVCEmpleados.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MVCEmpleados.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240811010706_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Departamento", b =>
                {
                    b.Property<int>("DepartamentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartamentoId"));

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("DepartamentoId");

                    b.ToTable("Departamentos");

                    b.HasData(
                        new
                        {
                            DepartamentoId = 1,
                            Nombre = "Recursos Humanos"
                        },
                        new
                        {
                            DepartamentoId = 2,
                            Nombre = "Tecnología"
                        },
                        new
                        {
                            DepartamentoId = 3,
                            Nombre = "Ventas"
                        });
                });

            modelBuilder.Entity("Empleado", b =>
                {
                    b.Property<int>("EmpleadoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmpleadoId"));

                    b.Property<int>("DepartamentoId")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaContratacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Salario")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("EmpleadoId");

                    b.HasIndex("DepartamentoId");

                    b.ToTable("Empleados");

                    b.HasData(
                        new
                        {
                            EmpleadoId = 1,
                            DepartamentoId = 1,
                            FechaContratacion = new DateTime(2010, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FechaNacimiento = new DateTime(1985, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "John Doe",
                            Salario = 50000m
                        },
                        new
                        {
                            EmpleadoId = 2,
                            DepartamentoId = 2,
                            FechaContratacion = new DateTime(2015, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FechaNacimiento = new DateTime(1990, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Jane Smith",
                            Salario = 70000m
                        },
                        new
                        {
                            EmpleadoId = 3,
                            DepartamentoId = 3,
                            FechaContratacion = new DateTime(2012, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FechaNacimiento = new DateTime(1982, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Mark Johnson",
                            Salario = 55000m
                        },
                        new
                        {
                            EmpleadoId = 4,
                            DepartamentoId = 1,
                            FechaContratacion = new DateTime(2005, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FechaNacimiento = new DateTime(1978, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Emily Davis",
                            Salario = 75000m
                        },
                        new
                        {
                            EmpleadoId = 5,
                            DepartamentoId = 2,
                            FechaContratacion = new DateTime(2020, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FechaNacimiento = new DateTime(1995, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Michael Brown",
                            Salario = 60000m
                        });
                });

            modelBuilder.Entity("Empleado", b =>
                {
                    b.HasOne("Departamento", "Departamento")
                        .WithMany("Empleados")
                        .HasForeignKey("DepartamentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departamento");
                });

            modelBuilder.Entity("Departamento", b =>
                {
                    b.Navigation("Empleados");
                });
#pragma warning restore 612, 618
        }
    }
}
