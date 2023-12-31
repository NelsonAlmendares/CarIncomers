USE [master]
GO
/****** Object:  Database [CarIncome2]    Script Date: 12/11/2023 00:52:48 ******/
CREATE DATABASE [CarIncome2]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CarIncome2', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\CarIncome2.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CarIncome2_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\CarIncome2_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [CarIncome2] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CarIncome2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CarIncome2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CarIncome2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CarIncome2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CarIncome2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CarIncome2] SET ARITHABORT OFF 
GO
ALTER DATABASE [CarIncome2] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CarIncome2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CarIncome2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CarIncome2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CarIncome2] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CarIncome2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CarIncome2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CarIncome2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CarIncome2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CarIncome2] SET  ENABLE_BROKER 
GO
ALTER DATABASE [CarIncome2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CarIncome2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CarIncome2] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CarIncome2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CarIncome2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CarIncome2] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CarIncome2] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CarIncome2] SET RECOVERY FULL 
GO
ALTER DATABASE [CarIncome2] SET  MULTI_USER 
GO
ALTER DATABASE [CarIncome2] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CarIncome2] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CarIncome2] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CarIncome2] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CarIncome2] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CarIncome2] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'CarIncome2', N'ON'
GO
ALTER DATABASE [CarIncome2] SET QUERY_STORE = ON
GO
ALTER DATABASE [CarIncome2] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [CarIncome2]
GO
/****** Object:  Table [dbo].[RegistroVehiculo]    Script Date: 12/11/2023 00:52:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RegistroVehiculo](
	[ID_vehiculo] [int] IDENTITY(1,1) NOT NULL,
	[Numero_motor] [varchar](24) NOT NULL,
	[Numero_chasis] [varchar](24) NOT NULL,
	[Capacidad] [int] NOT NULL,
	[Kilometraje] [float] NOT NULL,
	[Transmicion] [varchar](100) NOT NULL,
	[Fecha_ingreso] [date] NOT NULL,
	[Valor_unidad] [float] NOT NULL,
	[Puertas] [varchar](10) NOT NULL,
	[Marca] [varchar](100) NOT NULL,
	[Modelo] [varchar](100) NOT NULL,
	[Anio] [varchar](100) NOT NULL,
	[Descripcion] [varchar](500) NOT NULL,
	[Equipaje] [varchar](10) NOT NULL,
	[Placa] [varchar](10) NOT NULL,
	[id_tipoVehiculo] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_vehiculo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoVehiculo]    Script Date: 12/11/2023 00:52:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoVehiculo](
	[ID_tipoVehiculo] [int] IDENTITY(1,1) NOT NULL,
	[tipo_vehiculo] [varchar](200) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_tipoVehiculo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Registro_Vehiculo]    Script Date: 12/11/2023 00:52:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Registro_Vehiculo] AS 
	SELECT Numero_motor AS 'Número de Motor', Numero_chasis AS 'Número de Chasis',tipo_vehiculo AS 'Tipo de Vehículo',
	CONCAT(Capacidad, ' Ocupantes') AS Capacidad, CONCAT(Kilometraje, ' KM') AS Kilometraje, Transmicion AS 'Transmición', Equipaje AS 'Capacidad de equipaje',
	Fecha_ingreso AS 'Ingresado en: ', CONCAT('$ ', Valor_unidad) AS 'Precio por Día', Marca, Modelo, Anio AS 'Año del Vehículo', Descripcion
FROM [dbo].[RegistroVehiculo]
INNER JOIN [dbo].[TipoVehiculo] ON [dbo].[RegistroVehiculo].id_tipoVehiculo = [dbo].[TipoVehiculo].ID_tipoVehiculo;
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 12/11/2023 00:52:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[ID_usuario] [int] IDENTITY(2023001,1) NOT NULL,
	[Nombre_usuario] [varchar](120) NOT NULL,
	[Apellido_usuario] [varchar](120) NOT NULL,
	[Documento] [varchar](14) NOT NULL,
	[Password_usuario] [varchar](1000) NOT NULL,
	[Edad_usuario] [int] NOT NULL,
	[Telefono_usuario] [varchar](12) NULL,
	[Celular_usuario] [varchar](12) NOT NULL,
	[Numero_tarjeta] [varchar](12) NULL,
	[Fecha_tarjeta] [date] NULL,
	[ID_estadoUsuario] [int] NOT NULL,
	[ID_tipoUsuario] [int] NOT NULL,
	[Acceso_usuario] [varchar](100) NOT NULL,
	[Fecha_Registro] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Solicitudes]    Script Date: 12/11/2023 00:52:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Solicitudes](
	[ID_solicitud] [int] IDENTITY(1,1) NOT NULL,
	[id_cliente] [int] NOT NULL,
	[id_estadoSolicitud] [int] NOT NULL,
	[id_vehiculo] [int] NOT NULL,
	[Fecha_inicio] [date] NOT NULL,
	[Fecha_fin] [date] NOT NULL,
	[Hora_inicio] [time](7) NOT NULL,
	[Hora_fin] [time](7) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_solicitud] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EstadoSolicitud]    Script Date: 12/11/2023 00:52:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EstadoSolicitud](
	[ID_estadoSolicitud] [int] IDENTITY(1,1) NOT NULL,
	[estado_solicitud] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_estadoSolicitud] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Select_Solicitud]    Script Date: 12/11/2023 00:52:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Select_Solicitud] AS 
SELECT ID_solicitud AS ID,  CONCAT(Nombre_usuario, ' ', Apellido_usuario) AS 'Cliente Solicitante', 
	CONCAT(Marca, ' ', Modelo, ' - Año ',' ', Anio) AS Vehiculo, estado_solicitud AS 'Estado de la Solicitud',
	Fecha_inicio AS 'Inicio de Renta', Fecha_fin AS 'Fecha de finalizacion', 
	CONCAT ( CONVERT (varchar, Hora_inicio, 108), ' ' ,
		CASE
			WHEN DATEPART (HOUR, Hora_inicio) >= 12 THEN ' PM '
			ELSE ' AM '
			END
		) AS 'Hora de inicio',
	CONCAT ( CONVERT (varchar, Hora_fin, 108), ' ',
		CASE
			WHEN DATEPART (HOUR, Hora_fin) >= 12 THEN ' PM '
			ELSE ' AM '
			END
		) AS 'Hora de finalilzación'
FROM [dbo].[Solicitudes]
INNER JOIN [dbo].[Usuario] ON [dbo].[Usuario].ID_usuario = [dbo].[Solicitudes].id_cliente
INNER JOIN [dbo].[EstadoSolicitud] ON [dbo].[Solicitudes].id_estadoSolicitud = [dbo].[EstadoSolicitud].ID_estadoSolicitud
INNER JOIN [dbo].[RegistroVehiculo] ON [dbo].[Solicitudes].id_vehiculo = [dbo].[RegistroVehiculo].ID_vehiculo;
GO
/****** Object:  Table [dbo].[Facturacion]    Script Date: 12/11/2023 00:52:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Facturacion](
	[ID_factura] [int] IDENTITY(1,1) NOT NULL,
	[Id_solicitud] [int] NOT NULL,
	[Kilometraje_vehiculo] [float] NOT NULL,
	[Hora_salida] [time](7) NOT NULL,
	[Fecha_salida] [date] NOT NULL,
	[Detalles_vehiculo] [varchar](500) NULL,
	[Numero_tarjeta] [varchar](1000) NOT NULL,
	[Pin_tarjeta] [varchar](1000) NOT NULL,
	[Poliza_seguro] [int] NULL,
	[Tipo_tarjeta] [int] NOT NULL,
	[Equipamentos] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Equipamentos]    Script Date: 12/11/2023 00:52:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Equipamentos](
	[ID_equipamento] [int] IDENTITY(1,1) NOT NULL,
	[nombre_equipamento] [varchar](100) NOT NULL,
	[descripcion_equipamento] [varchar](250) NOT NULL,
	[precio_equipamento] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_equipamento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoSeguro]    Script Date: 12/11/2023 00:52:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoSeguro](
	[ID_tipoSeguro] [int] IDENTITY(1,1) NOT NULL,
	[poliza_seguro] [varchar](100) NULL,
	[descripcion_poliza] [varchar](250) NOT NULL,
	[precio_poliza] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_tipoSeguro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reingreso]    Script Date: 12/11/2023 00:52:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reingreso](
	[ID_reingreso] [int] IDENTITY(1,1) NOT NULL,
	[id_factura] [int] NOT NULL,
	[Kilometraje] [float] NULL,
	[Hora_entrada] [time](7) NULL,
	[Fecha_Entrada] [date] NULL,
	[Detalles] [varchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_reingreso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Reingresos]    Script Date: 12/11/2023 00:52:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Reingresos] AS 
	SELECT [dbo].[Facturacion].ID_factura AS 'Número de Factura', CONCAT(Nombre_usuario, ' ', Apellido_usuario) AS 'Rentado por: ', CONCAT (Marca, ' ', Modelo) AS 'Vehículo Rentado',
	nombre_equipamento AS 'Con el equipamento de:', [dbo].[TipoSeguro].poliza_seguro AS 'y El seguro de: ', Fecha_inicio AS 'Desde la fecha de: ', Fecha_fin AS 'hasta: ', Detalles AS 'Detalles de Reingreso',
	Fecha_Entrada AS 'Entregado el día: ',
	CONCAT( CONVERT(varchar, Hora_entrada, 108), ' ', 
		CASE
			WHEN DATEPART(HOUR, Hora_entrada) >= 12 THEN ' PM '
			ELSE ' AM '
			END
		) AS 'Entregado a las: ',
	CONCAT(([dbo].[Reingreso].Kilometraje - Kilometraje_vehiculo), ' KM') AS 'Millaje registrado'
	FROM [dbo].[Reingreso]
	INNER JOIN [dbo].[Facturacion] ON [dbo].[Reingreso].id_factura = [dbo].[Facturacion].ID_factura
	INNER JOIN [dbo].[Solicitudes] ON [dbo].[Facturacion].Id_solicitud = [dbo].[Solicitudes].ID_solicitud
	INNER JOIN [dbo].[Usuario] ON [dbo].[Solicitudes].id_cliente = [dbo].[Usuario].ID_usuario
	INNER JOIN [dbo].[RegistroVehiculo] ON [dbo].[Solicitudes].id_vehiculo = [dbo].[RegistroVehiculo].ID_vehiculo
	INNER JOIN [dbo].[TipoSeguro] ON [dbo].[Facturacion].Poliza_seguro = [dbo].[TipoSeguro].ID_tipoSeguro
	INNER JOIN [dbo].[Equipamentos] ON [dbo].[Facturacion].Equipamentos = [dbo].[Equipamentos].ID_equipamento;
GO
/****** Object:  View [dbo].[GetFactura]    Script Date: 12/11/2023 00:52:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[GetFactura] AS 
SELECT ID_factura AS 'Código de Factura', CONCAT ('Factura: ', ID_factura, ', Cliente: ', ID_usuario, ' - ',Marca, ' ', Modelo) AS 'Vehículo'
	FROM [dbo].[Facturacion]
INNER JOIN [dbo].[Solicitudes] ON [dbo].[Facturacion].Id_solicitud = [dbo].[Solicitudes].ID_solicitud
INNER JOIN [dbo].[Usuario] ON [dbo].[Solicitudes].id_cliente = [dbo].[Usuario].ID_usuario
INNER JOIN [dbo].[RegistroVehiculo] ON [dbo].[Solicitudes].id_vehiculo = [dbo].[RegistroVehiculo].ID_vehiculo;
GO
/****** Object:  View [dbo].[Factura_Final]    Script Date: 12/11/2023 00:52:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Factura_Final] AS 
SELECT [dbo].[Facturacion].ID_factura AS 'Codigo_Factura', ID_usuario AS 'Num_registro', CONCAT(Nombre_usuario, ' ', Apellido_usuario) AS 'Nombre_Cliente', CONCAT (Marca, ' ', Modelo, ' - ', Anio) AS 'Vehiculo', 
	CONCAT(DATEDIFF (DAY,Fecha_inicio, Fecha_fin), ' dias') AS 'Dias_rentado', CONCAT('$ ', Valor_unidad) AS 'Precio_dia', Fecha_inicio AS 'Rentado_desde', 
	CONCAT( CONVERT(varchar, Hora_inicio, 108), ' ', 
		CASE
			WHEN DATEPART(HOUR, Hora_inicio) >= 12 THEN 'PM'
			ELSE 'AM'
			END
		) AS 'Entregado_desde',
	CONCAT( CONVERT(varchar, Hora_fin, 108), ' ', 
		CASE
			WHEN DATEPART(HOUR, Hora_fin) >= 12 THEN 'PM'
			ELSE ' AM '
			END
		) AS 'Hasta_la_hora', Fecha_fin AS 'del_dia',

	[dbo].[TipoSeguro].poliza_seguro AS 'Seguro', CONCAT('$ ', precio_poliza) AS  'Precio_Seguro', nombre_equipamento AS 'Equimamento', CONCAT('$', precio_equipamento) AS 'Precio_del_equipamento',
	CONCAT('$ ', Valor_unidad * DATEDIFF (DAY,Fecha_inicio, Fecha_fin) + (precio_equipamento + precio_poliza) + (Valor_unidad * DATEDIFF (DAY,Fecha_inicio, Fecha_fin) + (precio_equipamento + precio_poliza)) * 13/100)AS 'Precio_factura',
	CASE 
		WHEN DATEDIFF (DAY,Fecha_salida, Fecha_Entrada) > 0 THEN CONCAT('$', Valor_unidad * DATEDIFF (DAY,Fecha_inicio, Fecha_fin) + (precio_equipamento + precio_poliza) + 
		(Valor_unidad * DATEDIFF (DAY,Fecha_inicio, Fecha_fin) + (precio_equipamento + precio_poliza)) * 13/100 + Valor_unidad * DATEDIFF (DAY,Fecha_fin, Fecha_Entrada))
		ELSE 'Sin_mora'
	END AS 'Total_mora'
FROM [dbo].[Facturacion]
INNER JOIN [dbo].[Solicitudes] ON [dbo].[Facturacion].Id_solicitud = [dbo].[Solicitudes].ID_solicitud
INNER JOIN [dbo].[Usuario] ON [dbo].[Solicitudes].id_cliente = [dbo].[Usuario].ID_usuario
INNER JOIN [dbo].[RegistroVehiculo] ON [dbo].[Solicitudes].id_vehiculo = [dbo].[RegistroVehiculo].ID_vehiculo
INNER JOIN [dbo].[TipoSeguro] ON [dbo].[Facturacion].Poliza_seguro = [dbo].[TipoSeguro].ID_tipoSeguro
INNER JOIN [dbo].[Equipamentos] ON [dbo].[Facturacion].Equipamentos = [dbo].[Equipamentos].ID_equipamento
INNER JOIN [dbo].[Reingreso] ON [dbo].[Facturacion].ID_factura = [dbo].[Reingreso].id_factura;
GO
/****** Object:  View [dbo].[Factura]    Script Date: 12/11/2023 00:52:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Factura] AS SELECT [dbo].[Solicitudes].ID_solicitud AS 'Número de Solicitud', CONCAT(Nombre_usuario, ' ', Apellido_usuario) AS Solicitante,
	CONCAT( CONVERT(varchar, Hora_salida, 108), ' ', 
		CASE
			WHEN DATEPART(HOUR, Hora_salida) >= 12 THEN ' PM '
			ELSE ' AM '
			END
		) AS 'Entregado a las: ', Kilometraje_vehiculo AS 'Entregado con el kilometraje de: ', Fecha_salida AS 'El día: ', nombre_equipamento AS 'Equipo adquirido: ', 
		[dbo].[TipoSeguro].poliza_seguro AS 'Tipo de seguro adquirido: '
	FROM [dbo].[Facturacion]
INNER JOIN [dbo].[Solicitudes] ON [dbo].[Solicitudes].ID_solicitud = [dbo].[Facturacion].Id_solicitud
INNER JOIN [dbo].[TipoSeguro] ON [dbo].[TipoSeguro].ID_tipoSeguro = [dbo].[Facturacion].Poliza_seguro
INNER JOIN [dbo].[Equipamentos] ON [dbo].[Equipamentos].ID_equipamento = [dbo].[Facturacion].Equipamentos
INNER JOIN [dbo].[Usuario] ON [dbo].[Usuario].ID_usuario = [dbo].[Solicitudes].id_cliente;
GO
/****** Object:  View [dbo].[Vehiculo]    Script Date: 12/11/2023 00:52:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Vehiculo] AS 
SELECT ID_solicitud AS ID,  CONCAT(Nombre_usuario, ' ', Apellido_usuario) AS 'Cliente Solicitante', 
	-- Detalles del Vehículo
	CONCAT(Marca, ' ', Modelo) AS Vehiculo, tipo_vehiculo AS 'Tipo de Vehículo', Transmicion, Anio AS 'Año del Vehículo',
	-- Detalles de renta
	Fecha_inicio AS 'Inicio de Renta', 
	FORMAT (Fecha_fin, 'dd/MM/yyyy') AS 'Fecha de finalizacion',
	CONCAT ( CONVERT (varchar, Hora_inicio, 108), ' ' ,
		CASE
			WHEN DATEPART (HOUR, Hora_inicio) >= 12 THEN ' PM '
			ELSE ' AM '
			END
		) AS 'Hora de inicio',
	CONCAT ( CONVERT (varchar, Hora_fin, 108), ' ',
		CASE
			WHEN DATEPART (HOUR, Hora_fin) >= 12 THEN ' PM '
			ELSE ' AM '
			END
		) AS 'Hora de finalilzación', estado_solicitud, id_cliente
FROM [dbo].[Solicitudes]
INNER JOIN [dbo].[Usuario] ON [dbo].[Usuario].ID_usuario = [dbo].[Solicitudes].id_cliente
INNER JOIN [dbo].[EstadoSolicitud] ON [dbo].[Solicitudes].id_estadoSolicitud = [dbo].[EstadoSolicitud].ID_estadoSolicitud
INNER JOIN [dbo].[RegistroVehiculo] ON [dbo].[Solicitudes].id_vehiculo = [dbo].[RegistroVehiculo].ID_vehiculo
INNER JOIN [dbo].[TipoVehiculo] ON [dbo].[TipoVehiculo].ID_tipoVehiculo= [RegistroVehiculo].id_tipoVehiculo;
GO
/****** Object:  Table [dbo].[TipoUsuario]    Script Date: 12/11/2023 00:52:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoUsuario](
	[ID_tipoUsuario] [int] IDENTITY(1,1) NOT NULL,
	[tipo_Usuario] [varchar](100) NOT NULL,
	[descripcion_usuario] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_tipoUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EstadoUsuario]    Script Date: 12/11/2023 00:52:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EstadoUsuario](
	[ID_estadoUsuario] [int] IDENTITY(1,1) NOT NULL,
	[estado_usuario] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_estadoUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[LoginUser]    Script Date: 12/11/2023 00:52:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[LoginUser] AS 
SELECT ID_usuario AS ID, Acceso_usuario AS 'Usuario', Password_usuario, CONCAT(Nombre_usuario, ' ', Apellido_usuario) AS 'Nombre Completo', tipo_Usuario AS Rol, 
	CONCAT('+503 ', STUFF(Celular_usuario, LEN(Celular_usuario) -3, 0, '-')) as Celular , CONCAT('+503 ', STUFF(Telefono_usuario, LEN(Telefono_usuario) -3, 0, '-')) AS Teléfono,
	estado_usuario AS 'Estado del usuario', Numero_tarjeta AS 'Número de Licencia'
FROM [dbo].[Usuario]
INNER JOIN [dbo].[EstadoUsuario] ON [dbo].[EstadoUsuario].ID_estadoUsuario = [dbo].[Usuario].ID_estadoUsuario
INNER JOIN [dbo].[TipoUsuario] ON [dbo].[Usuario].ID_tipoUsuario = [dbo].[TipoUsuario].ID_tipoUsuario;
GO
/****** Object:  View [dbo].[Complete_User]    Script Date: 12/11/2023 00:52:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Complete_User] AS SELECT ID_usuario AS ID, Acceso_usuario AS 'Usuario', CONCAT(Nombre_usuario, ' ', Apellido_usuario) AS 'Nombre Completo', STUFF(Documento, LEN(Documento) -0 ,0, '-') AS 'Documento Único de Identidad', Edad_usuario as Edad,tipo_Usuario AS Rol, 
	CONCAT('+503 ', STUFF(Celular_usuario, LEN(Celular_usuario) -3, 0, '-')) as Celular , CONCAT('+503 ', STUFF(Telefono_usuario, LEN(Telefono_usuario) -3, 0, '-')) AS Teléfono,
	estado_usuario AS 'Estado del usuario', Numero_tarjeta AS 'Número de Licencia', Fecha_tarjeta AS 'Vencimiento de Tarjeta', Fecha_Registro AS 'Fecha de Registro'
FROM [dbo].[Usuario]
INNER JOIN [dbo].[EstadoUsuario] ON [dbo].[EstadoUsuario].ID_estadoUsuario = [dbo].[Usuario].ID_estadoUsuario
INNER JOIN [dbo].[TipoUsuario] ON [dbo].[Usuario].ID_tipoUsuario = [dbo].[TipoUsuario].ID_tipoUsuario;
GO
/****** Object:  Table [dbo].[availability]    Script Date: 12/11/2023 00:52:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[availability](
	[id_availability] [int] IDENTITY(1,1) NOT NULL,
	[book__availability] [varchar](100) NOT NULL,
 CONSTRAINT [PK_availability] PRIMARY KEY CLUSTERED 
(
	[id_availability] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[bills]    Script Date: 12/11/2023 00:52:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bills](
	[id_bill] [int] IDENTITY(1,1) NOT NULL,
	[sale__correlative] [int] NOT NULL,
	[quantity] [int] NOT NULL,
	[date__issue] [date] NOT NULL,
	[comments] [varchar](200) NULL,
	[id_sale] [int] NOT NULL,
	[id_client] [int] NOT NULL,
 CONSTRAINT [PK_bill] PRIMARY KEY CLUSTERED 
(
	[id_bill] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[brand]    Script Date: 12/11/2023 00:52:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[brand](
	[id_brand] [int] IDENTITY(1,1) NOT NULL,
	[product__brand] [varchar](100) NOT NULL,
 CONSTRAINT [PK_brand] PRIMARY KEY CLUSTERED 
(
	[id_brand] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[clasification]    Script Date: 12/11/2023 00:52:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clasification](
	[id_clasification] [int] IDENTITY(1,1) NOT NULL,
	[clasification__product] [varchar](100) NOT NULL,
 CONSTRAINT [PK_clasification] PRIMARY KEY CLUSTERED 
(
	[id_clasification] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[client]    Script Date: 12/11/2023 00:52:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[client](
	[id_client] [int] IDENTITY(1,1) NOT NULL,
	[client_firstName] [varchar](100) NOT NULL,
	[client_lastName] [varchar](100) NOT NULL,
	[password_client] [varchar](200) NOT NULL,
	[client_phone] [varchar](12) NOT NULL,
	[client_document] [varchar](11) NOT NULL,
	[client_address] [text] NOT NULL,
	[client_mail] [varchar](200) NOT NULL,
	[client_photo] [image] NULL,
	[id_statusClient] [int] NULL,
 CONSTRAINT [PK_client] PRIMARY KEY CLUSTERED 
(
	[id_client] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Contactos]    Script Date: 12/11/2023 00:52:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contactos](
	[ID_contacto] [int] IDENTITY(1,1) NOT NULL,
	[id_usuario] [int] NOT NULL,
	[Nombre_contacto] [varchar](100) NOT NULL,
	[Apellido_contacto] [varchar](100) NOT NULL,
	[Telefono_contacto] [varchar](100) NOT NULL,
	[Email_contacto] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_contacto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[distributor]    Script Date: 12/11/2023 00:52:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[distributor](
	[id_distributor] [int] IDENTITY(1,1) NOT NULL,
	[name_distributor] [varchar](200) NOT NULL,
	[comments] [text] NULL,
	[register] [date] NULL,
 CONSTRAINT [PK_distributot] PRIMARY KEY CLUSTERED 
(
	[id_distributor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[employee]    Script Date: 12/11/2023 00:52:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[employee](
	[id_employee] [int] IDENTITY(1,1) NOT NULL,
	[employee_firstName] [varchar](100) NOT NULL,
	[employee_lastName] [varchar](100) NOT NULL,
	[password_employee] [varchar](200) NOT NULL,
	[employee_address] [text] NOT NULL,
	[employee_phone] [int] NOT NULL,
	[employee_document] [int] NOT NULL,
	[employee_mail] [varchar](260) NOT NULL,
	[employee_photo] [image] NULL,
	[id_typeEmployee] [int] NOT NULL,
	[id_statusEmployee] [int] NOT NULL,
 CONSTRAINT [PK_employee] PRIMARY KEY CLUSTERED 
(
	[id_employee] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[gender]    Script Date: 12/11/2023 00:52:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[gender](
	[id_gender] [int] IDENTITY(1,1) NOT NULL,
	[book__gender] [varchar](100) NOT NULL,
 CONSTRAINT [PK_gender] PRIMARY KEY CLUSTERED 
(
	[id_gender] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[payment]    Script Date: 12/11/2023 00:52:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[payment](
	[id_typePayment] [int] IDENTITY(1,1) NOT NULL,
	[type__payment] [varchar](100) NOT NULL,
 CONSTRAINT [PK_payment] PRIMARY KEY CLUSTERED 
(
	[id_typePayment] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[products]    Script Date: 12/11/2023 00:52:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[products](
	[id_product] [int] IDENTITY(1,1) NOT NULL,
	[product_name] [varchar](100) NOT NULL,
	[product_price] [float] NOT NULL,
	[product_photo] [image] NULL,
	[product_description] [text] NOT NULL,
	[date_entry] [date] NULL,
	[product_brand] [int] NOT NULL,
	[id_productStatus] [int] NOT NULL,
	[id_productDistributor] [int] NOT NULL,
	[id_review] [int] NOT NULL,
	[id_availability] [int] NOT NULL,
 CONSTRAINT [PK_product] PRIMARY KEY CLUSTERED 
(
	[id_product] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[productSpecification]    Script Date: 12/11/2023 00:52:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[productSpecification](
	[id_productEspecification] [int] IDENTITY(1,1) NOT NULL,
	[product__quantity] [int] NOT NULL,
	[product__author] [varchar](200) NOT NULL,
	[product__format] [varchar](100) NOT NULL,
	[product__themes] [varchar](100) NOT NULL,
	[id_productGender] [int] NOT NULL,
	[id_clasification] [int] NOT NULL,
	[id_product] [int] NOT NULL,
 CONSTRAINT [PK_productSpecification] PRIMARY KEY CLUSTERED 
(
	[id_productEspecification] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[productStatus]    Script Date: 12/11/2023 00:52:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[productStatus](
	[id_productStatus] [int] IDENTITY(1,1) NOT NULL,
	[product__status] [varchar](90) NOT NULL,
 CONSTRAINT [PK_statusProduct] PRIMARY KEY CLUSTERED 
(
	[id_productStatus] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[reviews]    Script Date: 12/11/2023 00:52:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[reviews](
	[id_review] [int] IDENTITY(1,1) NOT NULL,
	[name_client] [varchar](100) NULL,
	[register_date] [date] NULL,
 CONSTRAINT [PK_review] PRIMARY KEY CLUSTERED 
(
	[id_review] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sales]    Script Date: 12/11/2023 00:52:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sales](
	[id_sales] [int] IDENTITY(1,1) NOT NULL,
	[sale_date] [date] NOT NULL,
	[sale_address] [text] NOT NULL,
	[sale_total_due] [float] NOT NULL,
	[sale_type_payment] [int] NOT NULL,
	[id_sale_purchaser] [int] NOT NULL,
	[id_product] [int] NOT NULL,
	[id_employee] [int] NOT NULL,
 CONSTRAINT [PK_sales] PRIMARY KEY CLUSTERED 
(
	[id_sales] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[statusClient]    Script Date: 12/11/2023 00:52:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[statusClient](
	[id_status] [int] IDENTITY(1,1) NOT NULL,
	[status__client] [varchar](50) NOT NULL,
 CONSTRAINT [PK_statusClient] PRIMARY KEY CLUSTERED 
(
	[id_status] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[statusEmployee]    Script Date: 12/11/2023 00:52:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[statusEmployee](
	[id_statusEmployee] [int] IDENTITY(1,1) NOT NULL,
	[status__employee] [varchar](90) NOT NULL,
 CONSTRAINT [PK_statusEmployee] PRIMARY KEY CLUSTERED 
(
	[id_statusEmployee] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoTarjeta]    Script Date: 12/11/2023 00:52:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoTarjeta](
	[ID_tipoTarjeta] [int] IDENTITY(1,1) NOT NULL,
	[tipo_tarjeta] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_tipoTarjeta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[typeEmployee]    Script Date: 12/11/2023 00:52:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[typeEmployee](
	[id_typeEmployee] [int] IDENTITY(1,1) NOT NULL,
	[type__employee] [varchar](100) NOT NULL,
 CONSTRAINT [PK_typeEmployee] PRIMARY KEY CLUSTERED 
(
	[id_typeEmployee] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[availability] ON 

INSERT [dbo].[availability] ([id_availability], [book__availability]) VALUES (1, N'Inmediata')
INSERT [dbo].[availability] ([id_availability], [book__availability]) VALUES (2, N'Agotado')
INSERT [dbo].[availability] ([id_availability], [book__availability]) VALUES (3, N'Pocas existencias')
INSERT [dbo].[availability] ([id_availability], [book__availability]) VALUES (4, N'Ingresos')
SET IDENTITY_INSERT [dbo].[availability] OFF
GO
SET IDENTITY_INSERT [dbo].[brand] ON 

INSERT [dbo].[brand] ([id_brand], [product__brand]) VALUES (1, N'Ibérica')
SET IDENTITY_INSERT [dbo].[brand] OFF
GO
SET IDENTITY_INSERT [dbo].[client] ON 

INSERT [dbo].[client] ([id_client], [client_firstName], [client_lastName], [password_client], [client_phone], [client_document], [client_address], [client_mail], [client_photo], [id_statusClient]) VALUES (1, N'Nelson', N'Almendares', N'123456', N'7823-2312', N'09821309-8', N'Por la casita', N'nelsonjose@gmail.com', 0x, 1)
SET IDENTITY_INSERT [dbo].[client] OFF
GO
SET IDENTITY_INSERT [dbo].[Contactos] ON 

INSERT [dbo].[Contactos] ([ID_contacto], [id_usuario], [Nombre_contacto], [Apellido_contacto], [Telefono_contacto], [Email_contacto]) VALUES (1, 2023002, N'Mirna Almelia', N'Guardado Centeno', N'8734923', N'MirnadeCenteno1999@gmail.com')
SET IDENTITY_INSERT [dbo].[Contactos] OFF
GO
SET IDENTITY_INSERT [dbo].[Equipamentos] ON 

INSERT [dbo].[Equipamentos] ([ID_equipamento], [nombre_equipamento], [descripcion_equipamento], [precio_equipamento]) VALUES (1, N'Conductor extra', N'El conductor debe ser mayor de edad y presentar licencia de conducir vigente', 5)
INSERT [dbo].[Equipamentos] ([ID_equipamento], [nombre_equipamento], [descripcion_equipamento], [precio_equipamento]) VALUES (2, N'Asientos para recién nacido', N'Ideal para mantener la seguridad de los nuevos integrantes de la familia', 5)
INSERT [dbo].[Equipamentos] ([ID_equipamento], [nombre_equipamento], [descripcion_equipamento], [precio_equipamento]) VALUES (3, N'Sin Equipamento', N'No se desea agregar otro equipo a la renta', 0)
SET IDENTITY_INSERT [dbo].[Equipamentos] OFF
GO
SET IDENTITY_INSERT [dbo].[EstadoSolicitud] ON 

INSERT [dbo].[EstadoSolicitud] ([ID_estadoSolicitud], [estado_solicitud]) VALUES (1, N'Pendiente')
INSERT [dbo].[EstadoSolicitud] ([ID_estadoSolicitud], [estado_solicitud]) VALUES (2, N'En Proceso')
INSERT [dbo].[EstadoSolicitud] ([ID_estadoSolicitud], [estado_solicitud]) VALUES (3, N'Aprobada')
INSERT [dbo].[EstadoSolicitud] ([ID_estadoSolicitud], [estado_solicitud]) VALUES (4, N'Rechazada')
SET IDENTITY_INSERT [dbo].[EstadoSolicitud] OFF
GO
SET IDENTITY_INSERT [dbo].[EstadoUsuario] ON 

INSERT [dbo].[EstadoUsuario] ([ID_estadoUsuario], [estado_usuario]) VALUES (1, N'Activo')
INSERT [dbo].[EstadoUsuario] ([ID_estadoUsuario], [estado_usuario]) VALUES (2, N'Ináctivo')
INSERT [dbo].[EstadoUsuario] ([ID_estadoUsuario], [estado_usuario]) VALUES (3, N'Mala reputación')
SET IDENTITY_INSERT [dbo].[EstadoUsuario] OFF
GO
SET IDENTITY_INSERT [dbo].[Facturacion] ON 

INSERT [dbo].[Facturacion] ([ID_factura], [Id_solicitud], [Kilometraje_vehiculo], [Hora_salida], [Fecha_salida], [Detalles_vehiculo], [Numero_tarjeta], [Pin_tarjeta], [Poliza_seguro], [Tipo_tarjeta], [Equipamentos]) VALUES (4, 2, 76004, CAST(N'13:30:00' AS Time), CAST(N'2023-11-06' AS Date), N'', N'972EDDC2B31143DF3C281DF6164470ED077C6D707D515115E4F70AABE5A5B626', N'114BD151F8FB0C58642D2170DA4AE7D7C57977260AC2CC8905306CAB6B2ACABC', 2, 1, 1)
SET IDENTITY_INSERT [dbo].[Facturacion] OFF
GO
SET IDENTITY_INSERT [dbo].[gender] ON 

INSERT [dbo].[gender] ([id_gender], [book__gender]) VALUES (1, N'Narrativo')
INSERT [dbo].[gender] ([id_gender], [book__gender]) VALUES (2, N'Lírico')
INSERT [dbo].[gender] ([id_gender], [book__gender]) VALUES (3, N'Dramático')
INSERT [dbo].[gender] ([id_gender], [book__gender]) VALUES (4, N'Didáctico')
SET IDENTITY_INSERT [dbo].[gender] OFF
GO
SET IDENTITY_INSERT [dbo].[productStatus] ON 

INSERT [dbo].[productStatus] ([id_productStatus], [product__status]) VALUES (1, N'En Existencias')
SET IDENTITY_INSERT [dbo].[productStatus] OFF
GO
SET IDENTITY_INSERT [dbo].[RegistroVehiculo] ON 

INSERT [dbo].[RegistroVehiculo] ([ID_vehiculo], [Numero_motor], [Numero_chasis], [Capacidad], [Kilometraje], [Transmicion], [Fecha_ingreso], [Valor_unidad], [Puertas], [Marca], [Modelo], [Anio], [Descripcion], [Equipaje], [Placa], [id_tipoVehiculo]) VALUES (1, N'1nr5016963', N'1HGBH41JXMN109186', 5, 98543.2, N'Automático', CAST(N'2023-09-12' AS Date), 45, N'4', N'Toyota', N'Yaris LE', N'2020', N'Cómodo sedán apto para la ciudad y los exteriores, todos nuestros vehículos cuentan con cero ruidos y aire acondicionado.', N'4 Maletas', N'P352 541', 1)
INSERT [dbo].[RegistroVehiculo] ([ID_vehiculo], [Numero_motor], [Numero_chasis], [Capacidad], [Kilometraje], [Transmicion], [Fecha_ingreso], [Valor_unidad], [Puertas], [Marca], [Modelo], [Anio], [Descripcion], [Equipaje], [Placa], [id_tipoVehiculo]) VALUES (2, N'P241DFG11', N'XE23FG54235GJK21', 10, 76002, N'Manual', CAST(N'2023-10-27' AS Date), 45, N'4', N'Mitsubishi', N'L200', N'2022', N'Ideal para viajes largos dentro del pais en zonas rurales con tracción 4x4', N'6 Maletas', N'V231P3', 4)
SET IDENTITY_INSERT [dbo].[RegistroVehiculo] OFF
GO
SET IDENTITY_INSERT [dbo].[Reingreso] ON 

INSERT [dbo].[Reingreso] ([ID_reingreso], [id_factura], [Kilometraje], [Hora_entrada], [Fecha_Entrada], [Detalles]) VALUES (1, 4, 76098, CAST(N'15:00:00' AS Time), CAST(N'2023-11-10' AS Date), N'Sin detalles registrados en la inspección')
SET IDENTITY_INSERT [dbo].[Reingreso] OFF
GO
SET IDENTITY_INSERT [dbo].[Solicitudes] ON 

INSERT [dbo].[Solicitudes] ([ID_solicitud], [id_cliente], [id_estadoSolicitud], [id_vehiculo], [Fecha_inicio], [Fecha_fin], [Hora_inicio], [Hora_fin]) VALUES (2, 2023003, 3, 2, CAST(N'2023-11-06' AS Date), CAST(N'2023-11-08' AS Date), CAST(N'10:00:00' AS Time), CAST(N'12:00:00' AS Time))
INSERT [dbo].[Solicitudes] ([ID_solicitud], [id_cliente], [id_estadoSolicitud], [id_vehiculo], [Fecha_inicio], [Fecha_fin], [Hora_inicio], [Hora_fin]) VALUES (3, 2023005, 3, 1, CAST(N'2023-11-12' AS Date), CAST(N'2023-11-14' AS Date), CAST(N'07:00:00' AS Time), CAST(N'17:00:00' AS Time))
SET IDENTITY_INSERT [dbo].[Solicitudes] OFF
GO
SET IDENTITY_INSERT [dbo].[statusClient] ON 

INSERT [dbo].[statusClient] ([id_status], [status__client]) VALUES (1, N'Activo')
INSERT [dbo].[statusClient] ([id_status], [status__client]) VALUES (2, N'Ináctivo')
SET IDENTITY_INSERT [dbo].[statusClient] OFF
GO
SET IDENTITY_INSERT [dbo].[statusEmployee] ON 

INSERT [dbo].[statusEmployee] ([id_statusEmployee], [status__employee]) VALUES (1, N'Activo')
INSERT [dbo].[statusEmployee] ([id_statusEmployee], [status__employee]) VALUES (2, N'Ináctivo')
INSERT [dbo].[statusEmployee] ([id_statusEmployee], [status__employee]) VALUES (3, N'Pasante')
SET IDENTITY_INSERT [dbo].[statusEmployee] OFF
GO
SET IDENTITY_INSERT [dbo].[TipoSeguro] ON 

INSERT [dbo].[TipoSeguro] ([ID_tipoSeguro], [poliza_seguro], [descripcion_poliza], [precio_poliza]) VALUES (1, N'Protección en el camino', N'Sientete seguro con la respuesta en caso de un incidente dentro del área metropolina', 15.99)
INSERT [dbo].[TipoSeguro] ([ID_tipoSeguro], [poliza_seguro], [descripcion_poliza], [precio_poliza]) VALUES (2, N'Máxima proteción', N'Respuesta inmediata a todos los confines del país. Elegido por la mayoría', 30.55)
SET IDENTITY_INSERT [dbo].[TipoSeguro] OFF
GO
SET IDENTITY_INSERT [dbo].[TipoTarjeta] ON 

INSERT [dbo].[TipoTarjeta] ([ID_tipoTarjeta], [tipo_tarjeta]) VALUES (1, N'Crédito')
INSERT [dbo].[TipoTarjeta] ([ID_tipoTarjeta], [tipo_tarjeta]) VALUES (2, N'Débito')
SET IDENTITY_INSERT [dbo].[TipoTarjeta] OFF
GO
SET IDENTITY_INSERT [dbo].[TipoUsuario] ON 

INSERT [dbo].[TipoUsuario] ([ID_tipoUsuario], [tipo_Usuario], [descripcion_usuario]) VALUES (1, N'Root', N'Solo pueden haber 2 usuarios con este nivel de acceso, controla las ventas y reportes del sistema')
INSERT [dbo].[TipoUsuario] ([ID_tipoUsuario], [tipo_Usuario], [descripcion_usuario]) VALUES (2, N'Administrador', N'Pueden haber como máximo 5 administradores, personas roles de insercciones y gestión de solicitudes')
INSERT [dbo].[TipoUsuario] ([ID_tipoUsuario], [tipo_Usuario], [descripcion_usuario]) VALUES (3, N'Cliente', N'Usuarios con el menor rango de acceso al sistema, accesan solicitudes y ven estados de las mismas')
SET IDENTITY_INSERT [dbo].[TipoUsuario] OFF
GO
SET IDENTITY_INSERT [dbo].[TipoVehiculo] ON 

INSERT [dbo].[TipoVehiculo] ([ID_tipoVehiculo], [tipo_vehiculo]) VALUES (1, N'Sedán')
INSERT [dbo].[TipoVehiculo] ([ID_tipoVehiculo], [tipo_vehiculo]) VALUES (2, N'Hatchback')
INSERT [dbo].[TipoVehiculo] ([ID_tipoVehiculo], [tipo_vehiculo]) VALUES (3, N'SUV')
INSERT [dbo].[TipoVehiculo] ([ID_tipoVehiculo], [tipo_vehiculo]) VALUES (4, N'Pickup')
INSERT [dbo].[TipoVehiculo] ([ID_tipoVehiculo], [tipo_vehiculo]) VALUES (5, N'Coupe')
INSERT [dbo].[TipoVehiculo] ([ID_tipoVehiculo], [tipo_vehiculo]) VALUES (6, N'VAN')
INSERT [dbo].[TipoVehiculo] ([ID_tipoVehiculo], [tipo_vehiculo]) VALUES (7, N'Minivan')
INSERT [dbo].[TipoVehiculo] ([ID_tipoVehiculo], [tipo_vehiculo]) VALUES (8, N'Microbus')
SET IDENTITY_INSERT [dbo].[TipoVehiculo] OFF
GO
SET IDENTITY_INSERT [dbo].[typeEmployee] ON 

INSERT [dbo].[typeEmployee] ([id_typeEmployee], [type__employee]) VALUES (1, N'Administrador')
INSERT [dbo].[typeEmployee] ([id_typeEmployee], [type__employee]) VALUES (2, N'Gerente')
INSERT [dbo].[typeEmployee] ([id_typeEmployee], [type__employee]) VALUES (3, N'Vendedor')
INSERT [dbo].[typeEmployee] ([id_typeEmployee], [type__employee]) VALUES (4, N'Caja')
INSERT [dbo].[typeEmployee] ([id_typeEmployee], [type__employee]) VALUES (5, N'Bodega')
INSERT [dbo].[typeEmployee] ([id_typeEmployee], [type__employee]) VALUES (6, N'Repartidor')
INSERT [dbo].[typeEmployee] ([id_typeEmployee], [type__employee]) VALUES (7, N'Ordenanza')
INSERT [dbo].[typeEmployee] ([id_typeEmployee], [type__employee]) VALUES (8, N'Seguridad')
INSERT [dbo].[typeEmployee] ([id_typeEmployee], [type__employee]) VALUES (9, N'Administración')
SET IDENTITY_INSERT [dbo].[typeEmployee] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuario] ON 

INSERT [dbo].[Usuario] ([ID_usuario], [Nombre_usuario], [Apellido_usuario], [Documento], [Password_usuario], [Edad_usuario], [Telefono_usuario], [Celular_usuario], [Numero_tarjeta], [Fecha_tarjeta], [ID_estadoUsuario], [ID_tipoUsuario], [Acceso_usuario], [Fecha_Registro]) VALUES (2023001, N'Nelson', N'Almendares', N'063856630', N'C1C224B03CD9BC7B6A86D77F5DACE40191766C485CD55DC48CAF9AC873335D6F', 20, N'78347623', N'21348932', N'063856630', CAST(N'2027-02-01' AS Date), 1, 1, N'NelsonAlmendares', CAST(N'2023-01-01' AS Date))
INSERT [dbo].[Usuario] ([ID_usuario], [Nombre_usuario], [Apellido_usuario], [Documento], [Password_usuario], [Edad_usuario], [Telefono_usuario], [Celular_usuario], [Numero_tarjeta], [Fecha_tarjeta], [ID_estadoUsuario], [ID_tipoUsuario], [Acceso_usuario], [Fecha_Registro]) VALUES (2023002, N'Camila Michelle', N'Centeno', N'034565423', N'BBD81E5A964A70D01C5D926323842A93EF2EE462501E368257497D22AE401CF4', 19, N'87430942', N'23414312', N'034565423', CAST(N'2028-02-01' AS Date), 1, 2, N'Camichelle', CAST(N'2022-04-08' AS Date))
INSERT [dbo].[Usuario] ([ID_usuario], [Nombre_usuario], [Apellido_usuario], [Documento], [Password_usuario], [Edad_usuario], [Telefono_usuario], [Celular_usuario], [Numero_tarjeta], [Fecha_tarjeta], [ID_estadoUsuario], [ID_tipoUsuario], [Acceso_usuario], [Fecha_Registro]) VALUES (2023003, N'Karla Daniela', N'Martinez', N'02345231', N'E46A2779CEB2B754744502FCF1E5E0391066B228F7A7F8FA4A9AD09AEFE5D41F', 21, N'6534452', N'2456223', N'02345231', CAST(N'2028-03-01' AS Date), 1, 3, N'KarlaMartinez', CAST(N'2022-02-08' AS Date))
INSERT [dbo].[Usuario] ([ID_usuario], [Nombre_usuario], [Apellido_usuario], [Documento], [Password_usuario], [Edad_usuario], [Telefono_usuario], [Celular_usuario], [Numero_tarjeta], [Fecha_tarjeta], [ID_estadoUsuario], [ID_tipoUsuario], [Acceso_usuario], [Fecha_Registro]) VALUES (2023004, N'Astrid Nicole', N'Arevalo Mejía', N'093423094', N'E03112B3005D969F7623B240EF9D385C5C0E078EDE08720F66E78C85AD73F3A3', 22, N'23419831', N'78430123', N'093423094', CAST(N'2027-07-01' AS Date), 1, 3, N'AstridNicole', CAST(N'2023-03-09' AS Date))
INSERT [dbo].[Usuario] ([ID_usuario], [Nombre_usuario], [Apellido_usuario], [Documento], [Password_usuario], [Edad_usuario], [Telefono_usuario], [Celular_usuario], [Numero_tarjeta], [Fecha_tarjeta], [ID_estadoUsuario], [ID_tipoUsuario], [Acceso_usuario], [Fecha_Registro]) VALUES (2023005, N'Carlos Daniel', N'Lopez Peraza', N'094234091', N'6369568F26E218856B8AF13F45017C0C79AE212D31E4C9DB41AF71CE1F022A22', 24, N'29410931', N'79346712', N'094234091', CAST(N'2025-02-01' AS Date), 1, 3, N'CarlosPeraza', CAST(N'2022-05-06' AS Date))
SET IDENTITY_INSERT [dbo].[Usuario] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [uq_mail]    Script Date: 12/11/2023 00:52:49 ******/
ALTER TABLE [dbo].[client] ADD  CONSTRAINT [uq_mail] UNIQUE NONCLUSTERED 
(
	[client_mail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UK_mail]    Script Date: 12/11/2023 00:52:49 ******/
ALTER TABLE [dbo].[employee] ADD  CONSTRAINT [UK_mail] UNIQUE NONCLUSTERED 
(
	[employee_mail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[bills] ADD  DEFAULT ('') FOR [comments]
GO
ALTER TABLE [dbo].[client] ADD  DEFAULT ((1)) FOR [id_statusClient]
GO
ALTER TABLE [dbo].[distributor] ADD  DEFAULT ('Sin comentarios') FOR [comments]
GO
ALTER TABLE [dbo].[Facturacion] ADD  DEFAULT ('Sin detalles registrados') FOR [Detalles_vehiculo]
GO
ALTER TABLE [dbo].[Usuario] ADD  DEFAULT ('No posee teléfono fijo') FOR [Telefono_usuario]
GO
ALTER TABLE [dbo].[Usuario] ADD  DEFAULT ('Es un empleado') FOR [Numero_tarjeta]
GO
ALTER TABLE [dbo].[Contactos]  WITH CHECK ADD  CONSTRAINT [FK_contactos] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[Usuario] ([ID_usuario])
GO
ALTER TABLE [dbo].[Contactos] CHECK CONSTRAINT [FK_contactos]
GO
ALTER TABLE [dbo].[Facturacion]  WITH CHECK ADD  CONSTRAINT [FK_equipamentos] FOREIGN KEY([Equipamentos])
REFERENCES [dbo].[Equipamentos] ([ID_equipamento])
GO
ALTER TABLE [dbo].[Facturacion] CHECK CONSTRAINT [FK_equipamentos]
GO
ALTER TABLE [dbo].[Facturacion]  WITH CHECK ADD  CONSTRAINT [FK_solicitudes] FOREIGN KEY([Id_solicitud])
REFERENCES [dbo].[Solicitudes] ([ID_solicitud])
GO
ALTER TABLE [dbo].[Facturacion] CHECK CONSTRAINT [FK_solicitudes]
GO
ALTER TABLE [dbo].[Facturacion]  WITH CHECK ADD  CONSTRAINT [FK_tipoSeguros] FOREIGN KEY([Poliza_seguro])
REFERENCES [dbo].[TipoSeguro] ([ID_tipoSeguro])
GO
ALTER TABLE [dbo].[Facturacion] CHECK CONSTRAINT [FK_tipoSeguros]
GO
ALTER TABLE [dbo].[Facturacion]  WITH CHECK ADD  CONSTRAINT [FK_tipoTarjeta] FOREIGN KEY([Tipo_tarjeta])
REFERENCES [dbo].[TipoTarjeta] ([ID_tipoTarjeta])
GO
ALTER TABLE [dbo].[Facturacion] CHECK CONSTRAINT [FK_tipoTarjeta]
GO
ALTER TABLE [dbo].[RegistroVehiculo]  WITH CHECK ADD  CONSTRAINT [FK_tipoVehiculo] FOREIGN KEY([id_tipoVehiculo])
REFERENCES [dbo].[TipoVehiculo] ([ID_tipoVehiculo])
GO
ALTER TABLE [dbo].[RegistroVehiculo] CHECK CONSTRAINT [FK_tipoVehiculo]
GO
ALTER TABLE [dbo].[Reingreso]  WITH CHECK ADD  CONSTRAINT [FK_reingreso] FOREIGN KEY([id_factura])
REFERENCES [dbo].[Facturacion] ([ID_factura])
GO
ALTER TABLE [dbo].[Reingreso] CHECK CONSTRAINT [FK_reingreso]
GO
ALTER TABLE [dbo].[Solicitudes]  WITH CHECK ADD  CONSTRAINT [FK_estadoSolicitud] FOREIGN KEY([id_estadoSolicitud])
REFERENCES [dbo].[EstadoSolicitud] ([ID_estadoSolicitud])
GO
ALTER TABLE [dbo].[Solicitudes] CHECK CONSTRAINT [FK_estadoSolicitud]
GO
ALTER TABLE [dbo].[Solicitudes]  WITH CHECK ADD  CONSTRAINT [FK_users] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[Usuario] ([ID_usuario])
GO
ALTER TABLE [dbo].[Solicitudes] CHECK CONSTRAINT [FK_users]
GO
ALTER TABLE [dbo].[Solicitudes]  WITH CHECK ADD  CONSTRAINT [FK_vehiculo] FOREIGN KEY([id_vehiculo])
REFERENCES [dbo].[RegistroVehiculo] ([ID_vehiculo])
GO
ALTER TABLE [dbo].[Solicitudes] CHECK CONSTRAINT [FK_vehiculo]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_estadoUser] FOREIGN KEY([ID_estadoUsuario])
REFERENCES [dbo].[EstadoUsuario] ([ID_estadoUsuario])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_estadoUser]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_tipoUser] FOREIGN KEY([ID_tipoUsuario])
REFERENCES [dbo].[TipoUsuario] ([ID_tipoUsuario])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_tipoUser]
GO
ALTER TABLE [dbo].[client]  WITH CHECK ADD  CONSTRAINT [ck_documentClient] CHECK  (([client_document] like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]-[0-9]'))
GO
ALTER TABLE [dbo].[client] CHECK CONSTRAINT [ck_documentClient]
GO
ALTER TABLE [dbo].[client]  WITH CHECK ADD  CONSTRAINT [ck_phoneClient] CHECK  (([client_phone] like '[0-9][0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]'))
GO
ALTER TABLE [dbo].[client] CHECK CONSTRAINT [ck_phoneClient]
GO
ALTER TABLE [dbo].[employee]  WITH CHECK ADD  CONSTRAINT [CK_documentEmplyee] CHECK  (([employee_document] like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]-[0-9]'))
GO
ALTER TABLE [dbo].[employee] CHECK CONSTRAINT [CK_documentEmplyee]
GO
ALTER TABLE [dbo].[employee]  WITH CHECK ADD  CONSTRAINT [CK_phoneEmployee] CHECK  (([employee_phone] like '[0-9][0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]'))
GO
ALTER TABLE [dbo].[employee] CHECK CONSTRAINT [CK_phoneEmployee]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [CK_CheckEdad] CHECK  (([Edad_usuario]>=(18) AND [Edad_usuario]<=(65)))
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [CK_CheckEdad]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [CK_FechaTarjeta] CHECK  ((datepart(year,[Fecha_tarjeta])<>datepart(year,getdate()) OR datepart(month,[Fecha_tarjeta])<>datepart(month,getdate())))
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [CK_FechaTarjeta]
GO
/****** Object:  StoredProcedure [dbo].[Add_User]    Script Date: 12/11/2023 00:52:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Add_User] --XXXXXXXXXXXXXXXXXXXXX CONTRASEÑA CON SHA256 (PARA MÁS SEGURIDAD SE HARÁ DOBLE AUTENTICACIÓN) XXXXXXXXXXXXXXXXXXXXX
	@Nombre VARCHAR (100), @Apellido VARCHAR (100), @DUI VARCHAR (12), @PWS VARCHAR (1000), @Edad INT, @Telefono VARCHAR (12), 
	@Celular VARCHAR (12), @Tarjeta VARCHAR (200), @Fecha DATE, @ID_EstadoUsuario INT, @ID_TipoUsuario INT, @User VARCHAR (100)
AS
BEGIN
	-- Damos formato a la fecha
	DECLARE @fecha_tarjeta DATE;
	SET @fecha_tarjeta = CONVERT(DATE, @Fecha, 105);

	IF @Edad <= 18 OR @Edad >= 65
		BEGIN
			PRINT 'La edad no es valida para ser registrado'
		END
	-- Validamos la fecha de vencimiento de las licencias, (se toma a partir del día que se realice la consulta)
	ELSE IF (@fecha_tarjeta) < GETDATE() 
		BEGIN
			PRINT 'Licencia vencida'
		END
	ELSE
		BEGIN
			PRINT 'Los datos ingresados son validos puede pasar'
			INSERT INTO [dbo].[Usuario] 
			(Nombre_usuario, Apellido_usuario, Documento, Password_usuario, Edad_usuario, 
			Telefono_usuario, Celular_usuario, Numero_tarjeta, Fecha_tarjeta, ID_estadoUsuario, ID_tipoUsuario, Acceso_usuario, Fecha_Registro) 
			VALUES 
			(@Nombre, @Apellido, @DUI, @PWS, @Edad, @Telefono, 
			@Celular, @Tarjeta, @fecha_tarjeta , @ID_EstadoUsuario, @ID_TipoUsuario, @User, GETDATE());
		END
END;
GO
/****** Object:  StoredProcedure [dbo].[Add_Vehicle]    Script Date: 12/11/2023 00:52:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Add_Vehicle]
	@NumeroMotor VARCHAR (24), @NumeroChasis VARCHAR(24), @Capacidad INT, @Kilometraje FLOAT, @Transmicion VARCHAR (100),
	@FechaIngreso DATE, @ValorUnidad FLOAT, @Puertas VARCHAR (10), @Marca VARCHAR (100), @Modelo VARCHAR (100), @Anio VARCHAR (100),
	@Descripcion VARCHAR (500), @Equipaje VARCHAR (10), @Placa VARCHAR (10), @ID_TipoVhehiculo INT
AS
BEGIN
	INSERT INTO [dbo].[RegistroVehiculo] (
	Numero_motor ,
	Numero_chasis,
	Capacidad ,
	Kilometraje ,
	Transmicion ,
	Fecha_ingreso ,
	Valor_unidad ,
	Puertas ,
	Marca ,
	Modelo ,
	Anio ,
	Descripcion ,
	Equipaje ,
	Placa ,
	id_tipoVehiculo) 
	VALUES (
	@NumeroMotor, @NumeroChasis, @Capacidad, @Kilometraje, 
	@Transmicion, @FechaIngreso, @ValorUnidad, @Puertas, 
	@Marca, @Modelo, @Anio, @Descripcion, @Equipaje, 
	@Placa, @ID_TipoVhehiculo);
END;
GO
/****** Object:  StoredProcedure [dbo].[Update_Solicitud]    Script Date: 12/11/2023 00:52:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Update_Solicitud]
	-- Variables para actualizar:
	@SOLICITUD_ID INT, @NEW_ID INT, @NEW_ESTAD INT, @NEW_VEHICLE INT, @NEW_STARTDATE DATE, @NEW_FINISHDATE DATE, @NEW_STARTHOUR TIME, @NEW_FINISHTIME TIME
AS
BEGIN
	UPDATE [dbo].[Solicitudes] 
	SET
		id_cliente = COALESCE(@NEW_ID, id_cliente),
		id_estadoSolicitud = COALESCE(@NEW_ESTAD, id_estadoSolicitud),
		id_vehiculo = COALESCE(@NEW_VEHICLE, id_vehiculo),
		Fecha_inicio = COALESCE(@NEW_STARTDATE, Fecha_inicio),
		Fecha_fin = COALESCE(@NEW_FINISHDATE, Fecha_fin),
		Hora_inicio = COALESCE(@NEW_STARTHOUR, Hora_inicio),
		Hora_fin = COALESCE(@NEW_FINISHTIME, Hora_fin)
	WHERE ID_solicitud = @SOLICITUD_ID
END;
GO
USE [master]
GO
ALTER DATABASE [CarIncome2] SET  READ_WRITE 
GO
