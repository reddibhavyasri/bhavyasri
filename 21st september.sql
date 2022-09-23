use septemberasnmnt
select  category,count(book_no) from book 
group by category

select * from book
select * from issue

select book_no,count(lib_issue_id) Issuedcount from issue 
group by book_no
order by issuedcount desc 

select* from member

select max(penalty_amount) Max ,min(penalty_amount) Min,sum(penalty_amount) Sum,avg(penalty_Amount) Avg  from member

select member_id,count(lib_issue_id) from issue
group by member_id
having count(lib_issue_id)> 1

select member_id, book_no,count(lib_issue_id) Issuedcount from issue 
group by book_no,member_id
order by issuedcount desc

select month(issue_date) month,count(book_no) bookcount from issue
group by month(issue_date)
order by bookcount desc

select book_no from issue 
where issue_date is null


select m.member_id,i.member_id "DEPT"
from member m inner join issue i
on m.member_id=i.member_id

select member_id ,max(lib_issue_id) Max,min(lib_issue_id) Min from issue
group by member_id

select * from issue
where month(issue_date) 
in (12,9)
-----------
use septemberasnmnt

select b.book_no,b.book_name,i.issue_date,b.category
from book b inner join issue i
on b.book_no=i.book_no
where month(issue_date)=9 and b.category='database'

select m.member_id,m.Member_Name,count(i.lib_issue_id) Issuecount
from member m inner join issue i
on m.Member_Id=i.Member_Id
group by rollup(m.Member_Id,m.Member_Name)
order by Issuecount desc


select b.Book_No,b.book_name,i.Issue_Date,i.Return_date,b.Author
from Book b inner join issue i
on b.Book_No=i.Book_No
where b.Author= 'Loni'

select m.member_id,m.member_name,count(i.lib_issue_id) Issuecount
from member m inner join issue i
on m.member_id=i.member_id


 select m.member_id,m.member_name
  from member m inner join  issue i
  on m. member_id=i.member_id
  inner join Book b
  on i.book_no=b.book_no
  where b.category='Database'

  select category,max(cost) from book
  group by category

  select distinct i.* from issue i,member m where i.issue_date not between m.acc_open_date and i.return_date

  select member_id from member
  except
  select member_id from issue

  select * from issue
  select * from member

use northwind
  
  select * from Customers

  select distinct  count(Customerid) from Customers

   select distinct  count(Customerid) from Customers
   where ContactName like 'b%'  

   select distinct  count(Customerid) from Customers
   where ContactName like '%s%'  

   select distinct city, count(Customerid) from Customers
   group by City



  








