USE master
GO

CREATE DATABASE Biblio
GO

USE Biblio
GO

CREATE TABLE Livre (
	CodeL VARCHAR(10) PRIMARY KEY, 
	Titre VARCHAR(80),
	Auteur VARCHAR(80),
	NbExemplaires INT
)
GO

INSERT INTO Livre VALUES ('L01','Intro Math','Samir',2)
INSERT INTO Livre VALUES ('L02','Physique facile','Saida',2)
INSERT INTO Livre VALUES ('L03','Init Windows','Fathia',2)
INSERT INTO Livre VALUES ('L04','Init Linux','Fathia',2)