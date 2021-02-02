SELECT     Customers.CustomerID, Customers.CompanyName, Customers.ContactName, Customers.ContactTitle, Customers.Address, Customers.City, Customers.Region, 
                      Customers.PostalCode, Customers.Country, Customers.Phone, Customers.Fax, Employees.EmployeeID, Employees.LastName, Employees.FirstName, 
                      Employees.Title, Employees.TitleOfCourtesy, Employees.BirthDate, Employees.HireDate, Employees.Address AS Expr1, Employees.City AS Expr2, 
                      Employees.Region AS Expr3, Employees.PostalCode AS Expr4, Employees.Country AS Expr5, Employees.HomePhone, Employees.Extension, Employees.Photo, 
                      Employees.Notes, Employees.ReportsTo, Employees.PhotoPath
FROM         Customers CROSS JOIN
                      Employees