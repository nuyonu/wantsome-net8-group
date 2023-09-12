--CreateFirstTablesScript.sql
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
    user_id int NOT NULL,
    PRIMARY KEY (id),
    FOREIGN KEY (user_id) REFERENCES Users(id)
);

CREATE TABLE OrderProduct(
    order_id int NOT NULL,
    product_id int NOT NULL,
    FOREIGN KEY (order_id) REFERENCES Orders(id),
    FOREIGN KEY (product_id) REFERENCES Products(id)
);

--NextUpdates.sql