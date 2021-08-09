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
    public class CarroCompraService : ICarroCompraService
    {
        //Connecction Sql Server
        private readonly SqlConnectionConfiguration _configuration;
        public CarroCompraService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<bool> CarroCompraInsert(CarroCompra carrocompra)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                var parameters = new DynamicParameters();
                parameters.Add("pk_cod_carro", carrocompra.pk_cod_carro, DbType.Int32);
                parameters.Add("fk_usuario", carrocompra.fk_usuario, DbType.Int32);

                const string query = @"INSERT INTO carroCompra (pk_cod_carro,fk_usuario)
                                     VALUES (@pk_cod_carro,@fk_usuario)";
                await conn.ExecuteAsync(query, new
                {
                    carrocompra.pk_cod_carro,
                    carrocompra.fk_usuario
                },
                    commandType: CommandType.Text);
            }
            return true;
        }
    }
}
