select * from Products

select * from [Order Details]

select 'P' + CONVERT(varchar, ProductID) from Products

select 100 + 20 * 2
select (100 + 20) * 2

select ProductID, ProductName, UnitPrice
from Products
WHERE ProductName LIKE 'G%'
AND UnitPrice < 10

select ProductID, ProductName, UnitPrice
from Products
where (UnitPrice < 20 AND ProductName LIKE 'C%')
OR (ProductName LIKE 'G%' AND UnitPrice < 10)

select ProductID, ProductName, UnitPrice
from Products
where UnitPrice < 20
AND (ProductName LIKE 'C%' OR ProductName LIKE 'G%')

select GETDATE()

select DATEADD(d, 1, GETDATE())
select DATEADD(MONTH, 1, GETDATE())
select DATEADD(d, -1, GETDATE())

select DATEDIFF(d, '2000-10-20', '2000-11-20')
select DATEDIFF(YEAR, '2000-01-03', GETDATE())

select DATEPART(DAYOFYEAR, getdate())

select CONVERT(float, '123') * 2

select OrderID,
		CASE ShipCountry
		WHEN 'Mexico' THEN 'Nacional'
		ELSE 'Internacional'
		END
from Orders

select OrderID,
		CASE
		WHEN ShipCountry = 'Mexico' THEN 'Nacional'
		ELSE 'Internacional'
		END
from Orders

select OrderID,
		CASE WHEN ShipRegion IS NULL THEN 'N/A' ELSE ShipRegion END
from Orders

select OrderID,
		COALESCE(ShipRegion, 'N/A')
from Orders

select OrderID,
		ISNULL(ShipRegion, 'N/A')
from Orders
