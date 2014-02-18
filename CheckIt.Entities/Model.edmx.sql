
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/16/2014 17:51:18
-- Generated from EDMX file: C:\Projects\CheckIt\CheckIt\CheckIt.Entities\Model.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
IF SCHEMA_ID(N'CheckIt') IS NULL EXECUTE(N'CREATE SCHEMA [CheckIt]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[CheckIt].[FK_AreaCategory]', 'F') IS NOT NULL
    ALTER TABLE [CheckIt].[Categorys] DROP CONSTRAINT [FK_AreaCategory];
GO
IF OBJECT_ID(N'[CheckIt].[FK_CategoryCategory]', 'F') IS NOT NULL
    ALTER TABLE [CheckIt].[Categorys] DROP CONSTRAINT [FK_CategoryCategory];
GO
IF OBJECT_ID(N'[CheckIt].[FK_ChecklistShare]', 'F') IS NOT NULL
    ALTER TABLE [CheckIt].[Shares] DROP CONSTRAINT [FK_ChecklistShare];
GO
IF OBJECT_ID(N'[CheckIt].[FK_ChecklistSection]', 'F') IS NOT NULL
    ALTER TABLE [CheckIt].[Sections] DROP CONSTRAINT [FK_ChecklistSection];
GO
IF OBJECT_ID(N'[CheckIt].[FK_SectionItem]', 'F') IS NOT NULL
    ALTER TABLE [CheckIt].[Items] DROP CONSTRAINT [FK_SectionItem];
GO
IF OBJECT_ID(N'[CheckIt].[FK_CategoryChecklist]', 'F') IS NOT NULL
    ALTER TABLE [CheckIt].[Checklists] DROP CONSTRAINT [FK_CategoryChecklist];
GO
IF OBJECT_ID(N'[CheckIt].[FK_AccountFolder]', 'F') IS NOT NULL
    ALTER TABLE [CheckIt].[Folders] DROP CONSTRAINT [FK_AccountFolder];
GO
IF OBJECT_ID(N'[CheckIt].[FK_FolderFolder]', 'F') IS NOT NULL
    ALTER TABLE [CheckIt].[Folders] DROP CONSTRAINT [FK_FolderFolder];
GO
IF OBJECT_ID(N'[CheckIt].[FK_AccountFavorite]', 'F') IS NOT NULL
    ALTER TABLE [CheckIt].[Favorites] DROP CONSTRAINT [FK_AccountFavorite];
GO
IF OBJECT_ID(N'[CheckIt].[FK_ChecklistFavorite]', 'F') IS NOT NULL
    ALTER TABLE [CheckIt].[Favorites] DROP CONSTRAINT [FK_ChecklistFavorite];
GO
IF OBJECT_ID(N'[CheckIt].[FK_SectionFavorite]', 'F') IS NOT NULL
    ALTER TABLE [CheckIt].[Favorites] DROP CONSTRAINT [FK_SectionFavorite];
GO
IF OBJECT_ID(N'[CheckIt].[FK_ItemFavorite]', 'F') IS NOT NULL
    ALTER TABLE [CheckIt].[Favorites] DROP CONSTRAINT [FK_ItemFavorite];
GO
IF OBJECT_ID(N'[CheckIt].[FK_ChecklistKeyword_Checklist]', 'F') IS NOT NULL
    ALTER TABLE [CheckIt].[ChecklistKeyword] DROP CONSTRAINT [FK_ChecklistKeyword_Checklist];
GO
IF OBJECT_ID(N'[CheckIt].[FK_ChecklistKeyword_Keyword]', 'F') IS NOT NULL
    ALTER TABLE [CheckIt].[ChecklistKeyword] DROP CONSTRAINT [FK_ChecklistKeyword_Keyword];
GO
IF OBJECT_ID(N'[CheckIt].[FK_SectionKeyword_Section]', 'F') IS NOT NULL
    ALTER TABLE [CheckIt].[SectionKeyword] DROP CONSTRAINT [FK_SectionKeyword_Section];
GO
IF OBJECT_ID(N'[CheckIt].[FK_SectionKeyword_Keyword]', 'F') IS NOT NULL
    ALTER TABLE [CheckIt].[SectionKeyword] DROP CONSTRAINT [FK_SectionKeyword_Keyword];
GO
IF OBJECT_ID(N'[CheckIt].[FK_ItemKeyword_Item]', 'F') IS NOT NULL
    ALTER TABLE [CheckIt].[ItemKeyword] DROP CONSTRAINT [FK_ItemKeyword_Item];
GO
IF OBJECT_ID(N'[CheckIt].[FK_ItemKeyword_Keyword]', 'F') IS NOT NULL
    ALTER TABLE [CheckIt].[ItemKeyword] DROP CONSTRAINT [FK_ItemKeyword_Keyword];
GO
IF OBJECT_ID(N'[CheckIt].[FK_KeywordKeyword_Keyword]', 'F') IS NOT NULL
    ALTER TABLE [CheckIt].[KeywordKeyword] DROP CONSTRAINT [FK_KeywordKeyword_Keyword];
GO
IF OBJECT_ID(N'[CheckIt].[FK_KeywordKeyword_Keyword1]', 'F') IS NOT NULL
    ALTER TABLE [CheckIt].[KeywordKeyword] DROP CONSTRAINT [FK_KeywordKeyword_Keyword1];
GO
IF OBJECT_ID(N'[CheckIt].[FK_ItemAnswer]', 'F') IS NOT NULL
    ALTER TABLE [CheckIt].[Answers] DROP CONSTRAINT [FK_ItemAnswer];
GO
IF OBJECT_ID(N'[CheckIt].[FK_CountryAccount]', 'F') IS NOT NULL
    ALTER TABLE [CheckIt].[Accounts] DROP CONSTRAINT [FK_CountryAccount];
GO
IF OBJECT_ID(N'[CheckIt].[FK_UserChecklist]', 'F') IS NOT NULL
    ALTER TABLE [CheckIt].[Checklists] DROP CONSTRAINT [FK_UserChecklist];
GO
IF OBJECT_ID(N'[CheckIt].[FK_UserShare]', 'F') IS NOT NULL
    ALTER TABLE [CheckIt].[Shares] DROP CONSTRAINT [FK_UserShare];
GO
IF OBJECT_ID(N'[CheckIt].[FK_UserAccount]', 'F') IS NOT NULL
    ALTER TABLE [CheckIt].[Accounts] DROP CONSTRAINT [FK_UserAccount];
GO
IF OBJECT_ID(N'[CheckIt].[FK_UserAnswer]', 'F') IS NOT NULL
    ALTER TABLE [CheckIt].[Answers] DROP CONSTRAINT [FK_UserAnswer];
GO
IF OBJECT_ID(N'[CheckIt].[FK_DichotomyAnswer_inherits_Answer]', 'F') IS NOT NULL
    ALTER TABLE [CheckIt].[Answers_DichotomyAnswer] DROP CONSTRAINT [FK_DichotomyAnswer_inherits_Answer];
GO
IF OBJECT_ID(N'[CheckIt].[FK_DichotomyItem_inherits_Item]', 'F') IS NOT NULL
    ALTER TABLE [CheckIt].[Items_DichotomyItem] DROP CONSTRAINT [FK_DichotomyItem_inherits_Item];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[CheckIt].[Checklists]', 'U') IS NOT NULL
    DROP TABLE [CheckIt].[Checklists];
GO
IF OBJECT_ID(N'[CheckIt].[Sections]', 'U') IS NOT NULL
    DROP TABLE [CheckIt].[Sections];
GO
IF OBJECT_ID(N'[CheckIt].[Items]', 'U') IS NOT NULL
    DROP TABLE [CheckIt].[Items];
GO
IF OBJECT_ID(N'[CheckIt].[Accounts]', 'U') IS NOT NULL
    DROP TABLE [CheckIt].[Accounts];
GO
IF OBJECT_ID(N'[CheckIt].[Categorys]', 'U') IS NOT NULL
    DROP TABLE [CheckIt].[Categorys];
GO
IF OBJECT_ID(N'[CheckIt].[Keywords]', 'U') IS NOT NULL
    DROP TABLE [CheckIt].[Keywords];
GO
IF OBJECT_ID(N'[CheckIt].[Favorites]', 'U') IS NOT NULL
    DROP TABLE [CheckIt].[Favorites];
GO
IF OBJECT_ID(N'[CheckIt].[Areas]', 'U') IS NOT NULL
    DROP TABLE [CheckIt].[Areas];
GO
IF OBJECT_ID(N'[CheckIt].[Folders]', 'U') IS NOT NULL
    DROP TABLE [CheckIt].[Folders];
GO
IF OBJECT_ID(N'[CheckIt].[Shares]', 'U') IS NOT NULL
    DROP TABLE [CheckIt].[Shares];
GO
IF OBJECT_ID(N'[CheckIt].[Answers]', 'U') IS NOT NULL
    DROP TABLE [CheckIt].[Answers];
GO
IF OBJECT_ID(N'[CheckIt].[Countries]', 'U') IS NOT NULL
    DROP TABLE [CheckIt].[Countries];
GO
IF OBJECT_ID(N'[CheckIt].[Users]', 'U') IS NOT NULL
    DROP TABLE [CheckIt].[Users];
GO
IF OBJECT_ID(N'[CheckIt].[Answers_DichotomyAnswer]', 'U') IS NOT NULL
    DROP TABLE [CheckIt].[Answers_DichotomyAnswer];
GO
IF OBJECT_ID(N'[CheckIt].[Items_DichotomyItem]', 'U') IS NOT NULL
    DROP TABLE [CheckIt].[Items_DichotomyItem];
GO
IF OBJECT_ID(N'[CheckIt].[ChecklistKeyword]', 'U') IS NOT NULL
    DROP TABLE [CheckIt].[ChecklistKeyword];
GO
IF OBJECT_ID(N'[CheckIt].[SectionKeyword]', 'U') IS NOT NULL
    DROP TABLE [CheckIt].[SectionKeyword];
GO
IF OBJECT_ID(N'[CheckIt].[ItemKeyword]', 'U') IS NOT NULL
    DROP TABLE [CheckIt].[ItemKeyword];
GO
IF OBJECT_ID(N'[CheckIt].[KeywordKeyword]', 'U') IS NOT NULL
    DROP TABLE [CheckIt].[KeywordKeyword];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Checklists'
CREATE TABLE [CheckIt].[Checklists] (
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
    [Category_CategoryId] int  NOT NULL,
    [User_UserId] nvarchar(128)  NOT NULL
);
GO

-- Creating table 'Sections'
CREATE TABLE [CheckIt].[Sections] (
    [SectionId] uniqueidentifier  NOT NULL,
    [Name] nvarchar(128)  NOT NULL,
    [Description] nvarchar(max)  NULL,
    [Hints] bigint  NOT NULL,
    [Status] int  NOT NULL,
    [Checklist_ChecklistId] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'Items'
CREATE TABLE [CheckIt].[Items] (
    [ItemId] uniqueidentifier  NOT NULL,
    [Content] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NULL,
    [Reference1] nvarchar(max)  NULL,
    [Reference2] nvarchar(max)  NULL,
    [Hints] bigint  NOT NULL,
    [Status] int  NOT NULL,
    [Type] int  NOT NULL,
    [Section_SectionId] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'Accounts'
CREATE TABLE [CheckIt].[Accounts] (
    [AccountId] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [Ocupation] nvarchar(max)  NOT NULL,
    [Industry] nvarchar(max)  NOT NULL,
    [Status] int  NOT NULL,
    [DefaultLanguage] nvarchar(6)  NOT NULL,
    [Country_CountryId] smallint  NOT NULL,
    [User_UserId] nvarchar(128)  NOT NULL
);
GO

-- Creating table 'Categorys'
CREATE TABLE [CheckIt].[Categorys] (
    [CategoryId] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(128)  NOT NULL,
    [Description] nvarchar(max)  NULL,
    [Area_AreaId] int  NOT NULL,
    [SuperCategory_CategoryId] int  NOT NULL
);
GO

-- Creating table 'Keywords'
CREATE TABLE [CheckIt].[Keywords] (
    [KeywordId] uniqueidentifier  NOT NULL,
    [Word] nvarchar(30)  NOT NULL,
    [Language] nvarchar(6)  NOT NULL,
    [Hints] bigint  NOT NULL
);
GO

-- Creating table 'Favorites'
CREATE TABLE [CheckIt].[Favorites] (
    [FavoriteId] int IDENTITY(1,1) NOT NULL,
    [Created] datetime  NOT NULL,
    [Account_AccountId] int  NOT NULL,
    [Checklist_ChecklistId] uniqueidentifier  NULL,
    [Section_SectionId] uniqueidentifier  NOT NULL,
    [Item_ItemId] uniqueidentifier  NULL
);
GO

-- Creating table 'Areas'
CREATE TABLE [CheckIt].[Areas] (
    [AreaId] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(128)  NOT NULL,
    [Description] nvarchar(max)  NULL
);
GO

-- Creating table 'Folders'
CREATE TABLE [CheckIt].[Folders] (
    [FolderId] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(60)  NOT NULL,
    [Description] nvarchar(max)  NULL,
    [Created] datetime  NOT NULL,
    [Account_AccountId] int  NOT NULL,
    [ParentFolder_FolderId] int  NOT NULL
);
GO

-- Creating table 'Shares'
CREATE TABLE [CheckIt].[Shares] (
    [ShareId] uniqueidentifier  NOT NULL,
    [AccessLevel] int  NOT NULL,
    [Created] datetime  NOT NULL,
    [Checklist_ChecklistId] uniqueidentifier  NOT NULL,
    [User_UserId] nvarchar(128)  NOT NULL
);
GO

-- Creating table 'Answers'
CREATE TABLE [CheckIt].[Answers] (
    [AnswerId] uniqueidentifier  NOT NULL,
    [Created] datetime  NOT NULL,
    [Modified] datetime  NOT NULL,
    [Value] varbinary(max)  NULL,
    [Item_ItemId] uniqueidentifier  NOT NULL,
    [User_UserId] nvarchar(128)  NOT NULL
);
GO

-- Creating table 'Countries'
CREATE TABLE [CheckIt].[Countries] (
    [CountryId] smallint IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [ShortName] nvarchar(max)  NOT NULL,
    [LongName] nvarchar(max)  NOT NULL,
    [Iso2] nvarchar(max)  NOT NULL,
    [Iso3] nvarchar(max)  NOT NULL,
    [NumCode] nvarchar(max)  NOT NULL,
    [UNMember] nvarchar(max)  NOT NULL,
    [CallingCode] nvarchar(max)  NOT NULL,
    [Cctld] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [CheckIt].[Users] (
    [UserId] nvarchar(128)  NOT NULL
);
GO

-- Creating table 'Answers_DichotomyAnswer'
CREATE TABLE [CheckIt].[Answers_DichotomyAnswer] (
    [AnswerId] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'Items_DichotomyItem'
CREATE TABLE [CheckIt].[Items_DichotomyItem] (
    [ItemId] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'ChecklistKeyword'
CREATE TABLE [CheckIt].[ChecklistKeyword] (
    [Checklists_ChecklistId] uniqueidentifier  NOT NULL,
    [Keywords_KeywordId] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'SectionKeyword'
CREATE TABLE [CheckIt].[SectionKeyword] (
    [Sections_SectionId] uniqueidentifier  NOT NULL,
    [Keywords_KeywordId] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'ItemKeyword'
CREATE TABLE [CheckIt].[ItemKeyword] (
    [Items_ItemId] uniqueidentifier  NOT NULL,
    [Keywords_KeywordId] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'KeywordKeyword'
CREATE TABLE [CheckIt].[KeywordKeyword] (
    [ReferencedKeywords_KeywordId] uniqueidentifier  NOT NULL,
    [RelatedKeywords_KeywordId] uniqueidentifier  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ChecklistId] in table 'Checklists'
ALTER TABLE [CheckIt].[Checklists]
ADD CONSTRAINT [PK_Checklists]
    PRIMARY KEY CLUSTERED ([ChecklistId] ASC);
GO

-- Creating primary key on [SectionId] in table 'Sections'
ALTER TABLE [CheckIt].[Sections]
ADD CONSTRAINT [PK_Sections]
    PRIMARY KEY CLUSTERED ([SectionId] ASC);
GO

-- Creating primary key on [ItemId] in table 'Items'
ALTER TABLE [CheckIt].[Items]
ADD CONSTRAINT [PK_Items]
    PRIMARY KEY CLUSTERED ([ItemId] ASC);
GO

-- Creating primary key on [AccountId] in table 'Accounts'
ALTER TABLE [CheckIt].[Accounts]
ADD CONSTRAINT [PK_Accounts]
    PRIMARY KEY CLUSTERED ([AccountId] ASC);
GO

-- Creating primary key on [CategoryId] in table 'Categorys'
ALTER TABLE [CheckIt].[Categorys]
ADD CONSTRAINT [PK_Categorys]
    PRIMARY KEY CLUSTERED ([CategoryId] ASC);
GO

-- Creating primary key on [KeywordId] in table 'Keywords'
ALTER TABLE [CheckIt].[Keywords]
ADD CONSTRAINT [PK_Keywords]
    PRIMARY KEY CLUSTERED ([KeywordId] ASC);
GO

-- Creating primary key on [FavoriteId] in table 'Favorites'
ALTER TABLE [CheckIt].[Favorites]
ADD CONSTRAINT [PK_Favorites]
    PRIMARY KEY CLUSTERED ([FavoriteId] ASC);
GO

-- Creating primary key on [AreaId] in table 'Areas'
ALTER TABLE [CheckIt].[Areas]
ADD CONSTRAINT [PK_Areas]
    PRIMARY KEY CLUSTERED ([AreaId] ASC);
GO

-- Creating primary key on [FolderId] in table 'Folders'
ALTER TABLE [CheckIt].[Folders]
ADD CONSTRAINT [PK_Folders]
    PRIMARY KEY CLUSTERED ([FolderId] ASC);
GO

-- Creating primary key on [ShareId] in table 'Shares'
ALTER TABLE [CheckIt].[Shares]
ADD CONSTRAINT [PK_Shares]
    PRIMARY KEY CLUSTERED ([ShareId] ASC);
GO

-- Creating primary key on [AnswerId] in table 'Answers'
ALTER TABLE [CheckIt].[Answers]
ADD CONSTRAINT [PK_Answers]
    PRIMARY KEY CLUSTERED ([AnswerId] ASC);
GO

-- Creating primary key on [CountryId] in table 'Countries'
ALTER TABLE [CheckIt].[Countries]
ADD CONSTRAINT [PK_Countries]
    PRIMARY KEY CLUSTERED ([CountryId] ASC);
GO

-- Creating primary key on [UserId] in table 'Users'
ALTER TABLE [CheckIt].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([UserId] ASC);
GO

-- Creating primary key on [AnswerId] in table 'Answers_DichotomyAnswer'
ALTER TABLE [CheckIt].[Answers_DichotomyAnswer]
ADD CONSTRAINT [PK_Answers_DichotomyAnswer]
    PRIMARY KEY CLUSTERED ([AnswerId] ASC);
GO

-- Creating primary key on [ItemId] in table 'Items_DichotomyItem'
ALTER TABLE [CheckIt].[Items_DichotomyItem]
ADD CONSTRAINT [PK_Items_DichotomyItem]
    PRIMARY KEY CLUSTERED ([ItemId] ASC);
GO

-- Creating primary key on [Checklists_ChecklistId], [Keywords_KeywordId] in table 'ChecklistKeyword'
ALTER TABLE [CheckIt].[ChecklistKeyword]
ADD CONSTRAINT [PK_ChecklistKeyword]
    PRIMARY KEY CLUSTERED ([Checklists_ChecklistId], [Keywords_KeywordId] ASC);
GO

-- Creating primary key on [Sections_SectionId], [Keywords_KeywordId] in table 'SectionKeyword'
ALTER TABLE [CheckIt].[SectionKeyword]
ADD CONSTRAINT [PK_SectionKeyword]
    PRIMARY KEY CLUSTERED ([Sections_SectionId], [Keywords_KeywordId] ASC);
GO

-- Creating primary key on [Items_ItemId], [Keywords_KeywordId] in table 'ItemKeyword'
ALTER TABLE [CheckIt].[ItemKeyword]
ADD CONSTRAINT [PK_ItemKeyword]
    PRIMARY KEY CLUSTERED ([Items_ItemId], [Keywords_KeywordId] ASC);
GO

-- Creating primary key on [ReferencedKeywords_KeywordId], [RelatedKeywords_KeywordId] in table 'KeywordKeyword'
ALTER TABLE [CheckIt].[KeywordKeyword]
ADD CONSTRAINT [PK_KeywordKeyword]
    PRIMARY KEY CLUSTERED ([ReferencedKeywords_KeywordId], [RelatedKeywords_KeywordId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Area_AreaId] in table 'Categorys'
ALTER TABLE [CheckIt].[Categorys]
ADD CONSTRAINT [FK_AreaCategory]
    FOREIGN KEY ([Area_AreaId])
    REFERENCES [CheckIt].[Areas]
        ([AreaId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_AreaCategory'
CREATE INDEX [IX_FK_AreaCategory]
ON [CheckIt].[Categorys]
    ([Area_AreaId]);
GO

-- Creating foreign key on [SuperCategory_CategoryId] in table 'Categorys'
ALTER TABLE [CheckIt].[Categorys]
ADD CONSTRAINT [FK_CategoryCategory]
    FOREIGN KEY ([SuperCategory_CategoryId])
    REFERENCES [CheckIt].[Categorys]
        ([CategoryId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CategoryCategory'
CREATE INDEX [IX_FK_CategoryCategory]
ON [CheckIt].[Categorys]
    ([SuperCategory_CategoryId]);
GO

-- Creating foreign key on [Checklist_ChecklistId] in table 'Shares'
ALTER TABLE [CheckIt].[Shares]
ADD CONSTRAINT [FK_ChecklistShare]
    FOREIGN KEY ([Checklist_ChecklistId])
    REFERENCES [CheckIt].[Checklists]
        ([ChecklistId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ChecklistShare'
CREATE INDEX [IX_FK_ChecklistShare]
ON [CheckIt].[Shares]
    ([Checklist_ChecklistId]);
GO

-- Creating foreign key on [Checklist_ChecklistId] in table 'Sections'
ALTER TABLE [CheckIt].[Sections]
ADD CONSTRAINT [FK_ChecklistSection]
    FOREIGN KEY ([Checklist_ChecklistId])
    REFERENCES [CheckIt].[Checklists]
        ([ChecklistId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ChecklistSection'
CREATE INDEX [IX_FK_ChecklistSection]
ON [CheckIt].[Sections]
    ([Checklist_ChecklistId]);
GO

-- Creating foreign key on [Section_SectionId] in table 'Items'
ALTER TABLE [CheckIt].[Items]
ADD CONSTRAINT [FK_SectionItem]
    FOREIGN KEY ([Section_SectionId])
    REFERENCES [CheckIt].[Sections]
        ([SectionId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_SectionItem'
CREATE INDEX [IX_FK_SectionItem]
ON [CheckIt].[Items]
    ([Section_SectionId]);
GO

-- Creating foreign key on [Category_CategoryId] in table 'Checklists'
ALTER TABLE [CheckIt].[Checklists]
ADD CONSTRAINT [FK_CategoryChecklist]
    FOREIGN KEY ([Category_CategoryId])
    REFERENCES [CheckIt].[Categorys]
        ([CategoryId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CategoryChecklist'
CREATE INDEX [IX_FK_CategoryChecklist]
ON [CheckIt].[Checklists]
    ([Category_CategoryId]);
GO

-- Creating foreign key on [Account_AccountId] in table 'Folders'
ALTER TABLE [CheckIt].[Folders]
ADD CONSTRAINT [FK_AccountFolder]
    FOREIGN KEY ([Account_AccountId])
    REFERENCES [CheckIt].[Accounts]
        ([AccountId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_AccountFolder'
CREATE INDEX [IX_FK_AccountFolder]
ON [CheckIt].[Folders]
    ([Account_AccountId]);
GO

-- Creating foreign key on [ParentFolder_FolderId] in table 'Folders'
ALTER TABLE [CheckIt].[Folders]
ADD CONSTRAINT [FK_FolderFolder]
    FOREIGN KEY ([ParentFolder_FolderId])
    REFERENCES [CheckIt].[Folders]
        ([FolderId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FolderFolder'
CREATE INDEX [IX_FK_FolderFolder]
ON [CheckIt].[Folders]
    ([ParentFolder_FolderId]);
GO

-- Creating foreign key on [Account_AccountId] in table 'Favorites'
ALTER TABLE [CheckIt].[Favorites]
ADD CONSTRAINT [FK_AccountFavorite]
    FOREIGN KEY ([Account_AccountId])
    REFERENCES [CheckIt].[Accounts]
        ([AccountId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_AccountFavorite'
CREATE INDEX [IX_FK_AccountFavorite]
ON [CheckIt].[Favorites]
    ([Account_AccountId]);
GO

-- Creating foreign key on [Checklist_ChecklistId] in table 'Favorites'
ALTER TABLE [CheckIt].[Favorites]
ADD CONSTRAINT [FK_ChecklistFavorite]
    FOREIGN KEY ([Checklist_ChecklistId])
    REFERENCES [CheckIt].[Checklists]
        ([ChecklistId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ChecklistFavorite'
CREATE INDEX [IX_FK_ChecklistFavorite]
ON [CheckIt].[Favorites]
    ([Checklist_ChecklistId]);
GO

-- Creating foreign key on [Section_SectionId] in table 'Favorites'
ALTER TABLE [CheckIt].[Favorites]
ADD CONSTRAINT [FK_SectionFavorite]
    FOREIGN KEY ([Section_SectionId])
    REFERENCES [CheckIt].[Sections]
        ([SectionId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_SectionFavorite'
CREATE INDEX [IX_FK_SectionFavorite]
ON [CheckIt].[Favorites]
    ([Section_SectionId]);
GO

-- Creating foreign key on [Item_ItemId] in table 'Favorites'
ALTER TABLE [CheckIt].[Favorites]
ADD CONSTRAINT [FK_ItemFavorite]
    FOREIGN KEY ([Item_ItemId])
    REFERENCES [CheckIt].[Items]
        ([ItemId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ItemFavorite'
CREATE INDEX [IX_FK_ItemFavorite]
ON [CheckIt].[Favorites]
    ([Item_ItemId]);
GO

-- Creating foreign key on [Checklists_ChecklistId] in table 'ChecklistKeyword'
ALTER TABLE [CheckIt].[ChecklistKeyword]
ADD CONSTRAINT [FK_ChecklistKeyword_Checklist]
    FOREIGN KEY ([Checklists_ChecklistId])
    REFERENCES [CheckIt].[Checklists]
        ([ChecklistId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Keywords_KeywordId] in table 'ChecklistKeyword'
ALTER TABLE [CheckIt].[ChecklistKeyword]
ADD CONSTRAINT [FK_ChecklistKeyword_Keyword]
    FOREIGN KEY ([Keywords_KeywordId])
    REFERENCES [CheckIt].[Keywords]
        ([KeywordId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ChecklistKeyword_Keyword'
CREATE INDEX [IX_FK_ChecklistKeyword_Keyword]
ON [CheckIt].[ChecklistKeyword]
    ([Keywords_KeywordId]);
GO

-- Creating foreign key on [Sections_SectionId] in table 'SectionKeyword'
ALTER TABLE [CheckIt].[SectionKeyword]
ADD CONSTRAINT [FK_SectionKeyword_Section]
    FOREIGN KEY ([Sections_SectionId])
    REFERENCES [CheckIt].[Sections]
        ([SectionId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Keywords_KeywordId] in table 'SectionKeyword'
ALTER TABLE [CheckIt].[SectionKeyword]
ADD CONSTRAINT [FK_SectionKeyword_Keyword]
    FOREIGN KEY ([Keywords_KeywordId])
    REFERENCES [CheckIt].[Keywords]
        ([KeywordId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_SectionKeyword_Keyword'
CREATE INDEX [IX_FK_SectionKeyword_Keyword]
ON [CheckIt].[SectionKeyword]
    ([Keywords_KeywordId]);
GO

-- Creating foreign key on [Items_ItemId] in table 'ItemKeyword'
ALTER TABLE [CheckIt].[ItemKeyword]
ADD CONSTRAINT [FK_ItemKeyword_Item]
    FOREIGN KEY ([Items_ItemId])
    REFERENCES [CheckIt].[Items]
        ([ItemId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Keywords_KeywordId] in table 'ItemKeyword'
ALTER TABLE [CheckIt].[ItemKeyword]
ADD CONSTRAINT [FK_ItemKeyword_Keyword]
    FOREIGN KEY ([Keywords_KeywordId])
    REFERENCES [CheckIt].[Keywords]
        ([KeywordId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ItemKeyword_Keyword'
CREATE INDEX [IX_FK_ItemKeyword_Keyword]
ON [CheckIt].[ItemKeyword]
    ([Keywords_KeywordId]);
GO

-- Creating foreign key on [ReferencedKeywords_KeywordId] in table 'KeywordKeyword'
ALTER TABLE [CheckIt].[KeywordKeyword]
ADD CONSTRAINT [FK_KeywordKeyword_Keyword]
    FOREIGN KEY ([ReferencedKeywords_KeywordId])
    REFERENCES [CheckIt].[Keywords]
        ([KeywordId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [RelatedKeywords_KeywordId] in table 'KeywordKeyword'
ALTER TABLE [CheckIt].[KeywordKeyword]
ADD CONSTRAINT [FK_KeywordKeyword_Keyword1]
    FOREIGN KEY ([RelatedKeywords_KeywordId])
    REFERENCES [CheckIt].[Keywords]
        ([KeywordId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_KeywordKeyword_Keyword1'
CREATE INDEX [IX_FK_KeywordKeyword_Keyword1]
ON [CheckIt].[KeywordKeyword]
    ([RelatedKeywords_KeywordId]);
GO

-- Creating foreign key on [Item_ItemId] in table 'Answers'
ALTER TABLE [CheckIt].[Answers]
ADD CONSTRAINT [FK_ItemAnswer]
    FOREIGN KEY ([Item_ItemId])
    REFERENCES [CheckIt].[Items]
        ([ItemId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ItemAnswer'
CREATE INDEX [IX_FK_ItemAnswer]
ON [CheckIt].[Answers]
    ([Item_ItemId]);
GO

-- Creating foreign key on [Country_CountryId] in table 'Accounts'
ALTER TABLE [CheckIt].[Accounts]
ADD CONSTRAINT [FK_CountryAccount]
    FOREIGN KEY ([Country_CountryId])
    REFERENCES [CheckIt].[Countries]
        ([CountryId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CountryAccount'
CREATE INDEX [IX_FK_CountryAccount]
ON [CheckIt].[Accounts]
    ([Country_CountryId]);
GO

-- Creating foreign key on [User_UserId] in table 'Checklists'
ALTER TABLE [CheckIt].[Checklists]
ADD CONSTRAINT [FK_UserChecklist]
    FOREIGN KEY ([User_UserId])
    REFERENCES [CheckIt].[Users]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserChecklist'
CREATE INDEX [IX_FK_UserChecklist]
ON [CheckIt].[Checklists]
    ([User_UserId]);
GO

-- Creating foreign key on [User_UserId] in table 'Shares'
ALTER TABLE [CheckIt].[Shares]
ADD CONSTRAINT [FK_UserShare]
    FOREIGN KEY ([User_UserId])
    REFERENCES [CheckIt].[Users]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserShare'
CREATE INDEX [IX_FK_UserShare]
ON [CheckIt].[Shares]
    ([User_UserId]);
GO

-- Creating foreign key on [User_UserId] in table 'Accounts'
ALTER TABLE [CheckIt].[Accounts]
ADD CONSTRAINT [FK_UserAccount]
    FOREIGN KEY ([User_UserId])
    REFERENCES [CheckIt].[Users]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserAccount'
CREATE INDEX [IX_FK_UserAccount]
ON [CheckIt].[Accounts]
    ([User_UserId]);
GO

-- Creating foreign key on [User_UserId] in table 'Answers'
ALTER TABLE [CheckIt].[Answers]
ADD CONSTRAINT [FK_UserAnswer]
    FOREIGN KEY ([User_UserId])
    REFERENCES [CheckIt].[Users]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserAnswer'
CREATE INDEX [IX_FK_UserAnswer]
ON [CheckIt].[Answers]
    ([User_UserId]);
GO

-- Creating foreign key on [AnswerId] in table 'Answers_DichotomyAnswer'
ALTER TABLE [CheckIt].[Answers_DichotomyAnswer]
ADD CONSTRAINT [FK_DichotomyAnswer_inherits_Answer]
    FOREIGN KEY ([AnswerId])
    REFERENCES [CheckIt].[Answers]
        ([AnswerId])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ItemId] in table 'Items_DichotomyItem'
ALTER TABLE [CheckIt].[Items_DichotomyItem]
ADD CONSTRAINT [FK_DichotomyItem_inherits_Item]
    FOREIGN KEY ([ItemId])
    REFERENCES [CheckIt].[Items]
        ([ItemId])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------