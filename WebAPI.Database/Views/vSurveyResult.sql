CREATE VIEW [Product].[vAverageProduct]
	AS SELECT 
	[Name] as ProductName, [Name] as BrandName, AVG(CAST(sr.[Rating]) as float) as Average
		FROM [dbo].[SurveyResult] as sr
		JOIN [Product].[Product] as p 
		ON p.[id] = sr.ProductId
		JOIN [Brand].[Brand] as b 
		ON b.[id] = sr.[BrandId]
		GROUP BY p.[Id], p.[Name], b.Id, b.[Name]