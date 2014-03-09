namespace CheckIt.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserIsTemporal : DbMigration
    {
        public override void Up()
        {
            AddColumn("chkit.Users", "IsTemporal", c => c.Boolean());
        }
        
        public override void Down()
        {
            DropColumn("chkit.Users", "IsTemporal");
        }
    }
}
