using System;
using System.ComponentModel.DataAnnotations;

public class Empleado
{
    [Key]
    public int EmpleadoId { get; set; }

    [Required]
    [StringLength(100, MinimumLength = 2)]
    public string Nombre { get; set; }

    [Required]
    [DataType(DataType.Date)]
    public DateTime FechaNacimiento { get; set; }

    [Required]
    [DataType(DataType.Date)]
    public DateTime FechaContratacion { get; set; }

    [Required]
    public int DepartamentoId { get; set; }
    public Departamento Departamento { get; set; }

    [Required]
    [Range(1, double.MaxValue, ErrorMessage = "El salario debe ser un valor positivo.")]
    public decimal Salario { get; set; }

    public string? Descripcion { get; set; }
}
