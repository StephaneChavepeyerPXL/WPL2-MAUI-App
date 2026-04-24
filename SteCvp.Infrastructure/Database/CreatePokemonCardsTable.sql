CREATE TABLE dbo.PokemonCards (
                                  Id INT IDENTITY(1,1) PRIMARY KEY,
                                  Name NVARCHAR(50) NOT NULL,
                                  SetName NVARCHAR(50) NOT NULL,
                                  Rarity NVARCHAR(25) NOT NULL,
                                  EstimatedValue DECIMAL(10,2) NOT NULL,
                                  PhotoUrl NVARCHAR(500) NOT NULL
);