CREATE TABLE [dbo].[OrderDetail] (
    [OrderDetailId]   INT        IDENTITY (1, 1) NOT NULL,
    [OrderId]         INT        NOT NULL,
    [ProductId]       INT        NOT NULL,
    [OrderedQuantity] INT        CONSTRAINT [DF_OrderDetail_OrderedQuantity] DEFAULT ((0)) NOT NULL,
    [Quantity]        INT        CONSTRAINT [DF_OrderDetail_Quantity] DEFAULT ((0)) NOT NULL,
    [UnitPrice]       SMALLMONEY CONSTRAINT [DF_OrderDetail_UnitPrice] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_OrderDetail] PRIMARY KEY CLUSTERED ([OrderDetailId] ASC),
    CONSTRAINT [FK_OrderDetail_Orders] FOREIGN KEY ([OrderId]) REFERENCES [dbo].[Orders] ([OrderId]),
    CONSTRAINT [FK_OrderDetail_Product] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Product] ([ProductId])
);

