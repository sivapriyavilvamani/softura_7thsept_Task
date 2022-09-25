
use AdventureWorks2019
go

--13
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
where (ProductID between 300 and 350 and LocationID = 50)
--&& LocationID =50

--18
select PPI.LocationID,Shelf,Name 
from Production.ProductInventory as PPI
join Production.Location as PL
on PPI.LocationID = PL.LocationID

select * from Production.ProductInventory
select * from Production.Location

--19
select AddressID,AddressLine1,AddressLine2, PA.StateProvinceID,StateProvinceCode,CountryRegionCode 
from Person.StateProvince as PSP
join Person.Address as PA
on PSP.StateProvinceID = PA.StateProvinceID

--20
select subtotal, TaxAmt 
from Sales.SalesOrderHeader as SSOH
join Sales.SalesTerritory as SST
on SSOH.TerritoryID = SST.TerritoryID

select CurrencyCode,SST.CountryRegionCode
from Sales.SalesTerritory as SST
join Sales.CountryRegionCurrency as SCRC
on SST.CountryRegionCode = SCRC.CountryRegionCode

select sum(subtotal+TaxAmt) as total
from Sales.SalesOrderHeader 




select * from Sales.SalesOrderHeader
select * from Sales.SalesTerritory 
select * from Sales.CountryRegionCurrency


