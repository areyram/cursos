select *
from employees
where titleofcourtesy = 'Mr.' or titleofcourtesy = 'Mrs.'

select *
from employees
where titleofcourtesy in ('Mr.', 'Mrs.')

--subquery
select *
from customers
where customerid in
(select customerid from orders)

select *
from customers
where customerid not in
(select customerid from orders)

select * from customers where contactname like '%na%'
select * from customers where contactname like 'ma%'

select * from orders where orderdate between '1997-01-01' and '1997-12-31'
select * from orders where year(orderdate) = 1997
select * from orders where datepart(yyyy, orderdate) = 1997
