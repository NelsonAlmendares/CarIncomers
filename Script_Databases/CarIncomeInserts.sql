USE [CarIncome]
GO

-- -> Para la tabla de los Tipos de usuario para definir los niveles de acciones que se pueden realizar
SELECT * FROM [dbo].[TipoUsuario];
INSERT INTO [dbo].[TipoUsuario] (tipo_Usuario, descripcion_usuario) 
	VALUES ('Root', 'Solo pueden haber 2 usuarios con este nivel de acceso, controla las ventas y reportes del sistema');
INSERT INTO [dbo].[TipoUsuario] (tipo_Usuario, descripcion_usuario) 
	VALUES ('Administrador', 'Pueden haber como máximo 5 administradores, personas roles de insercciones y gestión de solicitudes');
INSERT INTO [dbo].[TipoUsuario] (tipo_Usuario, descripcion_usuario) 
	VALUES ('Cliente', 'Usuarios con el menor rango de acceso al sistema, accesan solicitudes y ven estados de las mismas');

-- -> Para la tabla de Estado de los usuarios
SELECT * FROM [dbo].[EstadoUsuario];
	INSERT INTO [dbo].[EstadoUsuario] (estado_usuario) VALUES ('Activo');
	INSERT INTO [dbo].[EstadoUsuario] (estado_usuario) VALUES ('Ináctivo');
	INSERT INTO [dbo].[EstadoUsuario] (estado_usuario) VALUES ('Mala reputación'); -- Solo par clientes

-- -> Para la tabla de Tipos de tarjetas en el sistema:
SELECT * FROM [dbo].[TipoTarjeta];
	INSERT INTO [dbo].[TipoTarjeta] (tipo_tarjeta) VALUES ('Crédito');
	INSERT INTO [dbo].[TipoTarjeta] (tipo_tarjeta) VALUES ('Débito');

-- -> Para la tabla de los tipos de vehiculos que se van a registrar en el sistema
SELECT * FROM [dbo].[TipoVehiculo];
	INSERT INTO [dbo].[TipoVehiculo] (tipo_vehiculo) VALUES ('Sedán');
	INSERT INTO [dbo].[TipoVehiculo] (tipo_vehiculo) VALUES ('Hatchback');
	INSERT INTO [dbo].[TipoVehiculo] (tipo_vehiculo) VALUES ('SUV');
	INSERT INTO [dbo].[TipoVehiculo] (tipo_vehiculo) VALUES ('Pickup');
	INSERT INTO [dbo].[TipoVehiculo] (tipo_vehiculo) VALUES ('Coupe');
	INSERT INTO [dbo].[TipoVehiculo] (tipo_vehiculo) VALUES ('VAN');
	INSERT INTO [dbo].[TipoVehiculo] (tipo_vehiculo) VALUES ('Minivan');
	INSERT INTO [dbo].[TipoVehiculo] (tipo_vehiculo) VALUES ('Microbus');

-- -> Para la tabla de los estados de las solicitudes realizadas por los clientes
SELECT * FROM [dbo].[EstadoSolicitud];
	INSERT INTO [dbo].[EstadoSolicitud] (estado_solicitud) VALUES ('Pendiente');
	INSERT INTO [dbo].[EstadoSolicitud] (estado_solicitud) VALUES ('En Proceso');
	INSERT INTO [dbo].[EstadoSolicitud] (estado_solicitud) VALUES ('Aprobada');
	INSERT INTO [dbo].[EstadoSolicitud] (estado_solicitud) VALUES ('Rechazada');

-- -> Para la tabla de los tipos de seguros disponibles:
SELECT * FROM [dbo].[TipoSeguro];
	INSERT INTO [dbo].[TipoSeguro] (poliza_seguro, descripcion_poliza, precio_poliza) 
		VALUES ('Protección en el camino', 'Sientete seguro con la respuesta en caso de un incidente dentro del área metropolina', 15.99);
	INSERT INTO [dbo].[TipoSeguro] (poliza_seguro, descripcion_poliza, precio_poliza) 
		VALUES ('Máxima proteción', 'Respuesta inmediata a todos los confines del país. Elegido por la mayoría', 30.55);

-- -> Para la tabla de equipamentos del vehículos
SELECT * FROM [dbo].[Equipamentos];
INSERT INTO [dbo].[Equipamentos] (nombre_equipamento, descripcion_equipamento, precio_equipamento) 
	VALUES ('Conductor extra', 'El conductor debe ser mayor de edad y presentar licencia de conducir vigente', 5.00);
INSERT INTO [dbo].[Equipamentos] (nombre_equipamento, descripcion_equipamento, precio_equipamento) 
	VALUES ('Asientos para recién nacido', 'Ideal para mantener la seguridad de los nuevos integrantes de la familia', 5.00);
INSERT INTO [dbo].[Equipamentos] (nombre_equipamento, descripcion_equipamento, precio_equipamento) 
	VALUES ('Sin Equipamento', 'No se desea agregar otro equipo a la renta', 0.00);

-- -> Para la tabla de Contactos
SELECT * FROM [dbo].[Contactos];
INSERT INTO [dbo].[Contactos] (id_usuario, Nombre_contacto, Apellido_contacto, Telefono_contacto, Email_contacto) VALUES ('');

-- -> Para la tabla de Facturaciones
SELECT * FROM [dbo].[Facturacion];

SELECT * FROM [dbo].[TipoSeguro];

INSERT INTO [dbo].[Facturacion] (Id_solicitud, Kilometraje_vehiculo, Hora_salida, Fecha_salida, Detalles_vehiculo, Numero_tarjeta, Pin_tarjeta, Poliza_seguro, Tipo_tarjeta, Equipamentos) 
	VALUES ('');

-- -> Para la tabla de Solicitudes
INSERT INTO [dbo].[Solicitudes] (id_cliente, id_estadoSolicitud, id_vehiculo, Fecha_inicio, Fecha_fin, Hora_inicio, Hora_fin)
	VALUES ('');

-- -> Para los registros de los nuevos usuarios:
SELECT * FROM [dbo].[Usuario];
-- DELETE FROM [dbo].[Usuario]  WHERE ID_usuario = 2023001;
SELECT ID_vehiculo ,CONCAT(Marca, ' ', Modelo, ' - Año ',' ', Anio) AS Vehiculo FROM [dbo].[RegistroVehiculo];

SELECT ID_contacto AS ID, CONCAT(Nombre_usuario, ' ' , Apellido_usuario) AS Usuario, 
	CONCAT (Nombre_contacto, ' ', Apellido_contacto) AS 'Nombre del contacto', 
	CONCAT ('+ 503 ', STUFF(Telefono_contacto, LEN(Telefono_contacto) -3, 0, '-')) AS 'Celular de contacto', 
	Email_contacto AS 'Dirección de correo electrónico'
FROM [dbo].[Contactos]
INNER JOIN [dbo].[Usuario] ON [dbo].[Contactos].id_usuario = [dbo].[Usuario].ID_usuario;

GO
CREATE PROCEDURE Add_User --XXXXXXXXXXXXXXXXXXXXX CONTRASEÑA CON SHA256 (PARA MÁS SEGURIDAD SE HARÁ DOBLE AUTENTICACIÓN) XXXXXXXXXXXXXXXXXXXXX
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
			Telefono_usuario, Celular_usuario, Numero_tarjeta, Fecha_tarjeta, ID_estadoUsuario, ID_tipoUsuario, Acceso_usuario) 
			VALUES 
			(@Nombre, @Apellido, @DUI, @PWS, @Edad, @Telefono, 
			@Celular, @Tarjeta, @fecha_tarjeta , @ID_EstadoUsuario, @ID_TipoUsuario, @User);
		END
END;
EXEC Add_User @Nombre = 'Nelson José', @Apellido = 'Almendares', @DUI = '06375662-1', @PWS = 'Admin', @Edad = 20, @Telefono = '2932-2312',  
	@Celular = '7893-2412', @Tarjeta = '06375662-1', @Fecha = '2028-01-01', @ID_EstadoUsuario = 1, @ID_TipoUsuario = 1, @User = 'NelsonAlmendares';

-- -> Para la tabla de Registro de Vehiculos
SELECT * FROM [dbo].[RegistroVehiculo];

GO
CREATE PROCEDURE Add_Vehicle
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

EXEC Add_Vehicle @NumeroMotor = '1nr5016963', @NumeroChasis = '1HGBH41JXMN109186', @Capacidad = 5, @Kilometraje = 98543.2,
	@Transmicion = 'Automático', @FechaIngreso = '2023/09/12', @ValorUnidad = 45.00, @Puertas = 4,
	@Marca = 'Toyota', @Modelo = 'Yaris LE', @Anio = '2020', @Descripcion = 'Cómodo sedán apto para la ciudad y los exteriores, todos nuestros vehículos cuentan con cero ruidos y aire acondicionado.', @Equipaje = '4 Maletas', 
	@Placa = 'P352 541', @ID_TipoVhehiculo = 1

SELECT * FROM Registro_Vehiculo;

GO
ALTER VIEW Vehiculo AS 
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

SELECT * FROM Vehiculo WHERE estado_solicitud = 'Aprobada' AND id_cliente = 2023003;

SELECT * FROM [dbo].[Solicitudes];
SELECT * FROM [dbo].[EstadoSolicitud];
SELECT  ID_usuario ,CONCAT (Nombre_usuario, ' ' , Apellido_usuario) AS Usuario FROM [dbo].[Usuario] WHERE ID_tipoUsuario = 3;
SELECT  ID_usuario ,CONCAT (Nombre_usuario, ' ' , Apellido_usuario) AS Usuario FROM [dbo].[Usuario] WHERE ID_usuario = 2023003;

GO
CREATE PROCEDURE Update_Solicitud
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
EXEC Update_Solicitud @NEW_ID = 2023004 , @NEW_ESTAD = 3, @NEW_VEHICLE = 1, @NEW_STARTDATE = '', @NEW_FINISHDATE = '', @NEW_STARTHOUR = '', @NEW_FINISHTIME = '', @SOLICITUD_ID = 3;


UPDATE [dbo].[Solicitudes] 
	SET
		id_cliente = COALESCE(@NEW_ID, id_cliente),
		id_estadoSolicitud = COALESCE(@NEW_ESTAD, id_estadoSolicitud),
		id_vehiculo = COALESCE(@NEW_VEHICLE, id_vehiculo),
		Fecha_inicio = COALESCE(@NEW_STARTDATE, Fecha_inicio),
		Fecha_fin = COALESCE(@NEW_FINISHDATE, Fecha_fin),
		Hora_inicio = COALESCE(@NEW_STARTHOUR, Hora_inicio),
		Hora_fin = COALESCE(@NEW_FINISHTIME, Hora_fin)
	WHERE ID_solicitud = 1


INSERT INTO [dbo].[Reingreso] (id_factura, Kilometraje, Hora_entrada, Fecha_Entrada, Detalles) VALUES ('');
