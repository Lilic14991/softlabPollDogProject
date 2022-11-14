﻿CREATE TABLE [Product].[Product]
(
	[Id]      UNIQUEIDENTIFIER NOT NULL CONSTRAINT [DF_Product_Id] DEFAULT NEWID(), 
    [Name]    NVARCHAR(20)     NULL,
	[BrandId] UNIQUEIDENTIFIER NOT NULL,

	CONSTRAINT [PK_Product] PRIMARY KEY ([Id]),
	CONSTRAINT [FK_Product_Brand] FOREIGN KEY ([BrandId]) REFERENCES [Brand].[Brand] ([Id]),
);
