CREATE TABLE Product
(
    ID SERIAL PRIMARY KEY,
    Name VARCHAR(255)
);

CREATE TABLE Category
(
    ID SERIAL PRIMARY KEY,
    Name VARCHAR(255)
);

CREATE TABLE ProductCategory
(
    ProductID SERIAL REFERENCES Product(ID),
	CategoryID SERIAL REFERENCES Category(ID),
	PRIMARY KEY(ProductID, CategoryID)
);

SELECT p.Name, c.Name
FROM Product p 
 LEFT JOIN ProductCategory pc ON p.ID = pc.ProductID
 LEFT JOIN Category c ON c.ID = pc.CategoryID
