﻿CREATE TABLE [dbo].[Product] (
    [ProductId]        INT            IDENTITY (1, 1) NOT NULL,
    [ASIN]             VARCHAR (30)   NOT NULL,
    [BuyItNowPrice]    SMALLMONEY     CONSTRAINT [DF_Product_BuyItNowPrice] DEFAULT ((0)) NOT NULL,
    [CategoryId]       INT            NULL,
    [ESRBAgeRating]    NVARCHAR (50)  NULL,
    [Feature]          NVARCHAR (MAX) NULL,
    [Format]           NVARCHAR (50)  NULL,
    [Genre]            NVARCHAR (75)  NULL,
    [HardwarePlatform] NVARCHAR (75)  NULL,
    [LargeImage]       NVARCHAR (100) NULL,
    [ListPrice]        SMALLMONEY     CONSTRAINT [DF_Product_ListPrice] DEFAULT ((0)) NOT NULL,
    [Manufacturer]     NVARCHAR (75)  NULL,
    [Model]            NVARCHAR (50)  NULL,
    [Height]           SMALLMONEY     CONSTRAINT [DF_Product_Height] DEFAULT ((0)) NOT NULL,
    [Length]           SMALLMONEY     CONSTRAINT [DF_Product_Length] DEFAULT ((0)) NOT NULL,
    [Width]            SMALLMONEY     CONSTRAINT [DF_Product_Width] DEFAULT ((0)) NOT NULL,
    [Weight]           SMALLMONEY     CONSTRAINT [DF_Product_Weight] DEFAULT ((0)) NOT NULL,
    [PartNumber]       NVARCHAR (50)  NULL,
    [ProductGroup]     NVARCHAR (50)  NULL,
    [PublisherId]      INT            NULL,
    [Title]            NVARCHAR (250) NOT NULL,
    CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED ([ProductId] ASC),
    CONSTRAINT [FK_Product_Category] FOREIGN KEY ([CategoryId]) REFERENCES [dbo].[Category] ([CategoryId]),
    CONSTRAINT [FK_Product_Publisher] FOREIGN KEY ([PublisherId]) REFERENCES [dbo].[Publisher] ([PublisherId])
);

