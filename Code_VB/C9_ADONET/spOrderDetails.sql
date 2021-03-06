USE [AdventureWorksLT]
GO
/****** Object:  StoredProcedure [dbo].[SpOrderDetails]    Script Date: 02/04/2008 01:29:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SpOrderDetails]
	@OrderId int
AS
Select d.SalesOrderId, p.Name, p.ProductID, d.OrderQty, d.UnitPrice, d.LineTotal 
from SalesLT.SalesOrderDetail d 
inner join SalesLT.Product p on d.productid = p.productid
where d.SalesOrderId = @OrderID
RETURN

