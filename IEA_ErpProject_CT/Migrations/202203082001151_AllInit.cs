namespace IEA_ErpProject_CT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AllInit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                    "dbo.tblKonsinyeGonderimler",
                    c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CariTur = c.String(maxLength: 15),
                        CariAdi = c.String(maxLength: 200),
                        CariId = c.Int(nullable: false),
                        GonderimTarih = c.DateTime(nullable: false),
                        Aciklama = c.String(maxLength: 250),
                        UrunId = c.Int(nullable: false),
                        Adet = c.Int(nullable: false),
                        isDeleted = c.Boolean(nullable: false),
                        CreatedUser = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedUser = c.Int(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);

            CreateIndex("dbo.tblKonsinyeGonderimler", "UrunId");
            AddForeignKey("dbo.tblKonsinyeGonderimler", "UrunId", "dbo.tblStokDurum", "Id", cascadeDelete: true);


            CreateTable(
                "dbo.tblUsers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 10),
                        UserName = c.String(nullable: false, maxLength: 10),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblKonsinyeGonderimler", "UrunId", "dbo.tblStokDurum");
            DropIndex("dbo.tblKonsinyeGonderimler", new[] { "UrunId" });
            DropTable("dbo.tblUsers");
           // DropTable("dbo.tblStokDurum");
            DropTable("dbo.tblKonsinyeGonderimler");
        }
    }
}
