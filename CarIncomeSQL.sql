CREATE DATABASE [CarIncome]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CarIncome', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\CarIncome.mdf' , SIZE = 8192KB , FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CarIncome_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\CarIncome_log.ldf' , SIZE = 8192KB , FILEGROWTH = 65536KB )
 WITH LEDGER = OFF
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = Primary;
GO
IF NOT EXISTS (SELECT name FROM sys.filegroups WHERE is_default=1 AND name = N'PRIMARY') ALTER DATABASE [CarIncome] MODIFY FILEGROUP [PRIMARY] DEFAULT
GO
USE [CarIncome]
GO

SELECT  ID_usuario ,CONCAT (Nombre_usuario, ' ' , Apellido_usuario) AS Usuario FROM [dbo].[Usuario] WHERE ID_tipoUsuario = 3;

SELECT @@SERVERNAME AS Servidor;

-- DROP DATABASE [CarIncome];

-- Tabla de Usuarios:
CREATE TABLE [dbo].[Usuario] (
	ID_usuario INT NOT NULL IDENTITY (2023001, 1),
	Nombre_usuario VARCHAR (120) NOT NULL,
	Apellido_usuario VARCHAR (120) NOT NULL,
	Documento VARCHAR (14) NOT NULL,
	Password_usuario VARCHAR (1000) NOT NULL,
	Edad_usuario INT NOT NULL,
	Telefono_usuario VARCHAR (12) DEFAULT 'No posee teléfono fijo',
	Celular_usuario VARCHAR (12)NOT NULL,
	Numero_tarjeta VARCHAR (12) DEFAULT 'Es un empleado', -- Actualmente DUI de la persona
	Fecha_tarjeta DATE NULL,
	ID_estadoUsuario INT NOT NULL,
	ID_tipoUsuario INT NOT NULL,

	-- Validacioes de la tabla
	CONSTRAINT CK_FechaTarjeta  CHECK (
		YEAR (Fecha_tarjeta) != YEAR(GETDATE()) OR
		MONTH(Fecha_tarjeta) != MONTH(GETDATE())
	),
	CONSTRAINT CK_CheckEdad CHECK (Edad_usuario >= 18 AND Edad_usuario <= 65),
	PRIMARY KEY (ID_usuario)
);
SELECT * FROM [dbo].[Usuario];
-- UPDATE [dbo].[Usuario] SET ID_tipoUsuario = 3 WHERE ID_usuario = 2023005
-- UPDATE [dbo].[Usuario] SET ID_estadoUsuario = 1 WHERE ID_usuario = 2023005
-- ALTER TABLE [dbo].[Usuario] ADD Acceso_usuario VARCHAR (100) NOT NULL;

-- Tabla de Tipo de Usuarios:
CREATE TABLE [dbo].[TipoUsuario] (
	ID_tipoUsuario INT NOT NULL IDENTITY (1,1),
	tipo_Usuario VARCHAR (100) NOT NULL,
	descripcion_usuario VARCHAR (100) NOT NULL,
	PRIMARY KEY (ID_tipoUsuario)
);
SELECT * FROM [dbo].[TipoUsuario];

-- Tabla para el estado de los Usuarios
CREATE TABLE [dbo].[EstadoUsuario] (
	ID_estadoUsuario INT NOT NULL IDENTITY (1,1),
	estado_usuario VARCHAR (100) NOT NULL
	PRIMARY KEY (ID_estadoUsuario)
);
SELECT * FROM [dbo].[EstadoUsuario];

-- Tabla para los contactos de los usuarios
CREATE TABLE [dbo].[Contactos] (
	ID_contacto INT NOT NULL IDENTITY (1,1),
	id_usuario INT NOT NULL,
	Nombre_contacto VARCHAR (100) NOT NULL,
	Apellido_contacto VARCHAR (100) NOT NULL,
	Telefono_contacto VARCHAR (100) NOT NULL,
	Email_contacto VARCHAR (100) NOT NULL,
	PRIMARY KEY (ID_contacto)
);
SELECT * FROM [dbo].[Contactos];

-- Tabla para la Facturacion de las solicutudes de los usuarios
CREATE TABLE [dbo].[Facturacion] (
	ID_factura INT NOT NULL IDENTITY (1,1),
	Id_solicitud INT NOT NULL,
	Kilometraje_vehiculo FLOAT NOT NULL,
	Hora_salida TIME NOT NULL,
	Fecha_salida DATE NOT NULL,
	Detalles_vehiculo VARCHAR (500) DEFAULT 'Sin detalles registrados',
	-- Hacer una tabla de bitacora de los detalles que se registren en una placa
	Numero_tarjeta VARCHAR (1000) NOT NULL,
	Pin_tarjeta VARCHAR (1000) NOT NULL,
	Poliza_seguro INT NULL,
	Tipo_tarjeta INT NOT NULL,
	Equipamentos INT NOT NULL,
	PRIMARY KEY (ID_factura)
);


SELECT * FROM [dbo].[Facturacion];
SELECT * FROM [dbo].[Solicitudes];
SELECT * FROM [dbo].[RegistroVehiculo];
SELECT * FROM [dbo].[TipoSeguro];
SELECT * FROM [dbo].[Equipamentos];
SELECT * FROM [dbo].[Reingreso];


-- Tabla para los tipos de tarjeta que se pueda usar para las transacciones
CREATE TABLE [dbo].[TipoTarjeta] (
	ID_tipoTarjeta INT NOT NULL IDENTITY (1,1),
	tipo_tarjeta VARCHAR (100) NOT NULL,
	PRIMARY KEY (ID_tipoTarjeta)
);
SELECT * FROM [dbo].[TipoTarjeta];

-- Tabla para los Equipamentos de los vehiculos
CREATE TABLE [dbo].[Equipamentos] (
	ID_equipamento INT NOT NULL IDENTITY (1,1),
	nombre_equipamento VARCHAR (100) NOT NULL,
	descripcion_equipamento VARCHAR (250) NOT NULL,
	precio_equipamento FLOAT,
	PRIMARY KEY (ID_equipamento)
);
SELECT * FROM [dbo].[Equipamentos];

-- Tabla para las polizas de seguro
CREATE TABLE [dbo].[TipoSeguro] (
	ID_tipoSeguro INT NOT NULL IDENTITY (1,1),
	poliza_seguro VARCHAR (100),
	descripcion_poliza VARCHAR (250) NOT NULL,
	precio_poliza FLOAT,
	PRIMARY KEY (ID_tipoSeguro)
);
SELECT * FROM [dbo].[TipoSeguro];

-- Tabla para verificar el reingreso de los vehiculos que fueron rentados
CREATE TABLE [dbo].[Reingreso] (
	ID_reingreso INT NOT NULL IDENTITY (1,1),
	id_factura INT NOT NULL,
	Kilometraje FLOAT,
	Hora_entrada TIME,
	Fecha_Entrada DATE NULL,
	Detalles VARCHAR (500) NULL,
	PRIMARY KEY (ID_reingreso)
);
-- ALTER TABLE [dbo].[Reingreso] DROP COLUMN Recargo;
SELECT * FROM [dbo].[Reingreso];
SELECT * FROM [dbo].[Facturacion];

SELECT * FROM [dbo].[Facturacion];
SELECT * FROM [dbo].[Solicitudes];
SELECT * FROM [dbo].[RegistroVehiculo];
SELECT * FROM [dbo].[TipoSeguro];
SELECT * FROM [dbo].[Equipamentos];
SELECT * FROM [dbo].[Reingreso];

-- Tabla para almacenar las solicitudes que realicen los clientes
CREATE TABLE [dbo].[Solicitudes] (
	ID_solicitud INT NOT NULL IDENTITY (1,1),
	id_cliente INT NOT NULL,
	id_estadoSolicitud INT NOT NULL,
	id_vehiculo INT NOT NULL,
	Fecha_inicio DATE NOT NULL,
	Fecha_fin DATE NOT NULL,
	Hora_inicio TIME NOT NULL,
	Hora_fin TIME NOT NULL,
	PRIMARY KEY (ID_solicitud)
);
SELECT * FROM [dbo].[Solicitudes];
--DELETE FROM [dbo].[Solicitudes] WHERE ID_solicitud = ;
UPDATE [dbo].[Solicitudes] SET id_estadoSolicitud = 3 WHERE ID_solicitud = 2;

-- Tabla para clasificar los estados de las solicitudes
CREATE TABLE [dbo].[EstadoSolicitud] (
	ID_estadoSolicitud INT NOT NULL PRIMARY KEY IDENTITY (1,1),
	estado_solicitud VARCHAR (100) NOT NULL
);
SELECT * FROM [dbo].[EstadoSolicitud];
SELECT ID_estadoSolicitud, estado_solicitud FROM [dbo].[EstadoSolicitud] WHERE estado_solicitud = '';

-- Tabla para el registro de los vehiculos
CREATE TABLE [dbo].[RegistroVehiculo] (
	ID_vehiculo INT NOT NULL IDENTITY (0001, 1),
	Numero_motor VARCHAR (24) NOT NULL,
	Numero_chasis VARCHAR (24) NOT NULL,
	Capacidad INT NOT NULL,
	Kilometraje FLOAT NOT NULL,
	Transmicion VARCHAR (100) NOT NULL,
	Fecha_ingreso DATE NOT NULL,
	Valor_unidad FLOAT NOT NULL,
	Puertas VARCHAR (10) NOT NULL,
	Marca VARCHAR (100) NOT NULL,
	Modelo VARCHAR (100) NOT NULL,
	Anio VARCHAR (100) NOT NULL,
	Descripcion VARCHAR (500) NOT NULL,
	Equipaje VARCHAR (10) NOT NULL,
	Placa VARCHAR (10) NOT NULL,
	id_tipoVehiculo INT NOT NULL,
	PRIMARY KEY (ID_vehiculo)
);
SELECT * FROM [dbo].[RegistroVehiculo];
-- UPDATE [dbo].[RegistroVehiculo] SET Equipaje = '6 Maletas' WHERE ID_vehiculo = 2

SELECT ID_vehiculo ,CONCAT(Marca, ' ', Modelo, ' - Año ',' ', Anio) AS Vehiculo FROM [dbo].[RegistroVehiculo] WHERE CONCAT(Marca, ' ', Modelo, ' - Año ',' ', Anio) = '';

-- Tabla para registrar los tipos de vehiculos 
CREATE TABLE [dbo].[TipoVehiculo] (
	ID_tipoVehiculo INT NOT NULL PRIMARY KEY IDENTITY (1,1),
	tipo_vehiculo VARCHAR (200) NOT NULL
);
SELECT * FROM [dbo].[TipoVehiculo];

-- --------------------------- FOREING KEYS DE LAS TABLAS --------------------------- --
-- Tabla de Usuario -> Estado de los Usuarios
ALTER TABLE [dbo].[Usuario]
ADD CONSTRAINT FK_estadoUser
FOREIGN KEY (ID_estadoUsuario)
REFERENCES [dbo].[EstadoUsuario] (ID_estadoUsuario);

-- Tabla de Usuario -> Tipo de Usuarios
ALTER TABLE [dbo].[Usuario]
ADD CONSTRAINT FK_tipoUser
FOREIGN KEY (ID_tipoUsuario)
REFERENCES [dbo].[TipoUsuario] (ID_tipoUsuario);

-- Tabla de Usuario -> Tipo de Usuarios
ALTER TABLE [dbo].[Contactos]
ADD CONSTRAINT FK_contactos
FOREIGN KEY (id_usuario)
REFERENCES [dbo].[Usuario] (ID_usuario);

-- Tabla de Facturacion -> Equipamentos
ALTER TABLE [dbo].[Facturacion]
ADD CONSTRAINT FK_equipamentos
FOREIGN KEY (Equipamentos)
REFERENCES [dbo].[Equipamentos] (ID_equipamento);

-- Tabla de Facturacion -> Tipo de tarjeta
ALTER TABLE [dbo].[Facturacion]
ADD CONSTRAINT FK_tipoTarjeta
FOREIGN KEY (Tipo_tarjeta)
REFERENCES [dbo].[TipoTarjeta] (ID_tipoTarjeta);

-- Tabla de Facturacion -> Tipo de seguro
ALTER TABLE [dbo].[Facturacion]
ADD CONSTRAINT FK_tipoSeguros
FOREIGN KEY (Poliza_seguro)
REFERENCES [dbo].[TipoSeguro] (ID_tipoSeguro);

-- Tabla de Facturacion -> Reeingreso de los vehiculos
-- ALTER TABLE [dbo].[Facturacion] DROP CONSTRAINT FK_reingreso;
ALTER TABLE [dbo].[Reingreso]
ADD CONSTRAINT FK_reingreso
FOREIGN KEY (id_factura)
REFERENCES [dbo].[Facturacion] (ID_factura);

-- Tabla de Facturacion -> Solicitudes
ALTER TABLE [dbo].[Facturacion]
ADD CONSTRAINT FK_solicitudes
FOREIGN KEY (id_solicitud)
REFERENCES [dbo].[Solicitudes] (ID_solicitud);

-- Tabla de Solicitudes -> Estado de las solicitudes
ALTER TABLE [dbo].[Solicitudes]
ADD CONSTRAINT FK_estadoSolicitud
FOREIGN KEY (id_estadoSolicitud)
REFERENCES [dbo].[EstadoSolicitud] (ID_estadoSolicitud);

-- Tabla de Solicitudes -> Usuarios
ALTER TABLE [dbo].[Solicitudes]
ADD CONSTRAINT FK_users
FOREIGN KEY (id_cliente)
REFERENCES [dbo].[Usuario] (ID_usuario);

-- Tabla de Solicitudes -> Usuarios
ALTER TABLE [dbo].[Solicitudes]
ADD CONSTRAINT FK_vehiculo
FOREIGN KEY (id_vehiculo)
REFERENCES [dbo].[RegistroVehiculo] (ID_vehiculo);

-- Tabla de Solicitudes -> Usuarios
ALTER TABLE [dbo].[RegistroVehiculo]
ADD CONSTRAINT FK_tipoVehiculo
FOREIGN KEY (id_tipoVehiculo)
REFERENCES [dbo].[TipoVehiculo] (ID_tipoVehiculo);


-- VISTAS PARA LAS CONSULTAS
GO
CREATE VIEW Complete_User AS SELECT ID_usuario AS ID, Acceso_usuario AS 'Usuario', CONCAT(Nombre_usuario, ' ', Apellido_usuario) AS 'Nombre Completo', STUFF(Documento, LEN(Documento) -0 ,0, '-') AS 'Documento Único de Identidad', Edad_usuario as Edad,tipo_Usuario AS Rol, 
	CONCAT('+503 ', STUFF(Celular_usuario, LEN(Celular_usuario) -3, 0, '-')) as Celular , CONCAT('+503 ', STUFF(Telefono_usuario, LEN(Telefono_usuario) -3, 0, '-')) AS Teléfono,
	estado_usuario AS 'Estado del usuario', Numero_tarjeta AS 'Número de Licencia', Fecha_tarjeta AS 'Vencimiento de Tarjeta'
FROM [dbo].[Usuario]
INNER JOIN [dbo].[EstadoUsuario] ON [dbo].[EstadoUsuario].ID_estadoUsuario = [dbo].[Usuario].ID_estadoUsuario
INNER JOIN [dbo].[TipoUsuario] ON [dbo].[Usuario].ID_tipoUsuario = [dbo].[TipoUsuario].ID_tipoUsuario;
SELECT * FROM Complete_User;

GO
ALTER VIEW LoginUser AS 
SELECT ID_usuario AS ID, Acceso_usuario AS 'Usuario', Password_usuario, CONCAT(Nombre_usuario, ' ', Apellido_usuario) AS 'Nombre Completo', tipo_Usuario AS Rol, 
	CONCAT('+503 ', STUFF(Celular_usuario, LEN(Celular_usuario) -3, 0, '-')) as Celular , CONCAT('+503 ', STUFF(Telefono_usuario, LEN(Telefono_usuario) -3, 0, '-')) AS Teléfono,
	estado_usuario AS 'Estado del usuario', Numero_tarjeta AS 'Número de Licencia'
FROM [dbo].[Usuario]
INNER JOIN [dbo].[EstadoUsuario] ON [dbo].[EstadoUsuario].ID_estadoUsuario = [dbo].[Usuario].ID_estadoUsuario
INNER JOIN [dbo].[TipoUsuario] ON [dbo].[Usuario].ID_tipoUsuario = [dbo].[TipoUsuario].ID_tipoUsuario;
SELECT * FROM LoginUser;
SELECT * FROM LoginUser WHERE Usuario = '' AND Password_usuario = '';

GO
CREATE VIEW Registro_Vehiculo AS 
	SELECT Numero_motor AS 'Número de Motor', Numero_chasis AS 'Número de Chasis',tipo_vehiculo AS 'Tipo de Vehículo',
	CONCAT(Capacidad, ' Ocupantes') AS Capacidad, CONCAT(Kilometraje, ' KM') AS Kilometraje, Transmicion AS 'Transmición', Equipaje AS 'Capacidad de equipaje',
	Fecha_ingreso AS 'Ingresado en: ', CONCAT('$ ', Valor_unidad) AS 'Precio por Día', Marca, Modelo, Anio AS 'Año del Vehículo', Descripcion
FROM [dbo].[RegistroVehiculo]
INNER JOIN [dbo].[TipoVehiculo] ON [dbo].[RegistroVehiculo].id_tipoVehiculo = [dbo].[TipoVehiculo].ID_tipoVehiculo;
SELECT * FROM Registro_Vehiculo;

GO
-- -> Para la tabla de Solicitudes
ALTER VIEW Select_Solicitud AS 
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
SELECT * FROM Select_Solicitud;
GO

SELECT ID, CONCAT('N° ', ID, ' - ' ,[Cliente Solicitante]) AS Solicitud FROM Select_Solicitud;

-- -> Para la tabla de Facturaciones
CREATE VIEW Factura AS SELECT [dbo].[Solicitudes].ID_solicitud AS 'Número de Solicitud', CONCAT(Nombre_usuario, ' ', Apellido_usuario) AS Solicitante,
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
SELECT * FROM Factura;

SELECT * FROM Select_Solicitud WHERE [Cliente Solicitante] = 'Karla Daniela Martinez';
SELECT * FROM [dbo].[RegistroVehiculo];

SELECT ID_usuario ,CONCAT (Nombre_usuario, ' ' , Apellido_usuario) AS Usuario FROM [dbo].[Usuario] WHERE CONCAT (Nombre_usuario, ' ' , Apellido_usuario) = 'Nelson Almendares';

SELECT @@VERSION AS 'Version de Sql Server';

SELECT ID_factura AS 'Código de Factura', ID_usuario AS 'Num Cliente', CONCAT (Marca, ' ', Modelo) AS 'Vehículo', DATEDIFF (DAY,Fecha_inicio, Fecha_fin) AS 'Días rentado', Valor_unidad AS 'Precio por día',
	[dbo].[TipoSeguro].poliza_seguro AS 'Seguro', precio_poliza AS  'Precio Seguro', nombre_equipamento AS 'Equimamento', precio_equipamento AS 'Precio del equipamento',
	CONCAT('$ ', Valor_unidad * DATEDIFF (DAY,Fecha_inicio, Fecha_fin) + (precio_equipamento + precio_poliza) + (Valor_unidad * DATEDIFF (DAY,Fecha_inicio, Fecha_fin) + (precio_equipamento + precio_poliza)) * 13/100) AS 'Precio total'
FROM [dbo].[Facturacion]
INNER JOIN [dbo].[Solicitudes] ON [dbo].[Facturacion].Id_solicitud = [dbo].[Solicitudes].ID_solicitud
INNER JOIN [dbo].[Usuario] ON [dbo].[Solicitudes].id_cliente = [dbo].[Usuario].ID_usuario
INNER JOIN [dbo].[RegistroVehiculo] ON [dbo].[Solicitudes].id_vehiculo = [dbo].[RegistroVehiculo].ID_vehiculo
INNER JOIN [dbo].[TipoSeguro] ON [dbo].[Facturacion].Poliza_seguro = [dbo].[TipoSeguro].ID_tipoSeguro
INNER JOIN [dbo].[Equipamentos] ON [dbo].[Facturacion].Equipamentos = [dbo].[Equipamentos].ID_equipamento
WHERE ID_usuario = 2023003;


SELECT * FROM [dbo].[Facturacion];
SELECT * FROM [dbo].[Solicitudes];
SELECT * FROM [dbo].[RegistroVehiculo];
SELECT * FROM [dbo].[TipoSeguro];
SELECT * FROM [dbo].[Equipamentos];
SELECT * FROM [dbo].[Reingreso];

UPDATE [dbo].[RegistroVehiculo] SET Kilometraje = 98543.2 WHERE ID_vehiculo = 1

GO
ALTER VIEW Reingresos AS 
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
SELECT * FROM Reingresos;

GO

GO
CREATE VIEW GetFactura AS 
SELECT ID_factura AS 'Código de Factura', CONCAT ('Factura: ', ID_factura, ', Cliente: ', ID_usuario, ' - ',Marca, ' ', Modelo) AS 'Vehículo'
	FROM [dbo].[Facturacion]
INNER JOIN [dbo].[Solicitudes] ON [dbo].[Facturacion].Id_solicitud = [dbo].[Solicitudes].ID_solicitud
INNER JOIN [dbo].[Usuario] ON [dbo].[Solicitudes].id_cliente = [dbo].[Usuario].ID_usuario
INNER JOIN [dbo].[RegistroVehiculo] ON [dbo].[Solicitudes].id_vehiculo = [dbo].[RegistroVehiculo].ID_vehiculo;
SELECT [Código de Factura] AS Codigo, [Vehículo] AS Carro FROM GetFactura;

GO
CREATE VIEW Factura_Final AS 
SELECT [dbo].[Facturacion].ID_factura AS 'Código de Factura', ID_usuario AS 'Num de registro', CONCAT(Nombre_usuario, ' ', Apellido_usuario) AS 'Nombre del Cliente', CONCAT (Marca, ' ', Modelo, ' - ', Anio) AS 'Vehículo', 
	CONCAT(DATEDIFF (DAY,Fecha_inicio, Fecha_fin), ' días') AS 'Días rentado', CONCAT('$ ', Valor_unidad) AS 'Precio por día', Fecha_inicio AS 'Rentado desde: ', 
	CONCAT( CONVERT(varchar, Hora_inicio, 108), ' ', 
		CASE
			WHEN DATEPART(HOUR, Hora_inicio) >= 12 THEN ' PM '
			ELSE ' AM '
			END
		) AS 'Entregado desde: ',
	CONCAT( CONVERT(varchar, Hora_fin, 108), ' ', 
		CASE
			WHEN DATEPART(HOUR, Hora_fin) >= 12 THEN ' PM '
			ELSE ' AM '
			END
		) AS 'Hasta la hora de: ', Fecha_fin AS 'del día: ',

	[dbo].[TipoSeguro].poliza_seguro AS 'Seguro', CONCAT('$ ', precio_poliza) AS  'Precio Seguro', nombre_equipamento AS 'Equimamento', CONCAT('$ ', precio_equipamento) AS 'Precio del equipamento',
	CONCAT('$ ', Valor_unidad * DATEDIFF (DAY,Fecha_inicio, Fecha_fin) + (precio_equipamento + precio_poliza) + (Valor_unidad * DATEDIFF (DAY,Fecha_inicio, Fecha_fin) + (precio_equipamento + precio_poliza)) * 13/100)AS 'Precio en la factura',
	CASE 
		WHEN DATEDIFF (DAY,Fecha_salida, Fecha_Entrada) > 0 THEN CONCAT('$ ', Valor_unidad * DATEDIFF (DAY,Fecha_inicio, Fecha_fin) + (precio_equipamento + precio_poliza) + 
		(Valor_unidad * DATEDIFF (DAY,Fecha_inicio, Fecha_fin) + (precio_equipamento + precio_poliza)) * 13/100 + Valor_unidad * DATEDIFF (DAY,Fecha_fin, Fecha_Entrada))
		ELSE 'Sin mora'
	END AS 'Total con mora'
FROM [dbo].[Facturacion]
INNER JOIN [dbo].[Solicitudes] ON [dbo].[Facturacion].Id_solicitud = [dbo].[Solicitudes].ID_solicitud
INNER JOIN [dbo].[Usuario] ON [dbo].[Solicitudes].id_cliente = [dbo].[Usuario].ID_usuario
INNER JOIN [dbo].[RegistroVehiculo] ON [dbo].[Solicitudes].id_vehiculo = [dbo].[RegistroVehiculo].ID_vehiculo
INNER JOIN [dbo].[TipoSeguro] ON [dbo].[Facturacion].Poliza_seguro = [dbo].[TipoSeguro].ID_tipoSeguro
INNER JOIN [dbo].[Equipamentos] ON [dbo].[Facturacion].Equipamentos = [dbo].[Equipamentos].ID_equipamento
INNER JOIN [dbo].[Reingreso] ON [dbo].[Facturacion].ID_factura = [dbo].[Reingreso].id_factura;
SELECT * FROM Factura_Final;
