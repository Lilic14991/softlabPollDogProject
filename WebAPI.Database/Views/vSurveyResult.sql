CREATE VIEW [SurveyResult].[vSurveyResult]
AS 
SELECT P.[Name] AS ProductName, 
       B.[Name] AS BrandName, 
	   AVG(CAST(SR.[Rating] AS Float)) AS Average
FROM [SurveyResult].[SurveyResult] AS SR
JOIN [Product].[Product] AS P ON P.[Id] = SR.ProductId
JOIN [Brand].[Brand]     AS B ON B.[Id] = SR.[BrandId]
GROUP BY P.[Id], P.[Name], B.Id, B.[Name]