namespace Student_Management_Sysytem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tblsection : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sections",
                c => new
                    {
                        SectionId = c.Int(nullable: false, identity: true),
                        Section_Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.SectionId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Sections");
        }
    }
}
