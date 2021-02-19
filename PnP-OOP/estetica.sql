-- NO
create procedure [dbo].[salesbycategory] @categoryname nvarchar(15), @ordyear nvarchar(4) = '1998'
as
if @ordyear!='1996' and @ordyear!='1997' and @ordyear!='1998' select @ordyear='1998'
select p.productname,round(sum(convert(decimal(14,2),d.quantity*(1-d.discount)*d.unitprice)),0) totalpurchase
from [order details] as d inner join orders o on d.orderid=o.orderid inner join products p on d.productid=
p.productid inner join categories c on p.categoryid=c.categoryid
where c.categoryname=@categoryname and substring(convert(nvarchar(22),o.orderdate,111),1,4)=@ordyear
group by p.productname order by p.productname

-- YES
CREATE PROCEDURE [dbo].[SalesByCategory]
    @CategoryName nvarchar(15),
	@OrdYear nvarchar(4) = '1998'
AS
	IF @OrdYear != '1996' AND @OrdYear != '1997' AND @OrdYear != '1998' 
	BEGIN
		SELECT @OrdYear = '1998'
	END

	SELECT	p.ProductName,
			ROUND(SUM(CONVERT(decimal(14, 2), d.Quantity * (1 - d.Discount) * d.UnitPrice)), 0) AS TotalPurchase
	FROM [Order Details] AS d
	INNER JOIN Orders AS o ON d.OrderID = o.OrderID
	INNER JOIN Products AS p ON d.ProductID = p.ProductID
	INNER JOIN Categories AS c ON p.CategoryID = c.CategoryID
	WHERE  c.CategoryName = @CategoryName
		AND SUBSTRING(CONVERT(nvarchar(22), o.OrderDate, 111), 1, 4) = @OrdYear
	GROUP BY p.ProductName
	ORDER BY p.ProductName

