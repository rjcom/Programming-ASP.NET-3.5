USE [AdventureWorksLT]
GO
/****** Object:  StoredProcedure [dbo].[spAddOrder]    Script Date: 02/04/2008 01:28:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spAddOrder]
   @SalesOrderID integer out,
   @CustomerID integer
AS
	insert into SalesLT.SalesOrderHeader 
	(DueDate, CustomerID, ShipMethod)
	values
	(
	   GetDate()+5, @CustomerID, 'CARGO TRANSPORT 5'
	)
	
	select @SalesOrderID = scope_identity()
	RETURN
