Select * from Customers

Select * from Customers where city='London'

select * from Products where CategoryId=1 or CategoryId=3

select * from Products where CategoryId=1 and unitprice>20

select * from Products order by UnitPrice desc

select count(*) from Products where CategoryId=2

select Categoryid,count(*) from Products group by categoryid

select Categoryid,count(*) from Products group by categoryid having count(*)<10

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice>10



Select CompanyName from Customers c left join Orders o
on c.CustomerID= o.CustomerID
where o.CustomerID is null