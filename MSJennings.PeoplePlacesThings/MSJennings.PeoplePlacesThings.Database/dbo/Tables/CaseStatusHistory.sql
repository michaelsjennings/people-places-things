CREATE TABLE [dbo].[CaseStatusHistory] (
    [Id]           INT      IDENTITY (1, 1) NOT NULL,
    [CaseId]       INT      NOT NULL,
    [CaseStatusId] INT      NOT NULL,
    [StatusDate]   DATETIME NOT NULL,
    [UserId]       INT      NOT NULL,
    CONSTRAINT [PK_CaseStatusHistory] PRIMARY KEY CLUSTERED ([Id] ASC)
);

