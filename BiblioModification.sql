USE Biblio
GO

CREATE TABLE Theme 
(
CodeTh INT IDENTITY PRIMARY KEY, 
IntituleTh VARCHAR(100)
)
GO
ALTER TABLE Livre
ADD CodeTh INT REFERENCES Theme(CodeTh)

SELECT * FROM Livre

Insert INTO Theme VALUES ('Mathematique')
Insert INTO Theme VALUES ('Physique')
Insert INTO Theme VALUES ('Informatique')

SELECT * FROM Theme

DROP TABLE Adherent
GO
CREATE TABLE Adherent 
(
CodeA INT PRIMARY KEY IDENTITY, 
NomA VARCHAR(80), 
Adresse VARCHAR(100), 
DateInscription Datetime
)
GO