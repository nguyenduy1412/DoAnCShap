
CREATE DATABASE QLHS
GO
USE  QLHS
GO

CREATE TABLE USERS
(
	id int identity(1,1) primary key,
	userName nvarchar(255) not null unique,
	password nvarchar(255) not null,
	fullName nvarchar(255),
	gender bit,
	birthday date,
	addresss nvarchar(255),
	telephone char(15) unique,
	img nvarchar(255)
	
)
CREATE TABLE CATEGORY
(
	id int identity(1,1) primary key,
	categoryName nvarchar(255),
)
CREATE TABLE BOOK
(
	id int identity(1,1) primary key,
	bookName nvarchar(255),
	authorId int,
	publicsherId int,
	price int,
	priceSale int,
	sale int,
	img nvarchar(255),
	quantity int,
	dateAdded date,
	categoryId int,
	FOREIGN KEY(categoryId) REFERENCES CATEGORY(id),
	FOREIGN KEY(publicsherId) REFERENCES Publicsher(id),
	FOREIGN KEY(authorId) REFERENCES AUTHOR(id)
)
drop table ORDERS
CREATE TABLE ROLE
(
	id int identity(1,1) primary key,
	roleName nvarchar(255) 
)
CREATE TABLE USER_ROLE
(
	id int identity(1,1) primary key,
	userId int,
	roleId int,
	FOREIGN KEY(userId) REFERENCES USERS(id),
	FOREIGN KEY(roleId) REFERENCES ROLE(id)
	
)
SELECT ROLE.roleName
FROM USERS
JOIN USER_ROLE ON USERS.id = USER_ROLE.userId
JOIN ROLE ON USER_ROLE.roleId = ROLE.id where USERs.userName ='user' and USERs.password='123456' ;

CREATE TABLE AUTHOR
(
	id int identity(1,1) primary key,
	nameAuthor nvarchar(255)
)

CREATE TABLE Publicsher
(
	id int identity(1,1) primary key,
	namePublicsher nvarchar(255)
)

CREATE TABLE Warehouse
(
	id int identity(1,1) primary key,
	bookId int ,
	quantity int,
	FOREIGN KEY(bookId) REFERENCES BOOK(id)
)   
CREATE TABLE DETAIL_ORDER
(
	id int identity(1,1) primary key,
	bookId int ,
	orderId int,
	quantity int,
	price int
	FOREIGN KEY(bookId) REFERENCES BOOK(id),
	FOREIGN KEY(orderId) REFERENCES ORDERS(id),

)
CREATE TABLE ORDERS
(
	id int identity(1,1) primary key,
	userId int,
	sdtCustomer int,
	dateOrder date DEFAULT GETDATE()
	FOREIGN KEY(userId) REFERENCES USERS(id),
	FOREIGN KEY(sdtCustomer) REFERENCES CUSTOMER(sdt),


)

CREATE TABLE CUSTOMER
(
	sdt int primary key,
	customerName nvarchar(255),
	addresss nvarchar(255)

)