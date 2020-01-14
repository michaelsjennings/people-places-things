CREATE TABLE [dbo].[CaseUsers] (
    [Id]     INT IDENTITY (1, 1) NOT NULL,
    [CaseId] INT NOT NULL,
    [UserId] INT NOT NULL,
    CONSTRAINT [PK_CaseUsers] PRIMARY KEY CLUSTERED ([Id] ASC)
);

