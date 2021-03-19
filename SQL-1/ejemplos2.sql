SELECT *
FROM [Order Details]

-- Filtro
CREATE TABLE Featured ( ID int )

INSERT INTO featured values (41)
INSERT INTO featured values (51)
INSERT INTO featured values (65)
INSERT INTO featured values (22)
INSERT INTO featured values (57)

SELECT *
FROM featured

SELECT d.*
FROM [Order Details] d
INNER JOIN Featured f ON d.ProductID = f.ID
--

-- no coincidentes
SELECT c.*
FROM Customers c
WHERE c.CustomerID NOT IN (SELECT CustomerID FROM orders)

-- no coincidentes (mas flexible)
SELECT  c.*
FROM Customers c
LEFT JOIN Orders o ON c.CustomerID = o.CustomerID
WHERE o.CustomerID IS NULL 

-- Traducción
SELECT  o.OrderID, c.CompanyName
FROM Orders o
INNER JOIN Customers c ON o.CustomerID = c.CustomerID
