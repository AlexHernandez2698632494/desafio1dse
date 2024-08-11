using Employee.BL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Employee.Entities;
[ApiController]
[Route("api/[controller]")]
public class EmpleadosController : ControllerBase
{
    private readonly IEmpleadoService _empleadoService;

    public EmpleadosController(IEmpleadoService empleadoService)
    {
        _empleadoService = empleadoService;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var empleados = await _empleadoService.GetAllAsync();
        return Ok(empleados);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        var empleado = await _empleadoService.GetByIdAsync(id);
        if (empleado == null) return NotFound();
        return Ok(empleado);
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] EmpleadoDto empleadoDto)
    {
        await _empleadoService.AddAsync(empleadoDto);
        return CreatedAtAction(nameof(Get), new { id = empleadoDto.EmpleadoId }, empleadoDto);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, [FromBody] EmpleadoDto empleadoDto)
    {
        if (id != empleadoDto.EmpleadoId) return BadRequest();
        await _empleadoService.UpdateAsync(empleadoDto);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _empleadoService.DeleteAsync(id);
        return NoContent();
    }
}
