sp_configure "user instances enabled",0;

--Desable FTS Index
IF  EXISTS (SELECT * FROM sys.fulltext_indexes fti WHERE fti.object_id = OBJECT_ID(N'[chkit].[Checklists]'))
ALTER FULLTEXT INDEX ON chkit.Checklists DISABLE
GO
 
--Drop FTS Index
IF  EXISTS (SELECT * FROM sys.fulltext_indexes fti WHERE fti.object_id = OBJECT_ID(N'[chkit].[Checklists]'))
DROP FULLTEXT INDEX ON chkit.Checklists
GO
 
--Drop FTS Catalog
IF  EXISTS (SELECT * FROM sysfulltextcatalogs ftc WHERE ftc.name = N'FTS_Checklists')
DROP FULLTEXT CATALOG FTS_Checklists
GO

--Drop Stored Procedure
IF OBJECT_ID ( 'chkit.FTSChecklistsContent', 'P' ) IS NOT NULL 
    DROP PROCEDURE chkit.FTSChecklistsContent;
GO



CREATE FULLTEXT CATALOG FTS_Checklists;

CREATE FULLTEXT INDEX ON chkit.Checklists(Content) 
KEY INDEX "PK_chkit.Checklists" ON FTS_Checklists;
GO

CREATE PROCEDURE chkit.FTSChecklistsContent
(
	@SearchText nvarchar(1024)
)
AS
	SET NOCOUNT ON;
	SELECT Id FROM chkit.Checklists
	WHERE CONTAINS(Content, @SearchText);
GO