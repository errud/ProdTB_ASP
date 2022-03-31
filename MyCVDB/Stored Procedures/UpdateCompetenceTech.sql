CREATE PROCEDURE [dbo].[UpdateCompetenceTech]
	@skillTyp VARCHAR(50),
	@skillName VARCHAR(200),
	@skillYear DateTime2(7),
	@skillLevel VARCHAR(50),
	@idPers INT,
	@statusId INT,
	@idSk INT
AS
	BEGIN
		
		UPDATE ITSkills SET SkillTyp = @skillTyp, SkillName = @skillName, SkillYear = @skillYear, SkillLevel = @skillLevel, IdPers = @idPers, StatusId = @statusId
		WHERE IdSk = @idSk
	
	END