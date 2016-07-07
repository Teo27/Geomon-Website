Create procedure spHighscore
With Encryption
As
Begin
	SELECT [ScrName], [Score] FROM [Customer] ORDER BY [Score] DESC
	
End

GO

create procedure spGetCollection
(
@Username varchar(20)
)
with encryption 
as 
begin
	select Geomon.Id, [Name], Rarity, Picture,(select count(Geomon.Id) from Geomon) as [Max] from Geomon inner join Geomon_Collection on Geomon.Id = Geomon_Collection.Geomon_Id inner join Customer on Geomon_Collection.Customer_Username = Customer.Username where (Customer.Username = @Username) AND (Geomon.Level > 0);
end

GO

create procedure spAchievements
(
@Username varchar(20)
)
with encryption 
as 
begin
	SELECT Achievements.Name, Achievements.[Description], Achievements.Value, (select count(Achievements.Id) from Achievements) as [Max] FROM [Achievements] inner join Achievements_Collection on Achievements.Id=Achievements_Collection.Achievement_Id inner join Customer on Achievements_Collection.Customer_Us=Customer.Username where Username=@Username group by Achievements.Name, Achievements.[Description], Achievements.Value
end

Go

create procedure spGetEggs
(
@Username varchar(20)
)
with encryption 
as 
begin
	SELECT Geomon.Id, Geomon.Level, Geomon.Picture FROM Geomon INNER JOIN Geomon_Collection ON Geomon.Id = Geomon_Collection.Geomon_Id INNER JOIN Customer ON Geomon_Collection.Customer_Username = Customer.Username WHERE (Customer.Username = @Username) AND (Geomon.Level = 0)
end

Go

create procedure spProfile
(
@Clicked varchar(20)
)
with encryption 
as 
begin
	SELECT Geomon.Id, Geomon.Name, Geomon.Picture, Geomon.Rarity, Geomon.Type, Customer.Steps, Customer.Score FROM Geomon INNER JOIN Geomon_Collection ON Geomon.Id = Geomon_Collection.Geomon_Id INNER JOIN Customer ON Geomon_Collection.Customer_Username = Customer.Username WHERE (Customer.Username = @Clicked) AND (Geomon.Level > 0)
end

GO

Create procedure spGetGeomon
(
@Name varchar(20)
)
With Encryption
As
Begin
	SELECT * FROM [Geomon] WHERE Geomon.Name = @Name;
	
End
