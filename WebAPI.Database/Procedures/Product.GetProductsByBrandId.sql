CREATE PROCEDURE [Portfolio].[Product.GetProductsByBrandId]
	@BrandId UNIQUEIDENTIFIER
AS
BEGIN 

    /*----- VALIDATION -----*/
	IF @BrandId IS NULL
	BEGIN
        ;THROW 50000, 'BRAND_ID_IS_NOT_VALID.', 1
    END

	/*----- DATA -----*/
		SELECT * 
		FROM [Portfolio].[Product]
        WHERE [BrandId] = @BrandId;
END;
