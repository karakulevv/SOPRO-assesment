# SOPRO-assesment

To use the features from this Web Application you need to Register new User.

Note: When registering user please use the values from the enum Union (EU, UK, USA). 

For the purpose of this project I've scripted only the data from the SQL database, after the migrations execute the following script:

***SCRIPT***

USE [SOPRO]
GO
SET IDENTITY_INSERT [dbo].[Package] ON 
GO
INSERT [dbo].[Package] ([Id], [Name], [Period], [CurrencyAmount], [CurrencyName], [Union]) VALUES (11, N'EU', 0, CAST(8.99 AS Decimal(8, 2)), N'EUR', 0)
GO
INSERT [dbo].[Package] ([Id], [Name], [Period], [CurrencyAmount], [CurrencyName], [Union]) VALUES (12, N'EU', 1, CAST(99.99 AS Decimal(8, 2)), N'EUR', 0)
GO
INSERT [dbo].[Package] ([Id], [Name], [Period], [CurrencyAmount], [CurrencyName], [Union]) VALUES (13, N'Enterprise', 0, CAST(10.99 AS Decimal(8, 2)), N'USD', 2)
GO
INSERT [dbo].[Package] ([Id], [Name], [Period], [CurrencyAmount], [CurrencyName], [Union]) VALUES (14, N'Enterprise', 1, CAST(100.99 AS Decimal(8, 2)), N'USD', 2)
GO
INSERT [dbo].[Package] ([Id], [Name], [Period], [CurrencyAmount], [CurrencyName], [Union]) VALUES (15, N'UK', 0, CAST(7.99 AS Decimal(8, 2)), N'GBP', 1)
GO
INSERT [dbo].[Package] ([Id], [Name], [Period], [CurrencyAmount], [CurrencyName], [Union]) VALUES (16, N'UK', 1, CAST(79.99 AS Decimal(8, 2)), N'GBP', 1)
GO
SET IDENTITY_INSERT [dbo].[Package] OFF
GO


************
