using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;
using OnlineBlazorApp.Data.Model;

namespace OnlineBlazorApp.Data.Service
{
    public class UsuarioService : IUsuarioService
    {
        //Connecction Sql Server
        private readonly SqlConnectionConfiguration _configuration;
        public UsuarioService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<bool> UsuarioInsert(Usuario usuario)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                var parameters = new DynamicParameters();
                parameters.Add("nombre", usuario.nombre, DbType.String);
                parameters.Add("email", usuario.email, DbType.String);
                parameters.Add("pass", usuario.pass, DbType.String);
                parameters.Add("direccion", usuario.direccion, DbType.String);
                parameters.Add("telefono", usuario.telefono, DbType.String);

                const string query = @"INSERT INTO usuario (fk_cod_tienda,nombre,email,pass,direccion,telefono)
                     VALUES (1, @nombre,@email,@pass,@direccion,@telefono)";
                await conn.ExecuteAsync(query, new
                {
                    usuario.nombre,
                    usuario.email,
                    usuario.pass,
                    usuario.direccion,
                    usuario.telefono
                },
                    commandType: CommandType.Text);
            }
            return true;
        }
        public async Task<bool> UsuarioUpdate(Usuario usuario)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                var parameters = new DynamicParameters();

                parameters.Add("pass", usuario.pass, DbType.String);


                const string query = @"update usuario set pass = @pass)";
                await conn.ExecuteAsync(query, new
                {
                    usuario.nombre,
                    usuario.email,
                    usuario.pass,
                    usuario.direccion,
                    usuario.telefono
                },
                    commandType: CommandType.Text);
            }
            return true;
        }
        public async Task<bool> UsuarioRead(Usuario usuario)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                var parameters = new DynamicParameters();

                parameters.Add("email", usuario.email, DbType.String);


                const string query = @"Select * from  usuario where email=@email";
                await conn.ExecuteAsync(query, new
                {
                    usuario.email
                },
                    commandType: CommandType.Text);
            }
            return true;
        }

        public async Task<bool> UsuarioDelete(Usuario usuario)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                var parameters = new DynamicParameters();

                parameters.Add("email", usuario.email, DbType.String);


                const string query = @"delete from usuario where email=@email";
                await conn.ExecuteAsync(query, new
                {
                    usuario.email
                },
                    commandType: CommandType.Text);
            }
            return true;
        }
    }
}
