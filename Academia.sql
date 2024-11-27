USE master;
GO

IF EXISTS (SELECT * FROM sys.databases WHERE name = 'Academia')
    DROP DATABASE Academia;
GO

SET DATEFORMAT dmy;
GO

CREATE DATABASE Academia;
GO

USE Academia;
GO

IF EXISTS (SELECT * FROM sys.objects WHERE name = 'Planos' AND type = 'U')
    DROP TABLE Planos;
GO


CREATE TABLE Planos 
(
    CodPlano INT PRIMARY KEY IDENTITY(1,1),  
    Plano NVARCHAR(50) NOT NULL,             
    Descricao NVARCHAR(255),                  
    Valor DECIMAL(10, 2) NOT NULL             
);
GO


INSERT INTO Planos (Plano, Descricao, Valor)
VALUES ('Madeira', 'Teste', 10.34);
GO


IF EXISTS (SELECT * FROM sys.objects WHERE name = 'Alunos' AND type = 'U')
    DROP TABLE Alunos;
GO


CREATE TABLE Alunos
(
    CodAluno INT PRIMARY KEY IDENTITY(1,1),   
    RG NVARCHAR(20) UNIQUE,                    
    CPF NVARCHAR(14) UNIQUE NOT NULL,         
    Nome NVARCHAR(100) NOT NULL,               
    DataNascimento DATE,                       
    CEP NVARCHAR(10),                          
    Peso DECIMAL(6,2),  
    Altura DECIMAL(4,2),  
    Objetivo NVARCHAR(20) CHECK (Objetivo IN ('Emagrecer', 'Engordar', 'Saude')), 
    Sexo CHAR(1) CHECK (Sexo IN ('M', 'F')) 
);

GO


INSERT INTO Alunos (RG, CPF, Nome, DataNascimento, CEP, Peso, Altura, Objetivo, Sexo)
VALUES ('123', '12345678901', 'rrsrsr', '2004-04-12', '25265-500', 152.00, 1.75, 'Engordar', 'M');

INSERT INTO Alunos (RG, CPF, Nome, DataNascimento, CEP, Peso, Altura, Objetivo, Sexo)
VALUES ('124', '98765432100', 'Maria Oliveira', '2002-08-25', '24890-200', 60.50, 1.65, 'Emagrecer', 'F');

INSERT INTO Alunos (RG, CPF, Nome, DataNascimento, CEP, Peso, Altura, Objetivo, Sexo)
VALUES ('125', '12309876543', 'Carlos Pereira', '1998-12-30', '12345-678', 75.00, 1.80, 'Emagrecer', 'M');

INSERT INTO Alunos (RG, CPF, Nome, DataNascimento, CEP, Peso, Altura, Objetivo, Sexo)
VALUES ('126', '98712345678', 'Ana Souza', '1995-03-10', '34567-890', 65.00, 1.70, 'Engordar', 'F');
GO

Select * from Alunos;
Select * from Planos;