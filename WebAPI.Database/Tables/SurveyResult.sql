CREATE TABLE [SurveyResult].[SurveyResult]
(
	[Id]        UNIQUEIDENTIFIER NOT NULL CONSTRAINT [DF_SurveyResult_Id] DEFAULT NEWID(),
	[ProductId] UNIQUEIDENTIFIER NOT NULL,
	[BrandId]   UNIQUEIDENTIFIER NOT NULL,
	[Rating]    INT              NOT NULL,
	[Comment]   NVARCHAR(100)    NULL,

	CONSTRAINT [FK_SurveyResult_Product] FOREIGN KEY ([ProductId]) REFERENCES [Product].[Product] ([Id]),
	CONSTRAINT [FK_SurveyResult_Brand]   FOREIGN KEY ([BrandId])   REFERENCES [Brand].[Brand] ([Id])
);
