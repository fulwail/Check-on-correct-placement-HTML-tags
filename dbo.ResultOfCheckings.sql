CREATE TABLE [dbo].[ResultOfChecking] (
    [Id]         INT            IDENTITY (1, 1) NOT NULL,
    [IdTestCase] INT            NOT NULL,
    [DateTime]   DATETIME       NOT NULL,
    [Result]     NVARCHAR (MAX) NULL,
    [CountToken] INT            NOT NULL,
    CONSTRAINT [PK_dbo.ResultOfCheckings] PRIMARY KEY CLUSTERED ([Id] ASC)
);
