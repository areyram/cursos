select * from [Order Details]

create table Featured
(
	ID int
)

insert into featured values (41)
insert into featured values (51)
insert into featured values (65)
insert into featured values (22)
insert into featured values (57)

select * from featured

select d.*
from [Order Details] d
inner join Featured f on d.ProductID = f.ID

select c.*
from Customers c
where c.CustomerID not in (select CustomerID from orders)

-- no coincidentes
select c.*
from Customers c
left join Orders o ON c.CustomerID = o.CustomerID
where o.CustomerID IS NULL

select o.OrderID, c.CompanyName
from Orders o
inner join Customers c ON o.CustomerID = c.CustomerID