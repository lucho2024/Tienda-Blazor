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
                parameters.Add("fk_cod_categoria", producto.cantidad, DbType.Int32);
                parameters.Add("descripcion", producto.descripcion, DbType.String);
                parameters.Add("precio", producto.precio, DbType.Double);
                parameters.Add("imagen", producto.imagen, DbType.String);

                const string query = @"INSERT INTO producto(fk_cod_categoria,nombre,cantidad,descripcion,precio,imagen)
                                     VALUES (@fk_cod_categoria,@nombre,@cantidad,@descripcion,@precio,@imagen)";


                await conn.ExecuteAsync(query, new
                {

                    producto.nombre,
                    producto.cantidad,
                    producto.fk_cod_categoria,
                    producto.descripcion,
                    producto.precio,
                    producto.imagen,
                },
                    commandType: CommandType.Text);
            }
            return true;
        }
        public async Task<bool> ProductoUpdate(Producto producto)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                var parameters = new DynamicParameters();
                parameters.Add("pk_cod_producto", producto.pk_cod_producto, DbType.Int32);
                parameters.Add("nombre", producto.nombre, DbType.String);
                parameters.Add("cantidad", producto.cantidad, DbType.Int32);
                parameters.Add("fk_cod_categoria", producto.cantidad, DbType.Int32);
                parameters.Add("descripcion", producto.descripcion, DbType.String);
                parameters.Add("precio", producto.precio, DbType.Double);
                parameters.Add("imagen", producto.imagen, DbType.String);

                const string query = @"update producto set fk_cod_categoria=@fk_cod_categoria,
                                                            nombre=@nombre,
                                                            cantidad=@cantidad,
                                                            descripcion=@descripcion,
                                                            precio=@precio,
                                                            imagen=@imagen
                                                            where pk_cod_producto = @pk_cod_producto";
                Console.WriteLine("query" + query);
                await conn.ExecuteAsync(query, new
                {
                    producto.pk_cod_producto,
                    producto.nombre,
                    producto.cantidad,
                    producto.fk_cod_categoria,
                    producto.descripcion,
                    producto.precio,
                    producto.imagen,
                },
                    commandType: CommandType.Text);
            }
            return true;
        }
        public async Task<IEnumerable<Producto>> GetAllProductos()
        {
            IEnumerable<Producto> productos;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = "SELECT * FROM producto";
                productos = await conn.QueryAsync<Producto>(query, commandType: CommandType.Text);
            }

            return productos;
        }

        public async Task<bool> deleteIdproducto(int id)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                string query = "delete FROM producto where pk_cod_producto = " + id;
                await conn.QueryAsync<Producto>(query, commandType: CommandType.Text);
            }

            return true;
        }
        public async Task<Producto> GetProductoById(string idproducto)
        {

            using (var conn = new SqlConnection(_configuration.Value))
            {
                string query = "select * from producto " +
                    " where pk_cod_producto = " + idproducto;
                return await conn.QueryFirstOrDefaultAsync<Producto>(query.ToString(), new { pk_cod_producto = idproducto }, commandType: CommandType.Text);
            }


        }

        public async Task<IEnumerable<Producto>> GetProductoByCategory(string pk_categoria, int npagina)
        {

            int nregistros = 3;
            int paginares = npagina - 1;
            int multipr = paginares * nregistros;
            int multinpr = npagina * nregistros;


            IEnumerable<Producto> productos;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                /* string query = "select p.nombre,p.descripcion,p.precio,p.imagen from producto as p join categoria" +
                     " on p.fk_cod_categoria=categoria.pk_cod_categoria" +
                     " where categoria.pk_cod_categoria = " + pk_categoria;*/
                /*   string query = "with productos_aux as(" +
                                "select *, ROW_NUMBER() over(order by pk_cod_producto asc) as fila from producto with(nolock)" +
                                "where fk_cod_categoria = " + pk_categoria + ")" +
                                "select * from productos_aux" +
                                "where fila > (" + (npagina - 1) + ") *" + @nregistros + " and fila <= " + (@npagina * @nregistros) +")";*/
                string query = "with productos_aux as (" +
                                "select *, ROW_NUMBER() over(order by pk_cod_producto asc) as fila from producto with(nolock)" +
                                "where fk_cod_categoria = " + pk_categoria + ")" +
                                "select * from productos_aux where fila > "+multipr+" and fila <= "+multinpr+"";
                               
                productos = await conn.QueryAsync<Producto>(query, commandType: CommandType.Text);
            }

            return productos;
        }


    }
}
