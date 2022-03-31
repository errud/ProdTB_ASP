CREATE TABLE [dbo].[PersonInfo] (
    [IdPers]      INT           IDENTITY (1, 1) NOT NULL,
    [FirstName]   VARCHAR (50)  NULL,
    [LastName]    VARCHAR (50)  NULL,
    [Tel]         VARCHAR (50)  NULL,
    [Email]       VARCHAR (50)  NULL,
    [Address]     VARCHAR (250) NULL,
    [Age]         INT           NULL,
    [Nationality] VARCHAR (50)  NULL,
    [Strengths]   VARCHAR (250) NULL,
    [Weaknesses]  VARCHAR (250) NULL,
    [Objective]   VARCHAR (350) NULL,
    [Profile]     VARCHAR (250) NULL,
    [SocialMedia] VARCHAR (250) NULL,
    [InfoSup]     VARCHAR (250) NULL,
    [PersoImage]  IMAGE         NULL,
    PRIMARY KEY CLUSTERED ([IdPers] ASC)
);

