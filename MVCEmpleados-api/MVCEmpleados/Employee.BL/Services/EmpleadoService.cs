using Employee.BL.Interfaces;
using AutoMapper;
using Employee.DAL.Interfaces;
using Employee.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.BL.Services
{
    public class EmpleadoService : IEmpleadoService
    {
        private readonly IEmpleadoRepository _empleadoRepository;
        private readonly IMapper _mapper;

        public EmpleadoService(IEmpleadoRepository empleadoRepository, IMapper mapper)
        {
            _empleadoRepository = empleadoRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<EmpleadoDto>> GetAllAsync()
        {
            var empleados = await _empleadoRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<EmpleadoDto>>(empleados);
        }

        public async Task<EmpleadoDto> GetByIdAsync(int id)
        {
            var empleado = await _empleadoRepository.GetByIdAsync(id);
            return _mapper.Map<EmpleadoDto>(empleado);
        }

        public async Task AddAsync(EmpleadoDto empleadoDto)
        {
            var empleado = _mapper.Map<Empleado>(empleadoDto);
            await _empleadoRepository.AddAsync(empleado);
        }

        public async Task UpdateAsync(EmpleadoDto empleadoDto)
        {
            var empleado = _mapper.Map<Empleado>(empleadoDto);
            await _empleadoRepository.UpdateAsync(empleado);
        }

        public async Task DeleteAsync(int id)
        {
            await _empleadoRepository.DeleteAsync(id);
        }
    }
}