select customers.*
from customers left join orders
on customers.customerid = orders.customerid
where orders.customerid is null

declare @x int
set @x = NULL
select 'hello' where @x IS NULL

select customers.customerid, ISNULL(convert(varchar, orders.orderid), 'N/A')
from customers left join orders
on customers.customerid = orders.customerid

-- ISNULL(A.x, B.x)
