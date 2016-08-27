

USE [webcount]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

BEGIN TRANSACTION

IF NOT(EXISTS (SELECT * 
                 FROM INFORMATION_SCHEMA.TABLES 
                 WHERE TABLE_SCHEMA = 'dbo' 
                 AND  TABLE_NAME = 'ErrorLog'))
BEGIN
CREATE TABLE [dbo].[ErrorLog] (
    [Id]          INT           PRIMARY KEY,
    [Message]     VARCHAR (MAX) NOT NULL,
    [StackTrace]  VARCHAR (MAX) NULL,
    [DateCreated] DATETIME      NOT NULL
);
END


IF NOT(EXISTS (SELECT * 
                 FROM INFORMATION_SCHEMA.TABLES 
                 WHERE TABLE_SCHEMA = 'dbo' 
                 AND  TABLE_NAME = 'ProductType'))
BEGIN
CREATE TABLE [dbo].[ProductType] (
    [Id]   INT          PRIMARY KEY,
    [Name] VARCHAR (50) NOT NULL
);
END


IF NOT(EXISTS (SELECT * 
                 FROM INFORMATION_SCHEMA.TABLES 
                 WHERE TABLE_SCHEMA = 'dbo' 
                 AND  TABLE_NAME = 'Product'))
BEGIN
CREATE TABLE [dbo].[Product] (
    [Id]            INT          PRIMARY KEY,
    [Name]          VARCHAR (50) NOT NULL,
    [ProductTypeId] INT          FOREIGN KEY REFERENCES [dbo].[ProductType]
);
END


IF NOT(EXISTS (SELECT * 
                 FROM INFORMATION_SCHEMA.TABLES 
                 WHERE TABLE_SCHEMA = 'dbo' 
                 AND  TABLE_NAME = 'Inventory'))
BEGIN
	CREATE TABLE [dbo].[Inventory] (
		[Id]          INT			   PRIMARY KEY,
		[ProductId]   INT              FOREIGN KEY REFERENCES [dbo].[Product],
		[UniqueKey]   UNIQUEIDENTIFIER NOT NULL,
		[IsAvailable] BIT              NOT NULL
	);
END


IF NOT(EXISTS (SELECT * 
                 FROM INFORMATION_SCHEMA.TABLES 
                 WHERE TABLE_SCHEMA = 'dbo' 
                 AND  TABLE_NAME = 'Role'))
BEGIN
CREATE TABLE [dbo].[Role] (
    [Id]   INT          PRIMARY KEY,
    [Name] VARCHAR (50) NOT NULL
);
END


IF NOT(EXISTS (SELECT * 
                 FROM INFORMATION_SCHEMA.TABLES 
                 WHERE TABLE_SCHEMA = 'dbo' 
                 AND  TABLE_NAME = 'User'))
BEGIN
CREATE TABLE [dbo].[User] (
    [Id]             INT          PRIMARY KEY,
    [Username]       VARCHAR (50) NOT NULL,
    [Email]          VARCHAR (50) NOT NULL,
    [HashedPassword] VARCHAR (50) NOT NULL,
    [Salt]           VARCHAR (50) NOT NULL,
    [IsLocked]       BIT          NOT NULL,
    [DateCreated]    DATETIME     NOT NULL
);
END


IF NOT(EXISTS (SELECT * 
                 FROM INFORMATION_SCHEMA.TABLES 
                 WHERE TABLE_SCHEMA = 'dbo' 
                 AND  TABLE_NAME = 'UserRole'))
BEGIN
CREATE TABLE [dbo].[UserRole] (
    [Id]     INT PRIMARY KEY,
    [UserId] INT FOREIGN KEY REFERENCES [dbo].[User],
    [RoleId] INT FOREIGN KEY REFERENCES [dbo].[Role]
);
END


COMMIT TRANSACTION

