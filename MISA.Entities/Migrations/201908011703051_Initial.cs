namespace MISA.WDT02.NTHTrang.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Refs",
                c => new
                    {
                        RefID = c.Guid(nullable: false, defaultValueSql: "newid()", identity: true),
                        RefBirth = c.DateTime(nullable: false, defaultValueSql: "getdate()"),
                        RefNo = c.String(nullable: false),
                        RefPhone = c.String(nullable: false),
                        Note = c.String(nullable: false),
                        ContactName = c.String(nullable: false),
                        Status = c.String(nullable: false),
                        Group = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.RefID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Refs");
        }
    }
}
