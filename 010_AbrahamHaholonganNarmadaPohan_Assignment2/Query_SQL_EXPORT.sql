CREATE TABLE Customers (
customerNumber INT PRIMARY KEY,
customerName VARCHAR(50) NOT NULL,
contactLastName VARCHAR(20) NULL,
contactFirstName VARCHAR(30) NULL,
phone VARCHAR(20) NOT NULL,
addresLine1 VARCHAR(50) NULL,
addresLine2 VARCHAR(50) NULL,
city VARCHAR(20) NOT NULL,
state VARCHAR(20) NOT NULL,
postalCode VARCHAR(6) NULL,
country VARCHAR(20) NOT NULL,
creditLimit VARCHAR(20) NULL
)

CREATE TABLE employees (
employeeNumber INT PRIMARY KEY,
lastName VARCHAR(20) NOT NULL,
firstName VARCHAR(30) NOT NULL,
extension VARCHAR(20) NULL,
email VARCHAR(30) NULL,
officeCode INT NOT NULL,
reportsTo INT NOT NULL,
jobTitle VARCHAR(20) NOT NULL,
FOREIGN KEY (reportsTo) REFERENCES employees (employeeNumber)
)
ALTER TABLE employees ADD FOREIGN KEY (officeCode) REFERENCES offices (officeCode);

ALTER TABLE Customers ADD salesRepEmployeeNumber INT NOT NULL;
ALTER TABLE Customers ADD FOREIGN KEY (salesRepEmployeeNumber) REFERENCES employees (employeeNumber);

CREATE TABLE offices(
officeCode INT PRIMARY KEY,
city VARCHAR(20) NOT NULL,
phone VARCHAR(20) NOT NULL,
addressLine1 VARCHAR(50) NULL,
addressLine2 VARCHAR(50) NULL,
state VARCHAR(20) NOT NULL,
country VARCHAR(20) NOT NULL,
postalCode VARCHAR(6) NULL,
territory VARCHAR(20) NULL
)

CREATE TABLE orders(
orderNumber INT PRIMARY KEY,
orderDate DATE NOT NULL,
requiredDate DATE NOT NULL,
shippedDate DATE NOT NULL,
status VARCHAR(10) NOT NULL,
comments VARCHAR(20) NULL,
customerNumber INT NOT NULL,
FOREIGN KEY (customerNumber) REFERENCES Customers (customerNumber)
)

CREATE TABLE payments(
checkNumber INT PRIMARY KEY,
customerNumber INT NOT NULL,
paymentDate DATE NOT NULL,
amount VARCHAR(20) NOT NULL,
FOREIGN KEY (customerNumber) REFERENCES Customers (customerNumber)
)

CREATE TABLE products(
productCode INT PRIMARY KEY,
productName VARCHAR(50) NOT NULL,
productLine INT NOT NULL,
productScale VARCHAR(20) NOT NULL,
productVendor VARCHAR(20) NOT NULL,
productDescription VARCHAR(30) NULL,
quantityInStock INT NOT NULL,
buyPrice VARCHAR(20) NOT NULL,
MSRP VARCHAR(20) NOT NULL
)

ALTER TABLE products ADD FOREIGN KEY (productLine) REFERENCES productlines (productLine);

CREATE TABLE productlines(
productLine INT PRIMARY KEY,
textDescription VARCHAR(20) NULL,
htmlDescription VARCHAR(20) NULL,
image VARCHAR(100) NULL
)

CREATE TABLE orderdetails(
orderNumber INT NOT NULL,
productCode INT NOT NULL,
quantityOrdered INT NOT NULL,
priceEach VARCHAR(20) NOT NULL,
orderLineNumber INT NULL,
FOREIGN KEY (orderNumber) REFERENCES orders (orderNumber),
FOREIGN KEY (productCode) REFERENCES products (productCode)
)

INSERT INTO offices (officeCode, city, phone, addressLine1,
addressLine2, state, country, postalCode, territory) VALUES(
001, 'Surabaya', '08180002020', 'Gembong', '', 'Jawa Timur', 'Indonesia', '61726', 'Gembong'),
(002, 'Surabaya', '08190838399', 'Wonokromo', 'Tenggilis Mejoyo', 'Jawa Timur', 'Indonesia', '61727', 'Wonokromo'),
(003, 'Surabaya', '08180324234', 'Tenggilis Mejoyo', '', 'Jawa Timur', 'Indonesia', '61728', 'Tenggilis Mejoyo'),
(004, 'Sidoarjo', '08134234233', 'Waru', '', 'Jawa Timur', 'Indonesia', '61256', 'Waru'),
(005, 'Sidoarjo', '081324234236', 'Gedangan', 'Waru', 'Jawa Timur', 'Indonesia', '61255', 'Gedangan'),
(006, 'Sidoarjo', '081866575675', 'Porong', 'Tulangan', 'Jawa Timur', 'Indonesia', '61260', 'Porong'),
(007, 'Surabaya', '081856765765', 'Banyurip', '', 'Jawa Timur', 'Indonesia', '61729', 'Banyurip'),
(008, 'Surabaya', '08187686789', 'Demak', 'Perak', 'Jawa Timur', 'Indonesia', '61730', 'Demak'),
(009, 'Surabaya', '081853453423', 'Gembong', 'Gubeng', 'Jawa Timur', 'Indonesia', '61731', 'Gubeng'),
(010, 'Surabaya', '081853453545', 'Kertajaya', '', 'Jawa Timur', 'Indonesia', '61732', 'Kertajaya')

INSERT INTO employees (employeeNumber, lastName, firstName,
extension, email, officeCode, jobTitle) VALUES
(001, 'Pohan', 'Abraham', 'na', 'example@gmail.com', 001, 'Kepala'),
(002, 'Basmallah', 'Tantra','na','example@gmail.com',006,'Kepala'),
(003, 'Wahyu', 'Rahmanda', 'na', 'example@gmail.com', 003, 'Kepala')

INSERT INTO employees (employeeNumber, lastName, firstName,
extension, email, officeCode, reportsTo, jobTitle) VALUES
(004, 'Junior', 'Dannie', 'na', 'example@gmail.com', 001, 001, 'Staff'),
(005, 'Anam', 'Rizky', 'na', 'example@gmail.com', 006, 002, 'Staff'),
(006, 'Ulum', 'Bachrul', 'na', 'example@gmail.com', 001, 001, 'Staff'),
(007, 'Gamal', 'Mochammad', 'na', 'example@gmail.com', 003, 003, 'Staff'),
(008, 'Nandhany', 'Cyndya', 'na', 'example@gmail.com', 006, 002, 'Staff'),
(009, 'Masudah', 'Erica', 'na', 'example@gmail.com', 001, 001, 'Staff'),
(010, 'Fariska', 'Putri', 'na', 'example@gmail.com', 003, 003, 'Staff')

INSERT INTO Customers (customerNumber, customerName, contactLastName, contactFirstName,
phone, addresLine1, addresLine2, city, state, postalCode, country, salesRepEmployeeNumber,
creditLimit) VALUES 
(001, 'Namira', 'Namira' ,'Abda', '087832432423', 'Sidoarjo', 'Bandung', 'Bandung', 'Jawa TImur', '61256', 'Indonesia', 001,
'1000000')

INSERT INTO Customers (customerNumber, customerName, contactLastName, contactFirstName,
phone, addresLine1, addresLine2, city, state, postalCode, country, salesRepEmployeeNumber,
creditLimit) VALUES 
(002, 'Jinjin', 'Hayaza' ,'Qonita', '08782342342', 'Puri Indah', 'Rungkut Asri', 'Sidoarjo', 'Jawa Timur', '61782', 'Indonesia', 002,
'1500000'),
(003, 'Daisy', 'Andelah' ,'Daisy', '08782343241', 'Malioboro', 'Rewwin', 'Jogjakarta', 'DIY', '61454', 'Indonesia', 003,
'2000000'),
(004, 'Isni', 'Yuniar' ,'Isni', '087824354352', 'Rungkut Medokan', 'Rungkut Asri', 'Surabaya', 'Jawa Timur', '61733', 'Indonesia', 004,
'1940000'),
(005, 'Oding', 'Oding' ,'Ramadhani', '08782332224', 'Rungkut Mapan', 'Medokan Ayu', 'Surabaya', 'Jawa Timur', '61744', 'Indonesia', 005,
'1550000'),
(006, 'Yola', 'Yodhistina' ,'Yolanda', '08782343243', 'Taman', 'Waru', 'Sidoarjo', 'Jawa Timur', '61259', 'Indonesia', 006,
'1060000'),
(007, 'Hafizh', 'Ivan' ,'Hafizh', '087823434343', 'Puri', 'Rungkut Asri', 'Mojokerto', 'Jawa Timur', '61790', 'Indonesia', 007,
'30000000'),
(008, 'Boby', 'Rizky' ,'Boby', '0878234324227', 'Banyurip', 'Rungkut Asri', 'Surabaya', 'Jawa Timur', '61566', 'Indonesia', 008,
'1600000'),
(009, 'Pipin', 'Irawan' ,'Pipin', '0878233455678', 'Kenjeran Park', ' ', 'Surabaya', 'Jawa Timur', '61334', 'Indonesia', 009,
'1900000'),
(010, 'Randy', 'Randy' ,'Yusuf', '08798989776', 'Puri Indah', ' ', 'Sidoarjo', 'Jawa Timur', '61259', 'Indonesia', 010,
'1500000')

INSERT INTO productlines (productLine, textDescription,
htmlDescription, image) VALUES
(001, 'Mobil', 'example', 'example'),
(002, 'Motor', 'example', 'example'),
(003, 'Spare Part Mobil', 'example', 'example'),
(004, 'Spare Part Motor', 'example', 'example'),
(005, 'Elektronik', 'example', 'example'),
(006, 'Perabotan', 'example', 'example'),
(007, 'Pakaian', 'example', 'example'),
(008, 'Sepatu', 'example', 'example'),
(009, 'Makanan', 'example', 'example'),
(010, 'Minuman', 'example', 'example')

INSERT INTO products (productCode, productName, productLine,
productScale, productVendor, productDescription, quantityInStock,
buyPrice, MSRP) VALUES
(001, 'Honda Vario 125', 002, 'example', 'Honda', 'Motor matic', 2, '25000000', '24000000')

INSERT INTO products (productCode, productName, productLine,
productScale, productVendor, productDescription, quantityInStock,
buyPrice, MSRP) VALUES
(002, 'Toyota Kijang', 001, 'example', 'Toyota', 'Mobil Kijang', 1, '50000000', '50000000'),
(003, 'Belt Honda Vario', 004, 'example', 'Honda', 'Van Belt motor vario', 5, '150000', '175000'),
(004, 'Ban Mobil', 003, 'example', 'Goodyear', 'Ban mobil ukuran 20"', 11, '350000', '350000'),
(005, 'Laptop ROG GL552VX', 005, 'example', 'ASUS', 'Laptop gaming ROG', 1, '8800000', '10000000'),
(006, 'Meja Belajar', 006, 'example', 'Princess', 'meja belajar anak', 3, '300000', '300000'),
(007, 'Jaket Windbreaker ERIGO', 007, 'example', 'Erigo', 'Windbreaker XL', 9, '125000', '130000'),
(008, 'Vans Authentic', 008, 'example', 'Vans', 'Sepatu Vans ukuran 41', 6, '400000', '400000'),
(009, 'Layz BBQ', 009, 'example', 'Layz', 'Snack kentang rasa BBQ', 100, '11500', '11500'),
(010, 'Freshtea Freeze', 010, 'example', 'Freshtea', 'Teh botolan', 100, '3500', '3500')

INSERT INTO orders(orderNumber, orderDate, requiredDate, shippedDate,
status, comments, customerNumber) VALUES
(001, '2021-10-21', '2021-10-25', '2021-10-22', 'Delivered', '-', 001),
(002, '2021-11-25', '2021-10-29', '2021-10-26', 'Waiting', '-', 002),
(003, '2021-11-02', '2021-11-10', '2021-11-05', 'Delivered', '-', 003),
(004, '2021-11-16', '2021-11-26', '2021-11-18', 'On the way', '-', 004),
(005, '2021-11-20', '2021-11-25', '2021-11-22', 'Warehouse', 'Transit di Gudang', 005),
(006, '2021-10-21', '2021-10-25', '2021-10-22', 'Delivered', '-', 006),
(007, '2021-10-01', '2021-10-11', '2021-10-05', 'Lost', 'barang hilang', 007),
(008, '2021-09-21', '2021-09-25', '2021-09-22', 'Delivered', 'Barang rusak', 008),
(009, '2021-11-24', '2021-11-30', '2021-11-26', 'Waiting', 'menunggu', 009),
(010, '2021-11-09', '2021-11-15', '2021-11-11', 'Pending', 'dalam pengiriman', 010)

INSERT INTO orderdetails(orderNumber, productCode, quantityOrdered,
priceEach, orderLineNumber) VALUES
(001, 001, 1, '25000000', 1),
(002, 001, 1, '25000000', 1),
(001, 003, 2, '150000', 2),
(003, 005, 1, '8800000', 1),
(004, 007, 5, '125000', 1),
(006, 007, 1, '125000', 1),
(010, 008, 1, '400000', 1),
(009, 006, 1, '300000', 1),
(005, 004, 2, '150000', 5),
(007, 009, 75, '11500', 2),
(007, 010, 80, '3500', 3)

INSERT INTO payments(customerNumber, checkNumber, paymentDate, amount) VALUES
(001, 001, '2021-11-20', '20000000'),
(002, 002, '2021-10-22', '2500000'),
(003, 003, '2021-09-08', '2090000'),
(004, 004, '2021-08-19', '15000000'),
(005, 005, '2021-10-10', '200000'),
(006, 006, '2021-04-22', '2090000'),
(007, 007, '2021-09-19', '5000000'),
(008, 008, '2021-11-20', '10000000'),
(009, 009, '2021-07-28', '450000'),
(010, 010, '2021-09-20', '100000000')

SELECT * FROM offices;