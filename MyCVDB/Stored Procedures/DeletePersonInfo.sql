CREATE PROCEDURE [dbo].[DeletePersonInfo]
	@id INT
AS
BEGIN
	DELETE FROM PersonInfo WHERE IdPers = @id
END