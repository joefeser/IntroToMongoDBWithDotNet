CREATE TABLE [dbo].[Customer] (
    [CustomerId]      INT           IDENTITY (1, 1) NOT NULL,
    [FirstName]       NVARCHAR (50) NOT NULL,
    [LastName]        NVARCHAR (50) NOT NULL,
    [Address1]        NVARCHAR (75) NOT NULL,
    [Address2]        NVARCHAR (75) NULL,
    [City]            NVARCHAR (75) NOT NULL,
    [StateOrProvince] NVARCHAR (50) NOT NULL,
    [Country]         NVARCHAR (50) NOT NULL,
    [Email]           NVARCHAR (75) NOT NULL,
    [Phone]           NVARCHAR (25) NULL,
    CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED ([CustomerId] ASC)
);

