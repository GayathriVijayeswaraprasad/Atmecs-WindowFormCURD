USE [master]
GO

/****** Object:  Database [EmployeeInfo]    Script Date: 21-08-2019 18:42:13 ******/
DROP DATABASE [EmployeeInfo]
GO

/****** Object:  Database [EmployeeInfo]    Script Date: 21-08-2019 18:42:13 ******/
CREATE DATABASE [EmployeeInfo]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EmployeeInfo', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\EmployeeInfo.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'EmployeeInfo_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\EmployeeInfo_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EmployeeInfo].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [EmployeeInfo] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [EmployeeInfo] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [EmployeeInfo] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [EmployeeInfo] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [EmployeeInfo] SET ARITHABORT OFF 
GO

ALTER DATABASE [EmployeeInfo] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [EmployeeInfo] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [EmployeeInfo] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [EmployeeInfo] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [EmployeeInfo] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [EmployeeInfo] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [EmployeeInfo] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [EmployeeInfo] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [EmployeeInfo] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [EmployeeInfo] SET  DISABLE_BROKER 
GO

ALTER DATABASE [EmployeeInfo] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [EmployeeInfo] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [EmployeeInfo] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [EmployeeInfo] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [EmployeeInfo] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [EmployeeInfo] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [EmployeeInfo] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [EmployeeInfo] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [EmployeeInfo] SET  MULTI_USER 
GO

ALTER DATABASE [EmployeeInfo] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [EmployeeInfo] SET DB_CHAINING OFF 
GO

ALTER DATABASE [EmployeeInfo] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [EmployeeInfo] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [EmployeeInfo] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [EmployeeInfo] SET QUERY_STORE = OFF
GO

ALTER DATABASE [EmployeeInfo] SET  READ_WRITE 
GO


