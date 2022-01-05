namespace Student_Management_Sysytem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tblEnroll2 : DbMigration
    {
        public override void Up()
        { 
            AddColumn("dbo.Enroll_Now", "AdmissionFees", c => c.String());
            AddColumn("dbo.Enroll_Now", "MonthlyFee", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Enroll_Now", "MonthlyFee");
            DropColumn("dbo.Enroll_Now", "AdmissionFees");
        }
    }
}
