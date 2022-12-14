﻿CREATE PROCEDURE [Portfolio].[Brand.Create]
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
			THROW 50001, 'BRAND_NAME_NOT_SPECIFIED', 1
	END CATCH
END;
