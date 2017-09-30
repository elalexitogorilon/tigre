
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/30/2017 11:08:02
-- Generated from EDMX file: C:\Tigreapp\Tigreapp\DALTiger\TraderTiger.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [tigerdb];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_AccountEmailAccount]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EmailAccounts] DROP CONSTRAINT [FK_AccountEmailAccount];
GO
IF OBJECT_ID(N'[dbo].[FK_AccountTraderBuy]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TraderBuys] DROP CONSTRAINT [FK_AccountTraderBuy];
GO
IF OBJECT_ID(N'[dbo].[FK_AccountTraderSell]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TraderSells] DROP CONSTRAINT [FK_AccountTraderSell];
GO
IF OBJECT_ID(N'[dbo].[FK_EmailTypeEmailAccount]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EmailAccounts] DROP CONSTRAINT [FK_EmailTypeEmailAccount];
GO
IF OBJECT_ID(N'[dbo].[FK_PersonAccount]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Accounts] DROP CONSTRAINT [FK_PersonAccount];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Accounts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Accounts];
GO
IF OBJECT_ID(N'[dbo].[EmailAccounts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EmailAccounts];
GO
IF OBJECT_ID(N'[dbo].[EmailTypes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EmailTypes];
GO
IF OBJECT_ID(N'[dbo].[People]', 'U') IS NOT NULL
    DROP TABLE [dbo].[People];
GO
IF OBJECT_ID(N'[dbo].[TraderBuys]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TraderBuys];
GO
IF OBJECT_ID(N'[dbo].[TraderSells]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TraderSells];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Accounts'
CREATE TABLE [dbo].[Accounts] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [PersonId] int  NOT NULL,
    [Created] datetime  NOT NULL,
    [CreatedBy] nvarchar(max)  NULL,
    [Changed] datetime  NULL,
    [ChangedBy] datetime  NULL
);
GO

-- Creating table 'EmailAccounts'
CREATE TABLE [dbo].[EmailAccounts] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [AccountId] int  NOT NULL,
    [TypeEmailID] int  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [AlterEmail] nvarchar(max)  NULL,
    [Created] nvarchar(max)  NOT NULL,
    [CreatedBy] nvarchar(max)  NULL,
    [Changed] nvarchar(max)  NULL,
    [ChangedBy] nvarchar(max)  NULL
);
GO

-- Creating table 'EmailTypes'
CREATE TABLE [dbo].[EmailTypes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Type] nvarchar(max)  NOT NULL,
    [Created] nvarchar(max)  NOT NULL,
    [CreatedBy] nvarchar(max)  NULL,
    [Changed] nvarchar(max)  NULL,
    [ChangedBy] nvarchar(max)  NULL
);
GO

-- Creating table 'People'
CREATE TABLE [dbo].[People] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] varchar(50)  NOT NULL,
    [LastName] varchar(50)  NOT NULL,
    [Created] datetime  NOT NULL,
    [CreatedByID] uniqueidentifier  NULL,
    [ChangedDateTime] datetime  NULL,
    [ChangedBy] uniqueidentifier  NULL
);
GO

-- Creating table 'TraderBuys'
CREATE TABLE [dbo].[TraderBuys] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Accountid] int  NOT NULL,
    [Symbol] nvarchar(max)  NOT NULL,
    [Units] int  NOT NULL,
    [Prices] decimal(18,0)  NOT NULL,
    [Created] datetime  NOT NULL,
    [CreatedBy] nvarchar(max)  NULL,
    [Changed] nvarchar(max)  NULL,
    [ChangedBy] nvarchar(max)  NULL
);
GO

-- Creating table 'TraderSells'
CREATE TABLE [dbo].[TraderSells] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Accountid] int  NOT NULL,
    [Symbol] nvarchar(max)  NOT NULL,
    [Units] int  NOT NULL,
    [Prices] decimal(18,0)  NOT NULL,
    [Created] datetime  NOT NULL,
    [CreatedBy] nvarchar(max)  NULL,
    [Changed] nvarchar(max)  NULL,
    [ChangedBy] nvarchar(max)  NULL
);
GO

-- Creating table 'AccountCredentials'
CREATE TABLE [dbo].[AccountCredentials] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [AccountId] int  NOT NULL,
    [Created] datetime  NOT NULL,
    [CreatedBy] nvarchar(max)  NULL,
    [Changed] datetime  NULL,
    [ChangedBy] datetime  NULL,
    [UserID] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'AccountPayments'
CREATE TABLE [dbo].[AccountPayments] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [AccountId] int  NOT NULL,
    [Created] datetime  NOT NULL,
    [CreatedBy] nvarchar(max)  NULL,
    [Changed] datetime  NULL,
    [ChangedBy] datetime  NULL,
    [PaymentTypeID] int  NOT NULL,
    [Amount] decimal(18,0)  NOT NULL
);
GO

-- Creating table 'PaymentTypes'
CREATE TABLE [dbo].[PaymentTypes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [TypePayment] nvarchar(max)  NOT NULL,
    [Created] nvarchar(max)  NOT NULL,
    [CreatedBy] nvarchar(max)  NULL,
    [Changed] nvarchar(max)  NULL,
    [ChangedBy] nvarchar(max)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Accounts'
ALTER TABLE [dbo].[Accounts]
ADD CONSTRAINT [PK_Accounts]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'EmailAccounts'
ALTER TABLE [dbo].[EmailAccounts]
ADD CONSTRAINT [PK_EmailAccounts]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'EmailTypes'
ALTER TABLE [dbo].[EmailTypes]
ADD CONSTRAINT [PK_EmailTypes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'People'
ALTER TABLE [dbo].[People]
ADD CONSTRAINT [PK_People]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TraderBuys'
ALTER TABLE [dbo].[TraderBuys]
ADD CONSTRAINT [PK_TraderBuys]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TraderSells'
ALTER TABLE [dbo].[TraderSells]
ADD CONSTRAINT [PK_TraderSells]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AccountCredentials'
ALTER TABLE [dbo].[AccountCredentials]
ADD CONSTRAINT [PK_AccountCredentials]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AccountPayments'
ALTER TABLE [dbo].[AccountPayments]
ADD CONSTRAINT [PK_AccountPayments]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PaymentTypes'
ALTER TABLE [dbo].[PaymentTypes]
ADD CONSTRAINT [PK_PaymentTypes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [AccountId] in table 'EmailAccounts'
ALTER TABLE [dbo].[EmailAccounts]
ADD CONSTRAINT [FK_AccountEmailAccount]
    FOREIGN KEY ([AccountId])
    REFERENCES [dbo].[Accounts]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AccountEmailAccount'
CREATE INDEX [IX_FK_AccountEmailAccount]
ON [dbo].[EmailAccounts]
    ([AccountId]);
GO

-- Creating foreign key on [Accountid] in table 'TraderBuys'
ALTER TABLE [dbo].[TraderBuys]
ADD CONSTRAINT [FK_AccountTraderBuy]
    FOREIGN KEY ([Accountid])
    REFERENCES [dbo].[Accounts]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AccountTraderBuy'
CREATE INDEX [IX_FK_AccountTraderBuy]
ON [dbo].[TraderBuys]
    ([Accountid]);
GO

-- Creating foreign key on [Accountid] in table 'TraderSells'
ALTER TABLE [dbo].[TraderSells]
ADD CONSTRAINT [FK_AccountTraderSell]
    FOREIGN KEY ([Accountid])
    REFERENCES [dbo].[Accounts]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AccountTraderSell'
CREATE INDEX [IX_FK_AccountTraderSell]
ON [dbo].[TraderSells]
    ([Accountid]);
GO

-- Creating foreign key on [PersonId] in table 'Accounts'
ALTER TABLE [dbo].[Accounts]
ADD CONSTRAINT [FK_PersonAccount]
    FOREIGN KEY ([PersonId])
    REFERENCES [dbo].[People]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonAccount'
CREATE INDEX [IX_FK_PersonAccount]
ON [dbo].[Accounts]
    ([PersonId]);
GO

-- Creating foreign key on [TypeEmailID] in table 'EmailAccounts'
ALTER TABLE [dbo].[EmailAccounts]
ADD CONSTRAINT [FK_EmailTypeEmailAccount]
    FOREIGN KEY ([TypeEmailID])
    REFERENCES [dbo].[EmailTypes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmailTypeEmailAccount'
CREATE INDEX [IX_FK_EmailTypeEmailAccount]
ON [dbo].[EmailAccounts]
    ([TypeEmailID]);
GO

-- Creating foreign key on [AccountId] in table 'AccountCredentials'
ALTER TABLE [dbo].[AccountCredentials]
ADD CONSTRAINT [FK_AccountAccountCredentials]
    FOREIGN KEY ([AccountId])
    REFERENCES [dbo].[Accounts]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AccountAccountCredentials'
CREATE INDEX [IX_FK_AccountAccountCredentials]
ON [dbo].[AccountCredentials]
    ([AccountId]);
GO

-- Creating foreign key on [AccountId] in table 'AccountPayments'
ALTER TABLE [dbo].[AccountPayments]
ADD CONSTRAINT [FK_AccountAccountPayments]
    FOREIGN KEY ([AccountId])
    REFERENCES [dbo].[Accounts]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AccountAccountPayments'
CREATE INDEX [IX_FK_AccountAccountPayments]
ON [dbo].[AccountPayments]
    ([AccountId]);
GO

-- Creating foreign key on [PaymentTypeID] in table 'AccountPayments'
ALTER TABLE [dbo].[AccountPayments]
ADD CONSTRAINT [FK_PaymentTypeAccountPayments]
    FOREIGN KEY ([PaymentTypeID])
    REFERENCES [dbo].[PaymentTypes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PaymentTypeAccountPayments'
CREATE INDEX [IX_FK_PaymentTypeAccountPayments]
ON [dbo].[AccountPayments]
    ([PaymentTypeID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------