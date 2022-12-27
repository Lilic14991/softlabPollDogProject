CREATE PROCEDURE [Survey].[SurveyResult.Create]
    @ProductId UNIQUEIDENTIFIER,
    @Rating	   INT, 
    @Comment   NVARCHAR(MAX) = NULL
AS
BEGIN
    /*----- VALIDATION -----*/
    IF @ProductId IS NULL
    BEGIN
        ;THROW 50000, 'PRODUCT_IDENTIFIER_IS_NOT_VALID', 1
    END
    IF @Rating IS NULL OR (@Rating <= 0 OR @Rating >= 5)
    BEGIN
        ;THROW 50002, 'RATING_CANNOT_BE_NULL', 1
    END

	/*----- DATA -----*/
    INSERT INTO [Survey].[SurveyResult] ([ProductId],[Rating],[Comment]) 
    VALUES (@ProductId, @Rating, @Comment)
END