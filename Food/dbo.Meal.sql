CREATE TABLE [dbo].[Meal] (
    [Id]          INT            NOT NULL IDENTITY,
    [Name]        NVARCHAR (50)  NULL,
    [Date]        DATETIME       NULL,
    [Description] NVARCHAR (200) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

