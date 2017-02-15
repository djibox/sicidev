namespace SicIdev.API.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class ModifIdDepartDansSelection : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Selections", "ClientId", "dbo.Clients");
            DropForeignKey("dbo.Selections", "AgentId", "dbo.Agents");
            DropForeignKey("dbo.Selections", "DomaineId", "dbo.Domaines");
            DropForeignKey("dbo.Selections", "NatureaoId", "dbo.Natureaos");
            DropForeignKey("dbo.Selections", "OrigineaoId", "dbo.Origineaos");
            DropForeignKey("dbo.Selections", "PaysId", "dbo.Pays");
            DropForeignKey("dbo.Selections", "PriseEnChargeId", "dbo.PriseEnCharges");
            DropForeignKey("dbo.Selections", "TypeaoId", "dbo.Typeaos");
            DropForeignKey("dbo.Domaines", "DepartementId", "dbo.Departements");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropIndex("dbo.Selections", new[] { "Departement_Id" });
            DropColumn("dbo.Selections", "DepartementId");
            RenameColumn(table: "dbo.Selections", name: "Departement_Id", newName: "DepartementId");
            AlterColumn("dbo.Selections", "DepartementId", c => c.Int(nullable: false));
            AlterColumn("dbo.Selections", "DepartementId", c => c.Int(nullable: false));
            CreateIndex("dbo.Selections", "DepartementId");
            AddForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Selections", "ClientId", "dbo.Clients", "Id");
            AddForeignKey("dbo.Selections", "AgentId", "dbo.Agents", "Id");
            AddForeignKey("dbo.Selections", "DomaineId", "dbo.Domaines", "Id");
            AddForeignKey("dbo.Selections", "NatureaoId", "dbo.Natureaos", "Id");
            AddForeignKey("dbo.Selections", "OrigineaoId", "dbo.Origineaos", "Id");
            AddForeignKey("dbo.Selections", "PaysId", "dbo.Pays", "Id");
            AddForeignKey("dbo.Selections", "PriseEnChargeId", "dbo.PriseEnCharges", "Id");
            AddForeignKey("dbo.Selections", "TypeaoId", "dbo.Typeaos", "Id");
            AddForeignKey("dbo.Domaines", "DepartementId", "dbo.Departements", "Id");
            AddForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles", "Id");
        }

        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Domaines", "DepartementId", "dbo.Departements");
            DropForeignKey("dbo.Selections", "TypeaoId", "dbo.Typeaos");
            DropForeignKey("dbo.Selections", "PriseEnChargeId", "dbo.PriseEnCharges");
            DropForeignKey("dbo.Selections", "PaysId", "dbo.Pays");
            DropForeignKey("dbo.Selections", "OrigineaoId", "dbo.Origineaos");
            DropForeignKey("dbo.Selections", "NatureaoId", "dbo.Natureaos");
            DropForeignKey("dbo.Selections", "DomaineId", "dbo.Domaines");
            DropForeignKey("dbo.Selections", "AgentId", "dbo.Agents");
            DropForeignKey("dbo.Selections", "ClientId", "dbo.Clients");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.Selections", new[] { "DepartementId" });
            AlterColumn("dbo.Selections", "DepartementId", c => c.Int());
            AlterColumn("dbo.Selections", "DepartementId", c => c.String());
            RenameColumn(table: "dbo.Selections", name: "DepartementId", newName: "Departement_Id");
            AddColumn("dbo.Selections", "DepartementId", c => c.String());
            CreateIndex("dbo.Selections", "Departement_Id");
            AddForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Domaines", "DepartementId", "dbo.Departements", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Selections", "TypeaoId", "dbo.Typeaos", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Selections", "PriseEnChargeId", "dbo.PriseEnCharges", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Selections", "PaysId", "dbo.Pays", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Selections", "OrigineaoId", "dbo.Origineaos", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Selections", "NatureaoId", "dbo.Natureaos", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Selections", "DomaineId", "dbo.Domaines", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Selections", "AgentId", "dbo.Agents", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Selections", "ClientId", "dbo.Clients", "Id", cascadeDelete: true);
            AddForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
        }
    }
}
