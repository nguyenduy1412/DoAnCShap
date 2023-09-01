
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
GO
CREATE TABLE ROLE
(
	id int identity(1,1) primary key,
	roleName nvarchar(255) 
)
GO
CREATE TABLE USER_ROLE
(
	id int identity(1,1) primary key,
	userId int,
	roleId int,
	FOREIGN KEY(userId) REFERENCES USERS(id),
	FOREIGN KEY(roleId) REFERENCES ROLE(id)
	
)
go
CREATE TABLE CATEGORY
(
	id int identity(1,1) primary key,
	categoryName nvarchar(255),
)
go
CREATE TABLE AUTHOR
(
	id int identity(1,1) primary key,
	nameAuthor nvarchar(255)
)
go
CREATE TABLE Publicsher
(
	id int identity(1,1) primary key,
	namePublicsher nvarchar(255)
)

go
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
go
CREATE TABLE Warehouse
(
	id int identity(1,1) primary key,
	bookId int ,
	quantity int,
	FOREIGN KEY(bookId) REFERENCES BOOK(id)
) 
go
CREATE TABLE CUSTOMER
(
	sdt nvarchar(15) primary key,
	customerName nvarchar(255),
	addresss nvarchar(255)

)
go
CREATE TABLE ORDERS
(
	id int identity(1,1) primary key,
	userId int,
	sumMoney int default 0,
	sdtCustomer nvarchar(15),
	dateOrder date DEFAULT GETDATE(),
	FOREIGN KEY(userId) REFERENCES USERS(id),
	FOREIGN KEY(sdtCustomer) REFERENCES CUSTOMER(sdt),
)
go
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
drop table ORDERS


SELECT ROLE.roleName
FROM USERS
JOIN USER_ROLE ON USERS.id = USER_ROLE.userId
JOIN ROLE ON USER_ROLE.roleId = ROLE.id where USERs.userName ='user' and USERs.password='123456' ;

  


ALTER TABLE ORDERS
ADD sumMoney int;
drop table ORDERS

drop table ORDERS
ALTER TABLE ORDERS
ALTER COLUMN sdtCustomer nvarchar(15);
SELECT ROLE.roleName
FROM USERS
JOIN USER_ROLE ON USERS.id = USER_ROLE.userId
JOIN ROLE ON USER_ROLE.roleId = ROLE.id where USERs.userName ='user' and USERs.password='123456' ;

select book.bookName,book.priceSale,Publicsher.namePublicsher,CATEGORY.categoryName,AUTHOR.nameAuthor,Warehouse.quantity
from CATEGORY 
join book on CATEGORY.id =book.categoryId
join Warehouse on book.id =Warehouse.bookId
join Publicsher on Publicsher.id =book.publicsherId
join AUTHOR on AUTHOR.id =book.authorId
select book.*
from CATEGORY 
join book on CATEGORY.id =book.categoryId
join Warehouse on book.id =Warehouse.bookId
join Publicsher on Publicsher.id =book.publicsherId
join AUTHOR on AUTHOR.id =book.authorId
select book.*
from CATEGORY ,book,Warehouse,AUTHOR,Publicsher
where book.categoryId=category.id and
book.publicsherId=Publicsher.id and
book.authorId=AUTHOR.id and
Warehouse.bookId=BOOK.id
select priceSale from book where id='1'
select USERs.id, USERS.fullName from users where userName='user'
insert into CUSTOMER values('','','')
select * from CUSTOMER where sdt='0947669387'
insert into ORDERS values('','userId','sdt')
insert into DETAIL_ORDER values('bookId','orderId','quantity','price')
select * from ORDERS where dateOrder=' ' and sdtCustomer='' and userId=''
select sum(price) from DETAIL_ORDER where orderId=''
update ORDERS SET sumMoney= where id=
select * from ORDERS where dateOrder='2023-08-30' and sdtCustomer='0947669387' and userId=1
select bookId,quantity,price from Detail_Order where orderId=1
select * from orders
select * from DETAIL_ORDER where bookId=1 and orderId=1
select * fo
update DETAIL_ORDER SET quantity=2 , price=60000 where orderId=2 and bookId=1