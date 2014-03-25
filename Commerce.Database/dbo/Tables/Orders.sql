CREATE TABLE [dbo].[Orders] (
    [OrderId]    INT           IDENTITY (1, 1) NOT NULL,
    [CustomerId] INT           NOT NULL,
    [OrderDate]  DATETIME2 (7) CONSTRAINT [DF_Order_OrderDate] DEFAULT (sysdatetime()) NOT NULL,
    [OrderTotal] SMALLMONEY    CONSTRAINT [DF_Order_OrderTotal] DEFAULT ((0)) NOT NULL,
    [ShipTo]     INT           NOT NULL,
    [Status]     TINYINT       NOT NULL,
    CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED ([OrderId] ASC),
    CONSTRAINT [FK_Orders_Customer] FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[Customer] ([CustomerId]),
    CONSTRAINT [FK_Orders_Customer1] FOREIGN KEY ([ShipTo]) REFERENCES [dbo].[Customer] ([CustomerId])
);

