using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace AgendaContatos.Models
{
    public class ContatoDAL : IContatosDAL
    {
        string connectionString = @"Data Source=LocalHost;Initial Catalog=CadastroContato;Integrated Security=True;";

        public IEnumerable<Contato> GetAllContatos()
        {
            List<Contato> lstContatos = new List<Contato>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT ContatoId, Nome,Telefone,Email from Contatos", con);
                cmd.CommandType = CommandType.Text;

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Contato contato = new Contato();

                    contato.ContatoId = Convert.ToInt32(rdr["ContatoId"]);
                    contato.Nome = rdr["Nome"].ToString();
                    contato.Telefone = rdr["Telefone"].ToString();
                    contato.Email = rdr["Email"].ToString();

                    lstContatos.Add(contato);
                }
                con.Close();
            }
            return lstContatos;
        }

        public void AddContato(Contato contato)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string comandoSQL ="INSERT INTO Contatos (Nome,Telefone,Email) Values(@Nome, @Telefone, @Email)";
                SqlCommand cmd = new SqlCommand(comandoSQL, con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", contato.Nome);
                cmd.Parameters.AddWithValue("@Telefone", contato.Telefone);
                cmd.Parameters.AddWithValue("@Email", contato.Email);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        public void UpdateContato(Contato contato)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string comandoSQL = "Update Contatos set Nome = @Nome, Telefone = @Telefone, Email = @Email WHERE ContatoId = @ContatoId";
                SqlCommand cmd = new SqlCommand(comandoSQL, con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@ContatoId", contato.ContatoId);
                cmd.Parameters.AddWithValue("@Nome", contato.Nome);
                cmd.Parameters.AddWithValue("@Telefone", contato.Telefone);
                cmd.Parameters.AddWithValue("@Email", contato.Email);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public Contato GetContato(int? id)
        {
            Contato contato = new Contato();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT * FROM Contatos WHERE ContatoId = " + id;
                SqlCommand cmd = new SqlCommand(sqlQuery, con);

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    contato.ContatoId = Convert.ToInt32(rdr["ContatoId"]);
                    contato.Nome = rdr["Nome"].ToString();
                    contato.Telefone = rdr["Telefone"].ToString();
                    contato.Email = rdr["Email"].ToString();
                }
            }
            return contato;
        }
        public void DeleteContato(int? id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string comandoSQL = "Delete from Contatos where ContatoId = @ContatoId";
                SqlCommand cmd = new SqlCommand(comandoSQL, con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@ContatoId", id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
