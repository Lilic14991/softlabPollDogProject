CREATE VIEW [Survey].[vSurveyResult]
AS 
SELECT 
P.[Id]                                    AS [ProductId],
P.[Name]                                  AS [ProductName], 
P.[BrandId]                               AS [BrandId], 
B.[Name]                                  AS [BrandName],
ROUND(AVG(CAST(SR.[Rating] AS Float)), 2) AS [Average]
FROM [Survey].[SurveyResult] AS SR
JOIN [Portfolio].[Product]   AS P  ON P.[Id] = SR.[ProductId]
JOIN [Portfolio].[Brand]     AS B  ON P.[BrandId] = B.[Id]
GROUP BY P.[Id], P.[Name], P.[BrandId], B.[Name]