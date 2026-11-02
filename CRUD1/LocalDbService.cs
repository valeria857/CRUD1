using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD1
{
    public class LocalDbService
    {
        private const string DB_NAME = "demo_local_db.db3";
        private readonly SQLiteAsyncConnection _connection;

        public LocalDbService()
        {
            _connection = new SQLiteAsyncConnection(Path.Combine(FileSystem.AppDataDirectory, DB_NAME));

            //Le indica al sistema que crea la tabla de nuestra contexto
            _connection.CreateTableAsync<Cliente>();
        }

        //Método para listar los registros de nuestra tabla
        public async Task<List<Cliente>> GetClientes()
        {
            return await _connection.Table<Cliente>().ToListAsync();
        }

        //Método para listar los registro por id
        public async Task<Cliente> GetById(int id)
        {
            return await _connection.Table<Cliente>().Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        //Método para crear registro
        public async Task Create(Cliente clientes)
        {
            await _connection.InsertAsync(clientes);
        }

        //Método para actualizar
        public async Task Update(Cliente clientes)
        {
            await _connection.UpdateAsync(clientes);
        }

        //Método para eliminar
        public async Task Delete(Cliente clientes)
        {
            await _connection.DeleteAsync(clientes);
        }
    }
}
