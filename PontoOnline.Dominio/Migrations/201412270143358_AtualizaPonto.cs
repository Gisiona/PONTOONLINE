namespace PontoOnline.Dominio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AtualizaPonto : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ponto", "UsuarioId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Ponto", "UsuarioId");
        }
    }
}
