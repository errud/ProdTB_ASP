CREATE PROCEDURE [dbo].[AjouterExperience]
	@company VARCHAR(80),
	@position VARCHAR(80),
	@descr VARCHAR(250),
	@stadt DATETIME2(7),
	@enddt DATETIME2(7),
	@city VARCHAR(50),
	@country VARCHAR(50),
	@idpers INT
	
   AS
	BEGIN
		INSERT INTO Experience (Company, Position, [Description], StartDate, EndDate, City, Country, IdPers) 
		VALUES (@company, @position, @descr, @stadt, @enddt, @city, @country, @idpers)
	END