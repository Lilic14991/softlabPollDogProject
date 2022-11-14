CREATE VIEW [SurveyResult].[vSurveyResult]
AS 
SELECT P.[Id] AS ProductId, P.[Name] AS ProductName, P.[BrandId], B.[Name] AS BrandName,
	   AVG(CAST(SR.[Rating] AS Float)) AS Average
FROM [SurveyResult].[SurveyResult] AS SR
JOIN [Product].[Product] AS P ON P.[Id] = SR.[ProductId]
JOIN [Brand].[Brand] AS B ON P.[BrandId] = B.[Id]
GROUP BY P.[Id], P.[Name], P.[BrandId], B.[Name]