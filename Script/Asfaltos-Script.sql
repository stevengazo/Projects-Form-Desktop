USE [master]
GO
/****** Object:  Database [ProyectosAsfaltos]    Script Date: 27/1/2023 10:07:08 ******/
CREATE DATABASE [ProyectosAsfaltos]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ProyectosAsfaltos', FILENAME = N'/var/opt/mssql/data/ProyectosAsfaltos.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ProyectosAsfaltos_log', FILENAME = N'/var/opt/mssql/data/ProyectosAsfaltos_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ProyectosAsfaltos] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ProyectosAsfaltos].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ProyectosAsfaltos] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ProyectosAsfaltos] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ProyectosAsfaltos] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ProyectosAsfaltos] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ProyectosAsfaltos] SET ARITHABORT OFF 
GO
ALTER DATABASE [ProyectosAsfaltos] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ProyectosAsfaltos] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ProyectosAsfaltos] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ProyectosAsfaltos] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ProyectosAsfaltos] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ProyectosAsfaltos] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ProyectosAsfaltos] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ProyectosAsfaltos] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ProyectosAsfaltos] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ProyectosAsfaltos] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ProyectosAsfaltos] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ProyectosAsfaltos] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ProyectosAsfaltos] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ProyectosAsfaltos] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ProyectosAsfaltos] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ProyectosAsfaltos] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [ProyectosAsfaltos] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ProyectosAsfaltos] SET RECOVERY FULL 
GO
ALTER DATABASE [ProyectosAsfaltos] SET  MULTI_USER 
GO
ALTER DATABASE [ProyectosAsfaltos] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ProyectosAsfaltos] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ProyectosAsfaltos] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ProyectosAsfaltos] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ProyectosAsfaltos] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ProyectosAsfaltos] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'ProyectosAsfaltos', N'ON'
GO
ALTER DATABASE [ProyectosAsfaltos] SET QUERY_STORE = OFF
GO
USE [ProyectosAsfaltos]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 27/1/2023 10:07:08 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ofertas]    Script Date: 27/1/2023 10:07:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ofertas](
	[OfertaId] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [datetime2](7) NOT NULL,
	[Codigo] [int] NOT NULL,
	[Sellador] [bit] NOT NULL,
	[Asfalto] [bit] NOT NULL,
	[Base] [bit] NOT NULL,
	[SubBase] [bit] NOT NULL,
	[Excavacion] [bit] NOT NULL,
	[Monto] [real] NOT NULL,
	[Notas] [nvarchar](max) NOT NULL,
	[Observaciones] [nvarchar](max) NOT NULL,
	[AutorPrespuesto] [nvarchar](max) NOT NULL,
	[Cliente] [nvarchar](max) NOT NULL,
	[UltimaModificacion] [datetime2](7) NOT NULL,
	[UsuarioId] [int] NOT NULL,
 CONSTRAINT [PK_Ofertas] PRIMARY KEY CLUSTERED 
(
	[OfertaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proyectos]    Script Date: 27/1/2023 10:07:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proyectos](
	[ProyectoId] [int] IDENTITY(1,1) NOT NULL,
	[FechaOC] [datetime2](7) NOT NULL,
	[Contacto] [nvarchar](max) NOT NULL,
	[Cliente] [nvarchar](max) NOT NULL,
	[OfertaId] [nvarchar](max) NOT NULL,
	[Monto] [real] NOT NULL,
	[PorcentajeAnticipo] [int] NOT NULL,
	[FacturaAnticipoId] [nvarchar](max) NOT NULL,
	[FacturaFinalId] [nvarchar](max) NOT NULL,
	[TareaId] [int] NOT NULL,
	[Ubicacion] [nvarchar](max) NOT NULL,
	[FechaInicio] [datetime2](7) NOT NULL,
	[FechaFinal] [datetime2](7) NOT NULL,
	[Estado] [nvarchar](max) NOT NULL,
	[Autor] [nvarchar](max) NOT NULL,
	[UltimaEdicion] [datetime2](7) NOT NULL,
	[UltimoEditor] [nvarchar](max) NOT NULL,
	[UsuarioId] [int] NOT NULL,
	[Enable] [bit] NOT NULL,
 CONSTRAINT [PK_Proyectos] PRIMARY KEY CLUSTERED 
(
	[ProyectoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 27/1/2023 10:07:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[RolId] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[RolId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RolUsuarios]    Script Date: 27/1/2023 10:07:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RolUsuarios](
	[RolUsuarioId] [int] IDENTITY(1,1) NOT NULL,
	[RolId] [int] NOT NULL,
	[UsuarioId] [int] NOT NULL,
 CONSTRAINT [PK_RolUsuarios] PRIMARY KEY CLUSTERED 
(
	[RolUsuarioId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 27/1/2023 10:07:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[UsuarioId] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](max) NOT NULL,
	[Login] [nvarchar](max) NOT NULL,
	[Activo] [bit] NOT NULL,
	[HashContraseña] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[UsuarioId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230127160550_mymigration', N'7.0.2')
GO
SET IDENTITY_INSERT [dbo].[Ofertas] ON 

INSERT [dbo].[Ofertas] ([OfertaId], [Fecha], [Codigo], [Sellador], [Asfalto], [Base], [SubBase], [Excavacion], [Monto], [Notas], [Observaciones], [AutorPrespuesto], [Cliente], [UltimaModificacion], [UsuarioId]) 
VALUES (1, CAST(N'2023-01-27T00:00:00.0000000' AS DateTime2), 1, 1, 1, 1, 1, 1, 100, N'', N'', N'Administrador', N'Ejemplo', CAST(N'2023-01-27T01:00:00.0000000' AS DateTime2), 1)



SET IDENTITY_INSERT [dbo].[Ofertas] OFF
GO
SET IDENTITY_INSERT [dbo].[Proyectos] ON 

INSERT [dbo].[Proyectos] ([ProyectoId], [FechaOC], [Contacto], [Cliente], [OfertaId], [Monto], [PorcentajeAnticipo], [FacturaAnticipoId], [FacturaFinalId], [TareaId], [Ubicacion], [FechaInicio], [FechaFinal], [Estado], [Autor], [UltimaEdicion], [UltimoEditor], [UsuarioId], [Enable]) 
VALUES (1, CAST(N'2023-01-27T10:05:50.2357412' AS DateTime2), N'Ejemplo', N'Ejemplo de Cliente', N'PS-00001', 100, 50, N'No existente', N'No Existente', 2000, N'Grupo Mecsa', CAST(N'2023-01-26T00:00:00.0000000' AS DateTime2), CAST(N'2023-01-29T00:00:00.0000000' AS DateTime2), N'Finalizado', N'Administrador', CAST(N'2023-01-27T00:00:00.0000000' AS DateTime2), N'Administrador', 1, 1)
SET IDENTITY_INSERT [dbo].[Proyectos] OFF
GO
SET IDENTITY_INSERT [dbo].[Roles] ON 

INSERT [dbo].[Roles] ([RolId], [Nombre]) VALUES (1, N'Admin')
INSERT [dbo].[Roles] ([RolId], [Nombre]) VALUES (2, N'Vendedor')
SET IDENTITY_INSERT [dbo].[Roles] OFF
GO
SET IDENTITY_INSERT [dbo].[RolUsuarios] ON 

INSERT [dbo].[RolUsuarios] ([RolUsuarioId], [RolId], [UsuarioId]) VALUES (1, 1, 1)
SET IDENTITY_INSERT [dbo].[RolUsuarios] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([UsuarioId], [Nombre], [Login], [Activo], [HashContraseña]) VALUES (1, N'Administrador', N'admin', 1, N'0192023A7BBD73250516F069DF18B500'),
(2,'Carlos Fallas','Cfallas',1,CONVERT(VARCHAR(32), HashBytes('MD5','Cfallas1'))),
(3,'Adrian Solis','Asolis',1,CONVERT(VARCHAR(32), HashBytes('MD5','Asolis1'))),
(4,'Cinthya Sequeira','Csequeira',1,CONVERT(VARCHAR(32), HashBytes('MD5','Csequeira1'))),
(5,'Roy Garbanzo','Rgarbanzo',1,CONVERT(VARCHAR(32), HashBytes('MD5','Rgarbanzo1'))),
(6,'Anthony Fallas','Afallas',1,CONVERT(VARCHAR(32), HashBytes('MD5','Afallas1'))),
(7,'Marcela Hernandez','Mhernandez',1,CONVERT(VARCHAR(32), HashBytes('MD5','Mhernandez1'))),
(8,'Jimena Ferrey','Jferrey',1,CONVERT(VARCHAR(32), HashBytes('MD5','Jferrey1'))),
(9,'Erick Salazar','Esalazar',1,CONVERT(VARCHAR(32), HashBytes('MD5','Esalazar1'))),

SET IDENTITY_INSERT [dbo].[Usuarios] OFF
GO
/****** Object:  Index [IX_Ofertas_UsuarioId]    Script Date: 27/1/2023 10:07:08 ******/
CREATE NONCLUSTERED INDEX [IX_Ofertas_UsuarioId] ON [dbo].[Ofertas]
(
	[UsuarioId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Proyectos_UsuarioId]    Script Date: 27/1/2023 10:07:08 ******/
CREATE NONCLUSTERED INDEX [IX_Proyectos_UsuarioId] ON [dbo].[Proyectos]
(
	[UsuarioId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_RolUsuarios_RolId]    Script Date: 27/1/2023 10:07:08 ******/
CREATE NONCLUSTERED INDEX [IX_RolUsuarios_RolId] ON [dbo].[RolUsuarios]
(
	[RolId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_RolUsuarios_UsuarioId]    Script Date: 27/1/2023 10:07:08 ******/
CREATE NONCLUSTERED INDEX [IX_RolUsuarios_UsuarioId] ON [dbo].[RolUsuarios]
(
	[UsuarioId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Ofertas]  WITH CHECK ADD  CONSTRAINT [FK_Ofertas_Usuarios_UsuarioId] FOREIGN KEY([UsuarioId])
REFERENCES [dbo].[Usuarios] ([UsuarioId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Ofertas] CHECK CONSTRAINT [FK_Ofertas_Usuarios_UsuarioId]
GO
ALTER TABLE [dbo].[Proyectos]  WITH CHECK ADD  CONSTRAINT [FK_Proyectos_Usuarios_UsuarioId] FOREIGN KEY([UsuarioId])
REFERENCES [dbo].[Usuarios] ([UsuarioId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Proyectos] CHECK CONSTRAINT [FK_Proyectos_Usuarios_UsuarioId]
GO
ALTER TABLE [dbo].[RolUsuarios]  WITH CHECK ADD  CONSTRAINT [FK_RolUsuarios_Roles_RolId] FOREIGN KEY([RolId])
REFERENCES [dbo].[Roles] ([RolId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[RolUsuarios] CHECK CONSTRAINT [FK_RolUsuarios_Roles_RolId]
GO
ALTER TABLE [dbo].[RolUsuarios]  WITH CHECK ADD  CONSTRAINT [FK_RolUsuarios_Usuarios_UsuarioId] FOREIGN KEY([UsuarioId])
REFERENCES [dbo].[Usuarios] ([UsuarioId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[RolUsuarios] CHECK CONSTRAINT [FK_RolUsuarios_Usuarios_UsuarioId]
GO
USE [master]
GO
ALTER DATABASE [ProyectosAsfaltos] SET  READ_WRITE 
GO
