--0000CreateDatabase.sql
CREATE DATABASE PizzaApp;
Use PizzaApp;
--0001CreateFirstTablesScript.sql
CREATE TABLE Products(
    id int IDENTITY(1, 1),
    name varchar(100) NOT NULL,
    price int NOT NULL,
    description varchar(500),
    category int NOT NULL,
    createdAt datetime DEFAULT GETDATE(),
    PRIMARY KEY (id)
);

CREATE TABLE Users(
     id int IDENTITY(1, 1),
     email varchar(255) NOT NULL,
     username varchar(100) NOT NULL,
     password varchar(100) NOT NULL,
     firstName varchar(100) NOT NULL,
     lastName varchar(100) NOT NULL,
     PRIMARY KEY (id)
);

CREATE TABLE Orders(
    id int IDENTITY(1, 1),
    userId int NOT NULL,
    PRIMARY KEY (id),
    FOREIGN KEY (userId) REFERENCES Users(id)
);

CREATE TABLE OrderProduct(
    orderId int NOT NULL,
    productId int NOT NULL,
    FOREIGN KEY (orderId) REFERENCES Orders(id),
    FOREIGN KEY (productId) REFERENCES Products(id)
);

--0002DropColumnFirstNameFromUsers.sql
ALTER TABLE Users
DROP COLUMN firstName;

--0003AddColumnFirstNameBack.sql
ALTER TABLE Users
ADD firstName varchar(100);

--0004AddPrimaryKeyToOrderProduct.sql
ALTER TABLE OrderProduct
ADD id int IDENTITY(1, 1) PRIMARY KEY;

