use AdventureWorks2019
go
--1
select  FirstName, LastName
from Person.Person
where Title is not null
--2
select  FirstName, LastName
from Person.Person
where FirstName like '%a%'


--3
select CurrencyCode, name  from Sales.Currency where CurrencyCode in (select CurrencyCode from sales.CountryRegionCurrency );

select * from HumanResources.Department

insert into HR.Dept values(select * from HumanResources.Department);


--4

use AdventureWorks2019
go
select *
into HumanResources.Dept
from HumanResources.Department
--where domain = 1;
select * from HumanResources.Dept
go
--5

create table Employee
(
SNo int identity(1,1),
EmpId varchar(25),
Name varchar(25),
Dept varchar(25), 
DoB date 
)
select * from Employee
insert into Employee values ('AB61','dharsha','Manufacturing','07/09/2001')
--6
SELECT BusinessEntityID,AddressTypeID
from HumanResources.Department AS HRD
INNER JOIN Person.BusinessEntityAddress AS EA ON
HRD.DepartmentID = EA.BusinessEntityID

select * from HumanResources.Department
select * from Person.BusinessEntityAddress


--7
select GroupName 
from HumanResources.Department
where GroupName like 'Structural%'

8
SELECT (PR.ListPrice + PCH.StandardCost + PR.StandardCost) as TotalSum
from Production.ProductCostHistory AS PCH
JOIN Production.Product AS PR ON
PCH.ProductID = PR.ProductID


select * from Production.ProductCostHistory
select * from Production.Product



--9
select * from HumanResources.EmployeeDepartmentHistory


select DepartmentID, StartDate, EndDate, DATEDIFF(YEAR, StartDate, EndDate) as YearsOfExp
from HumanResources.EmployeeDepartmentHistory
where EndDate is not null

--select * from HumanResources.EmployeeDepartmentHistory where StartDate

--11.
select MAx(TaxRate)
from sales.SalesTaxRate

--10
select * from Sales.SalesPersonQuotaHistory
where (SalesQuota+5000) > 100000 order by SalesQuota desc

--12
select DepartmentID,HRE.BusinessentityId,ShiftId,BirthDate,DATEDIFF(YEAR,BirthDate,GETDATE()) as Age
from HumanResources.Employee as HRE
join HumanResources.EmployeeDepartmentHistory as HRD
on HRE.BusinessEntityID=HRD.BusinessEntityID


select * from HumanResources.Employee
select * from HumanResources.Department
select * from HumanResources.EmployeeDepartmentHistory

13
CREATE VIEW [Name_Age] as
select DepartmentID,HRE.BusinessentityId,ShiftId,BirthDate,DATEDIFF(YEAR,BirthDate,GETDATE()) as Age
from HumanResources.Employee as HRE
join HumanResources.EmployeeDepartmentHistory as HRD
on HRE.BusinessEntityID=HRD.BusinessEntityID

--14
--not neccesary
--15
--Not Enough Requirements
--16
select FirstName,MiddleName,Title,AddressTypeID,PP.BusinessEntityID 
from person.person as PP
join person.BusinessEntityAddress as BEA
on pp.BusinessEntityID=BEA.BusinessEntityID
where Title is not null

--select * from person.person
--select * from person.BusinessEntityAddress

--17
select ProductID,LocationID,Shelf
from Production.ProductInventory
where ProductID between 300 and 350 
--&& LocationID =50
