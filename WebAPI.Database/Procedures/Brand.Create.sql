CREATE PROCEDURE [Portfolio].[Brand.Create]
	@Name NVARCHAR(MAX) NULL
AS
BEGIN
	IF @Name = '' OR @Name IS NULL
	BEGIN 
		SELECT @Name = NULL
	END
	BEGIN TRY
			INSERT INTO [Portfolio].[Brand] ([Name]) 
			VALUES(@Name);
	END TRY
	BEGIN CATCH
		IF ISNULL(@Name, '') = ''
			THROW 50001, 'Brand Name cannot be null or empty string.', 1
	END CATCH
END;
