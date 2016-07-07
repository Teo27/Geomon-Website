create database GeomonLocal
go
use GeomonLocal
go
create table Customer
(
ScrName			varchar(20)		NOT NULL		UNIQUE,
Username		varchar(20)		NOT NULL		UNIQUE,
[Password]		varchar(100)	NOT NULL,
Salt			varchar(50)		NOT NULL		UNIQUE,
Email			varchar(40)		NOT NULL		UNIQUE,
Steps			int				DEFAULT(0),
Score			int				DEFAULT(0),
DateOfCreation	date			NOT NULL

				CONSTRAINT CustomerPK
					Primary Key(Username)
)

GO

Create table Geomon
(	
Id				int				NOT NULL		IDENTITY(1,1),
Name			varchar(20)		NOT NULL		UNIQUE,
Rarity			int				NOT NULL,
[Type]			varchar(20)		NOT NULL,
[Level]			int				DEFAULT(0),
Picture			varchar(max)	NOT NULL,

				
				CONSTRAINT GeomonPK	
					Primary Key(Id)
)

GO
Create table Geomon_Collection
(
Id				int				NOT NULL		IDENTITY(1,1),
Geomon_Id		int				foreign key references Geomon(Id),
Customer_Username		varchar(20)		foreign key references Customer(Username) 

)

Go

Create table Friends_List
(
Id				int				NOT NULL		IDENTITY(1,1),
Customer_Us1	varchar(20)		foreign key references Customer(Username),
Customer_Us2	varchar(20)		foreign key references Customer(Username)
)
Go 

Create table Achievements
(
Id				int				NOT NULL		IDENTITY(1,1),
Name			varchar(20)		NOT NULL		UNIQUE,
[Description]	varchar(200)	NOT NULL,
Value			int				NOT NULL,
		
		Constraint Achievements_Pk	
			Primary key (Id)

)
GO
Create table Achievements_Collection
(
Id				int			   NOT NULL			IDENTITY(1,1),
Achievement_Id	int			   foreign key references Achievements(Id)  ,
Customer_Us		varchar(20)	   foreign key references Customer(Username) 

)