CREATE TABLE [dbo].[TblProduct]
(
	[ProductID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ProductType] INT NULL, 
    [Description] NCHAR(10) NULL, 
    [Price] NCHAR(10) NULL, 
    [Image] IMAGE NULL
)
