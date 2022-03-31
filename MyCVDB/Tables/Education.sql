CREATE TABLE [dbo].[Education] (
    [IdEdu]         INT           IDENTITY (1, 1) NOT NULL,
    [SchoolName]    VARCHAR (80)  NULL,
    [SchoolScience] VARCHAR (200) NULL,
    [Degree]        VARCHAR (80)  NULL,
    [StartDate]     DATETIME2 (7) NULL,
    [EndDate]       DATETIME2 (7) NULL,
    [City]          VARCHAR (50)  NULL,
    [Country]       VARCHAR (50)  NULL,
    [IdPers]        INT           NULL,
    [StatusId]      INT           NULL,
    PRIMARY KEY CLUSTERED ([IdEdu] ASC),
    CONSTRAINT [FK_Education_PersInfo] FOREIGN KEY ([IdPers]) REFERENCES [dbo].[PersonInfo] ([IdPers]),
    CONSTRAINT [FK_Education_Status] FOREIGN KEY ([StatusId]) REFERENCES [dbo].[Status] ([StatusId])
);

