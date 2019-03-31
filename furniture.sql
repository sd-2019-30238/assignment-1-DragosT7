use Furniture

create table Users(
id int primary key identity,
username varchar(50),
password varchar(255),
firstname varchar(50),
lastname varchar(50),
email varchar(50),
phonenumber varchar(30),
address varchar(255),
isadmin bit default 0)

create table Furnitures(
id int primary key identity,
namefurniture varchar(50),
descriptionfurniture varchar(255),
typefurniture varchar(100),
price float default 0,
seller varchar(100),
nrofproducts int default 0)

insert into Furnitures(namefurniture, descriptionfurniture, typefurniture, price, seller, nrofproducts)
values('Delaktig', 'Cadru pat + tablie', 'Mobilier dormitor', 2279.99, 'Ikea', 23);

update Furnitures
set namefurniture = 'Bucatarie Rio', descriptionfurniture = 'Mobila de bucatarie', typefurniture = 'Bucatarie', price = 599.99, seller = 'Dedeman', nrofproducts = 40 where id = 2;

create table Orders(
id int primary key identity,
userID int, 
totalprice float default 0,
statusorder varchar(50),
FOREIGN KEY (userID) REFERENCES Users(id),
)

create table OrderItems(
id int primary key identity,
orderID int, 
furnitureID int,
FOREIGN KEY (furnitureID) REFERENCES Furnitures(id),
FOREIGN KEY (orderID) REFERENCES Orders(ID))

SELECT SUM(dbo.Furnitures.price) FROM dbo.Furnitures INNER JOIN dbo.OrderItems
on dbo.Furnitures.id = dbo.OrderItems.furnitureID and dbo.OrderItems.orderID = 7;

select * from OrderItems;
select * from Orders;
select * from Users;