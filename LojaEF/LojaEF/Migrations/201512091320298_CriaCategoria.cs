namespace LojaEF.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class CriaCategoria : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        CategoriaId = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.CategoriaId);
            
            AddColumn("dbo.Produtoes", "CategoriaId", c => c.Int());
            CreateIndex("dbo.Produtoes", "CategoriaId");
            AddForeignKey("dbo.Produtoes", "CategoriaId", "dbo.Categorias", "CategoriaId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Produtoes", "CategoriaId", "dbo.Categorias");
            DropIndex("dbo.Produtoes", new[] { "CategoriaId" });
            DropColumn("dbo.Produtoes", "CategoriaId");
            DropTable("dbo.Categorias");
        }
    }
}
