
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/30/2019 10:55:26
-- Generated from EDMX file: C:\Users\nejip\source\repos\WindowsFormsApp1\WindowsFormsApp1\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [DataWorkTest];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_DivisionWorker]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[WorkerSet] DROP CONSTRAINT [FK_DivisionWorker];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[WorkerSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[WorkerSet];
GO
IF OBJECT_ID(N'[dbo].[DivisionSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DivisionSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'WorkerSet'
CREATE TABLE [dbo].[WorkerSet] (
    [WorkerId] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Age] int  NOT NULL,
    [Salary] int  NOT NULL,
    [Floor] nvarchar(max)  NOT NULL,
    [Division_DiuvisionId] int  NOT NULL
);
GO

-- Creating table 'DivisionSet'
CREATE TABLE [dbo].[DivisionSet] (
    [DiuvisionId] int IDENTITY(1,1) NOT NULL,
    [WorkerId] nvarchar(max)  NOT NULL,
    [Subdivision] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [WorkerId] in table 'WorkerSet'
ALTER TABLE [dbo].[WorkerSet]
ADD CONSTRAINT [PK_WorkerSet]
    PRIMARY KEY CLUSTERED ([WorkerId] ASC);
GO

-- Creating primary key on [DiuvisionId] in table 'DivisionSet'
ALTER TABLE [dbo].[DivisionSet]
ADD CONSTRAINT [PK_DivisionSet]
    PRIMARY KEY CLUSTERED ([DiuvisionId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Division_DiuvisionId] in table 'WorkerSet'
ALTER TABLE [dbo].[WorkerSet]
ADD CONSTRAINT [FK_DivisionWorker]
    FOREIGN KEY ([Division_DiuvisionId])
    REFERENCES [dbo].[DivisionSet]
        ([DiuvisionId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DivisionWorker'
CREATE INDEX [IX_FK_DivisionWorker]
ON [dbo].[WorkerSet]
    ([Division_DiuvisionId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------