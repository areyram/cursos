SELECT o.orderid,
       MIN(o.orderdate) AS orderdate,
       SUM(d.unitprice * d.quantity) AS totalamount
FROM orders o
     INNER JOIN [Order Details] d ON o.orderid = d.orderid
GROUP BY o.orderid

SELECT DISTINCT orderid
FROM [Order Details]

SELECT orderid
FROM [Order Details]
GROUP BY orderid

SELECT TOP 10 d.productid,
       MIN(p.productname),
       SUM(d.unitprice * d.quantity *( 1 - d.discount )) AS amount
FROM orders o
     INNER JOIN [Order Details] d ON o.orderid = d.orderid
     INNER JOIN products p ON d.productid = p.productid
WHERE YEAR ( o.orderdate ) = 1997
GROUP BY d.productid
ORDER BY amount DESC

SELECT COUNT(*)
FROM customers

SELECT COUNT(DISTINCT customerid)
FROM orders

SELECT DISTINCT COUNT(customerid)  -- cuidado con este
FROM orders

-- SELECT COUNT（*）
-- FROM Orders
-- WHERE COUNT（*） > 10
-- GROUP BY  CustomerID

SELECT customerid
FROM orders

GROUP BY customerid
HAVING COUNT(*) > 10

-- duplicados
SELECT customerid
FROM customers
GROUP BY customerid
HAVING COUNT(*) > 1
