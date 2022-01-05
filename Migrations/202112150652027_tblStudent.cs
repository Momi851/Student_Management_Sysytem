namespace Student_Management_Sysytem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tblStudent : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Class = c.String(),
                        Section = c.String(),
                        Gender = c.String(),
                        Email = c.String(),
                        Address = c.String(),
                        Phone = c.String(),
                        Emergency_Contact_No = c.String(),
                        Blood_Group = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
        }
    }
}
