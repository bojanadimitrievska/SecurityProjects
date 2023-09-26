namespace ezdrastvoProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Emailprop : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pacients", "Email", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pacients", "Email");
        }
    }
}
