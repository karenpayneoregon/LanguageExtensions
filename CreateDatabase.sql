USE [master]
GO

/****** Object:  Database [NorthWindAzure]    Script Date: 12/16/2018 4:24:04 PM ******/
CREATE DATABASE [NorthWindAzure]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'NorthWindAzure', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\NorthWindAzure.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'NorthWindAzure_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\NorthWindAzure_log.ldf' , SIZE = 32448KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [NorthWindAzure] SET COMPATIBILITY_LEVEL = 110
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [NorthWindAzure].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [NorthWindAzure] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [NorthWindAzure] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [NorthWindAzure] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [NorthWindAzure] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [NorthWindAzure] SET ARITHABORT OFF 
GO

ALTER DATABASE [NorthWindAzure] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [NorthWindAzure] SET AUTO_CREATE_STATISTICS ON 
GO

ALTER DATABASE [NorthWindAzure] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [NorthWindAzure] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [NorthWindAzure] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [NorthWindAzure] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [NorthWindAzure] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [NorthWindAzure] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [NorthWindAzure] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [NorthWindAzure] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [NorthWindAzure] SET  DISABLE_BROKER 
GO

ALTER DATABASE [NorthWindAzure] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [NorthWindAzure] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [NorthWindAzure] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [NorthWindAzure] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [NorthWindAzure] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [NorthWindAzure] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [NorthWindAzure] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [NorthWindAzure] SET RECOVERY FULL 
GO

ALTER DATABASE [NorthWindAzure] SET  MULTI_USER 
GO

ALTER DATABASE [NorthWindAzure] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [NorthWindAzure] SET DB_CHAINING OFF 
GO

ALTER DATABASE [NorthWindAzure] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [NorthWindAzure] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO

ALTER DATABASE [NorthWindAzure] SET  READ_WRITE 
GO

