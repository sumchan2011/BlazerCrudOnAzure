CREATE TABLE [dbo].[Customer] (
    [ID]              INT             IDENTITY (1, 1) NOT NULL,
    [CustomerPhone]       INT             NOT NULL,
    [CustomerName]      NVARCHAR (255)  NOT NULL,
    [CustomerCompany]        NVARCHAR (255)  NOT NULL,
    [CustomerEmail]    DECIMAL (20, 6) DEFAULT ((0)) NULL,
    [DELETED]         BIT             DEFAULT ((0)) NOT NULL,
    [UpdatedDateTime] DATETIME        NOT NULL,
    [UpdatedBy]       NVARCHAR (255)  NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
);

