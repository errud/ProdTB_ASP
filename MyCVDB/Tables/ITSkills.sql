CREATE TABLE [dbo].[ITSkills] (
    [IdSk]       INT           IDENTITY (1, 1) NOT NULL,
    [SkillTyp]   VARCHAR (50)  NULL,
    [SkillName]  VARCHAR (200) NULL,
    [SkillYear]  DATETIME2 (7) NULL,
    [SkillLevel] VARCHAR (50)  NULL,
    [IdPers]     INT           NULL,
    [StatusId]   INT           NULL,
    PRIMARY KEY CLUSTERED ([IdSk] ASC),
    CONSTRAINT [FK_Skill_PersInfo] FOREIGN KEY ([IdPers]) REFERENCES [dbo].[PersonInfo] ([IdPers]),
    CONSTRAINT [FK_Skill_Status] FOREIGN KEY ([StatusId]) REFERENCES [dbo].[Status] ([StatusId])
);

