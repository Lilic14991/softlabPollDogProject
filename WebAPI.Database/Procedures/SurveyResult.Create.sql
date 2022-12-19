CREATE PROCEDURE [Survey].[SurveyResult.Create]
	@ProductId UNIQUEIDENTIFIER,
	@Rating INT, 
	@Comment NVARCHAR(MAX) = NULL
AS
BEGIN
	IF @ProductId IS NULL
		SELECT @ProductId = NULL
	IF @Rating IS NULL
		SELECT @Rating = NULL
	BEGIN TRY
		INSERT INTO [Survey].[SurveyResult] ([ProductId],[Rating],[Comment]) 
		VALUES (@ProductId, @Rating, @Comment)
	END TRY
	BEGIN CATCH 
		IF @ProductId IS NULL
			THROW 50000, 'PRODUCT_ID_IS_NOT_VALID', 1
		IF @Rating IS NULL
			THROW 50002, 'RATING CANNOT BE NULL', 1
	END CATCH
END
