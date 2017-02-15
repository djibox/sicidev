namespace SicIdev.API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CeationFSAO : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Agents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(),
                        FullName = c.String(),
                        Telephone = c.String(),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Libelle = c.String(),
                        Details = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Selections",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Projet = c.String(),
                        ProvenantDe = c.String(),
                        DepartementId = c.String(),
                        NatureaoId = c.Int(nullable: false),
                        Echeance = c.DateTime(nullable: false),
                        OrigineaoId = c.Int(nullable: false),
                        TypeaoId = c.Int(nullable: false),
                        DateConnaissance = c.DateTime(nullable: false),
                        PaysId = c.Int(nullable: false),
                        Ville = c.String(),
                        DomaineActivite = c.String(),
                        ClientId = c.Int(nullable: false),
                        Connu = c.Boolean(nullable: false),
                        Description = c.String(),
                        PriseEnChargeId = c.Int(nullable: false),
                        DomaineId = c.Int(nullable: false),
                        Commentaires = c.String(),
                        CadreDeConcertation = c.Boolean(nullable: false),
                        ComplementInfos = c.String(),
                        Partenaire = c.String(),
                        Observations = c.String(),
                        AgentId = c.Int(nullable: false),
                        VisaChefService = c.String(),
                        DateVisaCS = c.DateTime(nullable: false),
                        VisaServiceCom = c.String(),
                        DateVisaCom = c.DateTime(nullable: false),
                        VisaDg = c.String(),
                        DateVisaDg = c.DateTime(nullable: false),
                        Departement_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Agents", t => t.AgentId, cascadeDelete: true)
                .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: true)
                .ForeignKey("dbo.Departements", t => t.Departement_Id)
                .ForeignKey("dbo.Domaines", t => t.DomaineId, cascadeDelete: true)
                .ForeignKey("dbo.Natureaos", t => t.NatureaoId, cascadeDelete: true)
                .ForeignKey("dbo.Origineaos", t => t.OrigineaoId, cascadeDelete: true)
                .ForeignKey("dbo.Pays", t => t.PaysId, cascadeDelete: true)
                .ForeignKey("dbo.PriseEnCharges", t => t.PriseEnChargeId, cascadeDelete: true)
                .ForeignKey("dbo.Typeaos", t => t.TypeaoId, cascadeDelete: true)
                .Index(t => t.NatureaoId)
                .Index(t => t.OrigineaoId)
                .Index(t => t.TypeaoId)
                .Index(t => t.PaysId)
                .Index(t => t.ClientId)
                .Index(t => t.PriseEnChargeId)
                .Index(t => t.DomaineId)
                .Index(t => t.AgentId)
                .Index(t => t.Departement_Id);
            
            CreateTable(
                "dbo.Departements",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Designation = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Domaines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Designation = c.String(),
                        DepartementId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departements", t => t.DepartementId, cascadeDelete: true)
                .Index(t => t.DepartementId);
            
            CreateTable(
                "dbo.Natureaos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nature = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Origineaos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Origine = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Pays",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Designation = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PriseEnCharges",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Libelle = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Typeaos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Selections", "TypeaoId", "dbo.Typeaos");
            DropForeignKey("dbo.Selections", "PriseEnChargeId", "dbo.PriseEnCharges");
            DropForeignKey("dbo.Selections", "PaysId", "dbo.Pays");
            DropForeignKey("dbo.Selections", "OrigineaoId", "dbo.Origineaos");
            DropForeignKey("dbo.Selections", "NatureaoId", "dbo.Natureaos");
            DropForeignKey("dbo.Selections", "DomaineId", "dbo.Domaines");
            DropForeignKey("dbo.Domaines", "DepartementId", "dbo.Departements");
            DropForeignKey("dbo.Selections", "Departement_Id", "dbo.Departements");
            DropForeignKey("dbo.Selections", "ClientId", "dbo.Clients");
            DropForeignKey("dbo.Selections", "AgentId", "dbo.Agents");
            DropForeignKey("dbo.Agents", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Domaines", new[] { "DepartementId" });
            DropIndex("dbo.Selections", new[] { "Departement_Id" });
            DropIndex("dbo.Selections", new[] { "AgentId" });
            DropIndex("dbo.Selections", new[] { "DomaineId" });
            DropIndex("dbo.Selections", new[] { "PriseEnChargeId" });
            DropIndex("dbo.Selections", new[] { "ClientId" });
            DropIndex("dbo.Selections", new[] { "PaysId" });
            DropIndex("dbo.Selections", new[] { "TypeaoId" });
            DropIndex("dbo.Selections", new[] { "OrigineaoId" });
            DropIndex("dbo.Selections", new[] { "NatureaoId" });
            DropIndex("dbo.Agents", new[] { "ApplicationUser_Id" });
            DropTable("dbo.Typeaos");
            DropTable("dbo.PriseEnCharges");
            DropTable("dbo.Pays");
            DropTable("dbo.Origineaos");
            DropTable("dbo.Natureaos");
            DropTable("dbo.Domaines");
            DropTable("dbo.Departements");
            DropTable("dbo.Selections");
            DropTable("dbo.Clients");
            DropTable("dbo.Agents");
        }
    }
}
