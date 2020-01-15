CREATE TABLE [dbo].[Persons] (
    [Id]         INT            IDENTITY (1, 1) NOT NULL,
    [CaseId]     INT            NOT NULL,
    [FirstName]  NVARCHAR (100) NOT NULL,
    [MiddleName] NVARCHAR (100) NULL,
    [LastName]   NVARCHAR (100) NOT NULL,
    [BirthDate]  DATE           NULL,
    CONSTRAINT [PK_Persons] PRIMARY KEY CLUSTERED ([Id] ASC)
);

