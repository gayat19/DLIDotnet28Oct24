create database dbShopping
go

use dbShopping
go

create table Customer
(id int identity(101,1) constraint pk_CustomerID primary key,
name nvarchar(150) not null,
dateofbirth datetime constraint chk_DOB check (dateofbirth<=getDate()),
phone varchar(15),
email varchar(200))
go

create table Product
(id int identity(1,1) primary key,
name nvarchar(200) not null,
price float check(price>=0),
quantity int,
basicimage nvarchar(max))
go

create table orders
(orderid char(6) constraint pk_orderno primary key,
orderdate datetime default getdate(),
customer_id int constraint fk_order_cust foreign key references CUstomer(id),
totalvalue float)
go



create table orderdetails
(productId int references Product(id),
ordernumber char(6) constraint order_orderdet foreign key references orders(orderid),
quantity int,
price float,
discount float,
constraint pk_orderdetails primary key(productid,ordernumber))
go

drop table orderdetails

create table orderdetails
(sino int identity(1,1) primary key,
productId int references Product(id),
ordernumber char(6) constraint order_orderdet foreign key references orders(orderid),
quantity int,
price float,
discount float,
constraint uq_orderdetails unique(productid,ordernumber))

sp_help customer

alter table customer drop constraint chk_DOB

alter table customer add constraint chk_DOB check(dateofbirth<=getDate())


select * from Customer
insert into Customer(name,dateofbirth,phone,email)
values('Ramu','12-12-2000','9876543210','ramu@gmail.com')

insert into Customer(name,dateofbirth,phone,email)
values('Somu','05-10-2000','6549873210','somu@gmail.com'),
('Bimu','07-11-2000','2109876543','bimu@gmail.com'),
('Komu','03-21-2001','4321098765','komu@gmail.com'),
('Lomu','12-17-1999','7698543210','lomu@gmail.com')

select * from Product

insert into Product(name,price,quantity,basicimage)
values('Pencil',5,10,'')

insert into Product(name,price,quantity,basicimage)
values('Eraser',3,5,'')

insert into Product(name,price,quantity,basicimage)
values('Sharpner',2,15,'')

bulk insert Orders
from 'C:\Corp\Velveer\Participants\Day4\Customers.csv'
with(
FieldTerminator = ',',
RowTerminator = '\n',
FirstRow=2,
errorfile = 'C:\Corp\Velveer\Participants\Day4\insert_error_log.txt')

select * from orders

delete   from  orders

update orders set totalvalue = 
case when customer_id=1 then totalvalue+5
when customer_id = 2 then totalvalue +10
else totalvalue
end 
