USE [ControlCalidad]
GO
/****** Object:  Table [dbo].[Alerta]    Script Date: 14/2/2023 19:45:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alerta](
	[IdAlerta] [int] IDENTITY(1,1) NOT NULL,
	[FechaHoraDetiene] [datetime] NULL,
	[FechaHoraReinicio] [datetime] NULL,
	[IdSemaforo] [int] NULL,
	[IdTipoDefecto] [int] NULL,
	[IdOrdenProduccion] [int] NULL,
 CONSTRAINT [PK_Alerta] PRIMARY KEY CLUSTERED 
(
	[IdAlerta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Color]    Script Date: 14/2/2023 19:45:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Color](
	[IdColor] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [int] NULL,
	[Descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_Color] PRIMARY KEY CLUSTERED 
(
	[IdColor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Defecto]    Script Date: 14/2/2023 19:45:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Defecto](
	[IdDefecto] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NULL,
	[IdTipoDefecto] [int] NULL,
 CONSTRAINT [PK_Defecto] PRIMARY KEY CLUSTERED 
(
	[IdDefecto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 14/2/2023 19:45:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleado](
	[IdEmpleado] [int] IDENTITY(1,1) NOT NULL,
	[DNI] [varchar](50) NULL,
	[ApeYNom] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Rol] [varchar](50) NULL,
	[Contraseña] [varchar](50) NULL,
 CONSTRAINT [PK_Empleado] PRIMARY KEY CLUSTERED 
(
	[IdEmpleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EstadoOrden]    Script Date: 14/2/2023 19:45:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EstadoOrden](
	[IdEstadoOrden] [int] IDENTITY(1,1) NOT NULL,
	[Estado] [varchar](15) NULL,
 CONSTRAINT [PK__EstadoOr__F2E6940EB43A3FCD] PRIMARY KEY CLUSTERED 
(
	[IdEstadoOrden] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[JornadaLaboral]    Script Date: 14/2/2023 19:45:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[JornadaLaboral](
	[IdJornadaLaboral] [int] IDENTITY(1,1) NOT NULL,
	[FechaInicio] [datetime] NULL,
	[FechaFinal] [datetime] NULL,
	[CantParPrimera] [int] NULL,
	[CantParSegunda] [int] NULL,
	[IdEmpleado] [int] NULL,
	[IdOrdenProduccion] [int] NULL,
 CONSTRAINT [PK_JornadaLaboral] PRIMARY KEY CLUSTERED 
(
	[IdJornadaLaboral] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Linea]    Script Date: 14/2/2023 19:45:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Linea](
	[IdLinea] [int] IDENTITY(1,1) NOT NULL,
	[Numero] [int] NULL,
 CONSTRAINT [PK_Linea] PRIMARY KEY CLUSTERED 
(
	[IdLinea] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Modelo]    Script Date: 14/2/2023 19:45:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Modelo](
	[IdModelo] [int] IDENTITY(1,1) NOT NULL,
	[SKU] [varchar](50) NULL,
	[Denominacion] [varchar](50) NULL,
	[LimiteInferiorO] [int] NULL,
	[LimiteInferiorR] [int] NULL,
	[LimiteSuperiorO] [int] NULL,
	[LimiteSuperiorR] [int] NULL,
 CONSTRAINT [PK_Modelo] PRIMARY KEY CLUSTERED 
(
	[IdModelo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrdenProduccion]    Script Date: 14/2/2023 19:45:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrdenProduccion](
	[IdOrdenProduccion] [int] IDENTITY(1,1) NOT NULL,
	[Numero] [varchar](50) NULL,
	[FechaInicio] [datetime] NULL,
	[FechaFin] [datetime] NULL,
	[IdColor] [int] NULL,
	[IdModelo] [int] NULL,
	[IdEstadoOrden] [int] NULL,
	[IdLinea] [int] NULL,
	[IdEmpleado] [int] NULL,
 CONSTRAINT [PK_OrdenProduccion] PRIMARY KEY CLUSTERED 
(
	[IdOrdenProduccion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pie]    Script Date: 14/2/2023 19:45:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pie](
	[IdPie] [int] IDENTITY(1,1) NOT NULL,
	[Pie] [varchar](50) NULL,
 CONSTRAINT [PK_Pie] PRIMARY KEY CLUSTERED 
(
	[IdPie] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Registro]    Script Date: 14/2/2023 19:45:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Registro](
	[IdRegistro] [int] IDENTITY(1,1) NOT NULL,
	[Hora] [datetime] NULL,
	[IdDefecto] [int] NULL,
	[IdPie] [int] NULL,
	[IdJornadaLaboral] [int] NULL,
	[Cantidad] [int] NULL,
 CONSTRAINT [PK_Registro] PRIMARY KEY CLUSTERED 
(
	[IdRegistro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Semaforo]    Script Date: 14/2/2023 19:45:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Semaforo](
	[IdSemaforo] [int] IDENTITY(1,1) NOT NULL,
	[Semaforo] [varchar](50) NULL,
 CONSTRAINT [PK_Semaforo] PRIMARY KEY CLUSTERED 
(
	[IdSemaforo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoDefecto]    Script Date: 14/2/2023 19:45:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoDefecto](
	[IdTipoDefecto] [int] IDENTITY(1,1) NOT NULL,
	[Defecto] [varchar](50) NULL,
 CONSTRAINT [PK_TipoDefecto] PRIMARY KEY CLUSTERED 
(
	[IdTipoDefecto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Turno]    Script Date: 14/2/2023 19:45:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Turno](
	[IdTurno] [int] IDENTITY(1,1) NOT NULL,
	[HorarioInicio] [datetime] NULL,
	[HorarioFin] [datetime] NULL,
	[IdJornadaLaboral] [int] NULL,
 CONSTRAINT [PK_Turno] PRIMARY KEY CLUSTERED 
(
	[IdTurno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Color] ON 

INSERT [dbo].[Color] ([IdColor], [Codigo], [Descripcion]) VALUES (1, 3333, N'Rojo')
INSERT [dbo].[Color] ([IdColor], [Codigo], [Descripcion]) VALUES (2, 5454, N'Azul')
INSERT [dbo].[Color] ([IdColor], [Codigo], [Descripcion]) VALUES (3, 5678, N'Verde')
INSERT [dbo].[Color] ([IdColor], [Codigo], [Descripcion]) VALUES (4, 3231, N'Negro')
INSERT [dbo].[Color] ([IdColor], [Codigo], [Descripcion]) VALUES (5, 2222, N'Blanco')
INSERT [dbo].[Color] ([IdColor], [Codigo], [Descripcion]) VALUES (6, 8888, N'Gris')
SET IDENTITY_INSERT [dbo].[Color] OFF
GO
SET IDENTITY_INSERT [dbo].[Defecto] ON 

INSERT [dbo].[Defecto] ([IdDefecto], [Descripcion], [IdTipoDefecto]) VALUES (1, N'MAL PEGADO', 1)
INSERT [dbo].[Defecto] ([IdDefecto], [Descripcion], [IdTipoDefecto]) VALUES (2, N'PROBLEMA DE CUERO', 1)
INSERT [dbo].[Defecto] ([IdDefecto], [Descripcion], [IdTipoDefecto]) VALUES (3, N'SUELA ROTA', 1)
INSERT [dbo].[Defecto] ([IdDefecto], [Descripcion], [IdTipoDefecto]) VALUES (4, N'DISTINTOS TALLES', 1)
INSERT [dbo].[Defecto] ([IdDefecto], [Descripcion], [IdTipoDefecto]) VALUES (5, N'ARRUGA', 1)
INSERT [dbo].[Defecto] ([IdDefecto], [Descripcion], [IdTipoDefecto]) VALUES (6, N'MAL PINTADO', 1)
INSERT [dbo].[Defecto] ([IdDefecto], [Descripcion], [IdTipoDefecto]) VALUES (7, N'DESPEGADO', 2)
INSERT [dbo].[Defecto] ([IdDefecto], [Descripcion], [IdTipoDefecto]) VALUES (8, N'SUCIEDAD', 2)
INSERT [dbo].[Defecto] ([IdDefecto], [Descripcion], [IdTipoDefecto]) VALUES (9, N'HUMEDO', 2)
INSERT [dbo].[Defecto] ([IdDefecto], [Descripcion], [IdTipoDefecto]) VALUES (10, N'TALON TORCIDO', 2)
INSERT [dbo].[Defecto] ([IdDefecto], [Descripcion], [IdTipoDefecto]) VALUES (11, N'ROTO', 2)
SET IDENTITY_INSERT [dbo].[Defecto] OFF
GO
SET IDENTITY_INSERT [dbo].[Empleado] ON 

INSERT [dbo].[Empleado] ([IdEmpleado], [DNI], [ApeYNom], [Email], [Rol], [Contraseña]) VALUES (1, N'11111111', N'Martinez Luciana ', N'luciana@gmail.com', N'Supervisor Linea', N'123456')
INSERT [dbo].[Empleado] ([IdEmpleado], [DNI], [ApeYNom], [Email], [Rol], [Contraseña]) VALUES (2, N'22222222', N'Barraza Marisol ', N'marisol@gmail.com', N'Supervisor Calidad', N'123456')
INSERT [dbo].[Empleado] ([IdEmpleado], [DNI], [ApeYNom], [Email], [Rol], [Contraseña]) VALUES (3, N'33333333', N'Aparicio Facundo ', N'facundo@gmail.com', N'Administrador', N'123456')
INSERT [dbo].[Empleado] ([IdEmpleado], [DNI], [ApeYNom], [Email], [Rol], [Contraseña]) VALUES (4, N'44444444', N'Bechara Leandro ', N'leandro@gmail.com', N'Supervisor Calidad', N'123456')
INSERT [dbo].[Empleado] ([IdEmpleado], [DNI], [ApeYNom], [Email], [Rol], [Contraseña]) VALUES (5, N'55555555', N'Alfaro Fatima', N'fatima@gmail.com', N'Supervisor Linea', N'123456')
INSERT [dbo].[Empleado] ([IdEmpleado], [DNI], [ApeYNom], [Email], [Rol], [Contraseña]) VALUES (6, N'11111111', N'Sin Empleado', N'Sin Empleado', N'Sin Empleado', N'1111111111')
SET IDENTITY_INSERT [dbo].[Empleado] OFF
GO
SET IDENTITY_INSERT [dbo].[EstadoOrden] ON 

INSERT [dbo].[EstadoOrden] ([IdEstadoOrden], [Estado]) VALUES (1, N'Iniciada')
INSERT [dbo].[EstadoOrden] ([IdEstadoOrden], [Estado]) VALUES (2, N'Pausada')
INSERT [dbo].[EstadoOrden] ([IdEstadoOrden], [Estado]) VALUES (3, N'Finalizada')
SET IDENTITY_INSERT [dbo].[EstadoOrden] OFF
GO
SET IDENTITY_INSERT [dbo].[Linea] ON 

INSERT [dbo].[Linea] ([IdLinea], [Numero]) VALUES (1, 1)
INSERT [dbo].[Linea] ([IdLinea], [Numero]) VALUES (2, 2)
INSERT [dbo].[Linea] ([IdLinea], [Numero]) VALUES (3, 3)
INSERT [dbo].[Linea] ([IdLinea], [Numero]) VALUES (4, 4)
SET IDENTITY_INSERT [dbo].[Linea] OFF
GO
SET IDENTITY_INSERT [dbo].[Modelo] ON 

INSERT [dbo].[Modelo] ([IdModelo], [SKU], [Denominacion], [LimiteInferiorO], [LimiteInferiorR], [LimiteSuperiorO], [LimiteSuperiorR]) VALUES (1, N'11111', N'Air bike 
Nike', 5, 5, 10, 10)
INSERT [dbo].[Modelo] ([IdModelo], [SKU], [Denominacion], [LimiteInferiorO], [LimiteInferiorR], [LimiteSuperiorO], [LimiteSuperiorR]) VALUES (2, N'11112', N'Adidas FORUM MID', 5, 5, 10, 10)
INSERT [dbo].[Modelo] ([IdModelo], [SKU], [Denominacion], [LimiteInferiorO], [LimiteInferiorR], [LimiteSuperiorO], [LimiteSuperiorR]) VALUES (3, N'11113', N'Puma Mayze Stack', 5, 5, 10, 10)
INSERT [dbo].[Modelo] ([IdModelo], [SKU], [Denominacion], [LimiteInferiorO], [LimiteInferiorR], [LimiteSuperiorO], [LimiteSuperiorR]) VALUES (4, N'11114', N'Reebok Nano X1 Adventure', 5, 5, 10, 10)
INSERT [dbo].[Modelo] ([IdModelo], [SKU], [Denominacion], [LimiteInferiorO], [LimiteInferiorR], [LimiteSuperiorO], [LimiteSuperiorR]) VALUES (5, N'11115', N'Under Armour running UA HOVR', 5, 5, 10, 10)
INSERT [dbo].[Modelo] ([IdModelo], [SKU], [Denominacion], [LimiteInferiorO], [LimiteInferiorR], [LimiteSuperiorO], [LimiteSuperiorR]) VALUES (6, N'11116', N'Adidas Terrex', 5, 5, 10, 10)
SET IDENTITY_INSERT [dbo].[Modelo] OFF
GO
SET IDENTITY_INSERT [dbo].[Pie] ON 

INSERT [dbo].[Pie] ([IdPie], [Pie]) VALUES (1, N'Izquierdo')
INSERT [dbo].[Pie] ([IdPie], [Pie]) VALUES (2, N'Derecho')
SET IDENTITY_INSERT [dbo].[Pie] OFF
GO
SET IDENTITY_INSERT [dbo].[Semaforo] ON 

INSERT [dbo].[Semaforo] ([IdSemaforo], [Semaforo]) VALUES (1, N'Verde')
INSERT [dbo].[Semaforo] ([IdSemaforo], [Semaforo]) VALUES (2, N'Amarillo')
INSERT [dbo].[Semaforo] ([IdSemaforo], [Semaforo]) VALUES (3, N'Rojo')
SET IDENTITY_INSERT [dbo].[Semaforo] OFF
GO
SET IDENTITY_INSERT [dbo].[TipoDefecto] ON 

INSERT [dbo].[TipoDefecto] ([IdTipoDefecto], [Defecto]) VALUES (1, N'Observado')
INSERT [dbo].[TipoDefecto] ([IdTipoDefecto], [Defecto]) VALUES (2, N'Reproceso')
SET IDENTITY_INSERT [dbo].[TipoDefecto] OFF
GO
ALTER TABLE [dbo].[Alerta]  WITH CHECK ADD  CONSTRAINT [FK_Alerta_OrdenProduccion] FOREIGN KEY([IdOrdenProduccion])
REFERENCES [dbo].[OrdenProduccion] ([IdOrdenProduccion])
GO
ALTER TABLE [dbo].[Alerta] CHECK CONSTRAINT [FK_Alerta_OrdenProduccion]
GO
ALTER TABLE [dbo].[Alerta]  WITH CHECK ADD  CONSTRAINT [FK_Alerta_Semaforo] FOREIGN KEY([IdSemaforo])
REFERENCES [dbo].[Semaforo] ([IdSemaforo])
GO
ALTER TABLE [dbo].[Alerta] CHECK CONSTRAINT [FK_Alerta_Semaforo]
GO
ALTER TABLE [dbo].[Alerta]  WITH CHECK ADD  CONSTRAINT [FK_Alerta_TipoDefecto] FOREIGN KEY([IdTipoDefecto])
REFERENCES [dbo].[TipoDefecto] ([IdTipoDefecto])
GO
ALTER TABLE [dbo].[Alerta] CHECK CONSTRAINT [FK_Alerta_TipoDefecto]
GO
ALTER TABLE [dbo].[Defecto]  WITH CHECK ADD  CONSTRAINT [FK_Defecto_TipoDefecto] FOREIGN KEY([IdTipoDefecto])
REFERENCES [dbo].[TipoDefecto] ([IdTipoDefecto])
GO
ALTER TABLE [dbo].[Defecto] CHECK CONSTRAINT [FK_Defecto_TipoDefecto]
GO
ALTER TABLE [dbo].[JornadaLaboral]  WITH CHECK ADD  CONSTRAINT [FK_JornadaLaboral_Empleado] FOREIGN KEY([IdEmpleado])
REFERENCES [dbo].[Empleado] ([IdEmpleado])
GO
ALTER TABLE [dbo].[JornadaLaboral] CHECK CONSTRAINT [FK_JornadaLaboral_Empleado]
GO
ALTER TABLE [dbo].[JornadaLaboral]  WITH CHECK ADD  CONSTRAINT [FK_JornadaLaboral_OrdenProduccion] FOREIGN KEY([IdOrdenProduccion])
REFERENCES [dbo].[OrdenProduccion] ([IdOrdenProduccion])
GO
ALTER TABLE [dbo].[JornadaLaboral] CHECK CONSTRAINT [FK_JornadaLaboral_OrdenProduccion]
GO
ALTER TABLE [dbo].[OrdenProduccion]  WITH CHECK ADD  CONSTRAINT [FK_OrdenProduccion_Color] FOREIGN KEY([IdColor])
REFERENCES [dbo].[Color] ([IdColor])
GO
ALTER TABLE [dbo].[OrdenProduccion] CHECK CONSTRAINT [FK_OrdenProduccion_Color]
GO
ALTER TABLE [dbo].[OrdenProduccion]  WITH CHECK ADD  CONSTRAINT [FK_OrdenProduccion_Empleado] FOREIGN KEY([IdEmpleado])
REFERENCES [dbo].[Empleado] ([IdEmpleado])
GO
ALTER TABLE [dbo].[OrdenProduccion] CHECK CONSTRAINT [FK_OrdenProduccion_Empleado]
GO
ALTER TABLE [dbo].[OrdenProduccion]  WITH CHECK ADD  CONSTRAINT [FK_OrdenProduccion_EstadoOrden] FOREIGN KEY([IdEstadoOrden])
REFERENCES [dbo].[EstadoOrden] ([IdEstadoOrden])
GO
ALTER TABLE [dbo].[OrdenProduccion] CHECK CONSTRAINT [FK_OrdenProduccion_EstadoOrden]
GO
ALTER TABLE [dbo].[OrdenProduccion]  WITH CHECK ADD  CONSTRAINT [FK_OrdenProduccion_Linea] FOREIGN KEY([IdLinea])
REFERENCES [dbo].[Linea] ([IdLinea])
GO
ALTER TABLE [dbo].[OrdenProduccion] CHECK CONSTRAINT [FK_OrdenProduccion_Linea]
GO
ALTER TABLE [dbo].[OrdenProduccion]  WITH CHECK ADD  CONSTRAINT [FK_OrdenProduccion_Modelo] FOREIGN KEY([IdModelo])
REFERENCES [dbo].[Modelo] ([IdModelo])
GO
ALTER TABLE [dbo].[OrdenProduccion] CHECK CONSTRAINT [FK_OrdenProduccion_Modelo]
GO
ALTER TABLE [dbo].[Registro]  WITH CHECK ADD  CONSTRAINT [FK_Registro_Defecto] FOREIGN KEY([IdDefecto])
REFERENCES [dbo].[Defecto] ([IdDefecto])
GO
ALTER TABLE [dbo].[Registro] CHECK CONSTRAINT [FK_Registro_Defecto]
GO
ALTER TABLE [dbo].[Registro]  WITH CHECK ADD  CONSTRAINT [FK_Registro_JornadaLaboral] FOREIGN KEY([IdJornadaLaboral])
REFERENCES [dbo].[JornadaLaboral] ([IdJornadaLaboral])
GO
ALTER TABLE [dbo].[Registro] CHECK CONSTRAINT [FK_Registro_JornadaLaboral]
GO
ALTER TABLE [dbo].[Registro]  WITH CHECK ADD  CONSTRAINT [FK_Registro_Pie] FOREIGN KEY([IdPie])
REFERENCES [dbo].[Pie] ([IdPie])
GO
ALTER TABLE [dbo].[Registro] CHECK CONSTRAINT [FK_Registro_Pie]
GO
ALTER TABLE [dbo].[Turno]  WITH CHECK ADD  CONSTRAINT [FK_Turno_JornadaLaboral] FOREIGN KEY([IdJornadaLaboral])
REFERENCES [dbo].[JornadaLaboral] ([IdJornadaLaboral])
GO
ALTER TABLE [dbo].[Turno] CHECK CONSTRAINT [FK_Turno_JornadaLaboral]
GO
ALTER TABLE [dbo].[EstadoOrden]  WITH CHECK ADD  CONSTRAINT [CK__EstadoOrd__Estad__36B12243] CHECK  (([Estado]='Finalizada' OR [Estado]='Pausada' OR [Estado]='Iniciada'))
GO
ALTER TABLE [dbo].[EstadoOrden] CHECK CONSTRAINT [CK__EstadoOrd__Estad__36B12243]
GO
