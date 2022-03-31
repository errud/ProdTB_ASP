CREATE TABLE [dbo].[Experience] (
    [IdExp]       INT           IDENTITY (1, 1) NOT NULL,
    [Company]     VARCHAR (80)  NULL,
    [Position]    VARCHAR (80)  NULL,
    [Description] VARCHAR (250) NULL,
    [StartDate]   DATETIME2 (7) NULL,
    [EndDate]     DATETIME2 (7) NULL,
    [City]        VARCHAR (50)  NULL,
    [Country]     VARCHAR (50)  NULL,
    [IdPers]      INT           NULL,
    PRIMARY KEY CLUSTERED ([IdExp] ASC),
    CONSTRAINT [FK_Experience_PersInfo] FOREIGN KEY ([IdPers]) REFERENCES [dbo].[PersonInfo] ([IdPers])
);

