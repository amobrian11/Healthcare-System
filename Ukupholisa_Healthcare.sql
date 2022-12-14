USE [master]
GO
/****** Object:  Database [Ukupholisa Healthcare]    Script Date: 2022/11/08 23:36:18 ******/
CREATE DATABASE [Ukupholisa Healthcare]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Ukupholisa Healthcare', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Ukupholisa Healthcare.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Ukupholisa Healthcare_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Ukupholisa Healthcare_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Ukupholisa Healthcare] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Ukupholisa Healthcare].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Ukupholisa Healthcare] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Ukupholisa Healthcare] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Ukupholisa Healthcare] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Ukupholisa Healthcare] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Ukupholisa Healthcare] SET ARITHABORT OFF 
GO
ALTER DATABASE [Ukupholisa Healthcare] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Ukupholisa Healthcare] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Ukupholisa Healthcare] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Ukupholisa Healthcare] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Ukupholisa Healthcare] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Ukupholisa Healthcare] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Ukupholisa Healthcare] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Ukupholisa Healthcare] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Ukupholisa Healthcare] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Ukupholisa Healthcare] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Ukupholisa Healthcare] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Ukupholisa Healthcare] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Ukupholisa Healthcare] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Ukupholisa Healthcare] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Ukupholisa Healthcare] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Ukupholisa Healthcare] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Ukupholisa Healthcare] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Ukupholisa Healthcare] SET RECOVERY FULL 
GO
ALTER DATABASE [Ukupholisa Healthcare] SET  MULTI_USER 
GO
ALTER DATABASE [Ukupholisa Healthcare] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Ukupholisa Healthcare] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Ukupholisa Healthcare] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Ukupholisa Healthcare] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Ukupholisa Healthcare] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Ukupholisa Healthcare] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Ukupholisa Healthcare', N'ON'
GO
ALTER DATABASE [Ukupholisa Healthcare] SET QUERY_STORE = OFF
GO
USE [Ukupholisa Healthcare]
GO
/****** Object:  Table [dbo].[Call]    Script Date: 2022/11/08 23:36:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Call](
	[Call_ID] [int] NOT NULL,
	[Caller_number] [varchar](10) NULL,
	[Time_Started] [time](7) NULL,
	[Time_ended] [time](7) NULL,
	[Date] [date] NULL,
	[Client_ID] [int] NULL,
	[Claim_ID] [int] NULL,
 CONSTRAINT [PK_Call] PRIMARY KEY CLUSTERED 
(
	[Call_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Claim]    Script Date: 2022/11/08 23:36:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Claim](
	[Claim_ID] [int] NOT NULL,
	[Conditon] [nchar](10) NULL,
	[Treatment] [nchar](10) NULL,
	[Provider] [nchar](10) NULL,
	[Client_ID] [int] NULL,
	[Date] [varchar](50) NULL,
 CONSTRAINT [PK_Claim] PRIMARY KEY CLUSTERED 
(
	[Claim_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 2022/11/08 23:36:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[Client_ID] [int] NOT NULL,
	[National_ID] [varchar](50) NULL,
	[Member_Status] [varchar](50) NULL,
	[First_name] [varchar](50) NULL,
	[Last_name] [varchar](50) NULL,
	[DOB] [varchar](50) NULL,
	[Street_Number_Name] [varchar](50) NULL,
	[City] [varchar](50) NULL,
	[Postal_Code] [varchar](50) NULL,
	[Cell_number] [varchar](10) NULL,
	[Email] [varchar](50) NULL,
	[Policy_ID] [int] NULL,
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[Client_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Client_Condition]    Script Date: 2022/11/08 23:36:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client_Condition](
	[Client_ID] [int] NULL,
	[Condition_ID] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Client_Treatment]    Script Date: 2022/11/08 23:36:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client_Treatment](
	[Client_ID] [int] NULL,
	[Treatment_ID] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Condition]    Script Date: 2022/11/08 23:36:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Condition](
	[Condition_ID] [int] NOT NULL,
	[Condition_name] [varchar](50) NULL,
 CONSTRAINT [PK_Condition] PRIMARY KEY CLUSTERED 
(
	[Condition_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Condition_treatment]    Script Date: 2022/11/08 23:36:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Condition_treatment](
	[Treatment_ID] [int] NULL,
	[Condition_ID] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Policy]    Script Date: 2022/11/08 23:36:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Policy](
	[Policy_ID] [int] NOT NULL,
	[Package_tear] [varchar](50) NULL,
	[Package_type] [varchar](50) NULL,
	[Package_Status] [varchar](50) NULL,
	[Price] [money] NULL,
 CONSTRAINT [PK_Policy] PRIMARY KEY CLUSTERED 
(
	[Policy_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Policy_Treatment]    Script Date: 2022/11/08 23:36:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Policy_Treatment](
	[Policy_ID] [int] NULL,
	[Treatment_ID] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Provider]    Script Date: 2022/11/08 23:36:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Provider](
	[Provider_ID] [int] NOT NULL,
	[Provider_Name] [varchar](50) NULL,
	[Provider_Status] [varchar](50) NULL,
	[City] [varchar](50) NULL,
	[Street_Number_Name] [varchar](50) NULL,
	[Postal_Code] [varchar](50) NULL,
 CONSTRAINT [PK_Provider] PRIMARY KEY CLUSTERED 
(
	[Provider_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Provider_Client]    Script Date: 2022/11/08 23:36:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Provider_Client](
	[Provider_ID] [int] NULL,
	[Client_ID] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Treatment]    Script Date: 2022/11/08 23:36:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Treatment](
	[Treatment_ID] [int] NOT NULL,
	[Treatment_name] [varchar](50) NULL,
 CONSTRAINT [PK_Treatment] PRIMARY KEY CLUSTERED 
(
	[Treatment_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Treatment_Provider]    Script Date: 2022/11/08 23:36:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Treatment_Provider](
	[Provider_ID] [int] NULL,
	[Treatment_ID] [int] NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Call]  WITH CHECK ADD  CONSTRAINT [FK_Call_Claim] FOREIGN KEY([Claim_ID])
REFERENCES [dbo].[Claim] ([Claim_ID])
GO
ALTER TABLE [dbo].[Call] CHECK CONSTRAINT [FK_Call_Claim]
GO
ALTER TABLE [dbo].[Call]  WITH CHECK ADD  CONSTRAINT [FK_Call_Client] FOREIGN KEY([Client_ID])
REFERENCES [dbo].[Client] ([Client_ID])
GO
ALTER TABLE [dbo].[Call] CHECK CONSTRAINT [FK_Call_Client]
GO
ALTER TABLE [dbo].[Claim]  WITH CHECK ADD  CONSTRAINT [FK_Claim_Client] FOREIGN KEY([Client_ID])
REFERENCES [dbo].[Client] ([Client_ID])
GO
ALTER TABLE [dbo].[Claim] CHECK CONSTRAINT [FK_Claim_Client]
GO
ALTER TABLE [dbo].[Client]  WITH CHECK ADD  CONSTRAINT [FK_Client_Policy] FOREIGN KEY([Policy_ID])
REFERENCES [dbo].[Policy] ([Policy_ID])
GO
ALTER TABLE [dbo].[Client] CHECK CONSTRAINT [FK_Client_Policy]
GO
ALTER TABLE [dbo].[Client_Condition]  WITH CHECK ADD  CONSTRAINT [FK_Client_Condition_Client] FOREIGN KEY([Client_ID])
REFERENCES [dbo].[Client] ([Client_ID])
GO
ALTER TABLE [dbo].[Client_Condition] CHECK CONSTRAINT [FK_Client_Condition_Client]
GO
ALTER TABLE [dbo].[Client_Condition]  WITH CHECK ADD  CONSTRAINT [FK_Client_Condition_Condition] FOREIGN KEY([Condition_ID])
REFERENCES [dbo].[Condition] ([Condition_ID])
GO
ALTER TABLE [dbo].[Client_Condition] CHECK CONSTRAINT [FK_Client_Condition_Condition]
GO
ALTER TABLE [dbo].[Client_Treatment]  WITH CHECK ADD  CONSTRAINT [FK_Client_Treatment_Client] FOREIGN KEY([Client_ID])
REFERENCES [dbo].[Client] ([Client_ID])
GO
ALTER TABLE [dbo].[Client_Treatment] CHECK CONSTRAINT [FK_Client_Treatment_Client]
GO
ALTER TABLE [dbo].[Client_Treatment]  WITH CHECK ADD  CONSTRAINT [FK_Client_Treatment_Treatment] FOREIGN KEY([Treatment_ID])
REFERENCES [dbo].[Treatment] ([Treatment_ID])
GO
ALTER TABLE [dbo].[Client_Treatment] CHECK CONSTRAINT [FK_Client_Treatment_Treatment]
GO
ALTER TABLE [dbo].[Condition_treatment]  WITH CHECK ADD  CONSTRAINT [FK_Condition_treatment_Condition] FOREIGN KEY([Condition_ID])
REFERENCES [dbo].[Condition] ([Condition_ID])
GO
ALTER TABLE [dbo].[Condition_treatment] CHECK CONSTRAINT [FK_Condition_treatment_Condition]
GO
ALTER TABLE [dbo].[Condition_treatment]  WITH CHECK ADD  CONSTRAINT [FK_Condition_treatment_treatment] FOREIGN KEY([Treatment_ID])
REFERENCES [dbo].[Treatment] ([Treatment_ID])
GO
ALTER TABLE [dbo].[Condition_treatment] CHECK CONSTRAINT [FK_Condition_treatment_treatment]
GO
ALTER TABLE [dbo].[Policy_Treatment]  WITH CHECK ADD  CONSTRAINT [FK_Policy_Treatment_Policy] FOREIGN KEY([Policy_ID])
REFERENCES [dbo].[Policy] ([Policy_ID])
GO
ALTER TABLE [dbo].[Policy_Treatment] CHECK CONSTRAINT [FK_Policy_Treatment_Policy]
GO
ALTER TABLE [dbo].[Policy_Treatment]  WITH CHECK ADD  CONSTRAINT [FK_Policy_Treatment_Treatment] FOREIGN KEY([Treatment_ID])
REFERENCES [dbo].[Treatment] ([Treatment_ID])
GO
ALTER TABLE [dbo].[Policy_Treatment] CHECK CONSTRAINT [FK_Policy_Treatment_Treatment]
GO
ALTER TABLE [dbo].[Provider_Client]  WITH CHECK ADD  CONSTRAINT [FK_Provider_Client_Client] FOREIGN KEY([Client_ID])
REFERENCES [dbo].[Client] ([Client_ID])
GO
ALTER TABLE [dbo].[Provider_Client] CHECK CONSTRAINT [FK_Provider_Client_Client]
GO
ALTER TABLE [dbo].[Provider_Client]  WITH CHECK ADD  CONSTRAINT [FK_Provider_Client_Provider] FOREIGN KEY([Provider_ID])
REFERENCES [dbo].[Provider] ([Provider_ID])
GO
ALTER TABLE [dbo].[Provider_Client] CHECK CONSTRAINT [FK_Provider_Client_Provider]
GO
ALTER TABLE [dbo].[Treatment_Provider]  WITH CHECK ADD  CONSTRAINT [FK_Treatment_Provider_Provider] FOREIGN KEY([Provider_ID])
REFERENCES [dbo].[Provider] ([Provider_ID])
GO
ALTER TABLE [dbo].[Treatment_Provider] CHECK CONSTRAINT [FK_Treatment_Provider_Provider]
GO
ALTER TABLE [dbo].[Treatment_Provider]  WITH CHECK ADD  CONSTRAINT [FK_Treatment_Provider_Treatment] FOREIGN KEY([Treatment_ID])
REFERENCES [dbo].[Treatment] ([Treatment_ID])
GO
ALTER TABLE [dbo].[Treatment_Provider] CHECK CONSTRAINT [FK_Treatment_Provider_Treatment]
GO
USE [master]
GO
ALTER DATABASE [Ukupholisa Healthcare] SET  READ_WRITE 
GO
