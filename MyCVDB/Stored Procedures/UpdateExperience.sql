CREATE PROCEDURE [dbo].[UpdateExperience]
    @company VARCHAR(80),
	@position VARCHAR(80),
	@descr VARCHAR(250),
	@stadt DATETIME2(7),
	@enddt DATETIME2(7),
	@city VARCHAR(50),
	@country VARCHAR(50),
	@idpers INT,
	@idexp INT
	
AS
	BEGIN
		UPDATE Experience SET Company = @company, Position = @position, [Description] = @descr,
		StartDate = @stadt, EndDate = @enddt, City = @city, Country = @country
		WHERE IdExp = @idexp
	END