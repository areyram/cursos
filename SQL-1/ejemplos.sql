SELECT *
FROM products

SELECT *
FROM [Order Details]

SELECT 'P' + CONVERT(VARCHAR, productid)
FROM products

SELECT 100 + 20 * 2
SELECT (100 + 20) * 2

SELECT productid, productname, unitprice
FROM products
WHERE productname LIKE 'G%' AND unitprice < 10

SELECT productid, productname, unitprice
FROM products
WHERE (unitprice < 20 AND productname LIKE 'C%')
	OR (productname LIKE 'G%' AND unitprice < 10)

SELECT productid, productname, unitprice
FROM products
WHERE unitprice < 20
	AND (productname LIKE 'C%' OR productname LIKE 'G%')

SELECT GETDATE()

SELECT DATEADD(d, 1, GETDATE())
SELECT DATEADD(MONTH, 1, GETDATE())
SELECT DATEADD(d, -1, GETDATE())

SELECT DATEDIFF(d, '2000-10-20', '2000-11-20')
SELECT DATEDIFF(YEAR, '2000-01-03', GETDATE())

SELECT DATEPART(DAYOFYEAR, GETDATE())

SELECT CONVERT(FLOAT, '123') * 2

SELECT orderid,
	CASE
		shipcountry
		WHEN 'Mexico' THEN 'Nacional'
		ELSE 'Internacional'
	END
FROM orders

SELECT orderid,
	CASE
		WHEN shipcountry = 'Mexico' THEN 'Nacional'
		ELSE 'Internacional'
	END
FROM orders

SELECT orderid,
	CASE
		WHEN shipregion IS NULL THEN 'N/A'
		ELSE shipregion
	END
FROM orders

SELECT orderid, COALESCE(shipregion, 'N/A')
FROM orders

SELECT orderid, ISNULL(shipregion, 'N/A')
FROM orders
