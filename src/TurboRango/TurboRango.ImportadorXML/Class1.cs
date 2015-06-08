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
    class Restaurantes
    {
        internal string ConnectionString { get; private set; }

        public Restaurantes(string ConnectionString)
        {
            //criado construtor para que sempre ocorra uma conexao obrigue informar a connexao
            this.ConnectionString = ConnectionString;
        }


        /// <summary>
        /// Insere um novo restaurante no banco de dados
        /// </summary>
        /// <param name="restaurante"></param>
        public void Inserir(Restaurante restaurante)
        {
            using (var connection = new SqlConnection(this.ConnectionString))
            {
                string comandoSQL = "INSERT INTO [dbo].[Restaurante] ([Nome], [Capacidade], [Categoria], [ContatoId], [LocalizacaoId])"
                +"VALUES (@Nome, @Capacidade, @Categoria, @ContatoId, @LocalizacaoId)";
                using (var inserirRestaurante = new SqlCommand(comandoSQL, connection))
                {
                    inserirRestaurante.Parameters.Add("@Nome", SqlDbType.NVarChar).Value = restaurante.Nome;
                    inserirRestaurante.Parameters.Add("@Capacidade", SqlDbType.Int).Value = restaurante.Capacidade;
                    inserirRestaurante.Parameters.Add("@Categoria", SqlDbType.NVarChar).Value = restaurante.Categoria.ToString();
                    inserirRestaurante.Parameters.Add("@ContatoId", SqlDbType.Int).Value = InserirContato(restaurante.Contato);
                    inserirRestaurante.Parameters.Add("@LocalizacaoId", SqlDbType.Int).Value = InserirLocalizacao(restaurante.Localizacao);

                    connection.Open();
                    inserirRestaurante.ExecuteNonQuery();
                }
            }
        }
        /// <summary>
        /// Metodo para inserir um novo contato ao banco de dados
        /// </summary>
        /// <param name="contato"></param>
        /// <returns></returns>
        private int InserirContato(Contato contato)
        {
            int idCriado = 0;
            using (var connection = new SqlConnection(this.ConnectionString))
            {
                string comandoSQL = "INSERT INTO [dbo].[Contato] ([Site], [Telefone]) VALUES (@Site, @Telefone)";
                string id = "SELECT @@IDENTITY";
                using (var inserirContato = new SqlCommand(comandoSQL, connection))
                {
                    inserirContato.Parameters.Add("@Site", SqlDbType.NVarChar).Value = contato.Site ?? (object)DBNull.Value;
                    inserirContato.Parameters.Add("@Telefone", SqlDbType.NVarChar).Value = contato.Telefone ?? (object)DBNull.Value;

                    connection.Open();
                    inserirContato.ExecuteNonQuery();
                    inserirContato.CommandText = id;
                    idCriado = Convert.ToInt32(inserirContato.ExecuteScalar());
                }
            }
            return idCriado;
        }

        /// <summary>
        /// Metodo para inserir localizaçao de um restaurante
        /// </summary>
        /// <param name="localizacao"></param>
        /// <returns></returns>
        private int InserirLocalizacao(Localizacao localizacao)
        {
            int idCriado = 0;
            using (var connection = new SqlConnection(this.ConnectionString))
            {
                string comandoSQL = "INSERT INTO [dbo].[Localizacao] ([Bairro], [Logradouro], [Latitude], [Longitude]) VALUES (@Bairro, @Logradouro, @Latitude, @Longitude)";
                string id = "SELECT @@IDENTITY";
                using (var inserirLocalizacao = new SqlCommand(comandoSQL, connection))
                {
                    inserirLocalizacao.Parameters.Add("@Bairro", SqlDbType.NVarChar).Value = localizacao.Bairro;
                    inserirLocalizacao.Parameters.Add("@Logradouro", SqlDbType.NVarChar).Value = localizacao.Logradouro;
                    inserirLocalizacao.Parameters.Add("@Latitude", SqlDbType.Float).Value = localizacao.Latitude;
                    inserirLocalizacao.Parameters.Add("@Longitude", SqlDbType.Float).Value = localizacao.Longitude;

                    connection.Open();
                    inserirLocalizacao.ExecuteNonQuery();
                    inserirLocalizacao.CommandText = id;
                    idCriado = Convert.ToInt32(inserirLocalizacao.ExecuteScalar());
                }
            }

            return idCriado;
        }



    }
}
