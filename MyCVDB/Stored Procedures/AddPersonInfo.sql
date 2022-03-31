CREATE PROCEDURE [dbo].[AddPersonInfo]
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
	@infosup VARCHAR(250)

	
	
AS
	BEGIN
		INSERT INTO PersonInfo (LastName, FirstName, Tel, Email, [Address], Age, Nationality, Strengths, Weaknesses, Objective, [Profile], SocialMedia, InfoSup) 
		VALUES (@lastname, @firstname, @tel, @email, @address, @age, @nationality, @strengths,	@weaknesses, @objective, @profile, @socialmedia, @infosup)
	END