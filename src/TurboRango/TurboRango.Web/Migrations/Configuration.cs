namespace TurboRango.Web.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TurboRango.Dominio;

    internal sealed class Configuration : DbMigrationsConfiguration<TurboRango.Web.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "TurboRango.Web.Models.ApplicationDbContext";
        }

        protected override void Seed(TurboRango.Web.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Restaurantes.AddOrUpdate(
                r => r.Nome,
                new Restaurante
                {
                    Nome = "GARFÃO RESTAURANTE E PIZZARIA",
                    Capacidade = 100,
                    Categoria = Categoria.Comum,
                    Localizacao = new Localizacao
                    {
                        Logradouro = "Rua Sete de Setembro, 1045",
                        Bairro = "Liberdade",
                        Latitude = -29.712571,
                        Longitude = -51.13636
                    },
                    Contato = new Contato
                    {
                        Site = "www.garfao.com",
                        Telefone = "(51) 3587-7700"
                    },
                    produtos = new Produtos
                    {
                        nome="Batata Frita",
                        preco=7.80,
                        descricao="Tiras de batatas, fritas em óleo",
                        imgPrato = "http://www.frangofamilia.com.br/wp-content/uploads/2014/11/batatafrita1.jpg"

                    }

                },
                new Restaurante
                {
                    Nome = "SEMENTE",
                    Capacidade = 40,
                    Categoria = Categoria.CozinhaNatural,
                    Localizacao = new Localizacao
                    {
                        Logradouro = "Rua: Joaquim Pedro Soares, 633",
                        Bairro = "Centro",
                        Latitude = -29.6812707,
                        Longitude = -51.1272292
                    },
                    Contato = new Contato
                    {
                        Telefone = "3595-5258"
                    }, 
                    produtos = new Produtos
                    {
                        nome="Batata Frita",
                        preco=7.80,
                        descricao="Tiras de batatas, fritas em óleo",
                        imgPrato = "http://www.frangofamilia.com.br/wp-content/uploads/2014/11/batatafrita1.jpg"

                    }

                },
                   
                new Restaurante
                {
                    Nome = "OLÉ ARMAZÉM MEXICANO",
                    Capacidade = 30,
                    Categoria = Categoria.CozinhaMexicana,
                    Localizacao = new Localizacao
                    {
                        Logradouro = "Rua Gomes Portinho, 448",
                        Bairro = "Centro",
                        Latitude = -29.682078,
                        Longitude = -51.125199
                    },
                    Contato = new Contato
                    {
                        Telefone = "3279-8828"
                    },
                    produtos = new Produtos
                    {
                        nome = "Tacos",
                        preco = 7.80,
                        descricao = "Tacos + tacos + tacos ariba ariba",
                        imgPrato = "http://img2.wikia.nocookie.net/__cb20130627145529/uncharted/images/a/a2/Taco-Bell-tacos-no-beef-meat.jpg"

                    }
                },
                new Restaurante
                {
                    Nome = "CHURRASCARIA PRIMAVERA",
                    Capacidade = 110,
                    Categoria = Categoria.Churrascaria,
                    Localizacao = new Localizacao
                    {
                        Logradouro = "BR 116, 2554, Km 31",
                        Bairro = "Primavera",
                        Latitude = -29.693741,
                        Longitude = -51.144554
                    },
                    Contato = new Contato
                    {
                        Site = "www.grupoprimaveranh.com.br",
                        Telefone = "3595-8081"
                    },
                    produtos = new Produtos
                    {
                        nome = "Mini espetinhos",
                        preco = 7.80,
                        descricao = "Mini espetinhos de todos os gostos",
                        imgPrato = "https://static.groupon.com.br/00/86/1337869288600.jpg"

                    }
                },
                new Restaurante
                {
                    Nome = "SUSHI DAI",
                    Capacidade = 40,
                    Categoria = Categoria.CozinhaJaponesa,
                    Localizacao = new Localizacao
                    {
                        Logradouro = "Bagé, 149",
                        Bairro = "Boa Vista",
                        Latitude = -29.68942,
                        Longitude = -51.125224
                    },
                    produtos = new Produtos
                    {
                        nome = "Batata Frita",
                        preco = 7.80,
                        descricao = "Tiras de batatas, fritas em óleo",
                        imgPrato = "http://www.frangofamilia.com.br/wp-content/uploads/2014/11/batatafrita1.jpg"

                    }
                },
                new Restaurante
                {
                    Nome = "TAKESHI",
                    Capacidade = 35,
                    Categoria = Categoria.CozinhaJaponesa,
                    Localizacao = new Localizacao
                    {
                        Logradouro = "Rua Confraternização, 792",
                        Bairro = "Pátria Nova",
                        Latitude = -29.698669,
                        Longitude = -51.130195
                    },
                    Contato = new Contato
                    {
                        Site = "www.grupoprimaveranh.com.br",
                        Telefone = "3066-6660"
                    },
                    produtos = new Produtos
                    {
                        nome = "Bolinho de batata",
                        preco = 7.80,
                        descricao = "Batata",
                        imgPrato = "http://www.multireceitas.com.br/wp-content/uploads/2015/05/Receita-de-Bolinho-de-Batata-Simples.jpg"

                    }
                },
                new Restaurante
                {
                    Nome = "HAI SAIKÔ",
                    Capacidade = 75,
                    Categoria = Categoria.CozinhaJaponesa,
                    Localizacao = new Localizacao
                    {
                        Logradouro = "Rua Gomes Portinho, 730",
                        Bairro = "Mauá",
                        Latitude = -29.684873,
                        Longitude = -51.122252
                    },
                    Contato = new Contato
                    {
                        Site = "www.haisaiko.com.br",
                        Telefone = "3593-5757"
                    },
                    produtos = new Produtos
                    {
                        nome = "Sushi Naruto",
                        preco = 7.80,
                        descricao = "Peixe crú e arroz",
                        imgPrato = "http://i.ytimg.com/vi/830ksHUK4Ig/maxresdefault.jpg"

                    }
                },
                new Restaurante
                {
                    Nome = "PICA-PAU LANCHES",
                    Capacidade = 30,
                    Categoria = Categoria.Fastfood,
                    Localizacao = new Localizacao
                    {
                        Logradouro = "Rua: José do Patrocínio, 880",
                        Bairro = "Rio Branco",
                        Latitude = -29.68339,
                        Longitude = -51.135376
                    },
                    Contato = new Contato
                    {
                        Site = "www.picapaulanches.com",
                        Telefone = "(51) 3593-8079"
                    },
                    produtos = new Produtos
                    {
                        nome = "Sandubão",
                        preco = 7.80,
                        descricao = "Sandubão com mortadela",
                        imgPrato = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSMdWs1gsTSSDIebFi3zgu8PV73LJNsFDnR5dWeiRVcmnpbnimq"

                    }
                },
                 new Restaurante
                {
                    Nome = "Massas do zé",
                    Capacidade = 30,
                    Categoria = Categoria.Fastfood,
                    Localizacao = new Localizacao
                    {
                        Logradouro = "Rua: José do Patrocínio, 880",
                        Bairro = "Rio Branco",
                        Latitude = -29.68339,
                        Longitude = -51.135376
                    },
                    produtos = new Produtos
                    {
                        nome = "Massa Caseira",
                        preco = 12.50,
                        descricao = "Massa caseira, tomates e azeitonas",
                        imgPrato = "http://gastrovia.com.br/upload/arquivos/Agosto-12/macarrao%20o%20que%20comer%202.jpg"

                    }
                }
                );
        }
    }
}
