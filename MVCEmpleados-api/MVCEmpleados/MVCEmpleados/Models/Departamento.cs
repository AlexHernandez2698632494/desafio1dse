using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Departamento
{
    [Key]
    public int DepartamentoId { get; set; }

    [Required]
    [StringLength(100, MinimumLength = 3)]
    public string Nombre { get; set; }

    public string? Descripcion { get; set; }
    public ICollection<Empleado> Empleados { get; set; }
}
