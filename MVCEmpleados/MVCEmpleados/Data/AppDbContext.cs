using Microsoft.EntityFrameworkCore;
using MVCEmpleados.Models;

namespace MVCEmpleados.Data
{
    public class AppDbContext : DbContext  // Hereda de DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Define los DbSet para cada entidad
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Empleado> Empleados { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Data Seeding para Departamentos
            modelBuilder.Entity<Departamento>().HasData(
                new Departamento { DepartamentoId = 1, Nombre = "Recursos Humanos" },
                new Departamento { DepartamentoId = 2, Nombre = "Tecnología" },
                new Departamento { DepartamentoId = 3, Nombre = "Ventas" }
            );

            // Data Seeding para Empleados
            modelBuilder.Entity<Empleado>().HasData(
                new Empleado { EmpleadoId = 1, Nombre = "John Doe", FechaNacimiento = new DateTime(1985, 5, 20), FechaContratacion = new DateTime(2010, 8, 15), Salario = 50000, DepartamentoId = 1 },
                new Empleado { EmpleadoId = 2, Nombre = "Jane Smith", FechaNacimiento = new DateTime(1990, 3, 10), FechaContratacion = new DateTime(2015, 1, 25), Salario = 70000, DepartamentoId = 2 },
                new Empleado { EmpleadoId = 3, Nombre = "Mark Johnson", FechaNacimiento = new DateTime(1982, 11, 22), FechaContratacion = new DateTime(2012, 6, 18), Salario = 55000, DepartamentoId = 3 },
                new Empleado { EmpleadoId = 4, Nombre = "Emily Davis", FechaNacimiento = new DateTime(1978, 7, 30), FechaContratacion = new DateTime(2005, 10, 12), Salario = 75000, DepartamentoId = 1 },
                new Empleado { EmpleadoId = 5, Nombre = "Michael Brown", FechaNacimiento = new DateTime(1995, 12, 5), FechaContratacion = new DateTime(2020, 4, 15), Salario = 60000, DepartamentoId = 2 }
            );
        }
    }
}