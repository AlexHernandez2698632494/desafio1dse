using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee.Entities;

namespace Employee.BL.Interfaces
{
    public interface IEmpleadoService
    {
        Task<IEnumerable<EmpleadoDto>> GetAllAsync();
        Task<EmpleadoDto> GetByIdAsync(int id);
        Task AddAsync(EmpleadoDto empleadoDto);
        Task UpdateAsync(EmpleadoDto empleadoDto);
        Task DeleteAsync(int id);
    }
}
