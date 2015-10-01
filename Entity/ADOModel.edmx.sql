
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 10/27/2014 22:59:14
-- Generated from EDMX file: C:\Users\work\Documents\Fall_2014_Student_Projects\RosenbergMichael\PAXTraq\Entity\ADOModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [mikerosenberg];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_SwagPAX]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PAXes] DROP CONSTRAINT [FK_SwagPAX];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[PAXes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PAXes];
GO
IF OBJECT_ID(N'[dbo].[Swags]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Swags];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'PAXes'
CREATE TABLE [dbo].[PAXes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Type] nvarchar(max)  NOT NULL,
    [Year] bigint  NOT NULL,
    [Location] nvarchar(max)  NOT NULL,
    [SwagId] int  NOT NULL
);
GO

-- Creating table 'Swags'
CREATE TABLE [dbo].[Swags] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ParentID] nvarchar(max)  NOT NULL,
    [SwagYear] bigint  NOT NULL,
    [Company] nvarchar(max)  NOT NULL,
    [Game] nvarchar(max)  NOT NULL,
    [SwagType] nvarchar(max)  NOT NULL,
    [Method] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'PAXes'
ALTER TABLE [dbo].[PAXes]
ADD CONSTRAINT [PK_PAXes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Swags'
ALTER TABLE [dbo].[Swags]
ADD CONSTRAINT [PK_Swags]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [SwagId] in table 'PAXes'
ALTER TABLE [dbo].[PAXes]
ADD CONSTRAINT [FK_SwagPAX]
    FOREIGN KEY ([SwagId])
    REFERENCES [dbo].[Swags]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SwagPAX'
CREATE INDEX [IX_FK_SwagPAX]
ON [dbo].[PAXes]
    ([SwagId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------