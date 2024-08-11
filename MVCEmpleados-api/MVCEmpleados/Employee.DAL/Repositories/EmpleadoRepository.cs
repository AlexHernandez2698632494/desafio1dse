using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Employee.Entities;
using System.Data;
using Employee.DAL.Interfaces;

namespace Employee.DAL.Repositories
{
    public class EmpleadoRepository : IEmpleadoRepository
    {
        private readonly IDbConnection _dbConnection;

        public EmpleadoRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<IEnumerable<Empleado>> GetAllAsync()
        {
            var sql = "SELECT * FROM Empleados";
            return await _dbConnection.QueryAsync<Empleado>(sql);
        }

        public async Task<Empleado> GetByIdAsync(int id)
        {
            var sql = "SELECT * FROM Empleados WHERE EmpleadoId = @Id";
            return await _dbConnection.QueryFirstOrDefaultAsync<Empleado>(sql, new { Id = id });
        }

        public async Task AddAsync(Empleado empleado)
        {
            var sql = "INSERT INTO Empleados (Nombre, FechaNacimiento, FechaContratacion, Salario, Descripcion, DepartamentoId) VALUES (@Nombre, @FechaNacimiento, @FechaContratacion, @Salario, @Descripcion, @DepartamentoId)";
            await _dbConnection.ExecuteAsync(sql, empleado);
        }

        public async Task UpdateAsync(Empleado empleado)
        {
            var sql = "UPDATE Empleados SET Nombre = @Nombre, FechaNacimiento = @FechaNacimiento, FechaContratacion = @FechaContratacion, Salario = @Salario, Descripcion = @Descripcion, DepartamentoId = @DepartamentoId WHERE EmpleadoId = @EmpleadoId";
            await _dbConnection.ExecuteAsync(sql, empleado);
        }

        public async Task DeleteAsync(int id)
        {
            var sql = "DELETE FROM Empleados WHERE EmpleadoId = @Id";
            await _dbConnection.ExecuteAsync(sql, new { Id = id });
        }
    }
}
