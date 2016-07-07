Create procedure spInsertNewCustomer
(
	@ScrName			varchar(20),
	@Username			varchar(20),
	@Password			varchar(100),
	@Salt				varchar(50),
	@Email				varchar(40),
	@DateOfCreation		date
)
With Encryption
As
Begin
	Insert Into dbo.Customer
	(
		[ScrName],
		[Username],
		[Password],
		[Salt],
		[Email],
		[Steps],
		[Score],
		[DateOfCreation]
	)
	Values
	(
		@ScrName,
		@Username,
		@Password,
		@Salt,
		@Email,
		0,
		0,
		@DateOfCreation
	)
End

GO


Create procedure spDeleteCustomer
(
	
	@Username			varchar(20)
	
)
With Encryption
As
Begin
	Delete from dbo.Customer
	where dbo.Customer.Username=@Username
	
End
GO
Create procedure spUpdateCustomer
(
	@ScrName			varchar(20),
	@Username			varchar(20),
	@Password			varchar(100),
	@Salt				varchar(50),
	@Email				varchar(40)
	
)
With Encryption
As
Begin
	UPDATE dbo.Customer
	SET ScrName=@ScrName,[Password]=@Password,Salt=@Salt,Email=@Email
	where dbo.Customer.Username=@Username
	
End
GO
Create procedure spReadCustomer
(
	
	@Username			varchar(20)
	
)
With Encryption
As
Begin
	Select * from dbo.Customer
	where dbo.Customer.Username=@Username
	
End
GO
Create procedure spCheckCustomer
(
	@Username			varchar(20),
	@Password		    varchar(100)
)
With Encryption 
As
Begin
    Select * from dbo.Customer
	where dbo.Customer.Username=@Username and dbo.Customer.[Password]=@Password
End

