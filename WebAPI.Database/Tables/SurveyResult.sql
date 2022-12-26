CREATE TABLE [Survey].[SurveyResult]
(
	[Id]        UNIQUEIDENTIFIER NOT NULL CONSTRAINT [DF_SurveyResult_Id] DEFAULT NEWID(),
	[ProductId] UNIQUEIDENTIFIER NOT NULL UNIQUE INDEX [IX_SurveyResult_ProductId] NONCLUSTERED,
	[Rating]    INT              NOT NULL,
	[Comment]   NVARCHAR(MAX)    NULL,

	CONSTRAINT [PK_SurveyResult]         PRIMARY KEY ([Id]),
	CONSTRAINT [FK_SurveyResult_Product] FOREIGN KEY ([ProductId]) REFERENCES [Portfolio].[Product] ([Id]),
);
