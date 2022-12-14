CREATE PROCEDURE [Portfolio].[Product.GetProductsByBrandId]
	@BrandId UNIQUEIDENTIFIER
AS
BEGIN 
	IF (@BrandId IS NULL)
	BEGIN
		;THROW 5000, 'BrandId is not valid.', 1
	END
	BEGIN TRY 
		SELECT * FROM [Portfolio].[Product]
        WHERE [BrandId] = @BrandId;
	END TRY
	BEGIN CATCH
		IF @BrandId IS NULL
		(
			SELECT 
				ERROR_NUMBER() AS ErrorNumber,
				ERROR_PROCEDURE() AS ErrorProcedure,
				ERROR_MESSAGE() AS ErrorMessage
		);
	END CATCH
END;
