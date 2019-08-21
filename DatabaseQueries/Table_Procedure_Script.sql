USE [EmployeeInfo]
GO
/****** Object:  StoredProcedure [dbo].[UpdateWork]    Script Date: 21-08-2019 18:43:17 ******/
DROP PROCEDURE IF EXISTS [dbo].[UpdateWork]
GO
/****** Object:  StoredProcedure [dbo].[UpdateEmp]    Script Date: 21-08-2019 18:43:17 ******/
DROP PROCEDURE IF EXISTS [dbo].[UpdateEmp]
GO
/****** Object:  StoredProcedure [dbo].[UpdateBank]    Script Date: 21-08-2019 18:43:17 ******/
DROP PROCEDURE IF EXISTS [dbo].[UpdateBank]
GO
/****** Object:  StoredProcedure [dbo].[InsertWork]    Script Date: 21-08-2019 18:43:17 ******/
DROP PROCEDURE IF EXISTS [dbo].[InsertWork]
GO
/****** Object:  StoredProcedure [dbo].[InsertEmp]    Script Date: 21-08-2019 18:43:17 ******/
DROP PROCEDURE IF EXISTS [dbo].[InsertEmp]
GO
/****** Object:  StoredProcedure [dbo].[InsertBank]    Script Date: 21-08-2019 18:43:17 ******/
DROP PROCEDURE IF EXISTS [dbo].[InsertBank]
GO
/****** Object:  StoredProcedure [dbo].[GetEmployeeDetails]    Script Date: 21-08-2019 18:43:17 ******/
DROP PROCEDURE IF EXISTS [dbo].[GetEmployeeDetails]
GO
/****** Object:  StoredProcedure [dbo].[GetDetails]    Script Date: 21-08-2019 18:43:17 ******/
DROP PROCEDURE IF EXISTS [dbo].[GetDetails]
GO
/****** Object:  StoredProcedure [dbo].[DeleteWork]    Script Date: 21-08-2019 18:43:17 ******/
DROP PROCEDURE IF EXISTS [dbo].[DeleteWork]
GO
/****** Object:  StoredProcedure [dbo].[DeleteEmp]    Script Date: 21-08-2019 18:43:17 ******/
DROP PROCEDURE IF EXISTS [dbo].[DeleteEmp]
GO
/****** Object:  StoredProcedure [dbo].[DeleteBank]    Script Date: 21-08-2019 18:43:17 ******/
DROP PROCEDURE IF EXISTS [dbo].[DeleteBank]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EmpWork]') AND type in (N'U'))
ALTER TABLE [dbo].[EmpWork] DROP CONSTRAINT IF EXISTS [FK_EmpWork_Emp_Personal]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EmpWork]') AND type in (N'U'))
ALTER TABLE [dbo].[EmpWork] DROP CONSTRAINT IF EXISTS [FK_EmpWork_DepartmentDetails]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BankDetails]') AND type in (N'U'))
ALTER TABLE [dbo].[BankDetails] DROP CONSTRAINT IF EXISTS [FK_BankDetails_Emp_Personal]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BankDetails]') AND type in (N'U'))
ALTER TABLE [dbo].[BankDetails] DROP CONSTRAINT IF EXISTS [FK_BankDetails_DepartmentDetails]
GO
/****** Object:  Table [dbo].[EmpWork]    Script Date: 21-08-2019 18:43:17 ******/
DROP TABLE IF EXISTS [dbo].[EmpWork]
GO
/****** Object:  Table [dbo].[Emp_Personal]    Script Date: 21-08-2019 18:43:17 ******/
DROP TABLE IF EXISTS [dbo].[Emp_Personal]
GO
/****** Object:  Table [dbo].[Emp_Login]    Script Date: 21-08-2019 18:43:17 ******/
DROP TABLE IF EXISTS [dbo].[Emp_Login]
GO
/****** Object:  Table [dbo].[DepartmentDetails]    Script Date: 21-08-2019 18:43:17 ******/
DROP TABLE IF EXISTS [dbo].[DepartmentDetails]
GO
/****** Object:  Table [dbo].[BankDetails]    Script Date: 21-08-2019 18:43:17 ******/
DROP TABLE IF EXISTS [dbo].[BankDetails]
GO
/****** Object:  Table [dbo].[BankDetails]    Script Date: 21-08-2019 18:43:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BankDetails](
	[Emp_Id] [int] NOT NULL,
	[DeptID] [int] NOT NULL,
	[Bank] [nchar](20) NULL,
	[Bank_AcNo] [varchar](50) NULL,
	[Netpay] [varchar](30) NULL,
	[PF_No] [varchar](30) NULL,
	[PF_Amount] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DepartmentDetails]    Script Date: 21-08-2019 18:43:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DepartmentDetails](
	[DeptId] [int] IDENTITY(1,1) NOT NULL,
	[DeptName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_DepartmentDetails] PRIMARY KEY CLUSTERED 
(
	[DeptId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Emp_Login]    Script Date: 21-08-2019 18:43:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Emp_Login](
	[username] [nvarchar](50) NULL,
	[password] [varchar](30) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Emp_Personal]    Script Date: 21-08-2019 18:43:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Emp_Personal](
	[Emp_Id] [int] IDENTITY(1,1) NOT NULL,
	[Emp_Name] [nchar](30) NULL,
	[Dob] [date] NULL,
	[Email_id] [varchar](50) NULL,
	[Ph_No] [varchar](20) NULL,
	[Address] [varchar](50) NULL,
	[Gender] [nchar](10) NULL,
 CONSTRAINT [PK_Emp_Personal] PRIMARY KEY CLUSTERED 
(
	[Emp_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmpWork]    Script Date: 21-08-2019 18:43:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmpWork](
	[Emp_Id] [int] NOT NULL,
	[DeptId] [int] NOT NULL,
	[Designation] [varchar](30) NULL,
	[Manager] [nchar](30) NULL,
	[Attendance] [varchar](20) NULL,
	[Salary] [int] NULL,
	[Experience] [varchar](20) NULL,
	[DeptName] [nvarchar](50) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[BankDetails] ([Emp_Id], [DeptID], [Bank], [Bank_AcNo], [Netpay], [PF_No], [PF_Amount]) VALUES (6, 1, N'sbi                 ', N'1212', N'1222', N'1222', 2122)
GO
INSERT [dbo].[BankDetails] ([Emp_Id], [DeptID], [Bank], [Bank_AcNo], [Netpay], [PF_No], [PF_Amount]) VALUES (8, 3, N'HDFC                ', N'1414', N'2000', N'2244', 2120)
GO
INSERT [dbo].[BankDetails] ([Emp_Id], [DeptID], [Bank], [Bank_AcNo], [Netpay], [PF_No], [PF_Amount]) VALUES (9, 6, N'SBI                 ', N'87421365498', N'2000', N'8164', 6000)
GO
INSERT [dbo].[BankDetails] ([Emp_Id], [DeptID], [Bank], [Bank_AcNo], [Netpay], [PF_No], [PF_Amount]) VALUES (7, 7, N'IDBI                ', N'365448522682', N'1000', N'6541', 5000)
GO
SET IDENTITY_INSERT [dbo].[DepartmentDetails] ON 
GO
INSERT [dbo].[DepartmentDetails] ([DeptId], [DeptName]) VALUES (1, N'Accounts')
GO
INSERT [dbo].[DepartmentDetails] ([DeptId], [DeptName]) VALUES (2, N'HR')
GO
INSERT [dbo].[DepartmentDetails] ([DeptId], [DeptName]) VALUES (3, N'IT')
GO
INSERT [dbo].[DepartmentDetails] ([DeptId], [DeptName]) VALUES (4, N'Admin')
GO
INSERT [dbo].[DepartmentDetails] ([DeptId], [DeptName]) VALUES (5, N'Production')
GO
INSERT [dbo].[DepartmentDetails] ([DeptId], [DeptName]) VALUES (6, N'R&D')
GO
INSERT [dbo].[DepartmentDetails] ([DeptId], [DeptName]) VALUES (7, N'Networking')
GO
INSERT [dbo].[DepartmentDetails] ([DeptId], [DeptName]) VALUES (8, N'Marketing')
GO
SET IDENTITY_INSERT [dbo].[DepartmentDetails] OFF
GO
INSERT [dbo].[Emp_Login] ([username], [password]) VALUES (N'Admin', N'Admin$123')
GO
SET IDENTITY_INSERT [dbo].[Emp_Personal] ON 
GO
INSERT [dbo].[Emp_Personal] ([Emp_Id], [Emp_Name], [Dob], [Email_id], [Ph_No], [Address], [Gender]) VALUES (6, N'Gayathri                      ', CAST(N'1998-11-08' AS Date), N'gayathripsd@gmail.com', N'7708553503', N'Pollachi,Coimbatore', N'Female    ')
GO
INSERT [dbo].[Emp_Personal] ([Emp_Id], [Emp_Name], [Dob], [Email_id], [Ph_No], [Address], [Gender]) VALUES (7, N'Raagav                        ', CAST(N'1994-10-08' AS Date), N'raagavv@gmail.com', N'9994431386', N'Palakad,Kerala', N'Male      ')
GO
INSERT [dbo].[Emp_Personal] ([Emp_Id], [Emp_Name], [Dob], [Email_id], [Ph_No], [Address], [Gender]) VALUES (8, N'Madhumathi                    ', CAST(N'1998-10-30' AS Date), N'madhumathi@gmail.com', N'7542178945', N'Aavadi,Chennai', N'Female    ')
GO
INSERT [dbo].[Emp_Personal] ([Emp_Id], [Emp_Name], [Dob], [Email_id], [Ph_No], [Address], [Gender]) VALUES (9, N'Kowsalya                      ', CAST(N'1998-08-10' AS Date), N'kowsalyap@gmail.com', N'8941247854', N'Palladam,Tirupur', N'Female    ')
GO
INSERT [dbo].[Emp_Personal] ([Emp_Id], [Emp_Name], [Dob], [Email_id], [Ph_No], [Address], [Gender]) VALUES (10, N'Akshai                        ', CAST(N'1995-06-27' AS Date), N'akshaigiri@gmail.com', N'7265489412', N'HSR layout,Bangalore', N'Male      ')
GO
INSERT [dbo].[Emp_Personal] ([Emp_Id], [Emp_Name], [Dob], [Email_id], [Ph_No], [Address], [Gender]) VALUES (11, N'Ram                           ', CAST(N'1997-05-07' AS Date), N'ramvenkat@gmail.com', N'8220308517', N'Mahepe,Mumbai', N'Male      ')
GO
INSERT [dbo].[Emp_Personal] ([Emp_Id], [Emp_Name], [Dob], [Email_id], [Ph_No], [Address], [Gender]) VALUES (12, N'Janani                        ', CAST(N'1997-07-29' AS Date), N'jananisree@gmail.com', N'9842365784', N'Yelahanka,Bangalore', N'Female    ')
GO
INSERT [dbo].[Emp_Personal] ([Emp_Id], [Emp_Name], [Dob], [Email_id], [Ph_No], [Address], [Gender]) VALUES (13, N'Saravanan                     ', CAST(N'1998-09-08' AS Date), N'saravananss@gmail.com', N'8623147894', N'Coimbatore', N'Male      ')
GO
INSERT [dbo].[Emp_Personal] ([Emp_Id], [Emp_Name], [Dob], [Email_id], [Ph_No], [Address], [Gender]) VALUES (14, N'Harini                        ', CAST(N'1998-05-19' AS Date), N'harinihappy@gmail.com', N'8436512365', N'Sundarapuram,Coimbatore', N'Female    ')
GO
INSERT [dbo].[Emp_Personal] ([Emp_Id], [Emp_Name], [Dob], [Email_id], [Ph_No], [Address], [Gender]) VALUES (16, N'Nithya                        ', CAST(N'1998-09-26' AS Date), N'nithya@gmail.com', N'8794563117', N'Gandhipuram,Coimbatore', N'Female    ')
GO
SET IDENTITY_INSERT [dbo].[Emp_Personal] OFF
GO
INSERT [dbo].[EmpWork] ([Emp_Id], [DeptId], [Designation], [Manager], [Attendance], [Salary], [Experience], [DeptName]) VALUES (9, 6, N'Trainee Software Engineering', N'Harish                        ', N'78%', 20000, N'2', N'R&D')
GO
INSERT [dbo].[EmpWork] ([Emp_Id], [DeptId], [Designation], [Manager], [Attendance], [Salary], [Experience], [DeptName]) VALUES (10, 2, N'Senior HR', N'Sumithra                      ', N'90%', 30000, N'2', N'HR')
GO
INSERT [dbo].[EmpWork] ([Emp_Id], [DeptId], [Designation], [Manager], [Attendance], [Salary], [Experience], [DeptName]) VALUES (6, 2, N'Accountant', N'Nikitha                       ', N'80%', 20000, N'1', N'HR')
GO
INSERT [dbo].[EmpWork] ([Emp_Id], [DeptId], [Designation], [Manager], [Attendance], [Salary], [Experience], [DeptName]) VALUES (8, 3, N'Software Engineer', N'Gokul                         ', N'80', 18000, N'1', N'')
GO
ALTER TABLE [dbo].[BankDetails]  WITH CHECK ADD  CONSTRAINT [FK_BankDetails_DepartmentDetails] FOREIGN KEY([DeptID])
REFERENCES [dbo].[DepartmentDetails] ([DeptId])
GO
ALTER TABLE [dbo].[BankDetails] CHECK CONSTRAINT [FK_BankDetails_DepartmentDetails]
GO
ALTER TABLE [dbo].[BankDetails]  WITH CHECK ADD  CONSTRAINT [FK_BankDetails_Emp_Personal] FOREIGN KEY([Emp_Id])
REFERENCES [dbo].[Emp_Personal] ([Emp_Id])
GO
ALTER TABLE [dbo].[BankDetails] CHECK CONSTRAINT [FK_BankDetails_Emp_Personal]
GO
ALTER TABLE [dbo].[EmpWork]  WITH CHECK ADD  CONSTRAINT [FK_EmpWork_DepartmentDetails] FOREIGN KEY([DeptId])
REFERENCES [dbo].[DepartmentDetails] ([DeptId])
GO
ALTER TABLE [dbo].[EmpWork] CHECK CONSTRAINT [FK_EmpWork_DepartmentDetails]
GO
ALTER TABLE [dbo].[EmpWork]  WITH CHECK ADD  CONSTRAINT [FK_EmpWork_Emp_Personal] FOREIGN KEY([Emp_Id])
REFERENCES [dbo].[Emp_Personal] ([Emp_Id])
GO
ALTER TABLE [dbo].[EmpWork] CHECK CONSTRAINT [FK_EmpWork_Emp_Personal]
GO
/****** Object:  StoredProcedure [dbo].[DeleteBank]    Script Date: 21-08-2019 18:43:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteBank]
@Emp_Id int
AS
BEGIN
DELETE FROM BankDetails WHERE Emp_Id=@Emp_Id
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteEmp]    Script Date: 21-08-2019 18:43:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteEmp]
@Emp_Id int
AS
BEGIN
DELETE FROM Emp_Personal WHERE Emp_Id=@Emp_Id
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteWork]    Script Date: 21-08-2019 18:43:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteWork]
@Emp_Id int

AS
BEGIN 
DELETE FROM EmpWork WHERE Emp_Id=@Emp_Id
END

GO
/****** Object:  StoredProcedure [dbo].[GetDetails]    Script Date: 21-08-2019 18:43:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetDetails] 
	
AS
BEGIN
	select EW.Designation, EW.Manager, EW.Attendance, EW.Salary, EW.Experience, EP.Emp_Name, EP.Dob, EP.Email_id, EP.Ph_No,
	EP.Address,EP.Gender, BD.Bank,BD.Bank_AcNo, BD.Netpay, BD.PF_Amount, BD.PF_No from EmpWork as EW 
	JOIN Emp_Personal as EP on EW.Emp_Id=EP.Emp_Id
	JOIN BankDetails as BD on EW.Emp_Id=BD.Emp_Id
END
GO
/****** Object:  StoredProcedure [dbo].[GetEmployeeDetails]    Script Date: 21-08-2019 18:43:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetEmployeeDetails] 
	
AS
BEGIN
	select EP.Emp_Name, EP.Dob, EP.Email_id, EP.Ph_No,
    EP.Address,EP.Gender, EW.Designation, EW.Manager, EW.Attendance, EW.Salary, EW.Experience, BD.Bank,BD.Bank_AcNo, BD.Netpay, BD.PF_Amount, BD.PF_No from Emp_Personal as EP
    JOIN EmpWork as EW on EP.Emp_Id=EW.Emp_Id
    JOIN BankDetails as BD on EW.Emp_Id=BD.Emp_Id
END
GO
/****** Object:  StoredProcedure [dbo].[InsertBank]    Script Date: 21-08-2019 18:43:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertBank]
@Emp_Id int,
@DeptId int,
@Bank nchar(20),
@Bank_AcNo varchar(50),
@Netpay varchar(30),
@PF_No varchar(30),
@PF_Amount int
 
 AS
 BEGIN
 INSERT INTO BankDetails(Emp_Id,DeptID,Bank,Bank_AcNo,Netpay,PF_No,PF_Amount)VALUES(@Emp_Id,@DeptId,@Bank,@Bank_AcNo,@Netpay,@PF_No,@PF_Amount)
 END
GO
/****** Object:  StoredProcedure [dbo].[InsertEmp]    Script Date: 21-08-2019 18:43:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertEmp]
@Emp_Name nchar(30) null,
@Dob date null,
@Email_id varchar(50) null,
@Ph_No varchar(20) null,
@Address varchar(50) null,
@Gender nchar(10) null

AS
BEGIN
INSERT INTO Emp_Personal(Emp_Name,Dob,Email_id,Ph_No,Address,Gender) VALUES(@Emp_Name,@Dob,@Email_id,@Ph_No,@Address,@Gender)
END 
GO
/****** Object:  StoredProcedure [dbo].[InsertWork]    Script Date: 21-08-2019 18:43:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertWork]
@Emp_Id int,
@DeptId int,
@Designation varchar(30),
@Manager nchar(30),
@Attendance varchar(20),
@salary int,
@Experience varchar(20),
@Deptname nvarchar(50)
AS
BEGIN
INSERT INTO EmpWork(Emp_Id,DeptId,Designation,Manager,Attendance,Salary,Experience,DeptName)VALUES(@Emp_Id,@DeptId,@Designation,@Manager,@Attendance,@salary,@Experience,@Deptname)
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateBank]    Script Date: 21-08-2019 18:43:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateBank]
@Emp_Id int,
@DeptId int,
@Bank nchar(20),
@Bank_AcNo varchar(50),
@Netpay varchar(30),
@PF_No varchar(30),
@PF_Amount int

AS
BEGIN
UPDATE BankDetails SET DeptID=@DeptId,Bank=@Bank,Bank_AcNo=@Bank_AcNo,Netpay=@Netpay,PF_No=@PF_No,PF_Amount=@PF_Amount WHERE Emp_Id=@Emp_Id
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateEmp]    Script Date: 21-08-2019 18:43:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateEmp]
@Emp_Id int,
@Emp_Name nchar(30) null,
@Dob date null,
@Email_id varchar(50) null,
@Ph_No varchar(20) null,
@Address varchar(50) null,
@Gender nchar(10) null
 
 AS
 BEGIN
 UPDATE Emp_Personal SET Emp_Name=@Emp_Name,Dob=@Dob,Email_id=@Email_id,Ph_No=@Ph_No,Address=@Address,Gender=@Gender WHERE Emp_Id=@Emp_Id
 END
GO
/****** Object:  StoredProcedure [dbo].[UpdateWork]    Script Date: 21-08-2019 18:43:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateWork]
@Emp_Id int,
@DeptId int,
@Designation varchar(30),
@Manager nchar(30),
@Attendance varchar(20),
@Salary int,
@Experience varchar(20),
@DeptName nvarchar(50)

AS
BEGIN
UPDATE EmpWork SET DeptId=@DeptId,Designation=@Designation,Manager=@Manager,Attendance=@Attendance,Salary=@Salary,Experience=@Experience,DeptName=@DeptName WHERE Emp_Id=@Emp_Id
END
GO
