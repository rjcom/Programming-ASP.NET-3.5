USE [AdventureWorksLT]
GO
/****** Object:  StoredProcedure [dbo].[spOrders]    Script Date: 02/04/2008 01:29:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spOrders]
AS
SELECT   o.SalesOrderID, o.OrderDate, c.CompanyName, 
         c.FirstName + ' ' + c.LastName AS 'Contact', o.TotalDue
FROM     SalesLT.SalesOrderHeader AS o 
INNER JOIN
   SalesLT.Customer AS c ON c.CustomerID = o.CustomerID
