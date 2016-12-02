﻿CREATE TABLE [dbo].[Aluno]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nome] NVARCHAR(150) NOT NULL, 
    [DataNascimento] DATETIME NOT NULL, 
    [Bolsa] BIT NOT NULL, 
    [Desconto] FLOAT NULL, 
    [GrupoId] INT NOT NULL, 
    [CEP] NVARCHAR(8) NULL, 
    [Numero] INT NULL, 
    [Complemento] NVARCHAR(50) NULL, 
    CONSTRAINT [FK_Aluno_Grupo] FOREIGN KEY ([GrupoId]) REFERENCES [Grupo]([Id])
)
