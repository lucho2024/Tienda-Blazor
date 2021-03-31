using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;
using OnlineBlazorApp.Data.Model;
using Microsoft.AspNetCore.Http;


namespace OnlineBlazorApp.Data.Service
{
    public class AspNetUsersService
    {
        IHttpContextAccessor httpContextAccessor;
        //Connecction Sql Server
        private readonly SqlConnectionConfiguration _configuration;
        public AspNetUsersService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<IEnumerable<AspNetUsers>> GetUsuario()
        {
            IEnumerable<AspNetUsers> usuario;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                if (httpContextAccessor.HttpContext.User.Identity.Name != null)
                {
                    var query = "SELECT * FROM AspNetUsers where email = "+
                        httpContextAccessor.HttpContext.User.Identity.Name;
                    usuario = await conn.QueryAsync<AspNetUsers>(query, commandType: CommandType.Text);

                    return usuario;
                }
                return null;
            }
           
           
        }
    }
}
