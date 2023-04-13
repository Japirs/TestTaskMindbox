CREATE TABLE Product(
	ID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Name nvarchar(255) NOT NULL
);

CREATE TABLE Category(
	ID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Name nvarchar(255) NOT NULL
);

CREATE TABLE ProductCategory (
    ID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	ProductID int FOREIGN KEY REFERENCES Product(ID),
	CategoryID int FOREIGN KEY REFERENCES Category(ID),
	PRIMARY KEY (ID)
);

SELECT     p.Name AS ProductName, c.Name AS CategoryName
FROM        dbo.Product AS p 
LEFT OUTER JOIN  dbo.ProductCategory AS pc ON pc.ProductId = p.Id 
LEFT OUTER JOIN  dbo.Category AS c ON pc.CategoryId = c.Id