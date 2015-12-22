namespace LojaEF.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class MudaConfiguracoesDoUsuario : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Usuarios", newName: "tbl_Usuarios");
            RenameColumn(table: "dbo.tbl_Usuarios", name: "Nome", newName: "col_nome");
            RenameColumn(table: "dbo.tbl_Usuarios", name: "Senha", newName: "col_senha");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.tbl_Usuarios", name: "col_senha", newName: "Senha");
            RenameColumn(table: "dbo.tbl_Usuarios", name: "col_nome", newName: "Nome");
            RenameTable(name: "dbo.tbl_Usuarios", newName: "Usuarios");
        }
    }
}
