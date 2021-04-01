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
    public class AspNetUsersService : IAspNetUsersService
    {

        //Connecction Sql Server
        private readonly SqlConnectionConfiguration _configuration;
        public AspNetUsersService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<IEnumerable<AspNetUsers>> GetUsuario(string email)
        {
            IEnumerable<AspNetUsers> usuarios;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                string query = @"select * from AspNetUsers where email = "+"'"+email+"'";
                usuarios = await conn.QueryAsync<AspNetUsers>(query, commandType: CommandType.Text);
                
            }
            return usuarios;
        }
    }
}
