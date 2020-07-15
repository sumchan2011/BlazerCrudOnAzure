CREATE TABLE [dbo].[Store]
(
	[ID]				INT PRIMARY KEY IDENTITY (1, 1) NOT NULL,
	[StoreName]			NVARCHAR (255)  NOT NULL,
	[StoreAddress]		NVARCHAR (255)  NOT NULL,
	[StorelocalPhone]	NVARCHAR (255)  ,
	[StoreMobilePhone]	NVARCHAR (255)  ,
	[StoreFax]			NVARCHAR (255)  ,
	[StoreBANKAC1]		NVARCHAR (255)  ,
	[StoreBANKAC2]		NVARCHAR (255)  ,
	[StoreBANKAC3]		NVARCHAR (255)  ,
	[StoreEmail]		NVARCHAR (255)  ,
	[StoreUnit]			INT DEFAULT 0,
	[StoreItemPerPage]	INT DEFAULT 10,
)
