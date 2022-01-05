namespace Student_Management_Sysytem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tblTeachers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teachers", "Qualification", c => c.String());
            DropColumn("dbo.Teachers", "Subject");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Teachers", "Subject", c => c.String());
            DropColumn("dbo.Teachers", "Qualification");
        }
    }
}
