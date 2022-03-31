CREATE TABLE [dbo].[AppUser] (
    [Id]       INT            IDENTITY (1, 1) NOT NULL,
    [Email]    VARCHAR (50)   NOT NULL,
    [Password] VARBINARY (64) NOT NULL,
    [Salt]     VARCHAR (100)  NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

