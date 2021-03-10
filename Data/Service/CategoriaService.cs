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
    public class CategoriaService : ICategoriaService
    {
        //Connecction Sql Server
        private readonly SqlConnectionConfiguration _configuration;
        public CategoriaService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<bool> CategoriaInsert(Categoria categoria)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                var parameters = new DynamicParameters();
                parameters.Add("pk_cod_categoria", categoria.pk_cod_categoria, DbType.Int32);
                parameters.Add("nombre", categoria.nombre, DbType.String);
                parameters.Add("descripcion", categoria.descripcion, DbType.String);



                const string query = @"INSERT INTO categoria (pk_cod_categoria,nombre,descripcion)
                                     VALUES (@pk_cod_categoria,@nombre, @descripcion)";
                await conn.ExecuteAsync(query, new
                {
                    categoria.pk_cod_categoria,
                    categoria.nombre,
                    categoria.descripcion
                },
                    commandType: CommandType.Text);
            }
            return true;
        }
    }
}
