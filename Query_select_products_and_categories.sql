--create tables
create table Products
(
ProductId int not null,
ProductName nvarchar(100) null
)

create table Category
(
CategoryId int not null,
CategoryName nvarchar(100) null
)

create table ProductCategory
(
CategoryId int not null,
ProductId int not null
)

--inserts in tables


--select all products and categories
select p.ProductName, c.CategoryName  from ProductCategory pc
join Category c on c.CategoryId = pc.CategoryId
join Products p on p.ProductId = pc.ProductId