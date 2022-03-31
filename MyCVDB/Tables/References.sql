CREATE TABLE [dbo].[References] (
    [IdRef]       INT           IDENTITY (1, 1) NOT NULL,
    [FullName]    VARCHAR (100) NULL,
    [Description] VARCHAR (300) NULL,
    [Position]    VARCHAR (100) NULL,
    [Company]     VARCHAR (80)  NULL,
    [Department]  VARCHAR (100) NULL,
    [Email]       VARCHAR (50)  NULL,
    [Tel]         VARCHAR (50)  NULL,
    [YearRef]     DATETIME2 (7) NULL,
    [IdPers]      INT           NULL,
    PRIMARY KEY CLUSTERED ([IdRef] ASC),
    CONSTRAINT [FK_References_PersInfo] FOREIGN KEY ([IdPers]) REFERENCES [dbo].[PersonInfo] ([IdPers])
);

