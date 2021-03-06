USE [master]
GO
/****** Object:  Database [Contact]    Script Date: 03/22/2018 23:49:24 ******/
CREATE DATABASE [Contact] 
GO
ALTER DATABASE [Contact] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Contact].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Contact] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [Contact] SET ANSI_NULLS OFF
GO
ALTER DATABASE [Contact] SET ANSI_PADDING OFF
GO
ALTER DATABASE [Contact] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [Contact] SET ARITHABORT OFF
GO
ALTER DATABASE [Contact] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [Contact] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [Contact] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [Contact] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [Contact] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [Contact] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [Contact] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [Contact] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [Contact] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [Contact] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [Contact] SET  ENABLE_BROKER
GO
ALTER DATABASE [Contact] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [Contact] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [Contact] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [Contact] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [Contact] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [Contact] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [Contact] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [Contact] SET  READ_WRITE
GO
ALTER DATABASE [Contact] SET RECOVERY FULL
GO
ALTER DATABASE [Contact] SET  MULTI_USER
GO
ALTER DATABASE [Contact] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [Contact] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'Contact', N'ON'
GO
USE [Contact]
GO
/****** Object:  User [test]    Script Date: 03/22/2018 23:49:24 ******/
CREATE USER [test] FOR LOGIN [test] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[User]    Script Date: 03/22/2018 23:49:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[User](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](50) NULL,
	[Password] [varbinary](2000) NULL,
	[Name] [nvarchar](100) NULL,
	[Email] [nvarchar](60) NULL,
	[Mobile] [nvarchar](20) NULL,
	[Mobile1] [nvarchar](20) NULL,
	[Address] [nvarchar](200) NULL,
	[Birthday] [date] NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Group]    Script Date: 03/22/2018 23:49:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Group](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](30) NULL,
 CONSTRAINT [PK_Group] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[GetUserByName]    Script Date: 03/22/2018 23:49:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetUserByName]
@Name nvarchar(50)
as
begin
	select * from [user] where  userName = @Name
end
GO
/****** Object:  StoredProcedure [dbo].[GetUser]    Script Date: 03/22/2018 23:49:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetUser]
@Password nvarchar(20),
@Name nvarchar(50)
as
begin
	select * from [user] where [Password] = HASHBYTES('md5', @Password) and userName = @Name
end
GO
/****** Object:  StoredProcedure [dbo].[SaveGroup]    Script Date: 03/22/2018 23:49:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SaveGroup]
@Name nvarchar(50)
as
begin
	insert into [Group] (Name) values (@Name)
end
GO
/****** Object:  Table [dbo].[Person]    Script Date: 03/22/2018 23:49:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Person](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](100) NULL,
	[Address] [nvarchar](200) NULL,
	[PrimaryEmail] [nvarchar](60) NULL,
	[GroupId] [int] NULL,
	[Mobile1] [nvarchar](15) NULL,
	[Mobile2] [nvarchar](15) NULL,
	[Relation] [nvarchar](20) NULL,
	[Birthday] [datetime] NULL,
	[Company] [nvarchar](200) NULL,
	[Title] [nvarchar](50) NULL,
	[Website] [nvarchar](100) NULL,
	[ProfEmail] [nvarchar](60) NULL,
	[Telephone1] [nvarchar](15) NULL,
	[Telephone2] [nvarchar](15) NULL,
	[ProfMobile1] [nvarchar](15) NULL,
	[ProfMobile2] [nvarchar](15) NULL,
	[Fax] [nvarchar](15) NULL,
	[Note] [nvarchar](1500) NULL,
	[Skype] [nvarchar](120) NULL,
	[windowsLive] [nvarchar](120) NULL,
	[Yahoo] [nvarchar](120) NULL,
	[Hangout] [nvarchar](120) NULL,
	[Gmail] [nvarchar](120) NULL,
	[Facebook] [nvarchar](120) NULL,
	[ProfileImage] [nvarchar](40) NULL,
 CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[GetAllGroup]    Script Date: 03/22/2018 23:49:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GetAllGroup]
as
begin
	Select *, 'Delete' as [Option] from [Group]
end
GO
/****** Object:  StoredProcedure [dbo].[ChangePassword]    Script Date: 03/22/2018 23:49:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ChangePassword]
@Password nvarchar(20),
@Name nvarchar(50)
as
begin
	update [user] set [Password] = HASHBYTES('md5', @Password) where userName = @Name
end
GO
/****** Object:  StoredProcedure [dbo].[SaveUpdatePerson]    Script Date: 03/22/2018 23:49:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SaveUpdatePerson]
@FullName nvarchar(100),
@Address nvarchar(200) = null,
@PrimaryEmail nvarchar(600) = null,
@GroupId int  =null,
@Mobile1 nvarchar(15),
@Mobile2 nvarchar(15),
@Relation  nvarchar(20) = null,
@Birthday datetime = null,
@Company nvarchar(200) = null,
@Title nvarchar(50) = null,
@Website nvarchar(100) = null,
@ProfEmail nvarchar(60) = null,
@Telephone1 nvarchar(15) = null,
@Telephone2 nvarchar(15) = null,
@ProfMobile1 nvarchar(15) = null,
@ProfMobile2 nvarchar(15) = null,
@Fax nvarchar(15) = null,
@Note nvarchar(1500) = null,
@Skype nvarchar(120) = null,
@windowsLive nvarchar(120) = null,
@Yahoo nvarchar(120) = null,
@Hangout nvarchar(120) = null,
@Gmail nvarchar(120) = null,
@Facebook nvarchar(120) = null,
@ProfileImage nvarchar(120) = null,
@Id int = null
as
begin
	if (@Id is not null and @Id > 0)
	begin
		update Person set
			FullName = @FullName,
			Address = @Address,
			PrimaryEmail = @PrimaryEmail,
			GroupId = @GroupId,
			Mobile1 = @Mobile1,
			Mobile2 = @Mobile2,
			Relation = @Relation,
			Birthday = @Birthday,
			Company = @Company,
			Title = @Title,
			Website = @Website,
			ProfEmail = @ProfEmail,
			Telephone1 = @Telephone1,
			Telephone2 = @Telephone2,
			ProfMobile1 = @ProfMobile1,
			ProfMobile2 = @ProfMobile2,
			Fax = @Fax,
			Note= @Note,
			Skype = @Skype,
			windowsLive = @windowsLive,
			Yahoo = @Yahoo,
			Hangout = @Hangout,
			Gmail = @Gmail,
			Facebook = @Facebook,
			ProfileImage = @ProfileImage
			where id = @Id
	end
	else
	begin
		insert into Person(FullName, Address, PrimaryEmail, GroupId,Mobile1, Mobile2, Relation, Birthday, 
		Company, Title, Website, ProfEmail, Telephone1, Telephone2, ProfMobile1, ProfMobile2, Fax, Note,
		Skype, windowsLive, Yahoo, Hangout, Gmail, Facebook, ProfileImage) values
		(@FullName, @Address, @PrimaryEmail, @GroupId, @Mobile1, @Mobile2, @Relation, @Birthday, 
		@Company, @Title, @Website, @ProfEmail, @Telephone1, @Telephone2, @ProfMobile1, @ProfMobile2, @Fax, @Note,
		 @Skype, @windowsLive, @Yahoo, @Hangout, @Gmail, @Facebook, @ProfileImage)
	end	
end
GO
/****** Object:  StoredProcedure [dbo].[GetAllContact]    Script Date: 03/22/2018 23:49:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GetAllContact]
as
begin
	select p.*, g.Name as 'Group' from Person p
	left join [Group] g on p.GroupId =  g.id
end
GO
/****** Object:  StoredProcedure [dbo].[DeleteGroup]    Script Date: 03/22/2018 23:49:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[DeleteGroup]
@ID int
as
begin
	update Person set GroupId = null where GroupId = @ID
	delete from [Group] where Id = @ID
end
GO
/****** Object:  StoredProcedure [dbo].[DeleteContact]    Script Date: 03/22/2018 23:49:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DeleteContact]
@Id int
as
begin
	delete from Person where Id = @Id
end
GO
/****** Object:  StoredProcedure [dbo].[GetContactById]    Script Date: 03/22/2018 23:49:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetContactById]
@Id int
as
begin
	select top 1 * from Person where Id = @Id
end
GO
/****** Object:  ForeignKey [FK_Person_Group]    Script Date: 03/22/2018 23:49:27 ******/
ALTER TABLE [dbo].[Person]  WITH CHECK ADD  CONSTRAINT [FK_Person_Group] FOREIGN KEY([GroupId])
REFERENCES [dbo].[Group] ([Id])
GO
ALTER TABLE [dbo].[Person] CHECK CONSTRAINT [FK_Person_Group]
GO

insert into [User](UserName, Name, Email, Mobile, Mobile1, Address, Birthday) values
('subash', 'Subash Shrestha', 'subash@gmail.com','101010','202020','Boston','1992-1-1')

go
exec ChangePassword @Password = '1234', @Name='subash'