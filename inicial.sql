IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
CREATE TABLE [TB_REQUERIMENTOS] (
    [Id] int NOT NULL IDENTITY,
    [Momento] varchar(200) NOT NULL,
    [TipoRequerimento] varchar(200) NOT NULL,
    [IdLocacao] varchar(200) NOT NULL,
    [Observacao] varchar(200) NOT NULL,
    [Situacao] varchar(200) NOT NULL,
    [DataAtualizacao] varchar(200) NOT NULL,
    [IdUsuarioAtualizacao] varchar(200) NOT NULL,
    CONSTRAINT [PK_TB_REQUERIMENTOS] PRIMARY KEY ([Id])
);

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'DataAtualizacao', N'IdLocacao', N'IdUsuarioAtualizacao', N'Momento', N'Observacao', N'Situacao', N'TipoRequerimento') AND [object_id] = OBJECT_ID(N'[TB_REQUERIMENTOS]'))
    SET IDENTITY_INSERT [TB_REQUERIMENTOS] ON;
INSERT INTO [TB_REQUERIMENTOS] ([Id], [DataAtualizacao], [IdLocacao], [IdUsuarioAtualizacao], [Momento], [Observacao], [Situacao], [TipoRequerimento])
VALUES (1, '01/06/2025', '001', '007', 'Na locação de um objeto', 'Preciso da chave para meu armario.', 'Em analise', 'Requerimento sem custo'),
(2, '02/06/2025', '002', '006', ' Utilizando um objeto', 'Perdi as chaves do meu armario', 'Concluido', 'Requerimento com custo'),
(3, '03/06/2025', '003', '005', ' Utilizando um objeto', 'o armario tem um objeto do antigo usuario', 'Concluido', 'Requerimento sem custo'),
(4, '04/06/2025', '004', '004', ' Utilizando um objeto', 'quero canselar o plano e receber o restante do meu dinheiro', 'Negado', 'Requerimento com custo'),
(5, '05/06/2025', '005', '003', ' Utilizando um objeto', 'Perdi as chaves do meu armario ', 'Respondido', 'Requerimento com custo');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'DataAtualizacao', N'IdLocacao', N'IdUsuarioAtualizacao', N'Momento', N'Observacao', N'Situacao', N'TipoRequerimento') AND [object_id] = OBJECT_ID(N'[TB_REQUERIMENTOS]'))
    SET IDENTITY_INSERT [TB_REQUERIMENTOS] OFF;

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20250625191515_InitialCreate', N'9.0.6');

COMMIT;
GO

