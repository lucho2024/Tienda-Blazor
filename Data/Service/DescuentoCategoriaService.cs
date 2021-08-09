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
    public class DescuentoCategoriaService : IDescuentoCategoriaService
    {
        //Connecction Sql Server
        private readonly SqlConnectionConfiguration _configuration;
        public DescuentoCategoriaService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<bool> InsertarDescuento(DescuentoCategoria descuento)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                var parameters = new DynamicParameters();

                parameters.Add("fk_cod_categoria", descuento.fk_cod_categoria, DbType.Int32);
                parameters.Add("porcentaje", descuento.porcentaje, DbType.Double);


                string query = @"
                    delete descuentoCategoria where fk_cod_categoria=@fk_cod_categoria
                    INSERT INTO descuentoCategoria (fk_cod_categoria,porcentaje)
                                     VALUES (@fk_cod_categoria, @porcentaje)" +
              "update producto set precioDescuento=(precio-(precio*(@porcentaje)/100)) where fk_cod_categoria=@fk_cod_categoria";
                await conn.ExecuteAsync(query, new
                {
                    descuento.fk_cod_categoria,
                    descuento.porcentaje
                },
                    commandType: CommandType.Text);
            }
            return true;
        }
        public async Task<bool> EliminarDescuento(int id)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                var parameters = new DynamicParameters();


                string query = "delete descuentoCategoria where fk_cod_categoria=" + id +
                    "update producto set precioDescuento=0 where fk_cod_categoria=" + id;

                await conn.QueryAsync<DescuentoCategoria>(query, commandType: CommandType.Text);
                await conn.QueryAsync<Producto>(query, commandType: CommandType.Text);
            }
            return true;
        }
        public async Task<IEnumerable<DescuentoCategoria>> GetAlldescuentos()
        {
            IEnumerable<DescuentoCategoria> descuentos;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = "SELECT * FROM descuentoCategoria";
                descuentos = await conn.QueryAsync<DescuentoCategoria>(query, commandType: CommandType.Text);
            }

            return descuentos;
        }
    }
}
