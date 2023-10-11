CREATE TABLE [dbo].[Devices](
	[Id] int IDENTITY(1,1) PRIMARY KEY,
	[Temperature] [int] NULL,
	[Humidity] [int] NULL,
	[Occupancy] BIT NULL);
	