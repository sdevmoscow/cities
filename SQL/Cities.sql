
SELECT TOP 1000 [Id]
      ,[Name]
  FROM [1gb_academics].[dbo].[Cities]

SELECT TOP 1000 [Id]
      ,[Date]
      ,[CityId]
      ,[Value]
  FROM [1gb_academics].[dbo].[Facts]
  go
   delete FROM [1gb_academics].[dbo].[Cities]

   delete FROM [1gb_academics].[dbo].[Facts]