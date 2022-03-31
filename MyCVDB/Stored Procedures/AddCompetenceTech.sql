CREATE PROCEDURE [dbo].[AddCompetenceTech]
	@skillTyp VARCHAR(50),
	@skillName VARCHAR(200),
	@skillYear DateTime2(7),
	@skillLevel VARCHAR(50),
	@idPers INT,
	@statusId INT
AS
	BEGIN
		INSERT INTO ITSkills (SkillTyp, SkillName, SkillYear, SkillLevel, IdPers, StatusId) VALUES (@skillTyp, @skillName, @skillYear, @skillLevel, @idPers, @statusId)
	END