IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Adress] (
    [ID] int NOT NULL IDENTITY,
    [Street] nvarchar(max) NULL,
    [Colony] nvarchar(max) NULL,
    [City] nvarchar(max) NULL,
    [State] nvarchar(max) NULL,
    [PostalCode] nvarchar(max) NULL,
    [Country] nvarchar(max) NULL,
    [AddressType] nvarchar(max) NULL,
    [StreetAddress] nvarchar(max) NULL,
    [ApartmentNumber] nvarchar(max) NULL,
    CONSTRAINT [PK_Adress] PRIMARY KEY ([ID])
);

GO

CREATE TABLE [AspNetRoles] (
    [Id] nvarchar(450) NOT NULL,
    [Name] nvarchar(256) NULL,
    [NormalizedName] nvarchar(256) NULL,
    [ConcurrencyStamp] nvarchar(max) NULL,
    CONSTRAINT [PK_AspNetRoles] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [AspNetUsers] (
    [Id] nvarchar(450) NOT NULL,
    [UserName] nvarchar(256) NULL,
    [NormalizedUserName] nvarchar(256) NULL,
    [Email] nvarchar(256) NULL,
    [NormalizedEmail] nvarchar(256) NULL,
    [EmailConfirmed] bit NOT NULL,
    [PasswordHash] nvarchar(max) NULL,
    [SecurityStamp] nvarchar(max) NULL,
    [ConcurrencyStamp] nvarchar(max) NULL,
    [PhoneNumber] nvarchar(max) NULL,
    [PhoneNumberConfirmed] bit NOT NULL,
    [TwoFactorEnabled] bit NOT NULL,
    [LockoutEnd] datetimeoffset NULL,
    [LockoutEnabled] bit NOT NULL,
    [AccessFailedCount] int NOT NULL,
    CONSTRAINT [PK_AspNetUsers] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [BondPayments] (
    [ID] int NOT NULL IDENTITY,
    [DateCreated] datetime2 NOT NULL,
    [UserEditedID] int NOT NULL,
    [DateEdited] datetime2 NOT NULL,
    [BondID] int NOT NULL,
    [PayedDate] datetime2 NOT NULL,
    [PremiumPayed] decimal(18,2) NOT NULL,
    [CommissionPayed] bit NOT NULL,
    [LiquidationNumber] int NOT NULL,
    [Status] nvarchar(max) NULL,
    CONSTRAINT [PK_BondPayments] PRIMARY KEY ([ID])
);

GO

CREATE TABLE [Branch] (
    [ID] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    [Alias] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Branch] PRIMARY KEY ([ID])
);

GO

CREATE TABLE [Clients] (
    [ID] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    [LastName] nvarchar(max) NULL,
    [SecondLastName] nvarchar(max) NULL,
    [DayOfBirth] datetime2 NULL,
    [Gender] nvarchar(max) NULL,
    [RFC] nvarchar(max) NULL,
    [PhoneNumber] nvarchar(max) NULL,
    [Email] nvarchar(max) NULL,
    [PersonType] nvarchar(max) NULL,
    [IssueDate] datetime2 NOT NULL,
    [CompanyName] nvarchar(max) NULL,
    CONSTRAINT [PK_Clients] PRIMARY KEY ([ID])
);

GO

CREATE TABLE [CommissionPayments] (
    [ID] int NOT NULL IDENTITY,
    [DateCrated] datetime2 NOT NULL,
    [UserEditedID] int NOT NULL,
    [DateEdited] datetime2 NOT NULL,
    [BondPaymentID] int NOT NULL,
    [PayedDate] datetime2 NOT NULL,
    [AmountPayed] decimal(18,2) NOT NULL,
    CONSTRAINT [PK_CommissionPayments] PRIMARY KEY ([ID])
);

GO

CREATE TABLE [Company] (
    [ID] int NOT NULL IDENTITY,
    [CompanyName] nvarchar(max) NULL,
    [RFC] nvarchar(max) NULL,
    [CompanyClassification] nvarchar(max) NULL,
    [CompanyType] nvarchar(max) NULL,
    [ConstitutionDate] datetime2 NULL,
    [IssueDate] datetime2 NOT NULL,
    [Alias] nvarchar(max) NULL,
    [Days_Payment_First_Recibe_New] int NOT NULL,
    [Days_Payment_First_Recibe_Renewal] int NOT NULL,
    CONSTRAINT [PK_Company] PRIMARY KEY ([ID])
);

GO

CREATE TABLE [Coverage] (
    [ID] int NOT NULL IDENTITY,
    [Descripcion] nvarchar(max) NULL,
    [Deductible] decimal(18,2) NOT NULL,
    [CovergaPlanID] int NOT NULL,
    CONSTRAINT [PK_Coverage] PRIMARY KEY ([ID])
);

GO

CREATE TABLE [DocumentType] (
    [ID] int NOT NULL IDENTITY,
    [Descripcion] nvarchar(max) NULL,
    CONSTRAINT [PK_DocumentType] PRIMARY KEY ([ID])
);

GO

CREATE TABLE [EndorsementType] (
    [ID] int NOT NULL IDENTITY,
    [Descripcion] nvarchar(max) NULL,
    [Transaction] nvarchar(max) NULL,
    CONSTRAINT [PK_EndorsementType] PRIMARY KEY ([ID])
);

GO

CREATE TABLE [PaymentType] (
    [ID] int NOT NULL IDENTITY,
    [Description] nvarchar(max) NULL,
    [TotalPayments] int NOT NULL,
    CONSTRAINT [PK_PaymentType] PRIMARY KEY ([ID])
);

GO

CREATE TABLE [SubAgent] (
    [ID] int NOT NULL IDENTITY,
    [CompanyName] nvarchar(max) NULL,
    [Name] nvarchar(max) NULL,
    [LastName] nvarchar(max) NULL,
    [SecondLastName] nvarchar(max) NULL,
    [PersonType] nvarchar(max) NULL,
    [PersonalEmail] nvarchar(max) NULL,
    [RFC] nvarchar(max) NULL,
    [IdentificationNumber] nvarchar(max) NULL,
    [PhoneNumber] nvarchar(max) NULL,
    [Bank] nvarchar(max) NULL,
    [Status] bit NOT NULL,
    [IssueDate] datetime2 NULL,
    [ExpirationDate] datetime2 NULL,
    CONSTRAINT [PK_SubAgent] PRIMARY KEY ([ID])
);

GO

CREATE TABLE [AspNetRoleClaims] (
    [Id] int NOT NULL IDENTITY,
    [RoleId] nvarchar(450) NOT NULL,
    [ClaimType] nvarchar(max) NULL,
    [ClaimValue] nvarchar(max) NULL,
    CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [AspNetUserClaims] (
    [Id] int NOT NULL IDENTITY,
    [UserId] nvarchar(450) NOT NULL,
    [ClaimType] nvarchar(max) NULL,
    [ClaimValue] nvarchar(max) NULL,
    CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [AspNetUserLogins] (
    [LoginProvider] nvarchar(450) NOT NULL,
    [ProviderKey] nvarchar(450) NOT NULL,
    [ProviderDisplayName] nvarchar(max) NULL,
    [UserId] nvarchar(450) NOT NULL,
    CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY ([LoginProvider], [ProviderKey]),
    CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [AspNetUserRoles] (
    [UserId] nvarchar(450) NOT NULL,
    [RoleId] nvarchar(450) NOT NULL,
    CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY ([UserId], [RoleId]),
    CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [AspNetUserTokens] (
    [UserId] nvarchar(450) NOT NULL,
    [LoginProvider] nvarchar(450) NOT NULL,
    [Name] nvarchar(450) NOT NULL,
    [Value] nvarchar(max) NULL,
    CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY ([UserId], [LoginProvider], [Name]),
    CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [CoveragePlan] (
    [ID] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    [RamoID] int NOT NULL,
    CONSTRAINT [PK_CoveragePlan] PRIMARY KEY ([ID]),
    CONSTRAINT [FK_CoveragePlan_Branch_RamoID] FOREIGN KEY ([RamoID]) REFERENCES [Branch] ([ID]) ON DELETE CASCADE
);

GO

CREATE TABLE [SubBranch] (
    [ID] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    [Alias] nvarchar(max) NULL,
    [MenuLetter] nvarchar(max) NULL,
    [InputForm] nvarchar(max) NULL,
    [RamoID] int NOT NULL,
    CONSTRAINT [PK_SubBranch] PRIMARY KEY ([ID]),
    CONSTRAINT [FK_SubBranch_Branch_RamoID] FOREIGN KEY ([RamoID]) REFERENCES [Branch] ([ID]) ON DELETE CASCADE
);

GO

CREATE TABLE [Client_Address] (
    [ClientID] int NOT NULL,
    [AddressID] int NOT NULL,
    CONSTRAINT [PK_Client_Address] PRIMARY KEY ([AddressID], [ClientID]),
    CONSTRAINT [FK_Client_Address_Adress_AddressID] FOREIGN KEY ([AddressID]) REFERENCES [Adress] ([ID]) ON DELETE CASCADE,
    CONSTRAINT [FK_Client_Address_Clients_ClientID] FOREIGN KEY ([ClientID]) REFERENCES [Clients] ([ID]) ON DELETE CASCADE
);

GO

CREATE TABLE [ClientDocumentation] (
    [ID] int NOT NULL IDENTITY,
    [ClientID] int NOT NULL,
    [FileName] nvarchar(max) NULL,
    [SavedDate] datetime2 NOT NULL,
    [Notes] nvarchar(max) NULL,
    [FileExtension] nvarchar(max) NULL,
    [Url] nvarchar(max) NULL,
    CONSTRAINT [PK_ClientDocumentation] PRIMARY KEY ([ID]),
    CONSTRAINT [FK_ClientDocumentation_Clients_ClientID] FOREIGN KEY ([ClientID]) REFERENCES [Clients] ([ID]) ON DELETE CASCADE
);

GO

CREATE TABLE [Contact] (
    [ID] int NOT NULL IDENTITY,
    [LastName] nvarchar(max) NULL,
    [SecondLastName] nvarchar(max) NULL,
    [DayOfBirth] datetime2 NOT NULL,
    [Gender] nvarchar(max) NULL,
    [ClientID] int NOT NULL,
    CONSTRAINT [PK_Contact] PRIMARY KEY ([ID]),
    CONSTRAINT [FK_Contact_Clients_ClientID] FOREIGN KEY ([ClientID]) REFERENCES [Clients] ([ID]) ON DELETE CASCADE
);

GO

CREATE TABLE [Agent] (
    [ID] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    [LastName] nvarchar(max) NULL,
    [SecondLastName] nvarchar(max) NULL,
    [IdentificationCardNumber] nvarchar(max) NULL,
    [ExpirationDate] datetime2 NULL,
    [Code] nvarchar(max) NULL,
    [PersonalEmail] nvarchar(max) NULL,
    [PersonType] nvarchar(max) NULL,
    [PhoneNumber] nvarchar(max) NULL,
    [IssueDate] datetime2 NOT NULL,
    [CompanyName] nvarchar(max) NULL,
    [Status] bit NOT NULL,
    [CompanyID] int NULL,
    CONSTRAINT [PK_Agent] PRIMARY KEY ([ID]),
    CONSTRAINT [FK_Agent_Company_CompanyID] FOREIGN KEY ([CompanyID]) REFERENCES [Company] ([ID]) ON DELETE NO ACTION
);

GO

CREATE TABLE [Company_Address] (
    [CompanyID] int NOT NULL,
    [AddressID] int NOT NULL,
    CONSTRAINT [PK_Company_Address] PRIMARY KEY ([AddressID], [CompanyID]),
    CONSTRAINT [FK_Company_Address_Adress_AddressID] FOREIGN KEY ([AddressID]) REFERENCES [Adress] ([ID]) ON DELETE CASCADE,
    CONSTRAINT [FK_Company_Address_Company_CompanyID] FOREIGN KEY ([CompanyID]) REFERENCES [Company] ([ID]) ON DELETE CASCADE
);

GO

CREATE TABLE [Ramo_Coverage] (
    [CoverageID] int NOT NULL,
    [BranchID] int NOT NULL,
    CONSTRAINT [PK_Ramo_Coverage] PRIMARY KEY ([CoverageID], [BranchID]),
    CONSTRAINT [FK_Ramo_Coverage_Branch_BranchID] FOREIGN KEY ([BranchID]) REFERENCES [Branch] ([ID]) ON DELETE CASCADE,
    CONSTRAINT [FK_Ramo_Coverage_Coverage_CoverageID] FOREIGN KEY ([CoverageID]) REFERENCES [Coverage] ([ID]) ON DELETE CASCADE
);

GO

CREATE TABLE [Agent_PaymentTypes] (
    [CompanyID] int NOT NULL,
    [PaymenTypeID] int NOT NULL,
    [PaymentID] int NULL,
    CONSTRAINT [PK_Agent_PaymentTypes] PRIMARY KEY ([CompanyID], [PaymenTypeID]),
    CONSTRAINT [FK_Agent_PaymentTypes_Company_CompanyID] FOREIGN KEY ([CompanyID]) REFERENCES [Company] ([ID]) ON DELETE CASCADE,
    CONSTRAINT [FK_Agent_PaymentTypes_PaymentType_PaymentID] FOREIGN KEY ([PaymentID]) REFERENCES [PaymentType] ([ID]) ON DELETE NO ACTION
);

GO

CREATE TABLE [CoveragePlan_Coverage] (
    [CoveragePlanID] int NOT NULL,
    [CoverageID] int NOT NULL,
    CONSTRAINT [PK_CoveragePlan_Coverage] PRIMARY KEY ([CoverageID], [CoveragePlanID]),
    CONSTRAINT [FK_CoveragePlan_Coverage_Coverage_CoverageID] FOREIGN KEY ([CoverageID]) REFERENCES [Coverage] ([ID]) ON DELETE CASCADE,
    CONSTRAINT [FK_CoveragePlan_Coverage_CoveragePlan_CoveragePlanID] FOREIGN KEY ([CoveragePlanID]) REFERENCES [CoveragePlan] ([ID]) ON DELETE CASCADE
);

GO

CREATE TABLE [Agent_Address] (
    [AgentID] int NOT NULL,
    [AddressID] int NOT NULL,
    CONSTRAINT [PK_Agent_Address] PRIMARY KEY ([AddressID], [AgentID]),
    CONSTRAINT [FK_Agent_Address_Adress_AddressID] FOREIGN KEY ([AddressID]) REFERENCES [Adress] ([ID]) ON DELETE CASCADE,
    CONSTRAINT [FK_Agent_Address_Agent_AgentID] FOREIGN KEY ([AgentID]) REFERENCES [Agent] ([ID]) ON DELETE CASCADE
);

GO

CREATE TABLE [Bond] (
    [ID] int NOT NULL IDENTITY,
    [DateCreated] datetime2 NOT NULL,
    [UserEditedID] int NOT NULL,
    [DateEdited] datetime2 NOT NULL,
    [CompanyID] int NOT NULL,
    [SubAgentID] int NOT NULL,
    [ClientID] int NOT NULL,
    [BeneficiaryID] int NOT NULL,
    [RiskTypeID] int NOT NULL,
    [MovementID] int NOT NULL,
    [BranchID] int NOT NULL,
    [OfficeID] int NOT NULL,
    [StatusID] int NOT NULL,
    [Branch] nvarchar(max) NULL,
    [BondNumber] nvarchar(max) NULL,
    [BillingNumber] nvarchar(max) NULL,
    [IssueDate] datetime2 NOT NULL,
    [Start] datetime2 NOT NULL,
    [End] datetime2 NOT NULL,
    [CovergeAmount] decimal(18,2) NOT NULL,
    [Premium] decimal(18,2) NOT NULL,
    [Fee] decimal(18,2) NOT NULL,
    [IssueCost] decimal(18,2) NOT NULL,
    [BureauCost] decimal(18,2) NOT NULL,
    [TaxPercentage] decimal(18,2) NOT NULL,
    [Tax] decimal(18,2) NOT NULL,
    [PremiumTotal] decimal(18,2) NOT NULL,
    [Payed] bit NOT NULL,
    [CommissionPercentage] decimal(18,2) NOT NULL,
    [GroupCommissionPercentage] decimal(18,2) NOT NULL,
    [ClientsID] int NULL,
    [AgentID] int NULL,
    CONSTRAINT [PK_Bond] PRIMARY KEY ([ID]),
    CONSTRAINT [FK_Bond_Agent_AgentID] FOREIGN KEY ([AgentID]) REFERENCES [Agent] ([ID]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Bond_Clients_ClientsID] FOREIGN KEY ([ClientsID]) REFERENCES [Clients] ([ID]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Bond_Company_CompanyID] FOREIGN KEY ([CompanyID]) REFERENCES [Company] ([ID]) ON DELETE CASCADE,
    CONSTRAINT [FK_Bond_SubAgent_SubAgentID] FOREIGN KEY ([SubAgentID]) REFERENCES [SubAgent] ([ID]) ON DELETE CASCADE
);

GO

CREATE TABLE [Insurance] (
    [ID] int NOT NULL IDENTITY,
    [InsuranceNumber] nvarchar(max) NULL,
    [ValidFrom] datetime2 NULL,
    [ValidThrought] datetime2 NULL,
    [SeniorityDate] datetime2 NULL,
    [Renewal] decimal(18,2) NULL,
    [ClientID] int NOT NULL,
    [AgentID] int NOT NULL,
    [SubBranchID] int NOT NULL,
    [CompanyID] int NOT NULL,
    [SubAgentID] int NOT NULL,
    [PaymentTypeID] int NOT NULL,
    [Status] int NOT NULL,
    [Payed] bit NOT NULL,
    [CurrencyType] nvarchar(max) NULL,
    [NetPremium] decimal(18,2) NOT NULL,
    [Discount] decimal(18,2) NOT NULL,
    [DiscountPercentage] decimal(18,2) NOT NULL,
    [Surcharges] decimal(18,2) NOT NULL,
    [Rights] decimal(18,2) NOT NULL,
    [tax] decimal(18,2) NOT NULL,
    [TaxPercentage] decimal(18,2) NOT NULL,
    [SubTotal] decimal(18,2) NOT NULL,
    [TotalPremium] decimal(18,2) NOT NULL,
    [ExchangeRate] decimal(18,2) NOT NULL,
    [Endorsement] bit NOT NULL,
    [EndorsementNumber] nvarchar(max) NULL,
    [ReferenceName] nvarchar(max) NULL,
    [ReferenceNumber] nvarchar(max) NULL,
    [ReferenceEmail] nvarchar(max) NULL,
    [Brand] nvarchar(30) NULL,
    [Car_Plates] nvarchar(30) NULL,
    [Car_Use] nvarchar(30) NULL,
    [Capacity] int NOT NULL,
    [Car_Motor] nvarchar(30) NULL,
    [Model] nvarchar(30) NULL,
    [Transmission] nvarchar(30) NULL,
    [Car_Description] nvarchar(150) NULL,
    [Insuree_LastName] nvarchar(30) NULL,
    [Insuree_SecondLastName] nvarchar(30) NULL,
    [Insuree_Name] nvarchar(50) NULL,
    [Insuree_BirthDate] datetime2 NOT NULL,
    [Insuree_RFC] nvarchar(20) NULL,
    [Insuree_CURP] nvarchar(20) NULL,
    [Insuree_Gender] nvarchar(20) NULL,
    [Secondary_Insuree_LastName] nvarchar(30) NULL,
    [Secondary_Insuree_SecondLastName] nvarchar(30) NULL,
    [Secondary_Insuree_Name] nvarchar(50) NULL,
    [Secondary_Insuree_BirthDate] datetime2 NOT NULL,
    [Secondary_Insuree_RFC] nvarchar(20) NULL,
    [Secondary_Insuree_CURP] nvarchar(20) NULL,
    [Secondary_Insuree_Gender] nvarchar(20) NULL,
    [Comission_NetPremium] decimal(18,2) NOT NULL,
    [Comission_NetPremium_Percentage] decimal(18,2) NOT NULL,
    [Comission_Surcharges] decimal(18,2) NOT NULL,
    [Comission_Surcharges_Percentage] decimal(18,2) NOT NULL,
    [Comission_Rights] decimal(18,2) NOT NULL,
    [Comission_Rights_Percentage] decimal(18,2) NOT NULL,
    [Comission_Special] decimal(18,2) NOT NULL,
    [Comission_Special_Percentage] decimal(18,2) NOT NULL,
    CONSTRAINT [PK_Insurance] PRIMARY KEY ([ID]),
    CONSTRAINT [FK_Insurance_Agent_AgentID] FOREIGN KEY ([AgentID]) REFERENCES [Agent] ([ID]) ON DELETE CASCADE,
    CONSTRAINT [FK_Insurance_Clients_ClientID] FOREIGN KEY ([ClientID]) REFERENCES [Clients] ([ID]) ON DELETE CASCADE,
    CONSTRAINT [FK_Insurance_Company_CompanyID] FOREIGN KEY ([CompanyID]) REFERENCES [Company] ([ID]) ON DELETE CASCADE,
    CONSTRAINT [FK_Insurance_PaymentType_PaymentTypeID] FOREIGN KEY ([PaymentTypeID]) REFERENCES [PaymentType] ([ID]) ON DELETE CASCADE,
    CONSTRAINT [FK_Insurance_SubAgent_SubAgentID] FOREIGN KEY ([SubAgentID]) REFERENCES [SubAgent] ([ID]) ON DELETE CASCADE,
    CONSTRAINT [FK_Insurance_SubBranch_SubBranchID] FOREIGN KEY ([SubBranchID]) REFERENCES [SubBranch] ([ID]) ON DELETE CASCADE
);

GO

CREATE TABLE [Endorsement] (
    [ID] int NOT NULL IDENTITY,
    [InsuranceID] int NOT NULL,
    [ValidFrom] datetime2 NOT NULL,
    [ValidThrought] datetime2 NOT NULL,
    [EndosementTypeID] int NOT NULL,
    [Description] nvarchar(max) NULL,
    [EndorsementTypeID] int NULL,
    CONSTRAINT [PK_Endorsement] PRIMARY KEY ([ID]),
    CONSTRAINT [FK_Endorsement_EndorsementType_EndorsementTypeID] FOREIGN KEY ([EndorsementTypeID]) REFERENCES [EndorsementType] ([ID]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Endorsement_Insurance_InsuranceID] FOREIGN KEY ([InsuranceID]) REFERENCES [Insurance] ([ID]) ON DELETE CASCADE
);

GO

CREATE TABLE [InsuranceDocumentation] (
    [ID] int NOT NULL IDENTITY,
    [InsuranceID] int NOT NULL,
    [FileName] nvarchar(max) NULL,
    [SavedDate] datetime2 NOT NULL,
    [Notes] nvarchar(max) NULL,
    [FileExtension] nvarchar(max) NULL,
    [Url] nvarchar(max) NULL,
    CONSTRAINT [PK_InsuranceDocumentation] PRIMARY KEY ([ID]),
    CONSTRAINT [FK_InsuranceDocumentation_Insurance_InsuranceID] FOREIGN KEY ([InsuranceID]) REFERENCES [Insurance] ([ID]) ON DELETE CASCADE
);

GO

CREATE TABLE [PaymentInformation] (
    [ID] int NOT NULL IDENTITY,
    [Premium] decimal(18,2) NOT NULL,
    [InsuranceID] int NOT NULL,
    [PaymentExpirationDate] datetime2 NOT NULL,
    [PaymentNumber] nvarchar(max) NULL,
    [Payed] bit NOT NULL,
    [Canceled] bit NOT NULL,
    [Disabled] bit NOT NULL,
    [IssueDate] datetime2 NOT NULL,
    CONSTRAINT [PK_PaymentInformation] PRIMARY KEY ([ID]),
    CONSTRAINT [FK_PaymentInformation_Insurance_InsuranceID] FOREIGN KEY ([InsuranceID]) REFERENCES [Insurance] ([ID]) ON DELETE CASCADE
);

GO

CREATE TABLE [RegisterPayment] (
    [ID] int NOT NULL IDENTITY,
    [Bank] nvarchar(max) NULL,
    [PaymentAmount] decimal(18,2) NOT NULL,
    [DateRegistered] datetime2 NULL,
    [DocumentType] nvarchar(max) NULL,
    [DatePayment] datetime2 NOT NULL,
    [PaymentInformationID] int NOT NULL,
    [InsuranceID] int NOT NULL,
    [IssueDate] datetime2 NULL,
    CONSTRAINT [PK_RegisterPayment] PRIMARY KEY ([ID]),
    CONSTRAINT [FK_RegisterPayment_Insurance_InsuranceID] FOREIGN KEY ([InsuranceID]) REFERENCES [Insurance] ([ID]) ON DELETE CASCADE,
    CONSTRAINT [FK_RegisterPayment_PaymentInformation_PaymentInformationID] FOREIGN KEY ([PaymentInformationID]) REFERENCES [PaymentInformation] ([ID]) ON DELETE NO ACTION
);

GO

CREATE INDEX [IX_Agent_CompanyID] ON [Agent] ([CompanyID]);

GO

CREATE INDEX [IX_Agent_Address_AgentID] ON [Agent_Address] ([AgentID]);

GO

CREATE INDEX [IX_Agent_PaymentTypes_PaymentID] ON [Agent_PaymentTypes] ([PaymentID]);

GO

CREATE INDEX [IX_AspNetRoleClaims_RoleId] ON [AspNetRoleClaims] ([RoleId]);

GO

CREATE UNIQUE INDEX [RoleNameIndex] ON [AspNetRoles] ([NormalizedName]) WHERE [NormalizedName] IS NOT NULL;

GO

CREATE INDEX [IX_AspNetUserClaims_UserId] ON [AspNetUserClaims] ([UserId]);

GO

CREATE INDEX [IX_AspNetUserLogins_UserId] ON [AspNetUserLogins] ([UserId]);

GO

CREATE INDEX [IX_AspNetUserRoles_RoleId] ON [AspNetUserRoles] ([RoleId]);

GO

CREATE INDEX [EmailIndex] ON [AspNetUsers] ([NormalizedEmail]);

GO

CREATE UNIQUE INDEX [UserNameIndex] ON [AspNetUsers] ([NormalizedUserName]) WHERE [NormalizedUserName] IS NOT NULL;

GO

CREATE INDEX [IX_Bond_AgentID] ON [Bond] ([AgentID]);

GO

CREATE INDEX [IX_Bond_ClientsID] ON [Bond] ([ClientsID]);

GO

CREATE INDEX [IX_Bond_CompanyID] ON [Bond] ([CompanyID]);

GO

CREATE INDEX [IX_Bond_SubAgentID] ON [Bond] ([SubAgentID]);

GO

CREATE INDEX [IX_Client_Address_ClientID] ON [Client_Address] ([ClientID]);

GO

CREATE INDEX [IX_ClientDocumentation_ClientID] ON [ClientDocumentation] ([ClientID]);

GO

CREATE INDEX [IX_Company_Address_CompanyID] ON [Company_Address] ([CompanyID]);

GO

CREATE INDEX [IX_Contact_ClientID] ON [Contact] ([ClientID]);

GO

CREATE INDEX [IX_CoveragePlan_RamoID] ON [CoveragePlan] ([RamoID]);

GO

CREATE INDEX [IX_CoveragePlan_Coverage_CoveragePlanID] ON [CoveragePlan_Coverage] ([CoveragePlanID]);

GO

CREATE INDEX [IX_Endorsement_EndorsementTypeID] ON [Endorsement] ([EndorsementTypeID]);

GO

CREATE INDEX [IX_Endorsement_InsuranceID] ON [Endorsement] ([InsuranceID]);

GO

CREATE INDEX [IX_Insurance_AgentID] ON [Insurance] ([AgentID]);

GO

CREATE INDEX [IX_Insurance_ClientID] ON [Insurance] ([ClientID]);

GO

CREATE INDEX [IX_Insurance_CompanyID] ON [Insurance] ([CompanyID]);

GO

CREATE INDEX [IX_Insurance_PaymentTypeID] ON [Insurance] ([PaymentTypeID]);

GO

CREATE INDEX [IX_Insurance_SubAgentID] ON [Insurance] ([SubAgentID]);

GO

CREATE INDEX [IX_Insurance_SubBranchID] ON [Insurance] ([SubBranchID]);

GO

CREATE INDEX [IX_InsuranceDocumentation_InsuranceID] ON [InsuranceDocumentation] ([InsuranceID]);

GO

CREATE INDEX [IX_PaymentInformation_InsuranceID] ON [PaymentInformation] ([InsuranceID]);

GO

CREATE INDEX [IX_Ramo_Coverage_BranchID] ON [Ramo_Coverage] ([BranchID]);

GO

CREATE INDEX [IX_RegisterPayment_InsuranceID] ON [RegisterPayment] ([InsuranceID]);

GO

CREATE UNIQUE INDEX [IX_RegisterPayment_PaymentInformationID] ON [RegisterPayment] ([PaymentInformationID]);

GO

CREATE INDEX [IX_SubBranch_RamoID] ON [SubBranch] ([RamoID]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200110192901_Initial', N'3.0.0');

GO

ALTER TABLE [Agent] ADD [Account] nvarchar(max) NULL;

GO

ALTER TABLE [Agent] ADD [Bank] nvarchar(max) NULL;

GO

ALTER TABLE [Agent] ADD [Clabe] nvarchar(max) NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200113054511_Add_optionalAgent_colums', N'3.0.0');

GO

ALTER TABLE [Endorsement] DROP CONSTRAINT [FK_Endorsement_EndorsementType_EndorsementTypeID];

GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Endorsement]') AND [c].[name] = N'EndosementTypeID');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Endorsement] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [Endorsement] DROP COLUMN [EndosementTypeID];

GO

DECLARE @var1 sysname;
SELECT @var1 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Agent]') AND [c].[name] = N'Account');
IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [Agent] DROP CONSTRAINT [' + @var1 + '];');
ALTER TABLE [Agent] DROP COLUMN [Account];

GO

DECLARE @var2 sysname;
SELECT @var2 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Agent]') AND [c].[name] = N'Bank');
IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [Agent] DROP CONSTRAINT [' + @var2 + '];');
ALTER TABLE [Agent] DROP COLUMN [Bank];

GO

DECLARE @var3 sysname;
SELECT @var3 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Agent]') AND [c].[name] = N'Clabe');
IF @var3 IS NOT NULL EXEC(N'ALTER TABLE [Agent] DROP CONSTRAINT [' + @var3 + '];');
ALTER TABLE [Agent] DROP COLUMN [Clabe];

GO

DROP INDEX [IX_Endorsement_EndorsementTypeID] ON [Endorsement];
DECLARE @var4 sysname;
SELECT @var4 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Endorsement]') AND [c].[name] = N'EndorsementTypeID');
IF @var4 IS NOT NULL EXEC(N'ALTER TABLE [Endorsement] DROP CONSTRAINT [' + @var4 + '];');
ALTER TABLE [Endorsement] ALTER COLUMN [EndorsementTypeID] int NOT NULL;
CREATE INDEX [IX_Endorsement_EndorsementTypeID] ON [Endorsement] ([EndorsementTypeID]);

GO

ALTER TABLE [Endorsement] ADD CONSTRAINT [FK_Endorsement_EndorsementType_EndorsementTypeID] FOREIGN KEY ([EndorsementTypeID]) REFERENCES [EndorsementType] ([ID]) ON DELETE CASCADE;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200113190953_addColumn_EndorsementTypeID_TblEndorsement', N'3.0.0');

GO

DECLARE @var5 sysname;
SELECT @var5 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Insurance]') AND [c].[name] = N'EndorsementNumber');
IF @var5 IS NOT NULL EXEC(N'ALTER TABLE [Insurance] DROP CONSTRAINT [' + @var5 + '];');
ALTER TABLE [Insurance] ALTER COLUMN [EndorsementNumber] int NOT NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200113214912_changeStringToInt_ColumEndorsementNumber', N'3.0.0');

GO

ALTER TABLE [Bond] DROP CONSTRAINT [FK_Bond_Agent_AgentID];

GO

ALTER TABLE [Bond] DROP CONSTRAINT [FK_Bond_Clients_ClientsID];

GO

DROP INDEX [IX_Bond_ClientsID] ON [Bond];

GO

DECLARE @var6 sysname;
SELECT @var6 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Bond]') AND [c].[name] = N'ClientsID');
IF @var6 IS NOT NULL EXEC(N'ALTER TABLE [Bond] DROP CONSTRAINT [' + @var6 + '];');
ALTER TABLE [Bond] DROP COLUMN [ClientsID];

GO

ALTER TABLE [InsuranceDocumentation] ADD [containerName] nvarchar(max) NULL;

GO

ALTER TABLE [ClientDocumentation] ADD [containerName] nvarchar(max) NULL;

GO

DROP INDEX [IX_Bond_AgentID] ON [Bond];
DECLARE @var7 sysname;
SELECT @var7 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Bond]') AND [c].[name] = N'AgentID');
IF @var7 IS NOT NULL EXEC(N'ALTER TABLE [Bond] DROP CONSTRAINT [' + @var7 + '];');
ALTER TABLE [Bond] ALTER COLUMN [AgentID] int NOT NULL;
CREATE INDEX [IX_Bond_AgentID] ON [Bond] ([AgentID]);

GO

CREATE INDEX [IX_CommissionPayments_BondPaymentID] ON [CommissionPayments] ([BondPaymentID]);

GO

CREATE INDEX [IX_BondPayments_BondID] ON [BondPayments] ([BondID]);

GO

CREATE INDEX [IX_Bond_ClientID] ON [Bond] ([ClientID]);

GO

ALTER TABLE [Bond] ADD CONSTRAINT [FK_Bond_Agent_AgentID] FOREIGN KEY ([AgentID]) REFERENCES [Agent] ([ID]) ON DELETE CASCADE;

GO

ALTER TABLE [Bond] ADD CONSTRAINT [FK_Bond_Clients_ClientID] FOREIGN KEY ([ClientID]) REFERENCES [Clients] ([ID]) ON DELETE CASCADE;

GO

ALTER TABLE [BondPayments] ADD CONSTRAINT [FK_BondPayments_Bond_BondID] FOREIGN KEY ([BondID]) REFERENCES [Bond] ([ID]) ON DELETE CASCADE;

GO

ALTER TABLE [CommissionPayments] ADD CONSTRAINT [FK_CommissionPayments_BondPayments_BondPaymentID] FOREIGN KEY ([BondPaymentID]) REFERENCES [BondPayments] ([ID]) ON DELETE CASCADE;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200117223341_addColum_ContainerName', N'3.0.0');

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200120090553_new-Initial', N'3.0.0');

GO

DECLARE @var8 sysname;
SELECT @var8 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[ClientDocumentation]') AND [c].[name] = N'containerName');
IF @var8 IS NOT NULL EXEC(N'ALTER TABLE [ClientDocumentation] DROP CONSTRAINT [' + @var8 + '];');
ALTER TABLE [ClientDocumentation] ALTER COLUMN [containerName] nvarchar(30) NULL;

GO

DECLARE @var9 sysname;
SELECT @var9 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[ClientDocumentation]') AND [c].[name] = N'Notes');
IF @var9 IS NOT NULL EXEC(N'ALTER TABLE [ClientDocumentation] DROP CONSTRAINT [' + @var9 + '];');
ALTER TABLE [ClientDocumentation] ALTER COLUMN [Notes] nvarchar(150) NULL;

GO

DECLARE @var10 sysname;
SELECT @var10 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[ClientDocumentation]') AND [c].[name] = N'FileName');
IF @var10 IS NOT NULL EXEC(N'ALTER TABLE [ClientDocumentation] DROP CONSTRAINT [' + @var10 + '];');
ALTER TABLE [ClientDocumentation] ALTER COLUMN [FileName] nvarchar(50) NULL;

GO

DECLARE @var11 sysname;
SELECT @var11 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[ClientDocumentation]') AND [c].[name] = N'FileExtension');
IF @var11 IS NOT NULL EXEC(N'ALTER TABLE [ClientDocumentation] DROP CONSTRAINT [' + @var11 + '];');
ALTER TABLE [ClientDocumentation] ALTER COLUMN [FileExtension] nvarchar(15) NULL;

GO

DECLARE @var12 sysname;
SELECT @var12 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Bond]') AND [c].[name] = N'BondNumber');
IF @var12 IS NOT NULL EXEC(N'ALTER TABLE [Bond] DROP CONSTRAINT [' + @var12 + '];');
ALTER TABLE [Bond] ALTER COLUMN [BondNumber] nvarchar(max) NOT NULL;

GO

DECLARE @var13 sysname;
SELECT @var13 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Bond]') AND [c].[name] = N'BillingNumber');
IF @var13 IS NOT NULL EXEC(N'ALTER TABLE [Bond] DROP CONSTRAINT [' + @var13 + '];');
ALTER TABLE [Bond] ALTER COLUMN [BillingNumber] nvarchar(max) NOT NULL;

GO

DECLARE @var14 sysname;
SELECT @var14 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Agent]') AND [c].[name] = N'SecondLastName');
IF @var14 IS NOT NULL EXEC(N'ALTER TABLE [Agent] DROP CONSTRAINT [' + @var14 + '];');
ALTER TABLE [Agent] ALTER COLUMN [SecondLastName] nvarchar(50) NULL;

GO

DECLARE @var15 sysname;
SELECT @var15 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Agent]') AND [c].[name] = N'PhoneNumber');
IF @var15 IS NOT NULL EXEC(N'ALTER TABLE [Agent] DROP CONSTRAINT [' + @var15 + '];');
ALTER TABLE [Agent] ALTER COLUMN [PhoneNumber] nvarchar(50) NULL;

GO

DECLARE @var16 sysname;
SELECT @var16 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Agent]') AND [c].[name] = N'PersonalEmail');
IF @var16 IS NOT NULL EXEC(N'ALTER TABLE [Agent] DROP CONSTRAINT [' + @var16 + '];');
ALTER TABLE [Agent] ALTER COLUMN [PersonalEmail] nvarchar(50) NULL;

GO

DECLARE @var17 sysname;
SELECT @var17 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Agent]') AND [c].[name] = N'PersonType');
IF @var17 IS NOT NULL EXEC(N'ALTER TABLE [Agent] DROP CONSTRAINT [' + @var17 + '];');
ALTER TABLE [Agent] ALTER COLUMN [PersonType] nvarchar(50) NULL;

GO

DECLARE @var18 sysname;
SELECT @var18 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Agent]') AND [c].[name] = N'Name');
IF @var18 IS NOT NULL EXEC(N'ALTER TABLE [Agent] DROP CONSTRAINT [' + @var18 + '];');
ALTER TABLE [Agent] ALTER COLUMN [Name] nvarchar(50) NULL;

GO

DECLARE @var19 sysname;
SELECT @var19 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Agent]') AND [c].[name] = N'LastName');
IF @var19 IS NOT NULL EXEC(N'ALTER TABLE [Agent] DROP CONSTRAINT [' + @var19 + '];');
ALTER TABLE [Agent] ALTER COLUMN [LastName] nvarchar(50) NULL;

GO

DECLARE @var20 sysname;
SELECT @var20 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Agent]') AND [c].[name] = N'IdentificationCardNumber');
IF @var20 IS NOT NULL EXEC(N'ALTER TABLE [Agent] DROP CONSTRAINT [' + @var20 + '];');
ALTER TABLE [Agent] ALTER COLUMN [IdentificationCardNumber] nvarchar(50) NULL;

GO

DECLARE @var21 sysname;
SELECT @var21 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Agent]') AND [c].[name] = N'CompanyName');
IF @var21 IS NOT NULL EXEC(N'ALTER TABLE [Agent] DROP CONSTRAINT [' + @var21 + '];');
ALTER TABLE [Agent] ALTER COLUMN [CompanyName] nvarchar(50) NULL;

GO

DECLARE @var22 sysname;
SELECT @var22 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Agent]') AND [c].[name] = N'Code');
IF @var22 IS NOT NULL EXEC(N'ALTER TABLE [Agent] DROP CONSTRAINT [' + @var22 + '];');
ALTER TABLE [Agent] ALTER COLUMN [Code] nvarchar(50) NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200122223802_update-tabls', N'3.0.0');

GO

DECLARE @var23 sysname;
SELECT @var23 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Insurance]') AND [c].[name] = N'ValidThrought');
IF @var23 IS NOT NULL EXEC(N'ALTER TABLE [Insurance] DROP CONSTRAINT [' + @var23 + '];');
ALTER TABLE [Insurance] ALTER COLUMN [ValidThrought] datetime2 NOT NULL;

GO

DECLARE @var24 sysname;
SELECT @var24 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Insurance]') AND [c].[name] = N'ValidFrom');
IF @var24 IS NOT NULL EXEC(N'ALTER TABLE [Insurance] DROP CONSTRAINT [' + @var24 + '];');
ALTER TABLE [Insurance] ALTER COLUMN [ValidFrom] datetime2 NOT NULL;

GO

DECLARE @var25 sysname;
SELECT @var25 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Insurance]') AND [c].[name] = N'InsuranceNumber');
IF @var25 IS NOT NULL EXEC(N'ALTER TABLE [Insurance] DROP CONSTRAINT [' + @var25 + '];');
ALTER TABLE [Insurance] ALTER COLUMN [InsuranceNumber] nvarchar(50) NOT NULL;

GO

DECLARE @var26 sysname;
SELECT @var26 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Insurance]') AND [c].[name] = N'CurrencyType');
IF @var26 IS NOT NULL EXEC(N'ALTER TABLE [Insurance] DROP CONSTRAINT [' + @var26 + '];');
ALTER TABLE [Insurance] ALTER COLUMN [CurrencyType] nvarchar(50) NULL;

GO

DECLARE @var27 sysname;
SELECT @var27 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[EndorsementType]') AND [c].[name] = N'Transaction');
IF @var27 IS NOT NULL EXEC(N'ALTER TABLE [EndorsementType] DROP CONSTRAINT [' + @var27 + '];');
ALTER TABLE [EndorsementType] ALTER COLUMN [Transaction] nvarchar(max) NOT NULL;

GO

DECLARE @var28 sysname;
SELECT @var28 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[EndorsementType]') AND [c].[name] = N'Descripcion');
IF @var28 IS NOT NULL EXEC(N'ALTER TABLE [EndorsementType] DROP CONSTRAINT [' + @var28 + '];');
ALTER TABLE [EndorsementType] ALTER COLUMN [Descripcion] nvarchar(max) NOT NULL;

GO

DECLARE @var29 sysname;
SELECT @var29 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Endorsement]') AND [c].[name] = N'Description');
IF @var29 IS NOT NULL EXEC(N'ALTER TABLE [Endorsement] DROP CONSTRAINT [' + @var29 + '];');
ALTER TABLE [Endorsement] ALTER COLUMN [Description] nvarchar(max) NOT NULL;

GO

DECLARE @var30 sysname;
SELECT @var30 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[DocumentType]') AND [c].[name] = N'Descripcion');
IF @var30 IS NOT NULL EXEC(N'ALTER TABLE [DocumentType] DROP CONSTRAINT [' + @var30 + '];');
ALTER TABLE [DocumentType] ALTER COLUMN [Descripcion] nvarchar(max) NOT NULL;

GO

DECLARE @var31 sysname;
SELECT @var31 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Company]') AND [c].[name] = N'RFC');
IF @var31 IS NOT NULL EXEC(N'ALTER TABLE [Company] DROP CONSTRAINT [' + @var31 + '];');
ALTER TABLE [Company] ALTER COLUMN [RFC] nvarchar(max) NOT NULL;

GO

DECLARE @var32 sysname;
SELECT @var32 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Company]') AND [c].[name] = N'CompanyType');
IF @var32 IS NOT NULL EXEC(N'ALTER TABLE [Company] DROP CONSTRAINT [' + @var32 + '];');
ALTER TABLE [Company] ALTER COLUMN [CompanyType] nvarchar(max) NOT NULL;

GO

DECLARE @var33 sysname;
SELECT @var33 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Company]') AND [c].[name] = N'CompanyName');
IF @var33 IS NOT NULL EXEC(N'ALTER TABLE [Company] DROP CONSTRAINT [' + @var33 + '];');
ALTER TABLE [Company] ALTER COLUMN [CompanyName] nvarchar(max) NOT NULL;

GO

DECLARE @var34 sysname;
SELECT @var34 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Company]') AND [c].[name] = N'CompanyClassification');
IF @var34 IS NOT NULL EXEC(N'ALTER TABLE [Company] DROP CONSTRAINT [' + @var34 + '];');
ALTER TABLE [Company] ALTER COLUMN [CompanyClassification] nvarchar(max) NOT NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200122234603_update-TblInsurance', N'3.0.0');

GO

DECLARE @var35 sysname;
SELECT @var35 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Company]') AND [c].[name] = N'CompanyClassification');
IF @var35 IS NOT NULL EXEC(N'ALTER TABLE [Company] DROP CONSTRAINT [' + @var35 + '];');
ALTER TABLE [Company] ALTER COLUMN [CompanyClassification] nvarchar(max) NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200122235105_Update_tblCompany', N'3.0.0');

GO

DECLARE @var36 sysname;
SELECT @var36 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[PaymentInformation]') AND [c].[name] = N'PaymentNumber');
IF @var36 IS NOT NULL EXEC(N'ALTER TABLE [PaymentInformation] DROP CONSTRAINT [' + @var36 + '];');
ALTER TABLE [PaymentInformation] ALTER COLUMN [PaymentNumber] nvarchar(max) NOT NULL;

GO

DECLARE @var37 sysname;
SELECT @var37 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[InsuranceDocumentation]') AND [c].[name] = N'containerName');
IF @var37 IS NOT NULL EXEC(N'ALTER TABLE [InsuranceDocumentation] DROP CONSTRAINT [' + @var37 + '];');
ALTER TABLE [InsuranceDocumentation] ALTER COLUMN [containerName] nvarchar(30) NULL;

GO

DECLARE @var38 sysname;
SELECT @var38 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[InsuranceDocumentation]') AND [c].[name] = N'Url');
IF @var38 IS NOT NULL EXEC(N'ALTER TABLE [InsuranceDocumentation] DROP CONSTRAINT [' + @var38 + '];');
ALTER TABLE [InsuranceDocumentation] ALTER COLUMN [Url] nvarchar(40) NULL;

GO

DECLARE @var39 sysname;
SELECT @var39 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[InsuranceDocumentation]') AND [c].[name] = N'FileName');
IF @var39 IS NOT NULL EXEC(N'ALTER TABLE [InsuranceDocumentation] DROP CONSTRAINT [' + @var39 + '];');
ALTER TABLE [InsuranceDocumentation] ALTER COLUMN [FileName] nvarchar(50) NOT NULL;

GO

DECLARE @var40 sysname;
SELECT @var40 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[InsuranceDocumentation]') AND [c].[name] = N'FileExtension');
IF @var40 IS NOT NULL EXEC(N'ALTER TABLE [InsuranceDocumentation] DROP CONSTRAINT [' + @var40 + '];');
ALTER TABLE [InsuranceDocumentation] ALTER COLUMN [FileExtension] nvarchar(15) NOT NULL;

GO

CREATE TABLE [Movement] (
    [ID] int NOT NULL IDENTITY,
    [Decription] nvarchar(max) NULL,
    CONSTRAINT [PK_Movement] PRIMARY KEY ([ID])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200123163721_add_Tbl_Movement', N'3.0.0');

GO

DECLARE @var41 sysname;
SELECT @var41 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[SubAgent]') AND [c].[name] = N'SecondLastName');
IF @var41 IS NOT NULL EXEC(N'ALTER TABLE [SubAgent] DROP CONSTRAINT [' + @var41 + '];');
ALTER TABLE [SubAgent] ALTER COLUMN [SecondLastName] nvarchar(50) NULL;

GO

DECLARE @var42 sysname;
SELECT @var42 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[SubAgent]') AND [c].[name] = N'RFC');
IF @var42 IS NOT NULL EXEC(N'ALTER TABLE [SubAgent] DROP CONSTRAINT [' + @var42 + '];');
ALTER TABLE [SubAgent] ALTER COLUMN [RFC] nvarchar(max) NOT NULL;

GO

DECLARE @var43 sysname;
SELECT @var43 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[SubAgent]') AND [c].[name] = N'PhoneNumber');
IF @var43 IS NOT NULL EXEC(N'ALTER TABLE [SubAgent] DROP CONSTRAINT [' + @var43 + '];');
ALTER TABLE [SubAgent] ALTER COLUMN [PhoneNumber] nvarchar(20) NULL;

GO

DECLARE @var44 sysname;
SELECT @var44 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[SubAgent]') AND [c].[name] = N'PersonalEmail');
IF @var44 IS NOT NULL EXEC(N'ALTER TABLE [SubAgent] DROP CONSTRAINT [' + @var44 + '];');
ALTER TABLE [SubAgent] ALTER COLUMN [PersonalEmail] nvarchar(30) NULL;

GO

DECLARE @var45 sysname;
SELECT @var45 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[SubAgent]') AND [c].[name] = N'PersonType');
IF @var45 IS NOT NULL EXEC(N'ALTER TABLE [SubAgent] DROP CONSTRAINT [' + @var45 + '];');
ALTER TABLE [SubAgent] ALTER COLUMN [PersonType] nvarchar(15) NULL;

GO

DECLARE @var46 sysname;
SELECT @var46 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[SubAgent]') AND [c].[name] = N'Name');
IF @var46 IS NOT NULL EXEC(N'ALTER TABLE [SubAgent] DROP CONSTRAINT [' + @var46 + '];');
ALTER TABLE [SubAgent] ALTER COLUMN [Name] nvarchar(50) NULL;

GO

DECLARE @var47 sysname;
SELECT @var47 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[SubAgent]') AND [c].[name] = N'LastName');
IF @var47 IS NOT NULL EXEC(N'ALTER TABLE [SubAgent] DROP CONSTRAINT [' + @var47 + '];');
ALTER TABLE [SubAgent] ALTER COLUMN [LastName] nvarchar(50) NULL;

GO

DECLARE @var48 sysname;
SELECT @var48 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[SubAgent]') AND [c].[name] = N'IdentificationNumber');
IF @var48 IS NOT NULL EXEC(N'ALTER TABLE [SubAgent] DROP CONSTRAINT [' + @var48 + '];');
ALTER TABLE [SubAgent] ALTER COLUMN [IdentificationNumber] nvarchar(30) NULL;

GO

DECLARE @var49 sysname;
SELECT @var49 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[SubAgent]') AND [c].[name] = N'CompanyName');
IF @var49 IS NOT NULL EXEC(N'ALTER TABLE [SubAgent] DROP CONSTRAINT [' + @var49 + '];');
ALTER TABLE [SubAgent] ALTER COLUMN [CompanyName] nvarchar(50) NULL;

GO

DECLARE @var50 sysname;
SELECT @var50 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[SubAgent]') AND [c].[name] = N'Bank');
IF @var50 IS NOT NULL EXEC(N'ALTER TABLE [SubAgent] DROP CONSTRAINT [' + @var50 + '];');
ALTER TABLE [SubAgent] ALTER COLUMN [Bank] nvarchar(20) NULL;

GO

DECLARE @var51 sysname;
SELECT @var51 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[PaymentType]') AND [c].[name] = N'Description');
IF @var51 IS NOT NULL EXEC(N'ALTER TABLE [PaymentType] DROP CONSTRAINT [' + @var51 + '];');
ALTER TABLE [PaymentType] ALTER COLUMN [Description] nvarchar(max) NOT NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200123164627_update-Tbls', N'3.0.0');

GO

DECLARE @var52 sysname;
SELECT @var52 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Adress]') AND [c].[name] = N'Colony');
IF @var52 IS NOT NULL EXEC(N'ALTER TABLE [Adress] DROP CONSTRAINT [' + @var52 + '];');
ALTER TABLE [Adress] DROP COLUMN [Colony];

GO

DECLARE @var53 sysname;
SELECT @var53 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Adress]') AND [c].[name] = N'Street');
IF @var53 IS NOT NULL EXEC(N'ALTER TABLE [Adress] DROP CONSTRAINT [' + @var53 + '];');
ALTER TABLE [Adress] DROP COLUMN [Street];

GO

DECLARE @var54 sysname;
SELECT @var54 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Adress]') AND [c].[name] = N'StreetAddress');
IF @var54 IS NOT NULL EXEC(N'ALTER TABLE [Adress] DROP CONSTRAINT [' + @var54 + '];');
ALTER TABLE [Adress] ALTER COLUMN [StreetAddress] nvarchar(50) NULL;

GO

DECLARE @var55 sysname;
SELECT @var55 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Adress]') AND [c].[name] = N'State');
IF @var55 IS NOT NULL EXEC(N'ALTER TABLE [Adress] DROP CONSTRAINT [' + @var55 + '];');
ALTER TABLE [Adress] ALTER COLUMN [State] nvarchar(50) NULL;

GO

DECLARE @var56 sysname;
SELECT @var56 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Adress]') AND [c].[name] = N'PostalCode');
IF @var56 IS NOT NULL EXEC(N'ALTER TABLE [Adress] DROP CONSTRAINT [' + @var56 + '];');
ALTER TABLE [Adress] ALTER COLUMN [PostalCode] nvarchar(50) NULL;

GO

DECLARE @var57 sysname;
SELECT @var57 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Adress]') AND [c].[name] = N'Country');
IF @var57 IS NOT NULL EXEC(N'ALTER TABLE [Adress] DROP CONSTRAINT [' + @var57 + '];');
ALTER TABLE [Adress] ALTER COLUMN [Country] nvarchar(50) NULL;

GO

DECLARE @var58 sysname;
SELECT @var58 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Adress]') AND [c].[name] = N'City');
IF @var58 IS NOT NULL EXEC(N'ALTER TABLE [Adress] DROP CONSTRAINT [' + @var58 + '];');
ALTER TABLE [Adress] ALTER COLUMN [City] nvarchar(50) NULL;

GO

DECLARE @var59 sysname;
SELECT @var59 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Adress]') AND [c].[name] = N'ApartmentNumber');
IF @var59 IS NOT NULL EXEC(N'ALTER TABLE [Adress] DROP CONSTRAINT [' + @var59 + '];');
ALTER TABLE [Adress] ALTER COLUMN [ApartmentNumber] nvarchar(50) NULL;

GO

DECLARE @var60 sysname;
SELECT @var60 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Adress]') AND [c].[name] = N'AddressType');
IF @var60 IS NOT NULL EXEC(N'ALTER TABLE [Adress] DROP CONSTRAINT [' + @var60 + '];');
ALTER TABLE [Adress] ALTER COLUMN [AddressType] nvarchar(50) NULL;

GO

ALTER TABLE [Adress] ADD [AddressLine] nvarchar(200) NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200124174447_ChanngeTblAdress', N'3.0.0');

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Name', N'NormalizedName') AND [object_id] = OBJECT_ID(N'[AspNetRoles]'))
    SET IDENTITY_INSERT [AspNetRoles] ON;
INSERT INTO [AspNetRoles] ([Id], [ConcurrencyStamp], [Name], [NormalizedName])
VALUES (N'6b62204f-d8ee-41cb-8ef5-0d9bd46622b2', N'4e3dfcee-49ea-47a8-b5c6-330bfa41b120', N'admin', N'admin');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Name', N'NormalizedName') AND [object_id] = OBJECT_ID(N'[AspNetRoles]'))
    SET IDENTITY_INSERT [AspNetRoles] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AccessFailedCount', N'ConcurrencyStamp', N'Email', N'EmailConfirmed', N'LockoutEnabled', N'LockoutEnd', N'NormalizedEmail', N'NormalizedUserName', N'PasswordHash', N'PhoneNumber', N'PhoneNumberConfirmed', N'SecurityStamp', N'TwoFactorEnabled', N'UserName') AND [object_id] = OBJECT_ID(N'[AspNetUsers]'))
    SET IDENTITY_INSERT [AspNetUsers] ON;
INSERT INTO [AspNetUsers] ([Id], [AccessFailedCount], [ConcurrencyStamp], [Email], [EmailConfirmed], [LockoutEnabled], [LockoutEnd], [NormalizedEmail], [NormalizedUserName], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [SecurityStamp], [TwoFactorEnabled], [UserName])
VALUES (N'47a5d10c-25ba-4f8a-80d1-2e4918a20ca4', 0, N'ac50db9b-f642-46b9-8905-e1227da1e6b6', N'ccervantes@umbrella-seguros.com', CAST(1 AS bit), CAST(0 AS bit), NULL, N'ccervantes@umbrella-seguros.com', N'Admin123', N'AQAAAAEAACcQAAAAECP5XW8dTwMuGdXl89X/YD3wIgIA8SKFn7SksciHZMe0CXTc7ubT9PDai81WNntTOQ==', NULL, CAST(0 AS bit), N'd1ba0089-f58e-4e0d-930f-e7f53e69a291', CAST(0 AS bit), N'Admin123');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AccessFailedCount', N'ConcurrencyStamp', N'Email', N'EmailConfirmed', N'LockoutEnabled', N'LockoutEnd', N'NormalizedEmail', N'NormalizedUserName', N'PasswordHash', N'PhoneNumber', N'PhoneNumberConfirmed', N'SecurityStamp', N'TwoFactorEnabled', N'UserName') AND [object_id] = OBJECT_ID(N'[AspNetUsers]'))
    SET IDENTITY_INSERT [AspNetUsers] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'UserId', N'RoleId') AND [object_id] = OBJECT_ID(N'[AspNetUserRoles]'))
    SET IDENTITY_INSERT [AspNetUserRoles] ON;
INSERT INTO [AspNetUserRoles] ([UserId], [RoleId])
VALUES (N'47a5d10c-25ba-4f8a-80d1-2e4918a20ca4', N'6b62204f-d8ee-41cb-8ef5-0d9bd46622b2');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'UserId', N'RoleId') AND [object_id] = OBJECT_ID(N'[AspNetUserRoles]'))
    SET IDENTITY_INSERT [AspNetUserRoles] OFF;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200124182701_Add_Admin_User', N'3.0.0');

GO

