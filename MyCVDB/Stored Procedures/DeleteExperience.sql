CREATE PROCEDURE [dbo].[DeleteExperience]
	@id INT
AS
BEGIN
	DELETE FROM Experience WHERE IdExp = @id
END