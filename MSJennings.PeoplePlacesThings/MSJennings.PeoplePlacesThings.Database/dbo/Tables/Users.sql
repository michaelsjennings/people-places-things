CREATE TABLE [dbo].[Users] (
    [Id]           INT             IDENTITY (1, 1) NOT NULL,
    [DisplayName]  NVARCHAR (100)  NOT NULL,
    [EmailAddress] NVARCHAR (100)  NOT NULL,
    [PasswordHash] VARBINARY (100) NOT NULL,
    [PasswordSalt] NVARCHAR (100)  NOT NULL,
    [AuthToken]    NVARCHAR (100)  NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([Id] ASC)
);



