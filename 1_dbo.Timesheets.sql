CREATE TABLE [dbo].[Timesheets]
(
    [Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[UserId] NVARCHAR (128) NOT NULL, 
    [Date] DATETIME2 NOT NULL, 
    [Hours] FLOAT NOT NULL, 
    [Description] NVARCHAR(50) NULL,
	CONSTRAINT [FK_Timesheets_To_AspNetUsers] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers]([Id])
)


