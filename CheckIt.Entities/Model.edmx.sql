
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/12/2014 22:44:57
-- Generated from EDMX file: C:\Projects\CheckIt\CheckIt\CheckIt.Entities\Model.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
IF SCHEMA_ID(N'checkIt') IS NULL EXECUTE(N'CREATE SCHEMA [checkIt]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[checkIt].[FK_AreaCategory]', 'F') IS NOT NULL
    ALTER TABLE [checkIt].[Categorys] DROP CONSTRAINT [FK_AreaCategory];
GO
IF OBJECT_ID(N'[checkIt].[FK_CategoryCategory]', 'F') IS NOT NULL
    ALTER TABLE [checkIt].[Categorys] DROP CONSTRAINT [FK_CategoryCategory];
GO
IF OBJECT_ID(N'[checkIt].[FK_UserChecklist]', 'F') IS NOT NULL
    ALTER TABLE [checkIt].[Checklists] DROP CONSTRAINT [FK_UserChecklist];
GO
IF OBJECT_ID(N'[checkIt].[FK_ChecklistShare]', 'F') IS NOT NULL
    ALTER TABLE [checkIt].[Shares] DROP CONSTRAINT [FK_ChecklistShare];
GO
IF OBJECT_ID(N'[checkIt].[FK_UserShare]', 'F') IS NOT NULL
    ALTER TABLE [checkIt].[Shares] DROP CONSTRAINT [FK_UserShare];
GO
IF OBJECT_ID(N'[checkIt].[FK_ChecklistSection]', 'F') IS NOT NULL
    ALTER TABLE [checkIt].[Sections] DROP CONSTRAINT [FK_ChecklistSection];
GO
IF OBJECT_ID(N'[checkIt].[FK_SectionItem]', 'F') IS NOT NULL
    ALTER TABLE [checkIt].[Items] DROP CONSTRAINT [FK_SectionItem];
GO
IF OBJECT_ID(N'[checkIt].[FK_CategoryChecklist]', 'F') IS NOT NULL
    ALTER TABLE [checkIt].[Checklists] DROP CONSTRAINT [FK_CategoryChecklist];
GO
IF OBJECT_ID(N'[checkIt].[FK_AccountFolder]', 'F') IS NOT NULL
    ALTER TABLE [checkIt].[Folders] DROP CONSTRAINT [FK_AccountFolder];
GO
IF OBJECT_ID(N'[checkIt].[FK_FolderFolder]', 'F') IS NOT NULL
    ALTER TABLE [checkIt].[Folders] DROP CONSTRAINT [FK_FolderFolder];
GO
IF OBJECT_ID(N'[checkIt].[FK_AccountFavorite]', 'F') IS NOT NULL
    ALTER TABLE [checkIt].[Favorites] DROP CONSTRAINT [FK_AccountFavorite];
GO
IF OBJECT_ID(N'[checkIt].[FK_ChecklistFavorite]', 'F') IS NOT NULL
    ALTER TABLE [checkIt].[Favorites] DROP CONSTRAINT [FK_ChecklistFavorite];
GO
IF OBJECT_ID(N'[checkIt].[FK_SectionFavorite]', 'F') IS NOT NULL
    ALTER TABLE [checkIt].[Favorites] DROP CONSTRAINT [FK_SectionFavorite];
GO
IF OBJECT_ID(N'[checkIt].[FK_ItemFavorite]', 'F') IS NOT NULL
    ALTER TABLE [checkIt].[Favorites] DROP CONSTRAINT [FK_ItemFavorite];
GO
IF OBJECT_ID(N'[checkIt].[FK_ChecklistKeyword_Checklist]', 'F') IS NOT NULL
    ALTER TABLE [checkIt].[ChecklistKeyword] DROP CONSTRAINT [FK_ChecklistKeyword_Checklist];
GO
IF OBJECT_ID(N'[checkIt].[FK_ChecklistKeyword_Keyword]', 'F') IS NOT NULL
    ALTER TABLE [checkIt].[ChecklistKeyword] DROP CONSTRAINT [FK_ChecklistKeyword_Keyword];
GO
IF OBJECT_ID(N'[checkIt].[FK_SectionKeyword_Section]', 'F') IS NOT NULL
    ALTER TABLE [checkIt].[SectionKeyword] DROP CONSTRAINT [FK_SectionKeyword_Section];
GO
IF OBJECT_ID(N'[checkIt].[FK_SectionKeyword_Keyword]', 'F') IS NOT NULL
    ALTER TABLE [checkIt].[SectionKeyword] DROP CONSTRAINT [FK_SectionKeyword_Keyword];
GO
IF OBJECT_ID(N'[checkIt].[FK_ItemKeyword_Item]', 'F') IS NOT NULL
    ALTER TABLE [checkIt].[ItemKeyword] DROP CONSTRAINT [FK_ItemKeyword_Item];
GO
IF OBJECT_ID(N'[checkIt].[FK_ItemKeyword_Keyword]', 'F') IS NOT NULL
    ALTER TABLE [checkIt].[ItemKeyword] DROP CONSTRAINT [FK_ItemKeyword_Keyword];
GO
IF OBJECT_ID(N'[checkIt].[FK_UserAccount]', 'F') IS NOT NULL
    ALTER TABLE [checkIt].[Accounts] DROP CONSTRAINT [FK_UserAccount];
GO
IF OBJECT_ID(N'[checkIt].[FK_KeywordKeyword_Keyword]', 'F') IS NOT NULL
    ALTER TABLE [checkIt].[KeywordKeyword] DROP CONSTRAINT [FK_KeywordKeyword_Keyword];
GO
IF OBJECT_ID(N'[checkIt].[FK_KeywordKeyword_Keyword1]', 'F') IS NOT NULL
    ALTER TABLE [checkIt].[KeywordKeyword] DROP CONSTRAINT [FK_KeywordKeyword_Keyword1];
GO
IF OBJECT_ID(N'[checkIt].[FK_ItemAnswer]', 'F') IS NOT NULL
    ALTER TABLE [checkIt].[Answers] DROP CONSTRAINT [FK_ItemAnswer];
GO
IF OBJECT_ID(N'[checkIt].[FK_UserAnswer]', 'F') IS NOT NULL
    ALTER TABLE [checkIt].[Answers] DROP CONSTRAINT [FK_UserAnswer];
GO
IF OBJECT_ID(N'[checkIt].[FK_DichotomyAnswer_inherits_Answer]', 'F') IS NOT NULL
    ALTER TABLE [checkIt].[Answers_DichotomyAnswer] DROP CONSTRAINT [FK_DichotomyAnswer_inherits_Answer];
GO
IF OBJECT_ID(N'[checkIt].[FK_DichotomyItem_inherits_Item]', 'F') IS NOT NULL
    ALTER TABLE [checkIt].[Items_DichotomyItem] DROP CONSTRAINT [FK_DichotomyItem_inherits_Item];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[checkIt].[Checklists]', 'U') IS NOT NULL
    DROP TABLE [checkIt].[Checklists];
GO
IF OBJECT_ID(N'[checkIt].[Sections]', 'U') IS NOT NULL
    DROP TABLE [checkIt].[Sections];
GO
IF OBJECT_ID(N'[checkIt].[Items]', 'U') IS NOT NULL
    DROP TABLE [checkIt].[Items];
GO
IF OBJECT_ID(N'[checkIt].[Users]', 'U') IS NOT NULL
    DROP TABLE [checkIt].[Users];
GO
IF OBJECT_ID(N'[checkIt].[Accounts]', 'U') IS NOT NULL
    DROP TABLE [checkIt].[Accounts];
GO
IF OBJECT_ID(N'[checkIt].[Categorys]', 'U') IS NOT NULL
    DROP TABLE [checkIt].[Categorys];
GO
IF OBJECT_ID(N'[checkIt].[Keywords]', 'U') IS NOT NULL
    DROP TABLE [checkIt].[Keywords];
GO
IF OBJECT_ID(N'[checkIt].[Favorites]', 'U') IS NOT NULL
    DROP TABLE [checkIt].[Favorites];
GO
IF OBJECT_ID(N'[checkIt].[Areas]', 'U') IS NOT NULL
    DROP TABLE [checkIt].[Areas];
GO
IF OBJECT_ID(N'[checkIt].[Folders]', 'U') IS NOT NULL
    DROP TABLE [checkIt].[Folders];
GO
IF OBJECT_ID(N'[checkIt].[Shares]', 'U') IS NOT NULL
    DROP TABLE [checkIt].[Shares];
GO
IF OBJECT_ID(N'[checkIt].[Answers]', 'U') IS NOT NULL
    DROP TABLE [checkIt].[Answers];
GO
IF OBJECT_ID(N'[checkIt].[Answers_DichotomyAnswer]', 'U') IS NOT NULL
    DROP TABLE [checkIt].[Answers_DichotomyAnswer];
GO
IF OBJECT_ID(N'[checkIt].[Items_DichotomyItem]', 'U') IS NOT NULL
    DROP TABLE [checkIt].[Items_DichotomyItem];
GO
IF OBJECT_ID(N'[checkIt].[ChecklistKeyword]', 'U') IS NOT NULL
    DROP TABLE [checkIt].[ChecklistKeyword];
GO
IF OBJECT_ID(N'[checkIt].[SectionKeyword]', 'U') IS NOT NULL
    DROP TABLE [checkIt].[SectionKeyword];
GO
IF OBJECT_ID(N'[checkIt].[ItemKeyword]', 'U') IS NOT NULL
    DROP TABLE [checkIt].[ItemKeyword];
GO
IF OBJECT_ID(N'[checkIt].[KeywordKeyword]', 'U') IS NOT NULL
    DROP TABLE [checkIt].[KeywordKeyword];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Checklists'
CREATE TABLE [checkIt].[Checklists] (
    [ChecklistId] uniqueidentifier  NOT NULL,
    [Name] nvarchar(255)  NOT NULL,
    [Description] nvarchar(max)  NULL,
    [Reference1] nvarchar(255)  NULL,
    [Reference2] nvarchar(255)  NULL,
    [Hints] bigint  NOT NULL,
    [Rating] smallint  NOT NULL,
    [Language] nvarchar(6)  NOT NULL,
    [Created] datetime  NOT NULL,
    [Modified] datetime  NOT NULL,
    [Status] int  NOT NULL,
    [User_Id] nvarchar(128)  NOT NULL,
    [Category_CategoryId] int  NOT NULL
);
GO

-- Creating table 'Sections'
CREATE TABLE [checkIt].[Sections] (
    [SectionId] uniqueidentifier  NOT NULL,
    [Name] nvarchar(128)  NOT NULL,
    [Description] nvarchar(max)  NULL,
    [Hints] bigint  NOT NULL,
    [Status] int  NOT NULL,
    [Checklist_ChecklistId] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'Items'
CREATE TABLE [checkIt].[Items] (
    [ItemId] uniqueidentifier  NOT NULL,
    [Description] nvarchar(max)  NULL,
    [Reference1] nvarchar(max)  NULL,
    [Reference2] nvarchar(max)  NULL,
    [Hints] bigint  NOT NULL,
    [Status] int  NOT NULL,
    [Type] int  NOT NULL,
    [Section_SectionId] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [checkIt].[Users] (
    [Id] nvarchar(128)  NOT NULL,
    [PasswordHash] nvarchar(max)  NULL,
    [SecurityStamp] nvarchar(max)  NULL,
    [UserName] nvarchar(max)  NULL,
    [Discriminator] nvarchar(128)  NOT NULL
);
GO

-- Creating table 'Accounts'
CREATE TABLE [checkIt].[Accounts] (
    [AccountId] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [Ocupation] nvarchar(max)  NOT NULL,
    [Industry] nvarchar(max)  NOT NULL,
    [Status] int  NOT NULL,
    [DefaultLanguage] nvarchar(6)  NOT NULL,
    [User_Id] nvarchar(128)  NOT NULL
);
GO

-- Creating table 'Categorys'
CREATE TABLE [checkIt].[Categorys] (
    [CategoryId] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(128)  NOT NULL,
    [Description] nvarchar(max)  NULL,
    [Area_AreaId] int  NOT NULL,
    [SuperCategory_CategoryId] int  NOT NULL
);
GO

-- Creating table 'Keywords'
CREATE TABLE [checkIt].[Keywords] (
    [KeywordId] uniqueidentifier  NOT NULL,
    [Word] nvarchar(30)  NOT NULL,
    [Language] nvarchar(6)  NOT NULL,
    [Hints] bigint  NOT NULL
);
GO

-- Creating table 'Favorites'
CREATE TABLE [checkIt].[Favorites] (
    [FavoriteId] int IDENTITY(1,1) NOT NULL,
    [Created] datetime  NOT NULL,
    [Account_AccountId] int  NOT NULL,
    [Checklist_ChecklistId] uniqueidentifier  NULL,
    [Section_SectionId] uniqueidentifier  NOT NULL,
    [Item_ItemId] uniqueidentifier  NULL
);
GO

-- Creating table 'Areas'
CREATE TABLE [checkIt].[Areas] (
    [AreaId] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(128)  NOT NULL,
    [Description] nvarchar(max)  NULL
);
GO

-- Creating table 'Folders'
CREATE TABLE [checkIt].[Folders] (
    [FolderId] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(60)  NOT NULL,
    [Description] nvarchar(max)  NULL,
    [Created] datetime  NOT NULL,
    [Account_AccountId] int  NOT NULL,
    [ParentFolder_FolderId] int  NOT NULL
);
GO

-- Creating table 'Shares'
CREATE TABLE [checkIt].[Shares] (
    [ShareId] uniqueidentifier  NOT NULL,
    [AccessLevel] int  NOT NULL,
    [Created] datetime  NOT NULL,
    [Checklist_ChecklistId] uniqueidentifier  NOT NULL,
    [User_Id] nvarchar(128)  NOT NULL
);
GO

-- Creating table 'Answers'
CREATE TABLE [checkIt].[Answers] (
    [AnswerId] uniqueidentifier  NOT NULL,
    [Created] datetime  NOT NULL,
    [Modified] datetime  NOT NULL,
    [Value] varbinary(max)  NULL,
    [Item_ItemId] uniqueidentifier  NOT NULL,
    [User_Id] nvarchar(128)  NOT NULL
);
GO

-- Creating table 'Answers_DichotomyAnswer'
CREATE TABLE [checkIt].[Answers_DichotomyAnswer] (
    [AnswerId] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'Items_DichotomyItem'
CREATE TABLE [checkIt].[Items_DichotomyItem] (
    [ItemId] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'ChecklistKeyword'
CREATE TABLE [checkIt].[ChecklistKeyword] (
    [Checklists_ChecklistId] uniqueidentifier  NOT NULL,
    [Keywords_KeywordId] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'SectionKeyword'
CREATE TABLE [checkIt].[SectionKeyword] (
    [Sections_SectionId] uniqueidentifier  NOT NULL,
    [Keywords_KeywordId] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'ItemKeyword'
CREATE TABLE [checkIt].[ItemKeyword] (
    [Items_ItemId] uniqueidentifier  NOT NULL,
    [Keywords_KeywordId] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'KeywordKeyword'
CREATE TABLE [checkIt].[KeywordKeyword] (
    [ReferencedKeywords_KeywordId] uniqueidentifier  NOT NULL,
    [RelatedKeywords_KeywordId] uniqueidentifier  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ChecklistId] in table 'Checklists'
ALTER TABLE [checkIt].[Checklists]
ADD CONSTRAINT [PK_Checklists]
    PRIMARY KEY CLUSTERED ([ChecklistId] ASC);
GO

-- Creating primary key on [SectionId] in table 'Sections'
ALTER TABLE [checkIt].[Sections]
ADD CONSTRAINT [PK_Sections]
    PRIMARY KEY CLUSTERED ([SectionId] ASC);
GO

-- Creating primary key on [ItemId] in table 'Items'
ALTER TABLE [checkIt].[Items]
ADD CONSTRAINT [PK_Items]
    PRIMARY KEY CLUSTERED ([ItemId] ASC);
GO

-- Creating primary key on [Id] in table 'Users'
ALTER TABLE [checkIt].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [AccountId] in table 'Accounts'
ALTER TABLE [checkIt].[Accounts]
ADD CONSTRAINT [PK_Accounts]
    PRIMARY KEY CLUSTERED ([AccountId] ASC);
GO

-- Creating primary key on [CategoryId] in table 'Categorys'
ALTER TABLE [checkIt].[Categorys]
ADD CONSTRAINT [PK_Categorys]
    PRIMARY KEY CLUSTERED ([CategoryId] ASC);
GO

-- Creating primary key on [KeywordId] in table 'Keywords'
ALTER TABLE [checkIt].[Keywords]
ADD CONSTRAINT [PK_Keywords]
    PRIMARY KEY CLUSTERED ([KeywordId] ASC);
GO

-- Creating primary key on [FavoriteId] in table 'Favorites'
ALTER TABLE [checkIt].[Favorites]
ADD CONSTRAINT [PK_Favorites]
    PRIMARY KEY CLUSTERED ([FavoriteId] ASC);
GO

-- Creating primary key on [AreaId] in table 'Areas'
ALTER TABLE [checkIt].[Areas]
ADD CONSTRAINT [PK_Areas]
    PRIMARY KEY CLUSTERED ([AreaId] ASC);
GO

-- Creating primary key on [FolderId] in table 'Folders'
ALTER TABLE [checkIt].[Folders]
ADD CONSTRAINT [PK_Folders]
    PRIMARY KEY CLUSTERED ([FolderId] ASC);
GO

-- Creating primary key on [ShareId] in table 'Shares'
ALTER TABLE [checkIt].[Shares]
ADD CONSTRAINT [PK_Shares]
    PRIMARY KEY CLUSTERED ([ShareId] ASC);
GO

-- Creating primary key on [AnswerId] in table 'Answers'
ALTER TABLE [checkIt].[Answers]
ADD CONSTRAINT [PK_Answers]
    PRIMARY KEY CLUSTERED ([AnswerId] ASC);
GO

-- Creating primary key on [AnswerId] in table 'Answers_DichotomyAnswer'
ALTER TABLE [checkIt].[Answers_DichotomyAnswer]
ADD CONSTRAINT [PK_Answers_DichotomyAnswer]
    PRIMARY KEY CLUSTERED ([AnswerId] ASC);
GO

-- Creating primary key on [ItemId] in table 'Items_DichotomyItem'
ALTER TABLE [checkIt].[Items_DichotomyItem]
ADD CONSTRAINT [PK_Items_DichotomyItem]
    PRIMARY KEY CLUSTERED ([ItemId] ASC);
GO

-- Creating primary key on [Checklists_ChecklistId], [Keywords_KeywordId] in table 'ChecklistKeyword'
ALTER TABLE [checkIt].[ChecklistKeyword]
ADD CONSTRAINT [PK_ChecklistKeyword]
    PRIMARY KEY CLUSTERED ([Checklists_ChecklistId], [Keywords_KeywordId] ASC);
GO

-- Creating primary key on [Sections_SectionId], [Keywords_KeywordId] in table 'SectionKeyword'
ALTER TABLE [checkIt].[SectionKeyword]
ADD CONSTRAINT [PK_SectionKeyword]
    PRIMARY KEY CLUSTERED ([Sections_SectionId], [Keywords_KeywordId] ASC);
GO

-- Creating primary key on [Items_ItemId], [Keywords_KeywordId] in table 'ItemKeyword'
ALTER TABLE [checkIt].[ItemKeyword]
ADD CONSTRAINT [PK_ItemKeyword]
    PRIMARY KEY CLUSTERED ([Items_ItemId], [Keywords_KeywordId] ASC);
GO

-- Creating primary key on [ReferencedKeywords_KeywordId], [RelatedKeywords_KeywordId] in table 'KeywordKeyword'
ALTER TABLE [checkIt].[KeywordKeyword]
ADD CONSTRAINT [PK_KeywordKeyword]
    PRIMARY KEY CLUSTERED ([ReferencedKeywords_KeywordId], [RelatedKeywords_KeywordId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Area_AreaId] in table 'Categorys'
ALTER TABLE [checkIt].[Categorys]
ADD CONSTRAINT [FK_AreaCategory]
    FOREIGN KEY ([Area_AreaId])
    REFERENCES [checkIt].[Areas]
        ([AreaId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_AreaCategory'
CREATE INDEX [IX_FK_AreaCategory]
ON [checkIt].[Categorys]
    ([Area_AreaId]);
GO

-- Creating foreign key on [SuperCategory_CategoryId] in table 'Categorys'
ALTER TABLE [checkIt].[Categorys]
ADD CONSTRAINT [FK_CategoryCategory]
    FOREIGN KEY ([SuperCategory_CategoryId])
    REFERENCES [checkIt].[Categorys]
        ([CategoryId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CategoryCategory'
CREATE INDEX [IX_FK_CategoryCategory]
ON [checkIt].[Categorys]
    ([SuperCategory_CategoryId]);
GO

-- Creating foreign key on [User_Id] in table 'Checklists'
ALTER TABLE [checkIt].[Checklists]
ADD CONSTRAINT [FK_UserChecklist]
    FOREIGN KEY ([User_Id])
    REFERENCES [checkIt].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserChecklist'
CREATE INDEX [IX_FK_UserChecklist]
ON [checkIt].[Checklists]
    ([User_Id]);
GO

-- Creating foreign key on [Checklist_ChecklistId] in table 'Shares'
ALTER TABLE [checkIt].[Shares]
ADD CONSTRAINT [FK_ChecklistShare]
    FOREIGN KEY ([Checklist_ChecklistId])
    REFERENCES [checkIt].[Checklists]
        ([ChecklistId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ChecklistShare'
CREATE INDEX [IX_FK_ChecklistShare]
ON [checkIt].[Shares]
    ([Checklist_ChecklistId]);
GO

-- Creating foreign key on [User_Id] in table 'Shares'
ALTER TABLE [checkIt].[Shares]
ADD CONSTRAINT [FK_UserShare]
    FOREIGN KEY ([User_Id])
    REFERENCES [checkIt].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserShare'
CREATE INDEX [IX_FK_UserShare]
ON [checkIt].[Shares]
    ([User_Id]);
GO

-- Creating foreign key on [Checklist_ChecklistId] in table 'Sections'
ALTER TABLE [checkIt].[Sections]
ADD CONSTRAINT [FK_ChecklistSection]
    FOREIGN KEY ([Checklist_ChecklistId])
    REFERENCES [checkIt].[Checklists]
        ([ChecklistId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ChecklistSection'
CREATE INDEX [IX_FK_ChecklistSection]
ON [checkIt].[Sections]
    ([Checklist_ChecklistId]);
GO

-- Creating foreign key on [Section_SectionId] in table 'Items'
ALTER TABLE [checkIt].[Items]
ADD CONSTRAINT [FK_SectionItem]
    FOREIGN KEY ([Section_SectionId])
    REFERENCES [checkIt].[Sections]
        ([SectionId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_SectionItem'
CREATE INDEX [IX_FK_SectionItem]
ON [checkIt].[Items]
    ([Section_SectionId]);
GO

-- Creating foreign key on [Category_CategoryId] in table 'Checklists'
ALTER TABLE [checkIt].[Checklists]
ADD CONSTRAINT [FK_CategoryChecklist]
    FOREIGN KEY ([Category_CategoryId])
    REFERENCES [checkIt].[Categorys]
        ([CategoryId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CategoryChecklist'
CREATE INDEX [IX_FK_CategoryChecklist]
ON [checkIt].[Checklists]
    ([Category_CategoryId]);
GO

-- Creating foreign key on [Account_AccountId] in table 'Folders'
ALTER TABLE [checkIt].[Folders]
ADD CONSTRAINT [FK_AccountFolder]
    FOREIGN KEY ([Account_AccountId])
    REFERENCES [checkIt].[Accounts]
        ([AccountId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_AccountFolder'
CREATE INDEX [IX_FK_AccountFolder]
ON [checkIt].[Folders]
    ([Account_AccountId]);
GO

-- Creating foreign key on [ParentFolder_FolderId] in table 'Folders'
ALTER TABLE [checkIt].[Folders]
ADD CONSTRAINT [FK_FolderFolder]
    FOREIGN KEY ([ParentFolder_FolderId])
    REFERENCES [checkIt].[Folders]
        ([FolderId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FolderFolder'
CREATE INDEX [IX_FK_FolderFolder]
ON [checkIt].[Folders]
    ([ParentFolder_FolderId]);
GO

-- Creating foreign key on [Account_AccountId] in table 'Favorites'
ALTER TABLE [checkIt].[Favorites]
ADD CONSTRAINT [FK_AccountFavorite]
    FOREIGN KEY ([Account_AccountId])
    REFERENCES [checkIt].[Accounts]
        ([AccountId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_AccountFavorite'
CREATE INDEX [IX_FK_AccountFavorite]
ON [checkIt].[Favorites]
    ([Account_AccountId]);
GO

-- Creating foreign key on [Checklist_ChecklistId] in table 'Favorites'
ALTER TABLE [checkIt].[Favorites]
ADD CONSTRAINT [FK_ChecklistFavorite]
    FOREIGN KEY ([Checklist_ChecklistId])
    REFERENCES [checkIt].[Checklists]
        ([ChecklistId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ChecklistFavorite'
CREATE INDEX [IX_FK_ChecklistFavorite]
ON [checkIt].[Favorites]
    ([Checklist_ChecklistId]);
GO

-- Creating foreign key on [Section_SectionId] in table 'Favorites'
ALTER TABLE [checkIt].[Favorites]
ADD CONSTRAINT [FK_SectionFavorite]
    FOREIGN KEY ([Section_SectionId])
    REFERENCES [checkIt].[Sections]
        ([SectionId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_SectionFavorite'
CREATE INDEX [IX_FK_SectionFavorite]
ON [checkIt].[Favorites]
    ([Section_SectionId]);
GO

-- Creating foreign key on [Item_ItemId] in table 'Favorites'
ALTER TABLE [checkIt].[Favorites]
ADD CONSTRAINT [FK_ItemFavorite]
    FOREIGN KEY ([Item_ItemId])
    REFERENCES [checkIt].[Items]
        ([ItemId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ItemFavorite'
CREATE INDEX [IX_FK_ItemFavorite]
ON [checkIt].[Favorites]
    ([Item_ItemId]);
GO

-- Creating foreign key on [Checklists_ChecklistId] in table 'ChecklistKeyword'
ALTER TABLE [checkIt].[ChecklistKeyword]
ADD CONSTRAINT [FK_ChecklistKeyword_Checklist]
    FOREIGN KEY ([Checklists_ChecklistId])
    REFERENCES [checkIt].[Checklists]
        ([ChecklistId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Keywords_KeywordId] in table 'ChecklistKeyword'
ALTER TABLE [checkIt].[ChecklistKeyword]
ADD CONSTRAINT [FK_ChecklistKeyword_Keyword]
    FOREIGN KEY ([Keywords_KeywordId])
    REFERENCES [checkIt].[Keywords]
        ([KeywordId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ChecklistKeyword_Keyword'
CREATE INDEX [IX_FK_ChecklistKeyword_Keyword]
ON [checkIt].[ChecklistKeyword]
    ([Keywords_KeywordId]);
GO

-- Creating foreign key on [Sections_SectionId] in table 'SectionKeyword'
ALTER TABLE [checkIt].[SectionKeyword]
ADD CONSTRAINT [FK_SectionKeyword_Section]
    FOREIGN KEY ([Sections_SectionId])
    REFERENCES [checkIt].[Sections]
        ([SectionId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Keywords_KeywordId] in table 'SectionKeyword'
ALTER TABLE [checkIt].[SectionKeyword]
ADD CONSTRAINT [FK_SectionKeyword_Keyword]
    FOREIGN KEY ([Keywords_KeywordId])
    REFERENCES [checkIt].[Keywords]
        ([KeywordId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_SectionKeyword_Keyword'
CREATE INDEX [IX_FK_SectionKeyword_Keyword]
ON [checkIt].[SectionKeyword]
    ([Keywords_KeywordId]);
GO

-- Creating foreign key on [Items_ItemId] in table 'ItemKeyword'
ALTER TABLE [checkIt].[ItemKeyword]
ADD CONSTRAINT [FK_ItemKeyword_Item]
    FOREIGN KEY ([Items_ItemId])
    REFERENCES [checkIt].[Items]
        ([ItemId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Keywords_KeywordId] in table 'ItemKeyword'
ALTER TABLE [checkIt].[ItemKeyword]
ADD CONSTRAINT [FK_ItemKeyword_Keyword]
    FOREIGN KEY ([Keywords_KeywordId])
    REFERENCES [checkIt].[Keywords]
        ([KeywordId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ItemKeyword_Keyword'
CREATE INDEX [IX_FK_ItemKeyword_Keyword]
ON [checkIt].[ItemKeyword]
    ([Keywords_KeywordId]);
GO

-- Creating foreign key on [User_Id] in table 'Accounts'
ALTER TABLE [checkIt].[Accounts]
ADD CONSTRAINT [FK_UserAccount]
    FOREIGN KEY ([User_Id])
    REFERENCES [checkIt].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserAccount'
CREATE INDEX [IX_FK_UserAccount]
ON [checkIt].[Accounts]
    ([User_Id]);
GO

-- Creating foreign key on [ReferencedKeywords_KeywordId] in table 'KeywordKeyword'
ALTER TABLE [checkIt].[KeywordKeyword]
ADD CONSTRAINT [FK_KeywordKeyword_Keyword]
    FOREIGN KEY ([ReferencedKeywords_KeywordId])
    REFERENCES [checkIt].[Keywords]
        ([KeywordId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [RelatedKeywords_KeywordId] in table 'KeywordKeyword'
ALTER TABLE [checkIt].[KeywordKeyword]
ADD CONSTRAINT [FK_KeywordKeyword_Keyword1]
    FOREIGN KEY ([RelatedKeywords_KeywordId])
    REFERENCES [checkIt].[Keywords]
        ([KeywordId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_KeywordKeyword_Keyword1'
CREATE INDEX [IX_FK_KeywordKeyword_Keyword1]
ON [checkIt].[KeywordKeyword]
    ([RelatedKeywords_KeywordId]);
GO

-- Creating foreign key on [Item_ItemId] in table 'Answers'
ALTER TABLE [checkIt].[Answers]
ADD CONSTRAINT [FK_ItemAnswer]
    FOREIGN KEY ([Item_ItemId])
    REFERENCES [checkIt].[Items]
        ([ItemId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ItemAnswer'
CREATE INDEX [IX_FK_ItemAnswer]
ON [checkIt].[Answers]
    ([Item_ItemId]);
GO

-- Creating foreign key on [User_Id] in table 'Answers'
ALTER TABLE [checkIt].[Answers]
ADD CONSTRAINT [FK_UserAnswer]
    FOREIGN KEY ([User_Id])
    REFERENCES [checkIt].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserAnswer'
CREATE INDEX [IX_FK_UserAnswer]
ON [checkIt].[Answers]
    ([User_Id]);
GO

-- Creating foreign key on [AnswerId] in table 'Answers_DichotomyAnswer'
ALTER TABLE [checkIt].[Answers_DichotomyAnswer]
ADD CONSTRAINT [FK_DichotomyAnswer_inherits_Answer]
    FOREIGN KEY ([AnswerId])
    REFERENCES [checkIt].[Answers]
        ([AnswerId])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ItemId] in table 'Items_DichotomyItem'
ALTER TABLE [checkIt].[Items_DichotomyItem]
ADD CONSTRAINT [FK_DichotomyItem_inherits_Item]
    FOREIGN KEY ([ItemId])
    REFERENCES [checkIt].[Items]
        ([ItemId])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------