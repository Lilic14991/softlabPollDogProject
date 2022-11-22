CREATE TABLE [Survey].[SurveyResult]
(
	[Id]        UNIQUEIDENTIFIER NOT NULL CONSTRAINT [DF_SurveyResult_Id] DEFAULT NEWID(),
	[ProductId] UNIQUEIDENTIFIER NOT NULL,
	[Rating]    INT              NOT NULL,
	[Comment]   NVARCHAR(MAX)    NULL,

	CONSTRAINT [FK_SurveyResult_Product] FOREIGN KEY ([ProductId]) REFERENCES [Portfolio].[Product] ([Id]),
);
