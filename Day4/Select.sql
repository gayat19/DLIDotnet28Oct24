select * from Products
select * from categories
select * from Suppliers

--print the average products in stock in every category
select categoryid, avg(UnitsInStock) Avg_In_Stock
from Products
group by categoryid
having avg(UnitsInStock)>30
order by 2

select CategoryName, avg(UnitsInStock) Avg_In_Stock
from Products p join Categories c
on p.CategoryID = c.CategoryID
group by CategoryName
having avg(UnitsInStock)>30
order by 2

select categoryName,ProductName,CompanyName
from Categories c join PRoducts p
on c.CategoryID = p.CategoryID
join Suppliers s
on s.SupplierID = p.SupplierID
order by 1,3,2 desc

create or alter proc proc_GetProductsWithCategory
as
begin
   select categoryName,ProductName,CompanyName,
	dense_Rank() over(order by CategoryName) as CategoryRank
	from Categories c join PRoducts p
	on c.CategoryID = p.CategoryID
	join Suppliers s
	on s.SupplierID = p.SupplierID
	
end

exec proc_GetProductsWithCategory

create proc proc_PaginateOrders(@startnum int,@ncount int)
as
begin
   select * from orders order by OrderID
   offset @startnum rows 
   fetch next @ncount rows only
end


exec proc_PaginateOrders 11, 10
