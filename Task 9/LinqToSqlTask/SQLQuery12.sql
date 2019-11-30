USE [Cinema]
GO

SELECT 
       t1.Name 'Film Name',
       t1.Genre 'Film Genre',
       t1.Year 'Issue Year',
		t2.FirstName 'Director Name',
		t2.LastName 'Director Last Name'
  FROM [dbo].[Movies] t1, [dbo].[Directors] t2
  Where t1.DirectorId = t2.Id
GO


