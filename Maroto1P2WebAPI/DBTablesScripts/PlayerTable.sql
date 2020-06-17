CREATE TABLE [dbo].[Players]
(
	[Id]       NVARCHAR (128) NOT NULL,
	[Name]     NVARCHAR (256) NOT NULL,
    [BirthDay] DATETIME2 (7)  NOT NULL,
)