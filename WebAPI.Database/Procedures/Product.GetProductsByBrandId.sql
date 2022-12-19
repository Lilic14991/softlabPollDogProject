CREATE PROCEDURE [Portfolio].[Product.GetProductsByBrandId]
	@BrandId UNIQUEIDENTIFIER
AS
BEGIN 
	IF @BrandId IS NULL
		SELECT @BrandId = NULL
	BEGIN TRY 
		SELECT * 
		FROM [Portfolio].[Product]
        WHERE [BrandId] = @BrandId;
	END TRY
	BEGIN CATCH
		IF @BrandId IS NULL
			THROW 50000, 'BRAND_ID_IS_NOT_VALID.', 1
	END CATCH
END;
