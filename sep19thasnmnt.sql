create database shopping
use shopping
create table customer 
(
 custid int primary key,
 custname varchar(06),
 city varchar(60),
 state varchar(60)
 )
 create table products
 (
  prodid int primary key,
  prodname varchar(40),
  unitprice int,
  unitofmeasurement int,
  qtyinstock int,
  )
  create table sales_header
  (
   invono int primary key,
   invdate date,
   invamt int,
   dispercent int
   )
   create table sales_detail
   (
   invono int foreign key references sales_header(invono),
   custid int foreign key references customer(custid),
   prodid int foreign key references products(prodid),
   qtysold int
   )
   alter table sales_details
   drop column qtysold
   
   

