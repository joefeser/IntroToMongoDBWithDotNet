CREATE TABLE [dbo].[Publisher] (
    [PublisherId]   INT           IDENTITY (1, 1) NOT NULL,
    [PublisherName] NVARCHAR (75) NOT NULL,
    CONSTRAINT [PK_Publishers] PRIMARY KEY CLUSTERED ([PublisherId] ASC)
);

