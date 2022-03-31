CREATE PROCEDURE [dbo].[UpdatePersonInfo]
	@lastname VARCHAR(50),
	@firstname VARCHAR(50),
	@tel VARCHAR(50),
	@email VARCHAR(50),
	@address VARCHAR(250),
	@age INT,
	@nationality VARCHAR(50),
	@strengths VARCHAR(250),
	@weaknesses VARCHAR(250),
	@objective VARCHAR(350),
	@profile VARCHAR(250),
	@socialmedia VARCHAR(250),
	@infosup VARCHAR(250),
	@idpers INT

	
	
AS
	BEGIN
		UPDATE PersonInfo SET LastName = @lastname, FirstName = @firstname, Tel = @tel, Email = @email, [Address] = @address,
		Age = @age, Nationality = @nationality, Strengths = @strengths, Weaknesses = @weaknesses, Objective = @objective,
		[Profile] = @profile, SocialMedia = @socialmedia , InfoSup = @infosup
		WHERE IdPers = @idpers
	END