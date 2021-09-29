using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Microsoft.Extensions.Configuration;


namespace EstudoWebApiAspNet.Models.Context
{
    public class Conexao
    {


        public void Conectar()
        {

            

            SqlConnection con = new SqlConnection(_configuration["MinhaSecao:MeuPrimeiroConfig"]);


                con.Open();

        }
    }
}
