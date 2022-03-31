CREATE PROCEDURE [dbo].[DeleteCompetenceTech]
	@id INT
AS
BEGIN
	DELETE FROM ITSkills WHERE IdSk = @id
END