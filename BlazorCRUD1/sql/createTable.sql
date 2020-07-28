-- 1
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AuthRoles](
	[ID] [int] IDENTITY(1,1) NOT NULL,
    [Name] [nvarchar](255),
	[NormalizedName] [nvarchar](255),
	[ConcurrencyStamp] [nvarchar](255) NOT NULL,
	[DELETED] [bit] NOT NULL,
	[UpdatedDateTime] [datetime] NOT NULL,
	[UpdatedBy] [nvarchar](255) NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AuthRoles] ADD PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AuthRoles] ADD  DEFAULT ((0)) FOR [DELETED]
GO

-- 2
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AuthUsers](
	[ID] [int] IDENTITY(1,1) NOT NULL,
    [UserName] [nvarchar](255),
	[NormalizedUserName] [nvarchar](255),
    [Email] [nvarchar](255),
	[NormalizedEmail] [nvarchar](255),
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](255),
	[SecurityStamp] [nvarchar](255),
    [ConcurrencyStamp] [nvarchar](255),
	[PhoneNumber] [nvarchar](255),
    [PhoneNumberConfirmed] [bit] NOT NULL,
    [TwoFactorEnabled] [bit] NOT NULL,
    [LockoutEnd] [datetime],
    [LockoutEnabled] [bit],
	[AccessFailedCount] [int],
	[DELETED] [bit] NOT NULL,
	[UpdatedDateTime] [datetime] NOT NULL,
	[UpdatedBy] [nvarchar](255) NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AuthUsers] ADD PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AuthUsers] ADD  DEFAULT ((0)) FOR [EmailConfirmed]
ALTER TABLE [dbo].[AuthUsers] ADD  DEFAULT ((0)) FOR [DELETED]
ALTER TABLE [dbo].[AuthUsers] ADD  DEFAULT ((0)) FOR [PhoneNumberConfirmed]
ALTER TABLE [dbo].[AuthUsers] ADD  DEFAULT ((0)) FOR [TwoFactorEnabled]
GO


-- 3
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AuthRoleClaims](
	[ID] [int] IDENTITY(1,1) NOT NULL,
    [RoleId] [nvarchar](255),
	[ClaimType] [nvarchar](255),
    [ClaimValue] [nvarchar](255),
	[DELETED] [bit] NOT NULL,
	[UpdatedDateTime] [datetime] NOT NULL,
	[UpdatedBy] [nvarchar](255) NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AuthRoleClaims] ADD PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AuthRoleClaims] ADD  DEFAULT ((0)) FOR [DELETED]
GO
