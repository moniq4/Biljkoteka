CREATE TABLE [dbo].[Registracija] (
    [Ime]     VARCHAR (50) NULL,
    [Prezime] VARCHAR (50) NULL,
    [Email]   VARCHAR (50) NOT NULL, 
    [Lozinka] VARCHAR (50) NULL,
	PRIMARY KEY CLUSTERED ([Email] ASC)
);

