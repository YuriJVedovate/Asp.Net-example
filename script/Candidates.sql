--CREATE TABLE Partido (
--	Id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
--	Nome VARCHAR(255) NOT NULL,
--	Sigla VARCHAR(255) NOT NULL,
--	NumeroEleitoral INT NOT NULL,
--	Foto VARCHAR(255) NOT NULL
--);

--CREATE TABLE Vice (
--	Id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
--	Nome VARCHAR(255) NOT NULL,
--	PartidoId INT NOT NULL,
--	Idade INT NOT NULL,
--	Foto VARCHAR(255) NOT NULL,
--  CONSTRAINT FkPartido FOREIGN KEY (PartidoId) REFERENCES Partido(Id)
--	ON DELETE CASCADE
--);

--CREATE TABLE Candidato (
--	Id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
--	Nome VARCHAR(255) NOT NULL,
--	PartidoId INT NOT NULL,
--	Idade INT NOT NULL,
--	Posicao VARCHAR(255) NOT NULL,
--	ViceId INT NULL,
--	Foto VARCHAR(255) NOT NULL,
--	CONSTRAINT FkPartidoId FOREIGN KEY (PartidoId) REFERENCES Partido(Id)
--	ON DELETE CASCADE,
--	CONSTRAINT FkVice FOREIGN KEY (ViceId) REFERENCES Vice(Id)
--);


--select * from Partido P , candidato C, Vice V where p.Id = C.PartidoId and V.Id = C.ViceId;

