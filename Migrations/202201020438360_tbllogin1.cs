namespace Student_Management_Sysytem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tbllogin1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AdminLogins", "Role", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AdminLogins", "Role");
        }
    }
}
