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
    public class TiendaService : ITiendaService
    {
        //Connecction Sql Server
        private readonly SqlConnectionConfiguration _configuration;
        public TiendaService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<bool> TiendaInsert(Tienda tienda)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                var parameters = new DynamicParameters();
                parameters.Add("pk_cod_tienda", tienda.pk_cod_tienda, DbType.Int32);
                parameters.Add("nombre", tienda.nombre, DbType.String);

                const string query = @"INSERT INTO tienda (pk_cod_tienda,nombre)
                     VALUES (@pk_cod_tienda, @nombre)";
                await conn.ExecuteAsync(query, new { tienda.pk_cod_tienda, tienda.nombre }, commandType: CommandType.Text);
            }
            return true;
        }
    }
}
