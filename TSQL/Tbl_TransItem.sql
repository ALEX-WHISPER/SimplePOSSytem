CREATE TABLE [dbo].[TblTransItem]
(
	[TransItemID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [TransID] INT NOT NULL, 
    [ProductID] INT NOT NULL
)
