USE [EmployeeDB]
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'072820bd-4938-45e9-b9ba-2224bea6f4ac', N'Super Admin', N'SUPER ADMIN', N'84a97a43-e238-4c93-8ed0-35ba30241060')
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'0c3103d2-e917-4799-91ed-d93120027ee3', N'User', N'USER', N'396237d4-d944-41a7-a87c-35b2caa32506')
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'31603c9e-da68-4d21-b28e-55769f3dbacf', N'Admin', N'ADMIN', N'682eaf37-88ad-486a-bf5b-d50b4e50fcff')
GO
INSERT [dbo].[AspNetUsers] ([Id], [City], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'20fa9149-49ac-4d21-beda-29921637b602', N'Hyderabad', N'admin@gmail.com', N'ADMIN@GMAIL.COM', N'admin@gmail.com', N'ADMIN@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAELQh1vJzpFbyWTGcLOm4CJROJp/cc7VcA3lL8h9oz5omZ8ungmb6Wi/HFHV5d4B3lw==', N'R3FTVRN4G4FUZ4VEU3EVHQ5WMXTE4JGN', N'35f8795e-93bc-4560-a236-89b93a300622', NULL, 0, 0, NULL, 1, 0)
GO
INSERT [dbo].[AspNetUsers] ([Id], [City], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'8f9a1e95-6e7c-4628-8930-c6a74fb603d2', N'Hyderabad', N'user@gmail.com', N'USER@GMAIL.COM', N'user@gmail.com', N'USER@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEJ9PdKupJy9tNEUhQGlp3i7EJq+ya96CQhlLyl2qK4WrCOUqgFOoBk5tU6QwApT4dQ==', N'7C2ZHNAX3PMJKSSG4MPIOD5QAO2EX5JX', N'34ff275c-0b13-4570-bbb4-d5d10305394a', NULL, 0, 0, NULL, 1, 0)
GO
INSERT [dbo].[AspNetUsers] ([Id], [City], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'e9c1395b-f900-4abb-8910-152aef17bfcc', N'Hyderabad', N'padmasekhar@gmail.com', N'PADMASEKHAR@GMAIL.COM', N'padmasekhar@gmail.com', N'PADMASEKHAR@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEOdp88vsmMwfPXk8qjYhDW/JqcX+9d7qrgOnFNk8tTJy0PyLqr7U1JxGOyA3sTXHyA==', N'E4QXPW5FTRTKBENEWT22DWITMSH2KMQP', N'35eb7131-a165-475b-8334-967d98fd483b', NULL, 0, 0, NULL, 1, 0)
GO
INSERT [dbo].[AspNetUsers] ([Id], [City], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'ea7d82b6-3233-4579-b4a5-d2804d86a3c5', N'Hyderabad', N'superadmin@gmail.com', N'SUPERADMIN@GMAIL.COM', N'superadmin@gmail.com', N'SUPERADMIN@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEJlhNeQnOzizIY2Z2xgasQ1qXq0VUul72c1ol6hF45TTkxMSsr6jC2sae2CytYrUOg==', N'YKK36XRRR2IEWFOJIRDNLX75FLRCHENI', N'400f12cf-f199-4128-87f3-793988a6b154', NULL, 0, 0, NULL, 1, 0)
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'ea7d82b6-3233-4579-b4a5-d2804d86a3c5', N'072820bd-4938-45e9-b9ba-2224bea6f4ac')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'8f9a1e95-6e7c-4628-8930-c6a74fb603d2', N'0c3103d2-e917-4799-91ed-d93120027ee3')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'20fa9149-49ac-4d21-beda-29921637b602', N'31603c9e-da68-4d21-b28e-55769f3dbacf')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'e9c1395b-f900-4abb-8910-152aef17bfcc', N'31603c9e-da68-4d21-b28e-55769f3dbacf')
GO
SET IDENTITY_INSERT [dbo].[AspNetUserClaims] ON 
GO
INSERT [dbo].[AspNetUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (1, N'20fa9149-49ac-4d21-beda-29921637b602', N'Create Role', N'true')
GO
INSERT [dbo].[AspNetUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (2, N'20fa9149-49ac-4d21-beda-29921637b602', N'Edit Role', N'true')
GO
INSERT [dbo].[AspNetUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (3, N'20fa9149-49ac-4d21-beda-29921637b602', N'Delete Role', N'true')
GO
INSERT [dbo].[AspNetUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (4, N'e9c1395b-f900-4abb-8910-152aef17bfcc', N'Create Role', N'true')
GO
INSERT [dbo].[AspNetUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (5, N'e9c1395b-f900-4abb-8910-152aef17bfcc', N'Edit Role', N'true')
GO
INSERT [dbo].[AspNetUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (6, N'e9c1395b-f900-4abb-8910-152aef17bfcc', N'Delete Role', N'false')
GO
SET IDENTITY_INSERT [dbo].[AspNetUserClaims] OFF
GO
