using Empresa.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Db
{
    public class ClienteDb
    {

        //LIstar
        public List<Cliente> Listar()
        {
            string sql = @"SELECT * FROM Cliente";
            var cn = new SqlConnection(Db.Conexao);
            var cmd = new SqlCommand(sql, cn);

            cn.Open();

            List<Cliente> lista = new List<Cliente>();

          

            SqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {

                var cliente = new Cliente();

                cliente.Id = Convert.ToInt32(reader["Id"]);
                cliente.Nome = reader["Nome"].ToString();
                cliente.Email = reader["Email"].ToString();
                cliente.Telefone = reader["Telefone"].ToString();


                lista.Add(cliente);

            }


            reader.Close();
            cn.Close();


            return lista;




        }

        //Inserir
        public void Inserir(Cliente cliente)
        {
            string sql = @"INSERT INTO Cliente (Nome, Email, Telefone)VALUES(@Nome, @Email, @Telefone)";
            var cn = new SqlConnection(Db.Conexao);
            var cmd = new SqlCommand(sql, cn);


            cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
            cmd.Parameters.AddWithValue("@Email", cliente.Email);
            cmd.Parameters.AddWithValue("@Telefone", cliente.Telefone);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();


        }

        //Atualizar
        public void Atualizar(Cliente cliente)
        {
            string sql = @"UPDATE Cliente SET Nome = @Nome, Email = @Email, Telefone = @Telefone WHERE Id = @Id";
            var cn = new SqlConnection(Db.Conexao);
            var cmd = new SqlCommand(sql, cn);


            cmd.Parameters.AddWithValue("@Id", cliente.Id);
            cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
            cmd.Parameters.AddWithValue("@Email", cliente.Email);
            cmd.Parameters.AddWithValue("@Telefone", cliente.Telefone);


            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();

        }

        //Excluir
        public void Excluir(int id)
        {
            string sql = @"DELETE Cliente WHERE Id = @Id";
            var cn = new SqlConnection(Db.Conexao);
            var cmd = new SqlCommand(sql, cn);


            cmd.Parameters.AddWithValue("@Id", id);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();

        }


        //Metodos Para ASP.NET WEB
        //Listar
        public Cliente ObterPorId (int id)
        {
            string sql = @"SELECT * FROM Cliente WHERE Id = @Id";
            var cn = new SqlConnection(Db.Conexao);
            var cmd = new SqlCommand(sql, cn);

            cmd.Parameters.AddWithValue("@Id", id);

            cn.Open();

            Cliente cliente = null;

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {

                cliente = new Cliente();

                cliente.Id = Convert.ToInt32(reader["Id"]);
                cliente.Nome = reader["Nome"].ToString();
                cliente.Email = reader["Email"].ToString();
                cliente.Telefone = reader["Telefone"].ToString();


            }

            reader.Close();
            cn.Close();


            return cliente;


        }

    }
}
