CREATE TABLE [dbo].[Users]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Firstname] NVARCHAR(50) NULL, 
    [Lastname] NVARCHAR(50) NULL, 
    [Email] NVARCHAR(50) NULL, 
    [Phonenumber] INT NULL
)
