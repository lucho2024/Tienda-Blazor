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
                parameters.Add("pk_cod_producto", producto.pk_cod_producto, DbType.Int32);
                parameters.Add("fk_cod_tienda", producto.fk_cod_tienda, DbType.Int32);
                parameters.Add("fk_cod_categoria", producto.fk_cod_categoria, DbType.Int32);
                parameters.Add("nombre", producto.nombre, DbType.String);
                parameters.Add("cantidad", producto.cantidad, DbType.Int32);
                parameters.Add("descripcion", producto.descripcion, DbType.String);
                parameters.Add("precio", producto.precio, DbType.Double);


                const string query = @"INSERT INTO orden (pk_cod_producto,fk_cod_tienda,fk_cod_categoria,
                                    nombre,cantidad,descripcion,precio)
                                     VALUES (@pk_cod_producto,@fk_cod_tienda, @fk_cod_categoria,
                                     @nombre,@cantidad,@ddescripcion,@precio)";
                await conn.ExecuteAsync(query, new
                {
                    producto.pk_cod_producto,
                    producto.fk_cod_tienda,
                    producto.fk_cod_categoria,
                    producto.nombre,
                    producto.cantidad,
                    producto.descripcion,
                    producto.precio
                },
                    commandType: CommandType.Text);
            }
            return true;
        }
    }
}
