namespace Student_Management_Sysytem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tblCourse : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        SubjectId = c.Int(nullable: false, identity: true),
                        Subject = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.SubjectId);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        Teacher_Id = c.Int(nullable: false, identity: true),
                        Teacher_Name = c.String(nullable: false),
                        Subject = c.String(),
                        Gender = c.String(),
                        Email_Address = c.String(),
                        Address = c.String(),
                        Contact_Number = c.String(),
                    })
                .PrimaryKey(t => t.Teacher_Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Teachers");
            DropTable("dbo.Courses");
        }
    }
}
