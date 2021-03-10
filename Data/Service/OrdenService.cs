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
    public class OrdenService : IOrdenService
    {
        //Connecction Sql Server
        private readonly SqlConnectionConfiguration _configuration;
        public OrdenService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<bool> OrdenInsert(Orden orden)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                var parameters = new DynamicParameters();
                parameters.Add("pk_cod_order", orden.pk_cod_order, DbType.Int32);
                parameters.Add("fk_cod_carro", orden.fk_cod_carro, DbType.Int32);
                parameters.Add("total_pagar", orden.total_pagar, DbType.Double);
                parameters.Add("direccion_envio", orden.direccion_envio, DbType.String);

                const string query = @"INSERT INTO producto (pk_cod_order,fk_cod_carro,total_pagar,
                                    direccion_envio)
                                     VALUES (@pk_cod_order,@fk_cod_carro, @total_pagar,
                                     @direccion_envio)";
                await conn.ExecuteAsync(query, new
                {
                    orden.pk_cod_order,
                    orden.fk_cod_carro,
                    orden.total_pagar,
                    orden.direccion_envio
                },
                    commandType: CommandType.Text);
            }
            return true;
        }
    }
}
