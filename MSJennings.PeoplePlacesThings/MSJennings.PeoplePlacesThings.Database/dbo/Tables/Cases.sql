CREATE TABLE [dbo].[Cases] (
    [Id]        INT            IDENTITY (1, 1) NOT NULL,
    [CaseTitle] NVARCHAR (100) NOT NULL,
    CONSTRAINT [PK_Cases] PRIMARY KEY CLUSTERED ([Id] ASC)
);

