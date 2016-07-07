Create procedure spLocalGeomon
With Encryption
As
Begin
	SELECT Id, Name, Rarity FROM Geomon WHERE [Level] > 0
	
End

GO

Create procedure spLocalCollection
(
@Username varchar(20)
)
With Encryption
As
Begin
	SELECT Id FROM Geomon_Collection WHERE Customer_Username = @Username
End

GO

Create procedure spInsertCollection
(
@Username varchar(20),
@Id int
)
With Encryption
As
Begin
	INSERT INTO Geomon_Collection VALUES (@Id,@Username);
End