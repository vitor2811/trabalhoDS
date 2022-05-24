using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;




namespace program
    {
        class Program
        {
            static void Main(string[] args)
            {
                MySqlConnection conexao = new MySqlConnection("server=localhost;database=fila;uid=root;password=root;port=3306");
                try
                {
                    conexao.Open();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("erro ao acessar o banco de dados, contate o administrador!");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                String sql = "SELECT * FROM pessoa ";
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Console.WriteLine("Id:{0} Nome:{1} Senha:{2}", rdr["cpf"], rdr["nome"], rdr["idade"]); Console.ReadKey();
                    Console.ReadKey();
                }
                Console.ReadKey();
            }
        }
    }

    

