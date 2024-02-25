	CREATE TABLE [dbo].[RoleDetails] (
	[RoleId]  INT           NOT NULL,
	[RoleName] NVARCHAR (50) NOT NULL,
	PRIMARY KEY CLUSTERED ([RoleId] ASC)
);

INSERT INTO [dbo].[RoleDetails] ([RoleId], [RoleName]) VALUES (1, 'Admin');
INSERT INTO [dbo].[RoleDetails] ([RoleId], [RoleName]) VALUES (2, 'User');
-- drop table UserDetails;

CREATE TABLE [dbo].[UserDetails] (
	[Id]              INT      IDENTITY (1, 1)      NOT NULL,
	[Email]           NVARCHAR (50) NULL,
	[PhoneNo]         NVARCHAR (10) NULL,
	[Username]        NVARCHAR (50) NULL,
	[Password]        NVARCHAR (10) NOT NULL,
	[ConfirmPassword] NVARCHAR (10) NOT NULL,
	[RoleId]          INT           NOT NULL,
	PRIMARY KEY CLUSTERED ([Id] ASC),
	CONSTRAINT [FK_UserDetails_RoleDetails] FOREIGN KEY ([RoleId]) REFERENCES [dbo].[RoleDetails] ([RoleId])
);

-- Create Emp_Adv_Balance table
CREATE TABLE Masters (
    [BioId] INT IDENTITY(1001, 1) Primary key,
    Name VARCHAR(25) NOT NULL,
    Balance DECIMAL(10, 2)    
);

INSERT INTO Masters (Name, Balance) VALUES 
('Jane Smith', 2000.00),
('Alice Johnson', 1800.50),
('Bob Williams', 2200.75);

select * from Masters;

-- Create Emp_Adv_Balance table
CREATE TABLE Transactions (
ID int IDENTITY(1, 1) Primary Key,
    [BioId] INT,
    Name VARCHAR(25) NOT NULL,
    Balance DECIMAL(10, 2),
    Entry_Type VARCHAR(25),
    Need_Amount DECIMAL(10, 2),
    Reason VARCHAR(255),
    [Date] DATETIME,
	 FOREIGN KEY ([BioId]) REFERENCES Masters([BioId])
);

select * from Transactions;

truncate table Transactions;