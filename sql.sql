
CREATE DATABASE QLHS1
GO
USE  QLHS1
GO

CREATE TABLE USERS
(
	id int identity(1,1) primary key,
	userName nvarchar(255) not null unique,
	password nvarchar(255) not null,
	fullName nvarchar(255),
	gender nvarchar(10),
	birthday date,
	email nvarchar(15),
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
	categoryName nvarchar(255) unique,
)
drop table CATEGORY
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
	namxb int,
	categoryId int,
	FOREIGN KEY(categoryId) REFERENCES CATEGORY(id),
	FOREIGN KEY(publicsherId) REFERENCES Publicsher(id),
	FOREIGN KEY(authorId) REFERENCES AUTHOR(id)
)

drop table book
go
CREATE TABLE phieunhap
(
	id int identity(1,1) primary key,
	ngaynhap date DEFAULT GETDATE(),
	tiennhap int
)
go
CREATE TABLE chitietphieunhap
(
	id int identity(1,1) primary key,
	maphieunhap int,
	soluong int,
	gia int,
	bookId int,
	FOREIGN KEY(maphieunhap) REFERENCES phieunhap(id),
	FOREIGN KEY(bookId) REFERENCES BOOK(id)

)
go
CREATE TABLE Kho
(
	id int identity(1,1) primary key,
	bookId int ,
	quantity int default 0,
	FOREIGN KEY(bookId) REFERENCES Book(id)
) 
go
CREATE TABLE CUSTOMER
(
	sdt nvarchar(15) primary key,
	customerName nvarchar(255),
	addresss nvarchar(255)

)
go
CREATE TABLE HoaDon
(
	id int identity(1,1) primary key,
	sdtCus nvarchar(15),
	FOREIGN KEY(sdtCus) REFERENCES CUSTOMER(sdt)
)
go

CREATE TABLE CHITIETHOADON
(
	id int identity(1,1) primary key,
	bookId int,
	mahd int,
	quantity int,
	FOREIGN KEY(mahd) REFERENCES HoaDon(id),
	FOREIGN KEY(bookId) REFERENCES BOOK(id)

)
CREATE TABLE PhieuXuat
(
	id int identity(1,1) primary key,
	userId int,
	sumMoney int default 0,
	sdtCustomer nvarchar(15),
	dateOrder date DEFAULT GETDATE(),
	FOREIGN KEY(userId) REFERENCES USERS(id),
	FOREIGN KEY(sdtCustomer) REFERENCES CUSTOMER(sdt),
)
--phieu xuat

CREATE TABLE ChiTietPhieuXuat
(
	id int identity(1,1) primary key,
	bookId int ,
	maphieuxuat int,
	quantity int,
	price int
	FOREIGN KEY(bookId) REFERENCES BOOK(id),
	FOREIGN KEY(maphieuxuat) REFERENCES PhieuXuat(id),

)
insert into ChiTietPhieuXuat (bookId,maphieuxuat,quantity,price) values(1,1,1)

ALTER TABLE BOOK
DROP COLUMN quantity;
-- danh mục
SELECT * FROM CATEGORY
INSERT INTO CATEGORY(categoryName) values(N'thiếu nhi')
update CATEGORY SET categoryName=N'Tiểu thuyết' where id=1
DELETE FROM CATEGORY where id=1
SELECT * FROM CATEGORY where categoryName like N'%t%'
--book
SELECT * 
FROM BOOK
update BOOK SET price= where id=1
--kho
select * from kho
delete from kho where id=1
insert into kho(bookId) values(7)
update kho set quantity where bookId=
--phieu nhap
select * from phieunhap
INSERT INTO phieunhap(tiennhap) values(0)
update phieunhap SET tiennhap= where id=1
--chi tiet phieu nhap
INSERT INTO chitietphieunhap(maphieunhap,soluong,gia,bookId) values()
SELECT * FROM chitietphieunhap where maphieunhap= and bookId
ALTER TABLE users
ADD email nvarchar(255);
select sum(soluong * gia) from chitietphieunhap where maphieunhap=2
--hoa don
select * from HoaDon where idUser=1 and sdtCus='0947669387'
insert into HoaDon(sdtCus) values('0947669387')
select * from users
ALTER TABLE USERS
ADD  gender nvarchar(10);
--chi tiet hoa don
insert into CHITIETHOADON (bookId,mahd,quantity) values(1,1,1)
update CHITIETHOADON set quantity= where bookId= and mahd
select * from CHITIETHOADON where mahd=1
select * from CHITIETHOADON where bookId and mahd=
SELECT  SUM(b.price * c.quantity) AS tongTien ,c.mahd
FROM chitiethoadon c
JOIN Book b ON c.bookId = b.id
where c.mahd=2
GROUP BY c.mahd
SELECT ROLE.roleName FROM USERS JOIN USER_ROLE ON USERS.id = USER_ROLE.userId JOIN ROLE ON USER_ROLE.roleId = ROLE.id where USERs.userName ='kien' and USERs.password='123' ;
select 
SELECT ROLE.roleName
FROM USERS
JOIN USER_ROLE ON USERS.id = USER_ROLE.userId
JOIN ROLE ON USER_ROLE.roleId = ROLE.id where USERs.userName ='user' and USERs.password='123456' ;
Select * from 
  


ALTER TABLE phieunhap
 namxb int;
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