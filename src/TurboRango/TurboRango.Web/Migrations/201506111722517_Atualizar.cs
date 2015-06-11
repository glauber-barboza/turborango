namespace TurboRango.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Atualizar : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Produtos",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.String(),
                        preco = c.Double(nullable: false),
                        descricao = c.String(),
                        imgPrato = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            AddColumn("dbo.Restaurantes", "produtos_id", c => c.Int());
            CreateIndex("dbo.Restaurantes", "produtos_id");
            AddForeignKey("dbo.Restaurantes", "produtos_id", "dbo.Produtos", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Restaurantes", "produtos_id", "dbo.Produtos");
            DropIndex("dbo.Restaurantes", new[] { "produtos_id" });
            DropColumn("dbo.Restaurantes", "produtos_id");
            DropTable("dbo.Produtos");
        }
    }
}
