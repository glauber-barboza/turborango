using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurboRango.Dominio;

namespace TurboRango.ImportadorXML
{
    public class CarinhaQueManipulaOBanco
    {
        private string connectionString;
        public CarinhaQueManipulaOBanco(string connectionsString)
        {
            this.connectionString = connectionsString;
        }

        internal void Inserir(Contato contato)
        {
            using (var connection = new SqlConnection(this.connectionString))
            {

                String comandoSQL = "INSERT INTO contato (Site, Telefone) VALUES (@Site,@Telefone)";
                SqlCommand inserirContato = new SqlCommand(comandoSQL, connection);
                inserirContato.Parameters.Add("@Site", SqlDbType.NVarChar).Value = contato.Site;
                inserirContato.Parameters.Add("@Telefone", SqlDbType.NVarChar).Value = contato.Telefone;

                connection.Open();
                int resultado = inserirContato.ExecuteNonQuery();

            }
        }


        internal IEnumerable<Contato> getContatos()
        {
            using (var connection = new SqlConnection(this.connectionString))
            {

                String comandoSQL = "select Site, Telefone from contato";
                using (SqlCommand LerContatos = new SqlCommand(comandoSQL, connection))
                {
                connection.Open();
                var reader = LerContatos.ExecuteReader();
                }
               
                int resultado = inserirContato.ExecuteNonQuery();

            }
        }

    }
}