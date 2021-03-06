/*
   Monday, November 28, 20169:43:52 AM
   User: 
   Server: GAUSS\SQLEXPRESS
   Database: FOOBOSDB
   Application: 
*/

/* To prevent any potential data loss issues, you should review this script in detail before running it outside the context of the database designer.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Table_2
	(
	pkid int NOT NULL IDENTITY (1, 1),
	Supplier nvarchar(100) NOT NULL,
	Address nvarchar(100) NULL,
	Phone nvarchar(50) NULL,
	Email nvarchar(50) NULL,
	ValidFrom datetime NULL,
	ValidTo datetime NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Table_2 ADD CONSTRAINT
	PK_Table_2 PRIMARY KEY CLUSTERED 
	(
	pkid
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Table_2 SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
