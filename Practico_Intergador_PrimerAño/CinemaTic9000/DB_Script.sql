USE [master]
GO
/****** Object:  Database [PracticoIntegrador_MMRP]    Script Date: 25/11/2016 9:56:47 ******/
CREATE DATABASE [PracticoIntegrador_MMRP]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PracticoIntegrador_MMRP', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\PracticoIntegrador_MMRP.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'PracticoIntegrador_MMRP_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\PracticoIntegrador_MMRP_log.ldf' , SIZE = 1072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [PracticoIntegrador_MMRP] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PracticoIntegrador_MMRP].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PracticoIntegrador_MMRP] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PracticoIntegrador_MMRP] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PracticoIntegrador_MMRP] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PracticoIntegrador_MMRP] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PracticoIntegrador_MMRP] SET ARITHABORT OFF 
GO
ALTER DATABASE [PracticoIntegrador_MMRP] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [PracticoIntegrador_MMRP] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PracticoIntegrador_MMRP] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PracticoIntegrador_MMRP] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PracticoIntegrador_MMRP] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PracticoIntegrador_MMRP] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PracticoIntegrador_MMRP] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PracticoIntegrador_MMRP] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PracticoIntegrador_MMRP] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PracticoIntegrador_MMRP] SET  ENABLE_BROKER 
GO
ALTER DATABASE [PracticoIntegrador_MMRP] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PracticoIntegrador_MMRP] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PracticoIntegrador_MMRP] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PracticoIntegrador_MMRP] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PracticoIntegrador_MMRP] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PracticoIntegrador_MMRP] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PracticoIntegrador_MMRP] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PracticoIntegrador_MMRP] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [PracticoIntegrador_MMRP] SET  MULTI_USER 
GO
ALTER DATABASE [PracticoIntegrador_MMRP] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PracticoIntegrador_MMRP] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PracticoIntegrador_MMRP] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PracticoIntegrador_MMRP] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [PracticoIntegrador_MMRP] SET DELAYED_DURABILITY = DISABLED 
GO
USE [PracticoIntegrador_MMRP]
GO
/****** Object:  Table [dbo].[BUTACAS]    Script Date: 25/11/2016 9:56:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BUTACAS](
	[id_butaca] [int] IDENTITY(1,1) NOT NULL,
	[id_sala] [int] NOT NULL,
	[Fila] [char](1) NULL,
	[Asiento] [int] NULL,
 CONSTRAINT [id_butaca_pk] PRIMARY KEY CLUSTERED 
(
	[id_butaca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Cajas]    Script Date: 25/11/2016 9:56:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cajas](
	[id_caja] [int] IDENTITY(1,1) NOT NULL,
	[id_tipo_caja] [int] NOT NULL,
	[id_empleado] [int] NOT NULL,
 CONSTRAINT [id_caja_pk] PRIMARY KEY CLUSTERED 
(
	[id_caja] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Clasificaciones]    Script Date: 25/11/2016 9:56:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clasificaciones](
	[id_clasificacion] [int] IDENTITY(1,1) NOT NULL,
	[clasificacion] [varchar](20) NOT NULL,
	[descripcion] [varchar](350) NOT NULL,
 CONSTRAINT [id_clasificacion_pk] PRIMARY KEY CLUSTERED 
(
	[id_clasificacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[detalle_Tickets]    Script Date: 25/11/2016 9:56:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalle_Tickets](
	[id_Ticket] [int] NOT NULL,
	[id_detalle_Ticket] [int] IDENTITY(1,1) NOT NULL,
	[id_entrada] [int] NOT NULL,
	[Precio] [money] NOT NULL,
 CONSTRAINT [id_detalle_Ticket_PK] PRIMARY KEY CLUSTERED 
(
	[id_detalle_Ticket] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 25/11/2016 9:56:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleados](
	[id_empleado] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](30) NOT NULL,
	[apellido] [varchar](30) NOT NULL,
	[id_tipo_documento] [int] NOT NULL,
	[documento] [bigint] NOT NULL,
	[fec_nac] [datetime] NOT NULL,
 CONSTRAINT [empleado_pk] PRIMARY KEY CLUSTERED 
(
	[id_empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ENTRADAS]    Script Date: 25/11/2016 9:56:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ENTRADAS](
	[id_entrada] [int] IDENTITY(1,1) NOT NULL,
	[id_funcion] [int] NOT NULL,
	[id_butaca] [int] NOT NULL,
	[id_Estado] [int] NOT NULL,
 CONSTRAINT [id_entrada_PK] PRIMARY KEY CLUSTERED 
(
	[id_entrada] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Estados]    Script Date: 25/11/2016 9:56:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estados](
	[id_Estado] [int] IDENTITY(1,1) NOT NULL,
	[Estado] [varchar](10) NULL,
 CONSTRAINT [id_Estado_pk] PRIMARY KEY CLUSTERED 
(
	[id_Estado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Funcion_horarios]    Script Date: 25/11/2016 9:56:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Funcion_horarios](
	[id_horario] [int] IDENTITY(1,1) NOT NULL,
	[Horario] [varchar](10) NULL,
 CONSTRAINT [id_horario_pk] PRIMARY KEY CLUSTERED 
(
	[id_horario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Funciones]    Script Date: 25/11/2016 9:56:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Funciones](
	[id_funcion] [int] IDENTITY(1,1) NOT NULL,
	[id_pelicula] [int] NOT NULL,
	[id_horario] [int] NOT NULL,
	[id_idioma] [int] NOT NULL,
	[id_subtitulo] [int] NOT NULL,
 CONSTRAINT [id_funcion_pk] PRIMARY KEY CLUSTERED 
(
	[id_funcion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Generos]    Script Date: 25/11/2016 9:56:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Generos](
	[id_genero] [int] IDENTITY(1,1) NOT NULL,
	[genero] [varchar](20) NOT NULL,
 CONSTRAINT [id_genero_pk] PRIMARY KEY CLUSTERED 
(
	[id_genero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Idiomas]    Script Date: 25/11/2016 9:56:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Idiomas](
	[id_idioma] [int] IDENTITY(1,1) NOT NULL,
	[idioma] [varchar](15) NULL,
 CONSTRAINT [id_idioma_pk] PRIMARY KEY CLUSTERED 
(
	[id_idioma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Metodo_pagos]    Script Date: 25/11/2016 9:56:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Metodo_pagos](
	[id_metodo_pago] [int] IDENTITY(1,1) NOT NULL,
	[metodo_pago] [varchar](20) NOT NULL,
 CONSTRAINT [id_metodo_pago_PK] PRIMARY KEY CLUSTERED 
(
	[id_metodo_pago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Peliculas]    Script Date: 25/11/2016 9:56:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Peliculas](
	[id_pelicula] [int] IDENTITY(1,1) NOT NULL,
	[Pelicula] [varchar](20) NOT NULL,
	[descripcion] [varchar](800) NULL,
	[id_genero] [int] NOT NULL,
	[id_clasificacion] [int] NOT NULL,
 CONSTRAINT [id_pelicula_pk] PRIMARY KEY CLUSTERED 
(
	[id_pelicula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Salas]    Script Date: 25/11/2016 9:56:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Salas](
	[id_sala] [int] IDENTITY(1,1) NOT NULL,
	[id_tipo_sala] [int] NOT NULL,
	[sala] [varchar](15) NULL,
 CONSTRAINT [id_sala_pk] PRIMARY KEY CLUSTERED 
(
	[id_sala] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[subtitulos]    Script Date: 25/11/2016 9:56:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[subtitulos](
	[id_subtitulo] [int] IDENTITY(1,1) NOT NULL,
	[subtitulo] [varchar](10) NULL,
 CONSTRAINT [id_subtitulo_pk] PRIMARY KEY CLUSTERED 
(
	[id_subtitulo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TICKETS]    Script Date: 25/11/2016 9:56:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TICKETS](
	[id_Ticket] [int] IDENTITY(1,1) NOT NULL,
	[id_caja] [int] NOT NULL,
	[id_tipo_cliente] [int] NOT NULL,
	[id_metodo_pago] [int] NOT NULL,
	[Fecha] [datetime] NOT NULL,
 CONSTRAINT [id_Ticket_pk] PRIMARY KEY CLUSTERED 
(
	[id_Ticket] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tipo_cajas]    Script Date: 25/11/2016 9:56:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo_cajas](
	[id_tipo_caja] [int] IDENTITY(1,1) NOT NULL,
	[Tipo] [varchar](20) NOT NULL,
 CONSTRAINT [tipo_Caja_pk] PRIMARY KEY CLUSTERED 
(
	[id_tipo_caja] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tipo_Clientes]    Script Date: 25/11/2016 9:56:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo_Clientes](
	[id_tipo_cliente] [int] IDENTITY(1,1) NOT NULL,
	[tipo_cliente] [varchar](20) NOT NULL,
 CONSTRAINT [id_tipo_cliente_PK] PRIMARY KEY CLUSTERED 
(
	[id_tipo_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tipo_Documentos]    Script Date: 25/11/2016 9:56:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo_Documentos](
	[id_tipo_documento] [int] IDENTITY(1,1) NOT NULL,
	[tipo_documento] [varchar](80) NOT NULL,
 CONSTRAINT [tipo_documento_pk] PRIMARY KEY CLUSTERED 
(
	[id_tipo_documento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tipo_Salas]    Script Date: 25/11/2016 9:56:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipo_Salas](
	[id_tipo_sala] [int] IDENTITY(1,1) NOT NULL,
	[tipo] [varchar](15) NOT NULL,
 CONSTRAINT [id_tipo_sala_pk] PRIMARY KEY CLUSTERED 
(
	[id_tipo_sala] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[empleados_vista]    Script Date: 25/11/2016 9:56:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[empleados_vista]
as
select id_empleado 'Identificacion',
	apellido+' '+nombre 'Apellido, Nombre',
	td.tipo_documento 'Tipo documento',
	documento 'Documento',
	convert(varchar(10), cast(fec_nac as date), 101) 'Fecha Nacimiento'
from empleados e join tipo_documentos td on td.id_tipo_documento=e.id_tipo_documento
GO
/****** Object:  View [dbo].[cajas_vista]    Script Date: 25/11/2016 9:56:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[cajas_vista]
as
select id_caja 'Caja',
	tc.tipo 'Tipo de Caja',
	e.[apellido, nombre] 'Empleado asignado'
from cajas c join empleados_vista e on e.identificacion=c.id_empleado
join tipo_cajas tc on c.id_tipo_Caja=tc.id_tipo_caja
GO
/****** Object:  View [dbo].[Funciones_vista]    Script Date: 25/11/2016 9:56:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[Funciones_vista]
as
select id_Funcion 'Id de la Funcion',
	p.pelicula 'Pelicula',
	fh.horario 'Horario de comienzo',
	i.idioma 'Idioma',
	s.subtitulo 'Subtitulo'
	
from funciones f join peliculas p on p.id_pelicula=f.id_pelicula
join funcion_horarios fh on fh.id_horario=f.id_horario join
idiomas i on i.id_idioma =f.id_idioma join subtitulos s
on s.id_subtitulo=f.id_subtitulo
GO
/****** Object:  View [dbo].[Entradas_vista]    Script Date: 25/11/2016 9:56:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[Entradas_vista]
as
select e.id_Entrada 'Id de la entrada',
	ts.tipo 'Tipo de sala',
	'Sala: '+Convert(varchar(10),b.id_sala)+' Fila: '+b.fila+' Asiento: '+Convert(varchar(10),b.asiento) 'Lugar',
	f.pelicula 'Pelicula',
	f.[Horario de comienzo] 'Comienzo en',
	f.idioma 'Idioma',
	f.Subtitulo 'Subtitulo',
	cast(dt.Precio as decimal(18,2)) 'Precio'
from Entradas e join funciones_vista f on f.[id de la funcion]=e.id_funcion
join butacas b on b.id_butaca=e.id_butaca
join salas s on b.id_sala=s.id_sala
join tipo_salas ts on ts.id_tipo_sala=s.id_tipo_sala
join detalle_tickets dt on dt.id_entrada=e.id_entrada
GO
/****** Object:  View [dbo].[Metodo_pagos_vista]    Script Date: 25/11/2016 9:56:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[Metodo_pagos_vista]
as
select id_metodo_pago 'Id de Pago',
	metodo_pago 'Metodo de Pago'
from metodo_pagos
GO
/****** Object:  View [dbo].[Tipo_Clientes_vista]    Script Date: 25/11/2016 9:56:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[Tipo_Clientes_vista]
as
select id_tipo_cliente 'Id Tipo Cliente',
	tipo_cliente 'Tipo de Cliente'
from Tipo_Clientes

GO
/****** Object:  View [dbo].[tickets_vista]    Script Date: 25/11/2016 9:56:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[tickets_vista]
as
select t.id_ticket 'Id Ticket',
		t.id_caja 'Caja de la venta',
		tc.[tipo de cliente] 'Tipo de cliente',
		mp.[metodo de pago] 'Metodo de pago usado',
		fecha 'Fecha'
from  tickets t join Tipo_Clientes_vista tc on tc.[id tipo cliente]=t.id_tipo_cliente
join Metodo_pagos_vista mp on mp.[id de pago]=t.id_metodo_pago
GO
/****** Object:  View [dbo].[Clasificaciones_vista]    Script Date: 25/11/2016 9:56:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[Clasificaciones_vista]
as
select id_clasificacion'Id Clasificacion',
	clasificacion 'Clasificacion',
	descripcion 'Descripcion'
from Clasificaciones
GO
/****** Object:  View [dbo].[consulta2_view]    Script Date: 25/11/2016 9:56:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[consulta2_view]
as
select p.pelicula 'Pelicula', count(e.id_entrada)'Entrada Vendidas', sum(d.Precio)'Importe Total', 
avg(d.precio)'Precio Promedio', max(t.fecha)'Ultima Entrada Vendida'
from peliculas p join funciones f on p.id_pelicula=f.id_pelicula   
join entradas e on e.id_funcion=f.id_funcion join detalle_tickets d    
on d.id_entrada=e.id_entrada join tickets t on t.id_ticket=d.id_ticket  
group by p.pelicula
GO
/****** Object:  View [dbo].[consulta6_view]    Script Date: 25/11/2016 9:56:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[consulta6_view]
as
SELECT sum(precio) 'Recaudado', day(fecha) 'Dia'
FROM detalle_tickets d join tickets t 
ON t.id_ticket=d.id_ticket
WHERE  day(fecha) between 28 and 31
GROUP BY day(fecha)
GO
/****** Object:  View [dbo].[consulta7_view]    Script Date: 25/11/2016 9:56:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[consulta7_view]
as
SELECT e.apellido + ','+e.nombre'Nombre',
min(Convert(varchar,t.fecha,103))'Primera Entrada vendida',
max(Convert(varchar,t.fecha,103))'Ultima entrada vendida',
sum(d.precio)'Monto total'
FROM empleados e JOIN cajas c ON 
c.id_empleado=e.id_empleado JOIN TICKETS t ON t.id_caja=c.id_caja join detalle_tickets d on t.id_ticket=d.id_ticket
GROUP BY e.apellido + ','+e.nombre
GO
/****** Object:  View [dbo].[consulta8_view]    Script Date: 25/11/2016 9:56:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[consulta8_view]
as
SELECT e.id_empleado 'Numero Identificacion',
e.nombre + ','+e.nombre'Nombre Completo',
td.tipo_documento 'Tipo documento',
e.documento 'Numero de documento',
Convert(varchar,e.fec_nac,103) 'Fecha Nacimiento'
FROM empleados e JOIN 
tipo_documentos td ON td.id_tipo_documento=e.id_tipo_documento
WHERE exists(SELECT *
			FROM tickets t join detalle_tickets dt
			ON t.id_ticket=dt.id_ticket JOIN
			cajas c ON c.id_caja=t.id_caja
			WHERE c.id_empleado=e.id_empleado
			)
AND td.tipo_documento NOT LIKE 'Pasaporte'
GO
/****** Object:  View [dbo].[detalle_Tickets_vista]    Script Date: 25/11/2016 9:56:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[detalle_Tickets_vista]
as
select id_ticket 'ID Ticket correspondiente',
		id_entrada 'Id de la Entrada',
		cast(Precio as decimal(18,2)) 'Precio de la entrada'
from  detalle_Tickets
GO
/****** Object:  View [dbo].[Funcion_horarios_vista]    Script Date: 25/11/2016 9:56:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[Funcion_horarios_vista]
as
select id_horario 'Id del Horario',
	horario 'Horario de comienzo'
from Funcion_horarios
GO
/****** Object:  View [dbo].[generos_vista]    Script Date: 25/11/2016 9:56:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[generos_vista]
as
select id_genero'Id Genero',
	genero 'Genero'
from generos

GO
/****** Object:  View [dbo].[Idiomas_vista]    Script Date: 25/11/2016 9:56:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[Idiomas_vista]
as
select id_idioma 'Id del Idioma',
	idioma 'Idioma'
from Idiomas

GO
/****** Object:  View [dbo].[Peliculas_vista]    Script Date: 25/11/2016 9:56:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[Peliculas_vista]
as
select id_pelicula 'Id Pelicula',
	Pelicula 'Titulo',
	p.descripcion 'Descripcion',
	g.genero 'Genero',
	c.clasificacion 'Clasificacion'
from Peliculas p join generos g on g.id_genero=p.id_genero
join clasificaciones c on c.id_clasificacion=p.id_clasificacion
GO
/****** Object:  View [dbo].[subtitulos_vista]    Script Date: 25/11/2016 9:56:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[subtitulos_vista]
as
select id_subtitulo 'Id del Subtitulo',
	subtitulo 'Tipo de Subtitulo'
from subtitulos
GO
/****** Object:  View [dbo].[tipo_Cajas_vista]    Script Date: 25/11/2016 9:56:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[tipo_Cajas_vista]
as
select id_tipo_caja'Id Tipo de Caja',
	tipo 'Tipo de caja'
from tipo_Cajas
GO
/****** Object:  View [dbo].[tipo_documentos_vista]    Script Date: 25/11/2016 9:56:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[tipo_documentos_vista]
as
select id_tipo_documento 'Id Documento',
	tipo_documento 'Tipo de Documento'
from tipo_documentos
GO
/****** Object:  View [dbo].[tipo_Salas_vista]    Script Date: 25/11/2016 9:56:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[tipo_Salas_vista]
as
select id_tipo_Sala 'Id de la Sala',
	tipo 'Tipo de sala'
from tipo_Salas
GO
/****** Object:  View [dbo].[vista_detalleFunciones]    Script Date: 25/11/2016 9:56:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vista_detalleFunciones]
as
select f.id_funcion 'ID Funcion', p.pelicula 'Pelicula', 
fh.horario 'Comienzo Funcion', i.idioma 'Idioma', s.subtitulo 'Subtitulado'
from funciones f join peliculas p on f.id_pelicula=p.id_pelicula
join funcion_horarios fh on f.id_horario=fh.id_horario join
idiomas i on i.id_idioma=f.id_idioma join subtitulos s on
s.id_subtitulo=f.id_subtitulo
GO
/****** Object:  View [dbo].[vistaPeliculas_2]    Script Date: 25/11/2016 9:56:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[vistaPeliculas_2]
as
select p.id_pelicula 'Identificador', p.pelicula 'Pelicula', count(e.id_entrada)'Entrada Vendidas', sum(d.Precio)'Importe Total', 
avg(d.precio)'Precio Promedio', max(t.fecha)'Ultima Entrada Vendida'
from peliculas p join funciones f on p.id_pelicula=f.id_pelicula   join entradas e on e.id_funcion=f.id_funcion join detalle_tickets d    on d.id_entrada=e.id_entrada join tickets t on t.id_ticket=d.id_ticket  
group by p.id_pelicula, p.pelicula
GO
SET IDENTITY_INSERT [dbo].[BUTACAS] ON 

INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (1, 1, N'A', 1)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (2, 1, N'A', 2)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (3, 1, N'A', 3)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (4, 1, N'A', 4)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (5, 1, N'A', 5)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (6, 1, N'B', 1)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (7, 1, N'B', 2)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (8, 1, N'B', 3)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (9, 1, N'B', 4)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (10, 1, N'B', 5)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (11, 1, N'C', 1)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (12, 1, N'C', 2)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (13, 1, N'C', 3)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (14, 1, N'C', 4)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (15, 1, N'C', 5)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (16, 1, N'D', 1)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (17, 1, N'D', 2)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (18, 1, N'D', 3)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (19, 1, N'D', 4)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (20, 1, N'D', 5)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (21, 1, N'E', 1)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (22, 1, N'E', 2)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (23, 1, N'E', 3)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (24, 1, N'E', 4)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (25, 1, N'E', 5)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (26, 1, N'F', 1)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (27, 1, N'F', 2)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (28, 1, N'F', 3)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (29, 1, N'F', 4)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (30, 1, N'F', 5)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (31, 1, N'G', 1)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (32, 1, N'G', 2)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (33, 1, N'G', 3)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (34, 1, N'G', 4)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (35, 1, N'G', 5)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (36, 1, N'H', 1)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (37, 1, N'H', 2)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (38, 1, N'H', 3)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (39, 1, N'H', 4)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (40, 1, N'H', 5)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (41, 2, N'A', 1)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (42, 2, N'A', 2)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (43, 2, N'A', 3)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (44, 2, N'A', 4)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (45, 2, N'A', 5)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (46, 2, N'B', 1)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (47, 2, N'B', 2)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (48, 2, N'B', 3)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (49, 2, N'B', 4)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (50, 2, N'B', 5)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (51, 2, N'C', 1)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (52, 2, N'C', 2)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (53, 2, N'C', 3)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (54, 2, N'C', 4)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (55, 2, N'C', 5)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (56, 2, N'D', 1)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (57, 2, N'D', 2)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (58, 2, N'D', 3)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (59, 2, N'D', 4)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (60, 2, N'D', 5)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (61, 2, N'E', 1)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (62, 2, N'E', 2)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (63, 2, N'E', 3)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (64, 2, N'E', 4)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (65, 2, N'E', 5)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (66, 2, N'F', 1)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (67, 2, N'F', 2)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (68, 2, N'F', 3)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (69, 2, N'F', 4)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (70, 2, N'F', 5)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (71, 2, N'G', 1)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (72, 2, N'G', 2)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (73, 2, N'G', 3)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (74, 2, N'G', 4)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (75, 2, N'G', 5)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (76, 2, N'H', 1)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (77, 2, N'H', 2)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (78, 2, N'H', 3)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (79, 2, N'H', 4)
INSERT [dbo].[BUTACAS] ([id_butaca], [id_sala], [Fila], [Asiento]) VALUES (80, 2, N'H', 5)
SET IDENTITY_INSERT [dbo].[BUTACAS] OFF
SET IDENTITY_INSERT [dbo].[Cajas] ON 

INSERT [dbo].[Cajas] ([id_caja], [id_tipo_caja], [id_empleado]) VALUES (1, 1, 1)
INSERT [dbo].[Cajas] ([id_caja], [id_tipo_caja], [id_empleado]) VALUES (2, 1, 2)
INSERT [dbo].[Cajas] ([id_caja], [id_tipo_caja], [id_empleado]) VALUES (3, 2, 3)
INSERT [dbo].[Cajas] ([id_caja], [id_tipo_caja], [id_empleado]) VALUES (4, 2, 4)
INSERT [dbo].[Cajas] ([id_caja], [id_tipo_caja], [id_empleado]) VALUES (5, 1, 5)
SET IDENTITY_INSERT [dbo].[Cajas] OFF
SET IDENTITY_INSERT [dbo].[Clasificaciones] ON 

INSERT [dbo].[Clasificaciones] ([id_clasificacion], [clasificacion], [descripcion]) VALUES (1, N'ATP', N'Todas las edades pueden ver. No hay desnudez ni sangre y/o alcohol. El lenguaje es cortés sin el uso de insultos o con ofensas muy suaves que caen en lo gracioso.')
INSERT [dbo].[Clasificaciones] ([id_clasificacion], [clasificacion], [descripcion]) VALUES (2, N'+13', N' Apta mayores de 13 años. Desnudez parcial, sangre fuerte, muertes poco violentas, lenguaje regularizado e imágenes intensas suelen aparecer en las películas de esta clasificación.')
INSERT [dbo].[Clasificaciones] ([id_clasificacion], [clasificacion], [descripcion]) VALUES (3, N'+16', N' Apta mayores de 16 años. Desnudez fuerte y explicita, escenas fuertes, alcohol y drogas, insultos, imágenes muy intensas y sangre en mucha cantidad. Se recomienda discreción para los menores de 16 años.')
INSERT [dbo].[Clasificaciones] ([id_clasificacion], [clasificacion], [descripcion]) VALUES (4, N'+18', N' Apta mayores de 18 años. Los menores de edad no están destinados a ver la película. Desnudez fuerte (pornografia).')
SET IDENTITY_INSERT [dbo].[Clasificaciones] OFF
SET IDENTITY_INSERT [dbo].[detalle_Tickets] ON 

INSERT [dbo].[detalle_Tickets] ([id_Ticket], [id_detalle_Ticket], [id_entrada], [Precio]) VALUES (1, 1, 5, 85.0000)
INSERT [dbo].[detalle_Tickets] ([id_Ticket], [id_detalle_Ticket], [id_entrada], [Precio]) VALUES (2, 2, 2, 85.0000)
INSERT [dbo].[detalle_Tickets] ([id_Ticket], [id_detalle_Ticket], [id_entrada], [Precio]) VALUES (3, 3, 3, 85.0000)
INSERT [dbo].[detalle_Tickets] ([id_Ticket], [id_detalle_Ticket], [id_entrada], [Precio]) VALUES (1, 4, 4, 85.0000)
INSERT [dbo].[detalle_Tickets] ([id_Ticket], [id_detalle_Ticket], [id_entrada], [Precio]) VALUES (3, 5, 4, 85.0000)
INSERT [dbo].[detalle_Tickets] ([id_Ticket], [id_detalle_Ticket], [id_entrada], [Precio]) VALUES (4, 6, 1, 115.0000)
SET IDENTITY_INSERT [dbo].[detalle_Tickets] OFF
SET IDENTITY_INSERT [dbo].[Empleados] ON 

INSERT [dbo].[Empleados] ([id_empleado], [nombre], [apellido], [id_tipo_documento], [documento], [fec_nac]) VALUES (1, N'Carlos', N'Perez', 1, 23578654, CAST(N'1973-01-11T00:00:00.000' AS DateTime))
INSERT [dbo].[Empleados] ([id_empleado], [nombre], [apellido], [id_tipo_documento], [documento], [fec_nac]) VALUES (2, N'Romina', N'Garcia', 2, 30157951, CAST(N'1980-04-20T00:00:00.000' AS DateTime))
INSERT [dbo].[Empleados] ([id_empleado], [nombre], [apellido], [id_tipo_documento], [documento], [fec_nac]) VALUES (3, N'Hector', N'Lopez', 3, 94546987, CAST(N'1990-08-04T00:00:00.000' AS DateTime))
INSERT [dbo].[Empleados] ([id_empleado], [nombre], [apellido], [id_tipo_documento], [documento], [fec_nac]) VALUES (4, N'Brenda', N'Sanchez', 1, 35175978, CAST(N'1990-02-22T00:00:00.000' AS DateTime))
INSERT [dbo].[Empleados] ([id_empleado], [nombre], [apellido], [id_tipo_documento], [documento], [fec_nac]) VALUES (5, N'Ariel', N'Peralta', 2, 31357951, CAST(N'1987-11-16T00:00:00.000' AS DateTime))
INSERT [dbo].[Empleados] ([id_empleado], [nombre], [apellido], [id_tipo_documento], [documento], [fec_nac]) VALUES (6, N'Daniel', N'Montiver', 4, 35124, CAST(N'2016-10-29T18:19:25.000' AS DateTime))
INSERT [dbo].[Empleados] ([id_empleado], [nombre], [apellido], [id_tipo_documento], [documento], [fec_nac]) VALUES (7, N'Maxy', N'Rodriguez', 1, 4445561, CAST(N'2016-03-17T18:20:52.000' AS DateTime))
INSERT [dbo].[Empleados] ([id_empleado], [nombre], [apellido], [id_tipo_documento], [documento], [fec_nac]) VALUES (9, N'dummy', N'dummyApellido', 1, 7778886, CAST(N'2016-10-29T19:55:47.000' AS DateTime))
INSERT [dbo].[Empleados] ([id_empleado], [nombre], [apellido], [id_tipo_documento], [documento], [fec_nac]) VALUES (10, N'Pepez2', N'Pepom', 4, 84651, CAST(N'2016-10-29T19:56:42.000' AS DateTime))
INSERT [dbo].[Empleados] ([id_empleado], [nombre], [apellido], [id_tipo_documento], [documento], [fec_nac]) VALUES (13, N'Jaimito', N'Jaimon', 4, 9843, CAST(N'2016-10-29T21:03:58.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Empleados] OFF
SET IDENTITY_INSERT [dbo].[ENTRADAS] ON 

INSERT [dbo].[ENTRADAS] ([id_entrada], [id_funcion], [id_butaca], [id_Estado]) VALUES (1, 1, 1, 1)
INSERT [dbo].[ENTRADAS] ([id_entrada], [id_funcion], [id_butaca], [id_Estado]) VALUES (2, 2, 55, 1)
INSERT [dbo].[ENTRADAS] ([id_entrada], [id_funcion], [id_butaca], [id_Estado]) VALUES (3, 5, 33, 1)
INSERT [dbo].[ENTRADAS] ([id_entrada], [id_funcion], [id_butaca], [id_Estado]) VALUES (4, 5, 32, 1)
INSERT [dbo].[ENTRADAS] ([id_entrada], [id_funcion], [id_butaca], [id_Estado]) VALUES (5, 4, 79, 1)
INSERT [dbo].[ENTRADAS] ([id_entrada], [id_funcion], [id_butaca], [id_Estado]) VALUES (6, 5, 27, 1)
SET IDENTITY_INSERT [dbo].[ENTRADAS] OFF
SET IDENTITY_INSERT [dbo].[Estados] ON 

INSERT [dbo].[Estados] ([id_Estado], [Estado]) VALUES (1, N'Libre')
INSERT [dbo].[Estados] ([id_Estado], [Estado]) VALUES (2, N'Ocupado')
SET IDENTITY_INSERT [dbo].[Estados] OFF
SET IDENTITY_INSERT [dbo].[Funcion_horarios] ON 

INSERT [dbo].[Funcion_horarios] ([id_horario], [Horario]) VALUES (1, N'10hs')
INSERT [dbo].[Funcion_horarios] ([id_horario], [Horario]) VALUES (2, N'14hs')
INSERT [dbo].[Funcion_horarios] ([id_horario], [Horario]) VALUES (3, N'16hs')
INSERT [dbo].[Funcion_horarios] ([id_horario], [Horario]) VALUES (4, N'18hs')
INSERT [dbo].[Funcion_horarios] ([id_horario], [Horario]) VALUES (5, N'20hs')
INSERT [dbo].[Funcion_horarios] ([id_horario], [Horario]) VALUES (6, N'22hs')
SET IDENTITY_INSERT [dbo].[Funcion_horarios] OFF
SET IDENTITY_INSERT [dbo].[Funciones] ON 

INSERT [dbo].[Funciones] ([id_funcion], [id_pelicula], [id_horario], [id_idioma], [id_subtitulo]) VALUES (1, 2, 1, 2, 2)
INSERT [dbo].[Funciones] ([id_funcion], [id_pelicula], [id_horario], [id_idioma], [id_subtitulo]) VALUES (2, 1, 3, 1, 3)
INSERT [dbo].[Funciones] ([id_funcion], [id_pelicula], [id_horario], [id_idioma], [id_subtitulo]) VALUES (3, 4, 4, 3, 2)
INSERT [dbo].[Funciones] ([id_funcion], [id_pelicula], [id_horario], [id_idioma], [id_subtitulo]) VALUES (4, 5, 3, 3, 1)
INSERT [dbo].[Funciones] ([id_funcion], [id_pelicula], [id_horario], [id_idioma], [id_subtitulo]) VALUES (5, 12, 6, 3, 1)
SET IDENTITY_INSERT [dbo].[Funciones] OFF
SET IDENTITY_INSERT [dbo].[Generos] ON 

INSERT [dbo].[Generos] ([id_genero], [genero]) VALUES (1, N'Terror')
INSERT [dbo].[Generos] ([id_genero], [genero]) VALUES (2, N'Ciencia Ficcion')
INSERT [dbo].[Generos] ([id_genero], [genero]) VALUES (3, N'Drama')
INSERT [dbo].[Generos] ([id_genero], [genero]) VALUES (4, N'Comedia')
INSERT [dbo].[Generos] ([id_genero], [genero]) VALUES (5, N'Documental')
INSERT [dbo].[Generos] ([id_genero], [genero]) VALUES (6, N'Musical')
INSERT [dbo].[Generos] ([id_genero], [genero]) VALUES (7, N'Accion')
INSERT [dbo].[Generos] ([id_genero], [genero]) VALUES (8, N'Animada')
SET IDENTITY_INSERT [dbo].[Generos] OFF
SET IDENTITY_INSERT [dbo].[Idiomas] ON 

INSERT [dbo].[Idiomas] ([id_idioma], [idioma]) VALUES (1, N'Ingles')
INSERT [dbo].[Idiomas] ([id_idioma], [idioma]) VALUES (2, N'Español')
INSERT [dbo].[Idiomas] ([id_idioma], [idioma]) VALUES (3, N'Esperanto')
INSERT [dbo].[Idiomas] ([id_idioma], [idioma]) VALUES (4, N'Italiano')
INSERT [dbo].[Idiomas] ([id_idioma], [idioma]) VALUES (5, N'Frances')
SET IDENTITY_INSERT [dbo].[Idiomas] OFF
SET IDENTITY_INSERT [dbo].[Metodo_pagos] ON 

INSERT [dbo].[Metodo_pagos] ([id_metodo_pago], [metodo_pago]) VALUES (1, N'Efectivo')
INSERT [dbo].[Metodo_pagos] ([id_metodo_pago], [metodo_pago]) VALUES (2, N'Tarjeta Credito')
INSERT [dbo].[Metodo_pagos] ([id_metodo_pago], [metodo_pago]) VALUES (3, N'Tarjeta Debito')
INSERT [dbo].[Metodo_pagos] ([id_metodo_pago], [metodo_pago]) VALUES (4, N'Voucher')
SET IDENTITY_INSERT [dbo].[Metodo_pagos] OFF
SET IDENTITY_INSERT [dbo].[Peliculas] ON 

INSERT [dbo].[Peliculas] ([id_pelicula], [Pelicula], [descripcion], [id_genero], [id_clasificacion]) VALUES (1, N'Zoolander 2', N'Comedia Loca', 4, 1)
INSERT [dbo].[Peliculas] ([id_pelicula], [Pelicula], [descripcion], [id_genero], [id_clasificacion]) VALUES (2, N'Dragon Ball Super', N'Anime Locx', 8, 1)
INSERT [dbo].[Peliculas] ([id_pelicula], [Pelicula], [descripcion], [id_genero], [id_clasificacion]) VALUES (3, N'El Exorcista', N'Terror Locx', 1, 4)
INSERT [dbo].[Peliculas] ([id_pelicula], [Pelicula], [descripcion], [id_genero], [id_clasificacion]) VALUES (4, N'Terminator 3', N'Accion Locx', 7, 3)
INSERT [dbo].[Peliculas] ([id_pelicula], [Pelicula], [descripcion], [id_genero], [id_clasificacion]) VALUES (5, N'El Gran Dragon Blaco', N'Pelea Locx', 7, 3)
INSERT [dbo].[Peliculas] ([id_pelicula], [Pelicula], [descripcion], [id_genero], [id_clasificacion]) VALUES (8, N'X Movie 1999', N'Pelicula de Anime destinada a publica adulto', 8, 4)
INSERT [dbo].[Peliculas] ([id_pelicula], [Pelicula], [descripcion], [id_genero], [id_clasificacion]) VALUES (9, N'Manolito', N'Una pelicula casi alegre para toda la familiaaaaaaaaaaaaaaaaaaaaaa jojo', 4, 3)
INSERT [dbo].[Peliculas] ([id_pelicula], [Pelicula], [descripcion], [id_genero], [id_clasificacion]) VALUES (11, N'La Genial Movie', N'Pues eso, es una genial movie (?)', 2, 2)
INSERT [dbo].[Peliculas] ([id_pelicula], [Pelicula], [descripcion], [id_genero], [id_clasificacion]) VALUES (12, N'Nueva Peli', N'Es una nueva peli que esta siendo cargada para ser re pro', 4, 4)
SET IDENTITY_INSERT [dbo].[Peliculas] OFF
SET IDENTITY_INSERT [dbo].[Salas] ON 

INSERT [dbo].[Salas] ([id_sala], [id_tipo_sala], [sala]) VALUES (1, 1, N'1')
INSERT [dbo].[Salas] ([id_sala], [id_tipo_sala], [sala]) VALUES (2, 1, N'2')
INSERT [dbo].[Salas] ([id_sala], [id_tipo_sala], [sala]) VALUES (3, 3, N'3')
INSERT [dbo].[Salas] ([id_sala], [id_tipo_sala], [sala]) VALUES (4, 2, N'4')
INSERT [dbo].[Salas] ([id_sala], [id_tipo_sala], [sala]) VALUES (5, 1, N'5')
SET IDENTITY_INSERT [dbo].[Salas] OFF
SET IDENTITY_INSERT [dbo].[subtitulos] ON 

INSERT [dbo].[subtitulos] ([id_subtitulo], [subtitulo]) VALUES (1, N'Ninguno')
INSERT [dbo].[subtitulos] ([id_subtitulo], [subtitulo]) VALUES (2, N'Español')
INSERT [dbo].[subtitulos] ([id_subtitulo], [subtitulo]) VALUES (3, N'Ingles')
SET IDENTITY_INSERT [dbo].[subtitulos] OFF
SET IDENTITY_INSERT [dbo].[TICKETS] ON 

INSERT [dbo].[TICKETS] ([id_Ticket], [id_caja], [id_tipo_cliente], [id_metodo_pago], [Fecha]) VALUES (1, 4, 1, 1, CAST(N'2016-10-07T00:00:00.000' AS DateTime))
INSERT [dbo].[TICKETS] ([id_Ticket], [id_caja], [id_tipo_cliente], [id_metodo_pago], [Fecha]) VALUES (2, 3, 4, 2, CAST(N'2016-08-30T00:00:00.000' AS DateTime))
INSERT [dbo].[TICKETS] ([id_Ticket], [id_caja], [id_tipo_cliente], [id_metodo_pago], [Fecha]) VALUES (3, 1, 1, 3, CAST(N'2015-09-02T00:00:00.000' AS DateTime))
INSERT [dbo].[TICKETS] ([id_Ticket], [id_caja], [id_tipo_cliente], [id_metodo_pago], [Fecha]) VALUES (4, 2, 2, 4, CAST(N'2013-12-30T00:00:00.000' AS DateTime))
INSERT [dbo].[TICKETS] ([id_Ticket], [id_caja], [id_tipo_cliente], [id_metodo_pago], [Fecha]) VALUES (5, 5, 2, 2, CAST(N'2016-01-01T00:00:00.000' AS DateTime))
INSERT [dbo].[TICKETS] ([id_Ticket], [id_caja], [id_tipo_cliente], [id_metodo_pago], [Fecha]) VALUES (6, 1, 1, 2, CAST(N'2011-06-19T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[TICKETS] OFF
SET IDENTITY_INSERT [dbo].[Tipo_cajas] ON 

INSERT [dbo].[Tipo_cajas] ([id_tipo_caja], [Tipo]) VALUES (1, N'Caja Normal')
INSERT [dbo].[Tipo_cajas] ([id_tipo_caja], [Tipo]) VALUES (2, N'Caja Preferencial')
INSERT [dbo].[Tipo_cajas] ([id_tipo_caja], [Tipo]) VALUES (3, N'Caja Socios')
SET IDENTITY_INSERT [dbo].[Tipo_cajas] OFF
SET IDENTITY_INSERT [dbo].[Tipo_Clientes] ON 

INSERT [dbo].[Tipo_Clientes] ([id_tipo_cliente], [tipo_cliente]) VALUES (1, N'Consumidor Final')
INSERT [dbo].[Tipo_Clientes] ([id_tipo_cliente], [tipo_cliente]) VALUES (2, N'Responsable Inscrp')
INSERT [dbo].[Tipo_Clientes] ([id_tipo_cliente], [tipo_cliente]) VALUES (3, N'Exento')
INSERT [dbo].[Tipo_Clientes] ([id_tipo_cliente], [tipo_cliente]) VALUES (4, N'Monotributista')
SET IDENTITY_INSERT [dbo].[Tipo_Clientes] OFF
SET IDENTITY_INSERT [dbo].[Tipo_Documentos] ON 

INSERT [dbo].[Tipo_Documentos] ([id_tipo_documento], [tipo_documento]) VALUES (1, N'DNI')
INSERT [dbo].[Tipo_Documentos] ([id_tipo_documento], [tipo_documento]) VALUES (2, N'DU')
INSERT [dbo].[Tipo_Documentos] ([id_tipo_documento], [tipo_documento]) VALUES (3, N'Pasaporte')
INSERT [dbo].[Tipo_Documentos] ([id_tipo_documento], [tipo_documento]) VALUES (4, N'Libreta Civica')
SET IDENTITY_INSERT [dbo].[Tipo_Documentos] OFF
SET IDENTITY_INSERT [dbo].[tipo_Salas] ON 

INSERT [dbo].[tipo_Salas] ([id_tipo_sala], [tipo]) VALUES (1, N'Normal')
INSERT [dbo].[tipo_Salas] ([id_tipo_sala], [tipo]) VALUES (2, N'3D')
INSERT [dbo].[tipo_Salas] ([id_tipo_sala], [tipo]) VALUES (3, N'4D')
SET IDENTITY_INSERT [dbo].[tipo_Salas] OFF
ALTER TABLE [dbo].[BUTACAS]  WITH CHECK ADD  CONSTRAINT [id_sala_fk] FOREIGN KEY([id_sala])
REFERENCES [dbo].[Salas] ([id_sala])
GO
ALTER TABLE [dbo].[BUTACAS] CHECK CONSTRAINT [id_sala_fk]
GO
ALTER TABLE [dbo].[Cajas]  WITH CHECK ADD  CONSTRAINT [empleado_fk] FOREIGN KEY([id_empleado])
REFERENCES [dbo].[Empleados] ([id_empleado])
GO
ALTER TABLE [dbo].[Cajas] CHECK CONSTRAINT [empleado_fk]
GO
ALTER TABLE [dbo].[Cajas]  WITH CHECK ADD  CONSTRAINT [tipo_caja_fk] FOREIGN KEY([id_tipo_caja])
REFERENCES [dbo].[Tipo_cajas] ([id_tipo_caja])
GO
ALTER TABLE [dbo].[Cajas] CHECK CONSTRAINT [tipo_caja_fk]
GO
ALTER TABLE [dbo].[detalle_Tickets]  WITH CHECK ADD  CONSTRAINT [entrada_FK] FOREIGN KEY([id_entrada])
REFERENCES [dbo].[ENTRADAS] ([id_entrada])
GO
ALTER TABLE [dbo].[detalle_Tickets] CHECK CONSTRAINT [entrada_FK]
GO
ALTER TABLE [dbo].[detalle_Tickets]  WITH CHECK ADD  CONSTRAINT [ticket_FK] FOREIGN KEY([id_Ticket])
REFERENCES [dbo].[TICKETS] ([id_Ticket])
GO
ALTER TABLE [dbo].[detalle_Tickets] CHECK CONSTRAINT [ticket_FK]
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [Tipo_Documentos_id_fk] FOREIGN KEY([id_tipo_documento])
REFERENCES [dbo].[Tipo_Documentos] ([id_tipo_documento])
GO
ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [Tipo_Documentos_id_fk]
GO
ALTER TABLE [dbo].[ENTRADAS]  WITH CHECK ADD  CONSTRAINT [butaca_fk] FOREIGN KEY([id_butaca])
REFERENCES [dbo].[BUTACAS] ([id_butaca])
GO
ALTER TABLE [dbo].[ENTRADAS] CHECK CONSTRAINT [butaca_fk]
GO
ALTER TABLE [dbo].[ENTRADAS]  WITH CHECK ADD  CONSTRAINT [estado_fk] FOREIGN KEY([id_Estado])
REFERENCES [dbo].[Estados] ([id_Estado])
GO
ALTER TABLE [dbo].[ENTRADAS] CHECK CONSTRAINT [estado_fk]
GO
ALTER TABLE [dbo].[ENTRADAS]  WITH CHECK ADD  CONSTRAINT [funcion_fk] FOREIGN KEY([id_funcion])
REFERENCES [dbo].[Funciones] ([id_funcion])
GO
ALTER TABLE [dbo].[ENTRADAS] CHECK CONSTRAINT [funcion_fk]
GO
ALTER TABLE [dbo].[Funciones]  WITH CHECK ADD  CONSTRAINT [horario_fk] FOREIGN KEY([id_horario])
REFERENCES [dbo].[Funcion_horarios] ([id_horario])
GO
ALTER TABLE [dbo].[Funciones] CHECK CONSTRAINT [horario_fk]
GO
ALTER TABLE [dbo].[Funciones]  WITH CHECK ADD  CONSTRAINT [idioma_fk] FOREIGN KEY([id_idioma])
REFERENCES [dbo].[Idiomas] ([id_idioma])
GO
ALTER TABLE [dbo].[Funciones] CHECK CONSTRAINT [idioma_fk]
GO
ALTER TABLE [dbo].[Funciones]  WITH CHECK ADD  CONSTRAINT [pelicula_fk] FOREIGN KEY([id_pelicula])
REFERENCES [dbo].[Peliculas] ([id_pelicula])
GO
ALTER TABLE [dbo].[Funciones] CHECK CONSTRAINT [pelicula_fk]
GO
ALTER TABLE [dbo].[Funciones]  WITH CHECK ADD  CONSTRAINT [subtitulo_fk] FOREIGN KEY([id_subtitulo])
REFERENCES [dbo].[subtitulos] ([id_subtitulo])
GO
ALTER TABLE [dbo].[Funciones] CHECK CONSTRAINT [subtitulo_fk]
GO
ALTER TABLE [dbo].[Peliculas]  WITH CHECK ADD  CONSTRAINT [clasificacion_fk] FOREIGN KEY([id_clasificacion])
REFERENCES [dbo].[Clasificaciones] ([id_clasificacion])
GO
ALTER TABLE [dbo].[Peliculas] CHECK CONSTRAINT [clasificacion_fk]
GO
ALTER TABLE [dbo].[Peliculas]  WITH CHECK ADD  CONSTRAINT [genero_fk] FOREIGN KEY([id_genero])
REFERENCES [dbo].[Generos] ([id_genero])
GO
ALTER TABLE [dbo].[Peliculas] CHECK CONSTRAINT [genero_fk]
GO
ALTER TABLE [dbo].[Salas]  WITH CHECK ADD  CONSTRAINT [tipo_sala_FK] FOREIGN KEY([id_tipo_sala])
REFERENCES [dbo].[tipo_Salas] ([id_tipo_sala])
GO
ALTER TABLE [dbo].[Salas] CHECK CONSTRAINT [tipo_sala_FK]
GO
ALTER TABLE [dbo].[TICKETS]  WITH CHECK ADD  CONSTRAINT [caja_fk] FOREIGN KEY([id_caja])
REFERENCES [dbo].[Cajas] ([id_caja])
GO
ALTER TABLE [dbo].[TICKETS] CHECK CONSTRAINT [caja_fk]
GO
ALTER TABLE [dbo].[TICKETS]  WITH CHECK ADD  CONSTRAINT [metodo_pago_fk] FOREIGN KEY([id_metodo_pago])
REFERENCES [dbo].[Metodo_pagos] ([id_metodo_pago])
GO
ALTER TABLE [dbo].[TICKETS] CHECK CONSTRAINT [metodo_pago_fk]
GO
ALTER TABLE [dbo].[TICKETS]  WITH CHECK ADD  CONSTRAINT [tipo_cliente_fk] FOREIGN KEY([id_tipo_cliente])
REFERENCES [dbo].[Tipo_Clientes] ([id_tipo_cliente])
GO
ALTER TABLE [dbo].[TICKETS] CHECK CONSTRAINT [tipo_cliente_fk]
GO
/****** Object:  StoredProcedure [dbo].[consulta1_proc]    Script Date: 25/11/2016 9:56:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[consulta1_proc]
@fechaingreso int = 2015
as
SELECT sum(precio) 'Facturacion Total del año'
FROM detalle_tickets dt JOIN
tickets t ON t.id_ticket=dt.id_ticket
WHERE year(fecha)=@fechaingreso

GO
/****** Object:  StoredProcedure [dbo].[consulta3_proc]    Script Date: 25/11/2016 9:56:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[consulta3_proc]
@apellido varchar(20)='%'
as
SELECT e.apellido+','+e.nombre 'Empleado', count(*)'Cantidad vendidas',
 p.pelicula 'Pelicula', 
 Convert(varchar,t.fecha,103) 'Fecha',
 m.metodo_pago 'Metodo de pago del cliente'
FROM empleados e JOIN
cajas c ON c.id_empleado=e.id_empleado JOIN
tickets t ON c.id_caja=t.id_caja join
detalle_tickets dt ON dt.id_ticket=t.id_ticket JOIN
entradas ent ON ent.id_entrada=dt.id_entrada JOIN
funciones f ON f.id_funcion=ent.id_funcion JOIN
peliculas p ON p.id_pelicula=f.id_pelicula JOIN
metodo_pagos m ON m.id_metodo_pago=t.id_metodo_pago
where e.apellido like @apellido
GROUP BY e.apellido+','+e.nombre, p.pelicula,Convert(varchar,t.fecha,103), m.metodo_pago

GO
/****** Object:  StoredProcedure [dbo].[consulta4_proc]    Script Date: 25/11/2016 9:56:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[consulta4_proc]
@empleado varchar(20) = 'brenda'
as
Select c.id_caja 'Caja numero',
tc.tipo 'Caja Tipo',
em.nombre 'Empleado'
from cajas c join tipo_cajas tc on c.id_tipo_caja=tc.id_tipo_caja join empleados em 
on em.id_empleado=c.id_empleado
where @empleado not like(select e.nombre
			from empleados e
			where e.id_empleado=c.id_empleado)
GO
/****** Object:  StoredProcedure [dbo].[consulta5_poc]    Script Date: 25/11/2016 9:56:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[consulta5_poc]
@fechaingreso int = 2016
as
SELECT min(Convert(varchar,t.fecha,103)) 'Primera Venta', 
max(Convert(varchar,t.fecha,103)) 'Ultima Venta' ,
max(Precio) 'Entrada mas cara'
FROM tickets t JOIN 
Detalle_tickets d 
ON t.id_ticket=d.id_ticket
WHERE year(fecha)=@fechaingreso
GO
/****** Object:  StoredProcedure [dbo].[insertarPelicula]    Script Date: 25/11/2016 9:56:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertarPelicula]
@titulo varchar(20),
@genero int,
@clasificacion int,
@descripcion varchar(800)
as 
insert into peliculas(pelicula, id_genero,id_clasificacion ,descripcion)
values(@titulo,@genero,@clasificacion,@descripcion)
GO
USE [master]
GO
ALTER DATABASE [PracticoIntegrador_MMRP] SET  READ_WRITE 
GO
