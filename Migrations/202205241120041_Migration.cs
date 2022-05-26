namespace VtysOdev.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.sysdiagrams",
                c => new
                    {
                        diagram_id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 128),
                        principal_id = c.Int(nullable: false),
                        version = c.Int(),
                        definition = c.Binary(),
                    })
                .PrimaryKey(t => t.diagram_id);
            
            CreateTable(
                "dbo.tBolum",
                c => new
                    {
                        bolumID = c.Int(nullable: false),
                        bolumAd = c.String(maxLength: 90, fixedLength: true),
                        fakulteID = c.Int(),
                    })
                .PrimaryKey(t => t.bolumID)
                .ForeignKey("dbo.tFakulte", t => t.fakulteID)
                .Index(t => t.fakulteID);
            
            CreateTable(
                "dbo.tFakulte",
                c => new
                    {
                        fakulteID = c.Int(nullable: false),
                        fakulteAd = c.String(maxLength: 90, fixedLength: true),
                    })
                .PrimaryKey(t => t.fakulteID);
            
            CreateTable(
                "dbo.tOgrenci",
                c => new
                    {
                        ogrenciID = c.Int(nullable: false),
                        ad = c.String(maxLength: 90, fixedLength: true),
                        soyad = c.String(maxLength: 90, fixedLength: true),
                        bolumID = c.Int(),
                    })
                .PrimaryKey(t => t.ogrenciID)
                .ForeignKey("dbo.tBolum", t => t.bolumID)
                .Index(t => t.bolumID);
            
            CreateTable(
                "dbo.tOgrenciDers",
                c => new
                    {
                        id = c.Int(nullable: false),
                        ogrenciID = c.Int(),
                        dersID = c.Int(),
                        yil = c.String(maxLength: 90, fixedLength: true),
                        yariyil = c.String(maxLength: 90, fixedLength: true),
                        vize = c.Double(),
                        final = c.Double(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.tDers", t => t.dersID)
                .ForeignKey("dbo.tOgrenci", t => t.ogrenciID)
                .Index(t => t.ogrenciID)
                .Index(t => t.dersID);
            
            CreateTable(
                "dbo.tDers",
                c => new
                    {
                        dersID = c.Int(nullable: false),
                        dersAD = c.String(maxLength: 90, fixedLength: true),
                        hocaID = c.Int(),
                    })
                .PrimaryKey(t => t.dersID)
                .ForeignKey("dbo.tHoca", t => t.hocaID)
                .Index(t => t.hocaID);
            
            CreateTable(
                "dbo.tHoca",
                c => new
                    {
                        hocaID = c.Int(nullable: false),
                        hocaAD = c.String(maxLength: 90, fixedLength: true),
                        hocaSoyad = c.String(maxLength: 90, fixedLength: true),
                    })
                .PrimaryKey(t => t.hocaID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tOgrenciDers", "ogrenciID", "dbo.tOgrenci");
            DropForeignKey("dbo.tOgrenciDers", "dersID", "dbo.tDers");
            DropForeignKey("dbo.tDers", "hocaID", "dbo.tHoca");
            DropForeignKey("dbo.tOgrenci", "bolumID", "dbo.tBolum");
            DropForeignKey("dbo.tBolum", "fakulteID", "dbo.tFakulte");
            DropIndex("dbo.tDers", new[] { "hocaID" });
            DropIndex("dbo.tOgrenciDers", new[] { "dersID" });
            DropIndex("dbo.tOgrenciDers", new[] { "ogrenciID" });
            DropIndex("dbo.tOgrenci", new[] { "bolumID" });
            DropIndex("dbo.tBolum", new[] { "fakulteID" });
            DropTable("dbo.tHoca");
            DropTable("dbo.tDers");
            DropTable("dbo.tOgrenciDers");
            DropTable("dbo.tOgrenci");
            DropTable("dbo.tFakulte");
            DropTable("dbo.tBolum");
            DropTable("dbo.sysdiagrams");
        }
    }
}
