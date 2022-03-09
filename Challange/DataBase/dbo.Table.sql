CREATE TABLE [dbo].[TbTopic]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [nmTopic] VARCHAR(MAX) NULL, 
    [idUserCreator] INT NULL, 
    [DtCreator] DATE NULL
)
