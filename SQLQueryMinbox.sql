SELECT Products.ProductName, Categories.CategoryName
FROM Products LEFT JOIN Categories ON Products.Id=Categories.ProductId
ORDER BY Products.ProductName