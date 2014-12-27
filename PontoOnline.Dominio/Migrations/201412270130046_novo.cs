namespace PontoOnline.Dominio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class novo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ponto",
                c => new
                    {
                        IdPonto = c.Int(nullable: false, identity: true),
                        Data = c.DateTime(nullable: false),
                        Entrada = c.Time(nullable: false, precision: 7),
                        SaidaAlmoco = c.Time(nullable: false, precision: 7),
                        EntradaAlmoco = c.Time(nullable: false, precision: 7),
                        SaidaEmbora = c.Time(nullable: false, precision: 7),
                        QtdeHoraExtra = c.Time(nullable: false, precision: 7),
                        TotalHoraTrabalhada = c.Time(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.IdPonto);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        IdUsuario = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        Senha = c.String(nullable: false),
                        DataCadastro = c.DateTime(nullable: false),
                        Status = c.Boolean(nullable: false),
                        LembrarSenha = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.IdUsuario);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Usuario");
            DropTable("dbo.Ponto");
        }
    }
}
