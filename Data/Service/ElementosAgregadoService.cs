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
    public class ElementosAgregadoService : IElementosAgregadoService
    {
        //Connecction Sql Server
        private readonly SqlConnectionConfiguration _configuration;
        public ElementosAgregadoService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<bool> ElementosAgregadoInsert(ElementosAgregado elementoagregado)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                var parameters = new DynamicParameters();
                parameters.Add("fk_cod_carro", elementoagregado.fk_cod_carro, DbType.Int32);
                parameters.Add("fk_cod_producto", elementoagregado.fk_cod_producto, DbType.Int32);
                parameters.Add("cantidad", elementoagregado.cantidad, DbType.Int32);

                const string query = @"INSERT INTO elementosAgregado (fk_cod_carro,fk_cod_producto,cantidad)
                                     VALUES (@fk_cod_carro,@fk_cod_producto, @fcantidad)";
                await conn.ExecuteAsync(query, new
                {
                    elementoagregado.fk_cod_carro,
                    elementoagregado.fk_cod_producto,
                    elementoagregado.cantidad
                },
                    commandType: CommandType.Text);
            }
            return true;
        }
    }
}
