namespace Student_Management_Sysytem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tblAssignCourses : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Assign_Course",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TeacherId = c.Int(nullable: false),
                        CourseId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: true)
                .ForeignKey("dbo.Teachers", t => t.TeacherId, cascadeDelete: true)
                .Index(t => t.TeacherId)
                .Index(t => t.CourseId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Assign_Course", "TeacherId", "dbo.Teachers");
            DropForeignKey("dbo.Assign_Course", "CourseId", "dbo.Courses");
            DropIndex("dbo.Assign_Course", new[] { "CourseId" });
            DropIndex("dbo.Assign_Course", new[] { "TeacherId" });
            DropTable("dbo.Assign_Course");
        }
    }
}
