CREATE TABLE [dbo].[Timesheets]
(
    [Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [Date] DATETIME2 NOT NULL, 
    [Hours] FLOAT NOT NULL, 
    [Description] NVARCHAR(50) NULL
)


