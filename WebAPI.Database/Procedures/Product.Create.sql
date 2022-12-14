CREATE PROCEDURE [Portfolio].[Product.Create]
	@Name NVARCHAR(MAX),
	@BrandId UNIQUEIDENTIFIER
AS
BEGIN 
	IF (@Name IS NULL) 
		THROW 50001, 'Product Name cannot be null', 1
	IF (@BrandId IS NULL)
		THROW 50000, 'BrandId is not valid.', 1
	BEGIN TRY
		INSERT INTO [Portfolio].[Product] ([Name], [BrandId])
        VALUES(@Name, @BrandId);
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
