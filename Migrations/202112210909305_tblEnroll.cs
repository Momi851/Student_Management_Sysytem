namespace Student_Management_Sysytem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tblEnroll : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Enroll_Now",
                c => new
                    {
                        Enroll_ID = c.Int(nullable: false, identity: true),
                        Student_Name = c.Int(nullable: false),
                        SectionId = c.Int(nullable: false),
                        Class_ID = c.Int(nullable: false),
                        phone = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Enroll_ID)
                .ForeignKey("dbo.Classes", t => t.Class_ID, cascadeDelete: true)
                .ForeignKey("dbo.Sections", t => t.SectionId, cascadeDelete: true)
                .Index(t => t.SectionId)
                .Index(t => t.Class_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Enroll_Now", "SectionId", "dbo.Sections");
            DropForeignKey("dbo.Enroll_Now", "Class_ID", "dbo.Classes");
            DropIndex("dbo.Enroll_Now", new[] { "Class_ID" });
            DropIndex("dbo.Enroll_Now", new[] { "SectionId" });
            DropTable("dbo.Enroll_Now");
        }
    }
}
