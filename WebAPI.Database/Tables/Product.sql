CREATE TABLE [Portfolio].[Product]
(
	[Id]      UNIQUEIDENTIFIER	NOT NULL CONSTRAINT [DF_Product_Id] DEFAULT NEWID(), 
    [Name]    NVARCHAR(MAX)     NOT NULL,
	[BrandId] UNIQUEIDENTIFIER	NOT NULL,

	CONSTRAINT [PK_Product] PRIMARY KEY ([Id]),
	CONSTRAINT [FK_Product_Brand] FOREIGN KEY ([BrandId]) REFERENCES [Portfolio].[Brand] ([Id])
);
