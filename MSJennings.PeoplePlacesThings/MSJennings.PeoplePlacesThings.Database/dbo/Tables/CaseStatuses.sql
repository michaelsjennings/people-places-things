CREATE TABLE [dbo].[CaseStatuses] (
    [Id]           INT            NOT NULL,
    [StatusName]   NVARCHAR (100) NOT NULL,
    [DisplayOrder] INT            NOT NULL,
    CONSTRAINT [PK_CaseStatuses] PRIMARY KEY CLUSTERED ([Id] ASC)
);

