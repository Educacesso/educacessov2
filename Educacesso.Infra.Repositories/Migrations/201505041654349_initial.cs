namespace Educacesso.Infra.Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Amigo",
                c => new
                    {
                        AmigoId = c.Int(nullable: false, identity: true),
                        UserIdentityId = c.String(maxLength: 100, unicode: false),
                        NomeUsuarioAmigo = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.AmigoId)
                .ForeignKey("dbo.IdentityUser", t => t.UserIdentityId)
                .Index(t => t.UserIdentityId);
            
            CreateTable(
                "dbo.AmigoUsuario",
                c => new
                    {
                        AmigoUsuarioId = c.Int(nullable: false, identity: true),
                        UserIdentityId = c.String(maxLength: 100, unicode: false),
                        AmigoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AmigoUsuarioId)
                .ForeignKey("dbo.Amigo", t => t.AmigoId)
                .ForeignKey("dbo.IdentityUser", t => t.UserIdentityId)
                .Index(t => t.UserIdentityId)
                .Index(t => t.AmigoId);
            
            CreateTable(
                "dbo.IdentityUser",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 100, unicode: false),
                        UserName = c.String(maxLength: 100, unicode: false),
                        PasswordHash = c.String(maxLength: 100, unicode: false),
                        SecurityStamp = c.String(maxLength: 100, unicode: false),
                        QtdSeguidores = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IdentityUserClaim",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClaimType = c.String(maxLength: 100, unicode: false),
                        ClaimValue = c.String(maxLength: 100, unicode: false),
                        User_Id = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.IdentityUser", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.IdentityUserLogin",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 100, unicode: false),
                        LoginProvider = c.String(maxLength: 100, unicode: false),
                        ProviderKey = c.String(maxLength: 100, unicode: false),
                        User_Id = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.IdentityUser", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.IdentityUserRole",
                c => new
                    {
                        RoleId = c.String(nullable: false, maxLength: 100, unicode: false),
                        UserId = c.String(nullable: false, maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => new { t.RoleId, t.UserId })
                .ForeignKey("dbo.IdentityRole", t => t.RoleId)
                .ForeignKey("dbo.IdentityUser", t => t.UserId)
                .Index(t => t.RoleId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.IdentityRole",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 100, unicode: false),
                        Name = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Curso",
                c => new
                    {
                        CursoID = c.Int(nullable: false, identity: true),
                        UserIdentityId = c.String(maxLength: 100, unicode: false),
                        Nome_Curso = c.String(maxLength: 100, unicode: false),
                        Resumo_Curso = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.CursoID)
                .ForeignKey("dbo.IdentityUser", t => t.UserIdentityId)
                .Index(t => t.UserIdentityId);
            
            CreateTable(
                "dbo.Exercicio",
                c => new
                    {
                        ExercicioID = c.Int(nullable: false, identity: true),
                        Pergunta_Exer = c.String(maxLength: 100, unicode: false),
                        Resposta_A = c.String(maxLength: 100, unicode: false),
                        Resposta_B = c.String(maxLength: 100, unicode: false),
                        Resposta_C = c.String(maxLength: 100, unicode: false),
                        Resposta_D = c.String(maxLength: 100, unicode: false),
                        Resposta_Correta = c.String(maxLength: 100, unicode: false),
                        CursoID_CursoID = c.Int(),
                    })
                .PrimaryKey(t => t.ExercicioID)
                .ForeignKey("dbo.Curso", t => t.CursoID_CursoID)
                .Index(t => t.CursoID_CursoID);
            
            CreateTable(
                "dbo.Licao",
                c => new
                    {
                        LicaoID = c.Int(nullable: false, identity: true),
                        Titulo_Licao = c.String(maxLength: 100, unicode: false),
                        Conteudo_Licao = c.String(maxLength: 7000, unicode: false),
                        CursoID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.LicaoID)
                .ForeignKey("dbo.Curso", t => t.CursoID)
                .Index(t => t.CursoID);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        UsuarioID = c.String(nullable: false, maxLength: 100, unicode: false),
                        Nome = c.String(nullable: false, maxLength: 250, unicode: false),
                        Email = c.String(nullable: false, maxLength: 250, unicode: false),
                        Senha = c.String(nullable: false, maxLength: 150, unicode: false),
                    })
                .PrimaryKey(t => t.UsuarioID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Licao", "CursoID", "dbo.Curso");
            DropForeignKey("dbo.Exercicio", "CursoID_CursoID", "dbo.Curso");
            DropForeignKey("dbo.Curso", "UserIdentityId", "dbo.IdentityUser");
            DropForeignKey("dbo.Amigo", "UserIdentityId", "dbo.IdentityUser");
            DropForeignKey("dbo.AmigoUsuario", "UserIdentityId", "dbo.IdentityUser");
            DropForeignKey("dbo.IdentityUserRole", "UserId", "dbo.IdentityUser");
            DropForeignKey("dbo.IdentityUserRole", "RoleId", "dbo.IdentityRole");
            DropForeignKey("dbo.IdentityUserLogin", "User_Id", "dbo.IdentityUser");
            DropForeignKey("dbo.IdentityUserClaim", "User_Id", "dbo.IdentityUser");
            DropForeignKey("dbo.AmigoUsuario", "AmigoId", "dbo.Amigo");
            DropIndex("dbo.Licao", new[] { "CursoID" });
            DropIndex("dbo.Exercicio", new[] { "CursoID_CursoID" });
            DropIndex("dbo.Curso", new[] { "UserIdentityId" });
            DropIndex("dbo.IdentityUserRole", new[] { "UserId" });
            DropIndex("dbo.IdentityUserRole", new[] { "RoleId" });
            DropIndex("dbo.IdentityUserLogin", new[] { "User_Id" });
            DropIndex("dbo.IdentityUserClaim", new[] { "User_Id" });
            DropIndex("dbo.AmigoUsuario", new[] { "AmigoId" });
            DropIndex("dbo.AmigoUsuario", new[] { "UserIdentityId" });
            DropIndex("dbo.Amigo", new[] { "UserIdentityId" });
            DropTable("dbo.Usuario");
            DropTable("dbo.Licao");
            DropTable("dbo.Exercicio");
            DropTable("dbo.Curso");
            DropTable("dbo.IdentityRole");
            DropTable("dbo.IdentityUserRole");
            DropTable("dbo.IdentityUserLogin");
            DropTable("dbo.IdentityUserClaim");
            DropTable("dbo.IdentityUser");
            DropTable("dbo.AmigoUsuario");
            DropTable("dbo.Amigo");
        }
    }
}
