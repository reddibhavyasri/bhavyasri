create database septemberasnmnt
use septemberasnmnt

create table member
(
member_id numeric(5) primary key,
member_name varchar(25),
acc_open_date date,
max_books_allowed numeric(2),
penalty_amount numeric(7,2)
)

create table book
(
book_no numeric(6) primary key,
book_name varchar(30),
author varchar(30),
cost numeric(7,2),
category varchar(15)
)

create table issue
(
lib_issue_id numeric(10) primary key,
book_no numeric(6) foreign key references book(book_no),
member_id numeric(5)foreign key references member(member_id),
issue_date date,
return_date date
)
--3
alter table issue
add  comments varchar(100) 

--4
alter table member
alter column member_name varchar(30)

--5
alter table issue
add  refrence char(30) 

alter table issue
drop column refrence 

insert into member values(1,'Richa Sharma','10-Dec-05',5,50)

insert into member values(2,'Garima Sen','20-Sep-22',3,null)
insert into member values(3,'Loki',null,4,100)
insert into member values(4,'Thor','15-Aug-15',null,null)
insert into member values(5,null,'02-Nov-18',6,300)

select * from member

alter table member
alter column member_name varchar(20)

insert into member values(6,'Kratos','10-Dec-05',110,null)
--------Arithmetic overflow error converting int to data type numeric----


select * into member101 from member

select * from member
select * from member101

insert into book values(101,'Let us C','Denis Ritchie',450,'System')
insert into book values(102,'Oracle – Complete Ref','Loni',550,'Database')
insert into book values(103,'Mastering SQL','Loni',250,'Database')
insert into book values(104,'PL SQL-Ref','Scott Urman',750,'Database')





select * into book101 from book
select * from book101

select * from member
select * from book

insert into book values(105,'National Geographic','Adis Scott',1000,'Science')

delete from book 
where book_no =105


 
update book set cost = 300,category = 'RDBMS' where book_no = 103 

select * from book 

insert into issue(Lib_Issue_Id,book_no,member_id,issue_date) values(7001,101,1,'10-Dec-06')

insert into issue(Lib_Issue_Id,book_no,member_id,issue_date) values(7002,102,2,'25-Dec-06')

insert into issue(Lib_Issue_Id,book_no,member_id,issue_date) values(7003,104,1,'15-Jan-06')

insert into issue(Lib_Issue_Id,book_no,member_id,issue_date) values(7004,101,1,'04-Jul-06')

insert into issue(Lib_Issue_Id,book_no,member_id,issue_date) values(7005,104,2,'15-Nov-06')

insert into issue(Lib_Issue_Id,book_no,member_id,issue_date) values(7006,101,3,'18-Feb-06')

select * from issue


update issue set return_date ='19-Jul-06'where lib_issue_id = 7004 

update issue set return_date ='30-Nov-06'where lib_issue_id = 7005

select * from issue

update member set penalty_amount = 100 where member_id = 2

select * from member

delete from issue
where member_id = 1 and issue_date < '10-Dec-06'

select * from issue


delete from book
where category != 'RDBMS' and category != 'Database'

drop table member101

drop table book101
----------------------------------------
select * from book where author='Loni' and
cost < 600;
select * from issue where return_date is  null ;

update issue set return_date='31-Dec-2006' where
Lib_issue_id=7001;
update issue set return_date='31-Dec-2006' where
Lib_issue_id=7002;
update issue set return_date='31-Dec-2006' where
Lib_issue_id=7003;
update issue set return_date='31-Dec-2006' where
Lib_issue_id=7004;

select* from issue where (return_date)-
(issue_date)>30

select*from book where cost BETWEEN 500 AND 750

select * from book where category in ('Science',
'Database', 'Fiction','Management');

select * from member order by penalty_amount desc;

select * from book order by category asc,cost desc;

select * from book where book_name like'%SQL%'; 

select* from member where member_name like'R%'or
member_name like'G%' and member_name like '%I%';

select initcap,(author),upper(book_name) from book
order by book_name desc

SELECT TO_CHAR(issue_date
'DY/MON/DD/YYYY'),TO_CHAR(return_date,'DY/MON/DD/YYYY')FROM
issue WHERE lib_issue_id=7001;

select
category,decode(category,'database','D','rdbms','R','science','S','others','O')
as types from book;


SELECT member_name FROM member WHERE
TO_CHAR(acc_open_date,'YY')=06;



SELECT lib_issue_id,issue_date,return_date(return_date-issue_date) AS No of days FROM issue;


select * from issue order by issue_date ;


SELECT SUM(MAX_BOOKS_ALLOWED) FROM member WHERE
member_id=1 ;

select sum(penalty_amount) from member ;














