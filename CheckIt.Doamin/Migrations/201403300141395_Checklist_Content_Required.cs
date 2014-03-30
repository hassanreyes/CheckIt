namespace CheckIt.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Checklist_Content_Required : DbMigration
    {
        public override void Up()
        {
            AlterColumn("chkit.Checklists", "Content", c => c.String(nullable: false, maxLength: 450));
        }
        
        public override void Down()
        {
            AlterColumn("chkit.Checklists", "Content", c => c.String());
        }
    }
}
