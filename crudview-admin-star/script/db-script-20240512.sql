USE [master]
GO
/****** Object:  Database [crudview_admin]    Script Date: 12/05/2024 6:33:36 pm ******/
CREATE DATABASE [crudview_admin]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'windntrees_core', FILENAME = N'E:\projects\software\windntrees.sites\database\windntrees_core.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'windntrees_core_log', FILENAME = N'E:\projects\software\windntrees.sites\database\windntrees_core_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [crudview_admin].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [crudview_admin] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [crudview_admin] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [crudview_admin] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [crudview_admin] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [crudview_admin] SET ARITHABORT OFF 
GO
ALTER DATABASE [crudview_admin] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [crudview_admin] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [crudview_admin] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [crudview_admin] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [crudview_admin] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [crudview_admin] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [crudview_admin] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [crudview_admin] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [crudview_admin] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [crudview_admin] SET  DISABLE_BROKER 
GO
ALTER DATABASE [crudview_admin] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [crudview_admin] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [crudview_admin] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [crudview_admin] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [crudview_admin] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [crudview_admin] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [crudview_admin] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [crudview_admin] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [crudview_admin] SET  MULTI_USER 
GO
ALTER DATABASE [crudview_admin] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [crudview_admin] SET DB_CHAINING OFF 
GO
ALTER DATABASE [crudview_admin] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [crudview_admin] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [crudview_admin]    Script Date: 12/05/2024 6:33:37 pm ******/
CREATE LOGIN [crudview_admin] WITH PASSWORD=N'crudview_admin@123', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
ALTER LOGIN [crudview_admin] DISABLE
GO
USE [crudview_admin]
GO
/****** Object:  User [crudview_admin]    Script Date: 12/05/2024 6:33:37 pm ******/
CREATE USER [crudview_admin] FOR LOGIN [crudview_admin] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [crudview_admin]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 12/05/2024 6:33:37 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ActivityHistory]    Script Date: 12/05/2024 6:33:37 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ActivityHistory](
	[UID] [uniqueidentifier] NOT NULL,
	[Activity] [nvarchar](100) NULL,
	[ActivityTime] [datetime2](7) NULL,
	[IPAddress] [nvarchar](max) NULL,
	[Request] [nvarchar](2048) NULL,
	[RowVersion] [timestamp] NULL,
	[UserID] [nvarchar](max) NULL,
 CONSTRAINT [PK_ActivityHistory] PRIMARY KEY CLUSTERED 
(
	[UID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Advertisement]    Script Date: 12/05/2024 6:33:37 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Advertisement](
	[UID] [uniqueidentifier] NOT NULL,
	[Detail] [nvarchar](1024) NOT NULL,
	[Enabled] [bit] NULL,
	[Heading] [nvarchar](100) NOT NULL,
	[Link1] [nvarchar](512) NULL,
	[Link2] [nvarchar](512) NULL,
	[Location] [nvarchar](50) NULL,
	[News] [bit] NULL,
	[Page] [nvarchar](50) NULL,
	[Picture] [nvarchar](50) NULL,
	[RecordTime] [datetime2](7) NOT NULL,
	[ReferenceID] [uniqueidentifier] NULL,
	[RowVersion] [timestamp] NULL,
	[SortOrder] [int] NULL,
	[Source] [nvarchar](100) NULL,
	[SubHeading] [nvarchar](100) NULL,
	[UpdateTime] [datetime2](7) NULL,
	[Video] [nvarchar](50) NULL,
 CONSTRAINT [PK_Advertisement] PRIMARY KEY CLUSTERED 
(
	[UID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AdvertisementLocation]    Script Date: 12/05/2024 6:33:37 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AdvertisementLocation](
	[UID] [uniqueidentifier] NOT NULL,
	[Description] [nvarchar](255) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[RowVersion] [timestamp] NULL,
 CONSTRAINT [PK_AdvertisementLocation] PRIMARY KEY CLUSTERED 
(
	[UID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AdvertisementPage]    Script Date: 12/05/2024 6:33:37 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AdvertisementPage](
	[UID] [uniqueidentifier] NOT NULL,
	[Description] [nvarchar](255) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[RowVersion] [timestamp] NULL,
 CONSTRAINT [PK_AdvertisementPage] PRIMARY KEY CLUSTERED 
(
	[UID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 12/05/2024 6:33:37 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 12/05/2024 6:33:37 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 12/05/2024 6:33:37 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 12/05/2024 6:33:37 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 12/05/2024 6:33:37 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 12/05/2024 6:33:37 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
	[ApprovedBy] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[CreationDate] [datetime2](7) NOT NULL,
	[Email] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[ExpiryDate] [datetime2](7) NULL,
	[FirstName] [nvarchar](100) NOT NULL,
	[ImageFile] [nvarchar](50) NULL,
	[IsApproved] [bit] NOT NULL,
	[LastName] [nvarchar](100) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Package] [nvarchar](20) NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[Sex] [nvarchar](10) NULL,
	[Title] [nvarchar](20) NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[UserName] [nvarchar](256) NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 12/05/2024 6:33:37 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 12/05/2024 6:33:37 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[UID] [uniqueidentifier] NOT NULL,
	[Description] [nvarchar](255) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[RowVersion] [timestamp] NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[UID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChartOfAccount]    Script Date: 12/05/2024 6:33:37 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChartOfAccount](
	[UID] [uniqueidentifier] NOT NULL,
	[AccountID] [nvarchar](20) NOT NULL,
	[Description] [nvarchar](255) NULL,
	[RowVersion] [timestamp] NULL,
	[Title] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_ChartOfAccount] PRIMARY KEY CLUSTERED 
(
	[UID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Color]    Script Date: 12/05/2024 6:33:37 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Color](
	[UID] [uniqueidentifier] NOT NULL,
	[Description] [nvarchar](255) NULL,
	[Name] [nvarchar](10) NOT NULL,
	[RowVersion] [timestamp] NULL,
 CONSTRAINT [PK_Color] PRIMARY KEY CLUSTERED 
(
	[UID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Company]    Script Date: 12/05/2024 6:33:37 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Company](
	[UID] [uniqueidentifier] NOT NULL,
	[Address] [nvarchar](255) NULL,
	[Cell1] [nvarchar](20) NULL,
	[Cell2] [nvarchar](20) NULL,
	[City] [nvarchar](100) NULL,
	[CompanyType] [nvarchar](100) NOT NULL,
	[ContactPerson] [nvarchar](100) NULL,
	[ContactPersonCell] [nvarchar](20) NULL,
	[ContactPersonDesignation] [nvarchar](100) NULL,
	[ContactPersonEmail] [nvarchar](128) NULL,
	[ContactPersonPhone] [nvarchar](20) NULL,
	[Country] [nvarchar](100) NULL,
	[Currency] [nvarchar](10) NULL,
	[Description] [nvarchar](1024) NULL,
	[Director] [nvarchar](100) NULL,
	[Email] [nvarchar](128) NULL,
	[Enabled] [bit] NOT NULL,
	[LegalCode] [nvarchar](100) NOT NULL,
	[LegalName] [nvarchar](255) NOT NULL,
	[NTN] [nvarchar](100) NULL,
	[PaidUpCapital] [bigint] NULL,
	[Phone1] [nvarchar](20) NULL,
	[Phone2] [nvarchar](20) NULL,
	[RowVersion] [varbinary](max) NULL,
	[STRN] [nvarchar](100) NULL,
	[Secretary] [nvarchar](100) NULL,
	[State] [nvarchar](100) NULL,
 CONSTRAINT [PK_Company] PRIMARY KEY CLUSTERED 
(
	[UID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CompanyType]    Script Date: 12/05/2024 6:33:37 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CompanyType](
	[UID] [uniqueidentifier] NOT NULL,
	[Description] [nvarchar](255) NULL,
	[Name] [nvarchar](100) NOT NULL,
	[RowVersion] [varbinary](max) NULL,
 CONSTRAINT [PK_CompanyType] PRIMARY KEY CLUSTERED 
(
	[UID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Configuration]    Script Date: 12/05/2024 6:33:37 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Configuration](
	[UID] [uniqueidentifier] NOT NULL,
	[KeyParam] [nvarchar](50) NOT NULL,
	[RowVersion] [timestamp] NULL,
	[ValParam] [nvarchar](1500) NOT NULL,
 CONSTRAINT [PK_Configuration] PRIMARY KEY CLUSTERED 
(
	[UID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LicenseInfo]    Script Date: 12/05/2024 6:33:37 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LicenseInfo](
	[ProductID] [uniqueidentifier] NOT NULL,
	[Code] [nvarchar](max) NOT NULL,
	[RowVersion] [timestamp] NULL,
 CONSTRAINT [PK_LicenseInfo] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Manufacturer]    Script Date: 12/05/2024 6:33:37 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Manufacturer](
	[UID] [uniqueidentifier] NOT NULL,
	[Description] [nvarchar](255) NULL,
	[Name] [nvarchar](50) NOT NULL,
	[RowVersion] [timestamp] NULL,
 CONSTRAINT [PK_Manufacturer] PRIMARY KEY CLUSTERED 
(
	[UID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 12/05/2024 6:33:37 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[UID] [uniqueidentifier] NOT NULL,
	[Category] [nvarchar](max) NULL,
	[Code] [nvarchar](100) NULL,
	[Color] [nvarchar](max) NULL,
	[Description] [nvarchar](1024) NULL,
	[LegalCode] [nvarchar](100) NULL,
	[Manufacturer] [nvarchar](max) NULL,
	[Name] [nvarchar](100) NULL,
	[Picture] [nvarchar](50) NULL,
	[ProductYear] [int] NULL,
	[RowVersion] [timestamp] NULL,
	[Service] [bit] NULL,
	[Unit] [nvarchar](max) NULL,
	[Version] [nvarchar](100) NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[UID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductFeature]    Script Date: 12/05/2024 6:33:37 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductFeature](
	[UID] [uniqueidentifier] NOT NULL,
	[Description] [nvarchar](255) NULL,
	[Name] [nvarchar](100) NOT NULL,
	[ProductID] [uniqueidentifier] NOT NULL,
	[RowVersion] [varbinary](max) NULL,
 CONSTRAINT [PK_ProductFeature] PRIMARY KEY CLUSTERED 
(
	[UID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reference]    Script Date: 12/05/2024 6:33:37 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reference](
	[UID] [uniqueidentifier] NOT NULL,
	[AudioVideo] [bit] NULL,
	[ContentBytes] [varbinary](max) NULL,
	[ContentFile] [nvarchar](100) NULL,
	[Description] [nvarchar](1024) NULL,
	[Download] [bit] NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Picture] [bit] NULL,
	[Readable] [bit] NULL,
	[ReferenceID] [uniqueidentifier] NULL,
	[RowVersion] [varbinary](max) NULL,
	[Size] [bigint] NOT NULL,
 CONSTRAINT [PK_Reference] PRIMARY KEY CLUSTERED 
(
	[UID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Transaction]    Script Date: 12/05/2024 6:33:37 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transaction](
	[UID] [uniqueidentifier] NOT NULL,
	[AccountID] [nvarchar](20) NOT NULL,
	[Active] [bit] NOT NULL,
	[CompositeUID] [uniqueidentifier] NOT NULL,
	[CrAmount] [decimal](18, 2) NOT NULL,
	[DrAmount] [decimal](18, 2) NOT NULL,
	[Particulars] [nvarchar](1500) NOT NULL,
	[Quantity] [int] NOT NULL,
	[RowVersion] [timestamp] NULL,
	[Title] [nvarchar](50) NOT NULL,
	[TransactionTime] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Transaction] PRIMARY KEY CLUSTERED 
(
	[UID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Unit]    Script Date: 12/05/2024 6:33:37 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Unit](
	[UID] [uniqueidentifier] NOT NULL,
	[Description] [nvarchar](255) NULL,
	[Name] [nvarchar](50) NOT NULL,
	[RowVersion] [timestamp] NULL,
 CONSTRAINT [PK_Unit] PRIMARY KEY CLUSTERED 
(
	[UID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20180730130324_FirstMigration', N'2.0.1-rtm-125')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20180730130657_ApplicationModels', N'2.0.1-rtm-125')
GO
INSERT [dbo].[AspNetRoles] ([Id], [ConcurrencyStamp], [Name], [NormalizedName]) VALUES (N'mngr_advertisements', N'0a936436-179b-42d8-b199-ee399a6741e1', N'mngr_advertisements', N'MNGR_ADVERTISEMENTS')
INSERT [dbo].[AspNetRoles] ([Id], [ConcurrencyStamp], [Name], [NormalizedName]) VALUES (N'mngr_configurations', N'eddd064c-b3b3-4081-93dc-3f357406ef1b', N'mngr_configurations', N'MNGR_CONFIGURATIONS')
INSERT [dbo].[AspNetRoles] ([Id], [ConcurrencyStamp], [Name], [NormalizedName]) VALUES (N'mngr_myaccount', N'1d0237e8-1482-4cca-98cb-98080b3eeb86', N'mngr_myaccount', N'MNGR_MYACCOUNT')
INSERT [dbo].[AspNetRoles] ([Id], [ConcurrencyStamp], [Name], [NormalizedName]) VALUES (N'mngr_users', N'046736e0-9ea8-408d-b0cc-9996f8ff2715', N'mngr_users', N'MNGR_USERS')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a0b83897-4681-45c3-98bd-445048c3ae6f', N'mngr_advertisements')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a0b83897-4681-45c3-98bd-445048c3ae6f', N'mngr_configurations')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a0b83897-4681-45c3-98bd-445048c3ae6f', N'mngr_myaccount')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a0b83897-4681-45c3-98bd-445048c3ae6f', N'mngr_users')
GO
INSERT [dbo].[AspNetUsers] ([Id], [AccessFailedCount], [ApprovedBy], [ConcurrencyStamp], [CreationDate], [Email], [EmailConfirmed], [ExpiryDate], [FirstName], [ImageFile], [IsApproved], [LastName], [LockoutEnabled], [LockoutEnd], [NormalizedEmail], [NormalizedUserName], [Package], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [SecurityStamp], [Sex], [Title], [TwoFactorEnabled], [UserName]) VALUES (N'a0b83897-4681-45c3-98bd-445048c3ae6f', 0, N'setup-registration', N'51ef5896-0ab0-46f7-9735-0831d51baf28', CAST(N'2023-08-23T17:19:57.9191990' AS DateTime2), N'support@invincibletec.com', 1, NULL, N'CRUDView', N'crudview_admin.png', 1, N'Admin', 1, NULL, N'SUPPORT@INVINCIBLETEC.COM', N'SUPPORT@INVINCIBLETEC.COM', NULL, N'AQAAAAIAAYagAAAAENu6vYm2hRbhKRZxR3Mxxo3JdnuRpFovNZnaKIPbFNW7m8yqFLbu7g5FsJa4in6shQ==', NULL, 0, N'7FPCHDBOCO6GXUUHXSIRHA57OOFZNFC5', N'm', N'Mr.', 0, N'support@invincibletec.com')
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetRoleClaims_RoleId]    Script Date: 12/05/2024 6:33:38 pm ******/
CREATE NONCLUSTERED INDEX [IX_AspNetRoleClaims_RoleId] ON [dbo].[AspNetRoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 12/05/2024 6:33:38 pm ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserClaims_UserId]    Script Date: 12/05/2024 6:33:38 pm ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserClaims_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserLogins_UserId]    Script Date: 12/05/2024 6:33:38 pm ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserLogins_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserRoles_RoleId]    Script Date: 12/05/2024 6:33:38 pm ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [EmailIndex]    Script Date: 12/05/2024 6:33:38 pm ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 12/05/2024 6:33:38 pm ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ProductFeature_ProductID]    Script Date: 12/05/2024 6:33:38 pm ******/
CREATE NONCLUSTERED INDEX [IX_ProductFeature_ProductID] ON [dbo].[ProductFeature]
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[LicenseInfo]  WITH CHECK ADD  CONSTRAINT [FK_LicenseInfo_Product_ProductID] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([UID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[LicenseInfo] CHECK CONSTRAINT [FK_LicenseInfo_Product_ProductID]
GO
ALTER TABLE [dbo].[ProductFeature]  WITH CHECK ADD  CONSTRAINT [FK_ProductFeature_Product_ProductID] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([UID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ProductFeature] CHECK CONSTRAINT [FK_ProductFeature_Product_ProductID]
GO
USE [master]
GO
ALTER DATABASE [crudview_admin] SET  READ_WRITE 
GO
