namespace Student_Management_Sysytem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tblclass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        Class_ID = c.Int(nullable: false, identity: true),
                        _Class = c.String(),
                        Class_Teacher = c.String(),
                    })
                .PrimaryKey(t => t.Class_ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Classes");
        }
    }
}
