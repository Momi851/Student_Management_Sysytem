namespace Student_Management_Sysytem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tblFeeBill : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FeeBills",
                c => new
                    {
                        Fee_ID = c.Int(nullable: false, identity: true),
                        Student_Name = c.String(),
                        SectionId = c.Int(nullable: false),
                        Class_ID = c.Int(nullable: false),
                        Admission_Fee = c.String(),
                        Monthly_Fee = c.String(),
                    })
                .PrimaryKey(t => t.Fee_ID)
                .ForeignKey("dbo.Classes", t => t.Class_ID, cascadeDelete: true)
                .ForeignKey("dbo.Sections", t => t.SectionId, cascadeDelete: true)
                .Index(t => t.SectionId)
                .Index(t => t.Class_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FeeBills", "SectionId", "dbo.Sections");
            DropForeignKey("dbo.FeeBills", "Class_ID", "dbo.Classes");
            DropIndex("dbo.FeeBills", new[] { "Class_ID" });
            DropIndex("dbo.FeeBills", new[] { "SectionId" });
            DropTable("dbo.FeeBills");
        }
    }
}
