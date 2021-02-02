SELECT c.CustomerID AS ID, SUM(d.UnitPrice * d.Quantity) AS Sales
  FROM Customers AS c
 INNER JOIN Orders AS o ON c.CustomerID = o.CustomerID
 INNER JOIN [Order Details] AS d ON o.OrderID = d.OrderID
 GROUP BY c.CustomerID
