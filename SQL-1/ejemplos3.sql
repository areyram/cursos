select	o.OrderID, MIN(o.OrderDate) AS OrderDate,
		SUM(d.UnitPrice * d.Quantity) as TotalAmount
from Orders o
inner join [Order Details] d ON o.OrderID = d.OrderID
group by o.OrderID

select distinct OrderID
from [Order Details]

select OrderID
from [Order Details]
group by OrderID

select TOP 10
		d.ProductID,
		MIN(p.ProductName),
		SUM(d.UnitPrice * d.Quantity * (1 - d.Discount)) AS Amount
from Orders o
inner join [Order Details] d ON o.OrderID = d.OrderID
inner join Products p ON d.ProductID = p.ProductID
where YEAR(o.OrderDate) = 1997
group by d.ProductID
order by Amount DESC

select count(*) from Customers

select count(distinct CustomerID) from Orders

select distinct count(CustomerID) from Orders

-- select count(*)
-- from Orders
-- where count(*) > 10
-- group by CustomerID

select CustomerID
from Orders
group by CustomerID
having count(*) > 10

select CustomerID
from Customers
group by CustomerID
having count(*) > 1
