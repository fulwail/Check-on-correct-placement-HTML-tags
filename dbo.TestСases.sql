CREATE TABLE [dbo].[TestСases] (
    [Id]   INT            IDENTITY (1, 1) NOT NULL,
    [Text] NVARCHAR (MAX) NULL,
    [Result_Id] INT NOT NULL, 
    CONSTRAINT [PK_dbo.TestСases] PRIMARY KEY CLUSTERED ([Id] ASC)
);

