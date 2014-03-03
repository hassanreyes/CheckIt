namespace CheckIt.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "chkit.Accounts",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Ocupation = c.String(),
                        Industry = c.String(),
                        Status = c.Int(nullable: false),
                        DefaultLanguage = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(nullable: false),
                        ModifiedDate = c.DateTime(),
                        Country_Id = c.Guid(),
                        User_Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("chkit.Countries", t => t.Country_Id)
                .ForeignKey("chkit.Users", t => t.User_Id)
                .Index(t => t.Country_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "chkit.Countries",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        ShortName = c.String(nullable: false, maxLength: 80),
                        LongName = c.String(nullable: false, maxLength: 80),
                        Iso2 = c.String(maxLength: 2),
                        Iso3 = c.String(maxLength: 3),
                        NumCode = c.String(maxLength: 6),
                        UNMember = c.String(maxLength: 12),
                        CallingCode = c.String(maxLength: 8),
                        Cctld = c.String(maxLength: 5),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(nullable: false),
                        ModifiedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "chkit.Favorites",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(nullable: false),
                        ModifiedDate = c.DateTime(),
                        Checklist_Id = c.Guid(),
                        Item_Id = c.Guid(),
                        Section_Id = c.Guid(),
                        Account_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("chkit.Checklists", t => t.Checklist_Id)
                .ForeignKey("chkit.Items", t => t.Item_Id)
                .ForeignKey("chkit.Sections", t => t.Section_Id)
                .ForeignKey("chkit.Accounts", t => t.Account_Id, cascadeDelete: true)
                .Index(t => t.Checklist_Id)
                .Index(t => t.Item_Id)
                .Index(t => t.Section_Id)
                .Index(t => t.Account_Id);
            
            CreateTable(
                "chkit.Checklists",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Description = c.String(),
                        Reference1 = c.String(),
                        Reference2 = c.String(),
                        Hints = c.Long(nullable: false),
                        Rating = c.Short(nullable: false),
                        Language = c.String(),
                        Status = c.Int(nullable: false),
                        Category_Id = c.Guid(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(nullable: false),
                        ModifiedDate = c.DateTime(),
                        Folder_Id = c.Guid(nullable: false),
                        User_Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("chkit.Categories", t => t.Category_Id)
                .ForeignKey("chkit.Folders", t => t.Folder_Id, cascadeDelete: true)
                .ForeignKey("chkit.Users", t => t.User_Id, cascadeDelete: true)
                .Index(t => t.Category_Id)
                .Index(t => t.Folder_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "chkit.Categories",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Description = c.String(maxLength: 255),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(nullable: false),
                        ModifiedDate = c.DateTime(),
                        Area_Id = c.Guid(nullable: false),
                        SuperCategory_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("chkit.Areas", t => t.Area_Id, cascadeDelete: true)
                .ForeignKey("chkit.Categories", t => t.SuperCategory_Id)
                .Index(t => t.Area_Id)
                .Index(t => t.SuperCategory_Id);
            
            CreateTable(
                "chkit.Areas",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Description = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(nullable: false),
                        ModifiedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "chkit.Folders",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Description = c.String(),
                        Status = c.Int(nullable: false),
                        Account_Id = c.Guid(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(nullable: false),
                        ModifiedDate = c.DateTime(),
                        ParentFolder_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("chkit.Folders", t => t.ParentFolder_Id)
                .ForeignKey("chkit.Accounts", t => t.Account_Id)
                .Index(t => t.ParentFolder_Id)
                .Index(t => t.Account_Id);
            
            CreateTable(
                "chkit.Keywords",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Word = c.String(nullable: false, maxLength: 60),
                        Language = c.String(nullable: false),
                        Hints = c.Long(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(nullable: false),
                        ModifiedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "chkit.Users",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        UserName = c.String(),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        DisplayName = c.String(),
                        Email = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "chkit.UserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                        User_Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("chkit.Users", t => t.User_Id, cascadeDelete: true)
                .Index(t => t.User_Id);
            
            CreateTable(
                "chkit.UserLogins",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.LoginProvider, t.ProviderKey })
                .ForeignKey("chkit.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "chkit.UserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("chkit.Roles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("chkit.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.RoleId)
                .Index(t => t.UserId);
            
            CreateTable(
                "chkit.Roles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "chkit.Shares",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        AccessLevel = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(nullable: false),
                        ModifiedDate = c.DateTime(),
                        Checklist_Id = c.Guid(nullable: false),
                        SharedBy_Id = c.Guid(nullable: false),
                        User_Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("chkit.Checklists", t => t.Checklist_Id, cascadeDelete: true)
                .ForeignKey("chkit.Accounts", t => t.SharedBy_Id)
                .ForeignKey("chkit.Users", t => t.User_Id)
                .Index(t => t.Checklist_Id)
                .Index(t => t.SharedBy_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "chkit.Answers",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Value = c.Binary(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(nullable: false),
                        ModifiedDate = c.DateTime(),
                        Item_Id = c.Guid(nullable: false),
                        User_Id = c.String(nullable: false, maxLength: 128),
                        Type = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("chkit.Items", t => t.Item_Id, cascadeDelete: true)
                .ForeignKey("chkit.Users", t => t.User_Id, cascadeDelete: true)
                .Index(t => t.Item_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "chkit.Sections",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Description = c.String(),
                        Hints = c.Long(nullable: false),
                        Status = c.Int(nullable: false),
                        Checklist_Id = c.Guid(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(nullable: false),
                        ModifiedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("chkit.Checklists", t => t.Checklist_Id)
                .Index(t => t.Checklist_Id);
            
            CreateTable(
                "chkit.Items",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Content = c.String(nullable: false),
                        Description = c.String(),
                        Reference1 = c.String(maxLength: 255),
                        Reference2 = c.String(maxLength: 255),
                        Hints = c.Long(nullable: false),
                        Status = c.Int(nullable: false),
                        Section_Id = c.Guid(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(nullable: false),
                        ModifiedDate = c.DateTime(),
                        Type = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("chkit.Sections", t => t.Section_Id)
                .Index(t => t.Section_Id);
            
            CreateTable(
                "chkit.KeywordChecklists",
                c => new
                    {
                        Keyword_Id = c.Guid(nullable: false),
                        Checklist_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.Keyword_Id, t.Checklist_Id })
                .ForeignKey("chkit.Keywords", t => t.Keyword_Id, cascadeDelete: true)
                .ForeignKey("chkit.Checklists", t => t.Checklist_Id, cascadeDelete: true)
                .Index(t => t.Keyword_Id)
                .Index(t => t.Checklist_Id);
            
            CreateTable(
                "chkit.KeywordItems",
                c => new
                    {
                        Keyword_Id = c.Guid(nullable: false),
                        Item_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.Keyword_Id, t.Item_Id })
                .ForeignKey("chkit.Keywords", t => t.Keyword_Id, cascadeDelete: true)
                .ForeignKey("chkit.Items", t => t.Item_Id, cascadeDelete: true)
                .Index(t => t.Keyword_Id)
                .Index(t => t.Item_Id);
            
            CreateTable(
                "chkit.KeywordsAssociation",
                c => new
                    {
                        RelatedKeyword_Id = c.Guid(nullable: false),
                        ReferencedKeyword_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.RelatedKeyword_Id, t.ReferencedKeyword_Id })
                .ForeignKey("chkit.Keywords", t => t.RelatedKeyword_Id)
                .ForeignKey("chkit.Keywords", t => t.ReferencedKeyword_Id)
                .Index(t => t.RelatedKeyword_Id)
                .Index(t => t.ReferencedKeyword_Id);
            
            CreateTable(
                "chkit.KeywordSections",
                c => new
                    {
                        Keyword_Id = c.Guid(nullable: false),
                        Section_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.Keyword_Id, t.Section_Id })
                .ForeignKey("chkit.Keywords", t => t.Keyword_Id, cascadeDelete: true)
                .ForeignKey("chkit.Sections", t => t.Section_Id, cascadeDelete: true)
                .Index(t => t.Keyword_Id)
                .Index(t => t.Section_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("chkit.Accounts", "User_Id", "chkit.Users");
            DropForeignKey("chkit.Folders", "Account_Id", "chkit.Accounts");
            DropForeignKey("chkit.Favorites", "Account_Id", "chkit.Accounts");
            DropForeignKey("chkit.Favorites", "Section_Id", "chkit.Sections");
            DropForeignKey("chkit.Favorites", "Item_Id", "chkit.Items");
            DropForeignKey("chkit.Favorites", "Checklist_Id", "chkit.Checklists");
            DropForeignKey("chkit.Checklists", "User_Id", "chkit.Users");
            DropForeignKey("chkit.Sections", "Checklist_Id", "chkit.Checklists");
            DropForeignKey("chkit.KeywordSections", "Section_Id", "chkit.Sections");
            DropForeignKey("chkit.KeywordSections", "Keyword_Id", "chkit.Keywords");
            DropForeignKey("chkit.KeywordsAssociation", "ReferencedKeyword_Id", "chkit.Keywords");
            DropForeignKey("chkit.KeywordsAssociation", "RelatedKeyword_Id", "chkit.Keywords");
            DropForeignKey("chkit.KeywordItems", "Item_Id", "chkit.Items");
            DropForeignKey("chkit.KeywordItems", "Keyword_Id", "chkit.Keywords");
            DropForeignKey("chkit.Items", "Section_Id", "chkit.Sections");
            DropForeignKey("chkit.Answers", "User_Id", "chkit.Users");
            DropForeignKey("chkit.Shares", "User_Id", "chkit.Users");
            DropForeignKey("chkit.Shares", "SharedBy_Id", "chkit.Accounts");
            DropForeignKey("chkit.Shares", "Checklist_Id", "chkit.Checklists");
            DropForeignKey("chkit.UserClaims", "User_Id", "chkit.Users");
            DropForeignKey("chkit.UserRoles", "UserId", "chkit.Users");
            DropForeignKey("chkit.UserRoles", "RoleId", "chkit.Roles");
            DropForeignKey("chkit.UserLogins", "UserId", "chkit.Users");
            DropForeignKey("chkit.Answers", "Item_Id", "chkit.Items");
            DropForeignKey("chkit.KeywordChecklists", "Checklist_Id", "chkit.Checklists");
            DropForeignKey("chkit.KeywordChecklists", "Keyword_Id", "chkit.Keywords");
            DropForeignKey("chkit.Folders", "ParentFolder_Id", "chkit.Folders");
            DropForeignKey("chkit.Checklists", "Folder_Id", "chkit.Folders");
            DropForeignKey("chkit.Categories", "SuperCategory_Id", "chkit.Categories");
            DropForeignKey("chkit.Checklists", "Category_Id", "chkit.Categories");
            DropForeignKey("chkit.Categories", "Area_Id", "chkit.Areas");
            DropForeignKey("chkit.Accounts", "Country_Id", "chkit.Countries");
            DropIndex("chkit.Accounts", new[] { "User_Id" });
            DropIndex("chkit.Folders", new[] { "Account_Id" });
            DropIndex("chkit.Favorites", new[] { "Account_Id" });
            DropIndex("chkit.Favorites", new[] { "Section_Id" });
            DropIndex("chkit.Favorites", new[] { "Item_Id" });
            DropIndex("chkit.Favorites", new[] { "Checklist_Id" });
            DropIndex("chkit.Checklists", new[] { "User_Id" });
            DropIndex("chkit.Sections", new[] { "Checklist_Id" });
            DropIndex("chkit.KeywordSections", new[] { "Section_Id" });
            DropIndex("chkit.KeywordSections", new[] { "Keyword_Id" });
            DropIndex("chkit.KeywordsAssociation", new[] { "ReferencedKeyword_Id" });
            DropIndex("chkit.KeywordsAssociation", new[] { "RelatedKeyword_Id" });
            DropIndex("chkit.KeywordItems", new[] { "Item_Id" });
            DropIndex("chkit.KeywordItems", new[] { "Keyword_Id" });
            DropIndex("chkit.Items", new[] { "Section_Id" });
            DropIndex("chkit.Answers", new[] { "User_Id" });
            DropIndex("chkit.Shares", new[] { "User_Id" });
            DropIndex("chkit.Shares", new[] { "SharedBy_Id" });
            DropIndex("chkit.Shares", new[] { "Checklist_Id" });
            DropIndex("chkit.UserClaims", new[] { "User_Id" });
            DropIndex("chkit.UserRoles", new[] { "UserId" });
            DropIndex("chkit.UserRoles", new[] { "RoleId" });
            DropIndex("chkit.UserLogins", new[] { "UserId" });
            DropIndex("chkit.Answers", new[] { "Item_Id" });
            DropIndex("chkit.KeywordChecklists", new[] { "Checklist_Id" });
            DropIndex("chkit.KeywordChecklists", new[] { "Keyword_Id" });
            DropIndex("chkit.Folders", new[] { "ParentFolder_Id" });
            DropIndex("chkit.Checklists", new[] { "Folder_Id" });
            DropIndex("chkit.Categories", new[] { "SuperCategory_Id" });
            DropIndex("chkit.Checklists", new[] { "Category_Id" });
            DropIndex("chkit.Categories", new[] { "Area_Id" });
            DropIndex("chkit.Accounts", new[] { "Country_Id" });
            DropTable("chkit.KeywordSections");
            DropTable("chkit.KeywordsAssociation");
            DropTable("chkit.KeywordItems");
            DropTable("chkit.KeywordChecklists");
            DropTable("chkit.Items");
            DropTable("chkit.Sections");
            DropTable("chkit.Answers");
            DropTable("chkit.Shares");
            DropTable("chkit.Roles");
            DropTable("chkit.UserRoles");
            DropTable("chkit.UserLogins");
            DropTable("chkit.UserClaims");
            DropTable("chkit.Users");
            DropTable("chkit.Keywords");
            DropTable("chkit.Folders");
            DropTable("chkit.Areas");
            DropTable("chkit.Categories");
            DropTable("chkit.Checklists");
            DropTable("chkit.Favorites");
            DropTable("chkit.Countries");
            DropTable("chkit.Accounts");
        }
    }
}
