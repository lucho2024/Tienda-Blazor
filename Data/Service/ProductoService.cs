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
    public class ProductoService : IProductoService
    {
        //Connecction Sql Server
        private readonly SqlConnectionConfiguration _configuration;
        public ProductoService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<bool> ProductoInsert(Producto producto)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                var parameters = new DynamicParameters();
               
                parameters.Add("nombre", producto.nombre, DbType.String);
                parameters.Add("cantidad", producto.cantidad, DbType.Int32);
                parameters.Add("descripcion", producto.descripcion, DbType.String);
                parameters.Add("precio", producto.precio, DbType.Double);
                parameters.Add("imagen", producto.imagen, DbType.String);


                const string query = @"INSERT INTO producto (fk_cod_tienda,fk_cod_categoria,nombre,cantidad,descripcion,precio,imagen)
                                     VALUES (1, 1,@nombre,@cantidad,@descripcion,@precio,@imagen)";
                await conn.ExecuteAsync(query, new
                {
                 
                    producto.nombre,
                    producto.cantidad,
                    producto.descripcion,
                    producto.precio,
                    producto.imagen,
                },
                    commandType: CommandType.Text);
            }
            return true;
        }
    }
}
