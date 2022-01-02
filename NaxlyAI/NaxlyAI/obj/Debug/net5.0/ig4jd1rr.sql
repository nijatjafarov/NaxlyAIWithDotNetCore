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
GO

CREATE TABLE [AboutCompany] (
    [Id] int NOT NULL IDENTITY,
    [PageHeader] nvarchar(40) NOT NULL,
    [Slogan] nvarchar(150) NULL,
    [Description] nvarchar(300) NOT NULL,
    [VideoTitle] nvarchar(70) NULL,
    [VideoUrl] nvarchar(max) NULL,
    [FoundationYear] int NULL,
    [Picture1] nvarchar(100) NULL,
    [Picture2] nvarchar(100) NULL,
    [Picture3] nvarchar(100) NULL,
    [AboutOurHistory] nvarchar(100) NULL,
    [WhyChooseUs] nvarchar(120) NULL,
    [WhyChooseUsPicture1] nvarchar(100) NULL,
    [WhyChooseUsPicture2] nvarchar(100) NULL,
    [TeamMemberDesc] nvarchar(150) NULL,
    [HomeCoverPicture] nvarchar(100) NULL,
    CONSTRAINT [PK_AboutCompany] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Client] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(50) NOT NULL,
    [Logo] nvarchar(70) NOT NULL,
    [ShowOnHomePage] bit NOT NULL,
    CONSTRAINT [PK_Client] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Configuration] (
    [Id] int NOT NULL IDENTITY,
    [Logo] nvarchar(50) NOT NULL,
    [PhoneNumber] nvarchar(20) NOT NULL,
    [Slogan] nvarchar(150) NULL,
    [Description] nvarchar(400) NULL,
    CONSTRAINT [PK_Configuration] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Contact] (
    [Id] int NOT NULL IDENTITY,
    [PageHeader] nvarchar(50) NOT NULL,
    [InnerHeader] nvarchar(50) NOT NULL,
    [Slogan] nvarchar(150) NULL,
    [Description] nvarchar(400) NOT NULL,
    [LocationHeader] nvarchar(40) NOT NULL,
    [LocationDesc] nvarchar(100) NOT NULL,
    [Address] nvarchar(200) NOT NULL,
    [PhoneHeader] nvarchar(40) NOT NULL,
    [PhoneDesc] nvarchar(100) NOT NULL,
    [PhoneNum] nvarchar(20) NOT NULL,
    [PhoneTime] nvarchar(60) NOT NULL,
    [EmailHeader] nvarchar(40) NOT NULL,
    [EmailDesc] nvarchar(100) NOT NULL,
    [Email1] nvarchar(300) NOT NULL,
    [Email2] nvarchar(300) NULL,
    [PagePicture] text NULL,
    CONSTRAINT [PK_Contact] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [HomePage] (
    [Id] int NOT NULL IDENTITY,
    [AboutServices] nvarchar(150) NULL,
    [ServicesPicture] nvarchar(100) NULL,
    [AboutProjects] nvarchar(150) NULL,
    [AboutWorkProcess] nvarchar(150) NULL,
    [WorkProcessHeader1] nvarchar(50) NOT NULL,
    [WorkProcessDesc1] nvarchar(100) NOT NULL,
    [WorkProcessHeader2] nvarchar(50) NOT NULL,
    [WorkProcessDesc2] nvarchar(100) NOT NULL,
    [WorkProcessHeader3] nvarchar(50) NOT NULL,
    [WorkProcessDesc3] nvarchar(100) NOT NULL,
    [AboutWhyChooseUs] nvarchar(100) NULL,
    [WhyChooseUsPicture] nvarchar(100) NULL,
    [ClientDescription] nvarchar(100) NULL,
    CONSTRAINT [PK_HomePage] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Industry] (
    [Id] int NOT NULL IDENTITY,
    [Icon] nvarchar(50) NULL,
    [Name] nvarchar(50) NOT NULL,
    [Description] nvarchar(300) NOT NULL,
    CONSTRAINT [PK_Industry] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [ReasonForChoosingUs] (
    [Id] int NOT NULL IDENTITY,
    [Icon] nvarchar(250) NOT NULL,
    [Header] nvarchar(100) NOT NULL,
    [Descrioption] nvarchar(300) NOT NULL,
    CONSTRAINT [PK_ReasonForChoosingUs] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Service] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(100) NOT NULL,
    [PageHeader] nvarchar(150) NOT NULL,
    [Intro] nvarchar(60) NULL,
    [Description] nvarchar(300) NULL,
    [StartYourProjectUrl] nvarchar(max) NULL,
    [FirstPicture] nvarchar(100) NULL,
    [SubservicesHeader] nvarchar(100) NULL,
    [SubservicesDescription] nvarchar(max) NULL,
    [TechnologiesHeader] nvarchar(100) NULL,
    [TechnologiesDescription] nvarchar(200) NULL,
    [SecondPicture] nvarchar(100) NULL,
    [ApplicationHeader] nvarchar(100) NULL,
    [ApplicationDescription] nvarchar(500) NULL,
    [ProjectsHeader] nvarchar(100) NOT NULL,
    [CoverPicture] nvarchar(100) NULL,
    [Icon] nvarchar(50) NULL,
    CONSTRAINT [PK_Service] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [ServicesPage] (
    [Id] int NOT NULL IDENTITY,
    [PageHeader] nvarchar(40) NOT NULL,
    [Explanation] nvarchar(100) NULL,
    [ExplanationAboutIndustries] nvarchar(100) NULL,
    [VideoUrl] nvarchar(max) NULL,
    [AwardText] nvarchar(40) NULL,
    [AwardPicture] nvarchar(100) NULL,
    [AwardDescription] nvarchar(150) NULL,
    CONSTRAINT [PK_ServicesPage] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [SocialMedia] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(20) NOT NULL,
    [Icon] nvarchar(30) NOT NULL,
    CONSTRAINT [PK_SocialMedia] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [SocialMediaOfCompany] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(50) NOT NULL,
    [Icon] nvarchar(50) NULL,
    [Url] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_SocialMediaOfCompany] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [StepOfHistory] (
    [Id] int NOT NULL IDENTITY,
    [Header] nvarchar(50) NOT NULL,
    [Year] int NOT NULL,
    [Description] nvarchar(200) NOT NULL,
    CONSTRAINT [PK_StepOfHistory] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [TeamMember] (
    [Id] int NOT NULL IDENTITY,
    [Photo] nvarchar(100) NOT NULL,
    [Fullname] nvarchar(50) NOT NULL,
    [Designation] nvarchar(70) NOT NULL,
    [Email] nvarchar(300) NOT NULL,
    CONSTRAINT [PK_TeamMember] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Technology] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(100) NOT NULL,
    [Picture] nvarchar(100) NULL,
    CONSTRAINT [PK_Technology] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Testimonial] (
    [Id] int NOT NULL IDENTITY,
    [Photo] text NOT NULL,
    [Review] nvarchar(150) NOT NULL,
    [Fullname] nvarchar(50) NOT NULL,
    [Designation] nvarchar(70) NOT NULL,
    [NumberOfStars] int NOT NULL,
    [Date] datetime NULL,
    CONSTRAINT [PK_Testimonial] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [UserMessage] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(60) NOT NULL,
    [Email] nvarchar(300) NOT NULL,
    [Subject] nvarchar(50) NULL,
    [Message] nvarchar(max) NOT NULL,
    [Date] datetime NOT NULL,
    CONSTRAINT [PK_UserMessage] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Project] (
    [Id] int NOT NULL IDENTITY,
    [ClientId] int NOT NULL,
    [Name] nvarchar(100) NOT NULL,
    [PageHeader] nvarchar(200) NULL,
    [IndustyId] int NOT NULL,
    [TimePeriod] int NOT NULL,
    [Website] nvarchar(150) NULL,
    [Header] nvarchar(150) NOT NULL,
    [Description] nvarchar(500) NULL,
    [Challenge] nvarchar(200) NULL,
    [Solution] nvarchar(200) NULL,
    [CoverPicture] nvarchar(100) NOT NULL,
    [PagePicture] nvarchar(100) NULL,
    [ProcessDescription] nvarchar(500) NULL,
    [ResultDescription] nvarchar(500) NULL,
    CONSTRAINT [PK_Project] PRIMARY KEY ([Id]),
    CONSTRAINT [ClientOfProjectFK] FOREIGN KEY ([ClientId]) REFERENCES [Client] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [IndustryOfProject] FOREIGN KEY ([IndustyId]) REFERENCES [Industry] ([Id]) ON DELETE NO ACTION
);
GO

CREATE TABLE [ServiceAndIndustry] (
    [Id] int NOT NULL IDENTITY,
    [ServiceId] int NOT NULL,
    [IndustryId] int NOT NULL,
    CONSTRAINT [PK_ServiceAndIndustry] PRIMARY KEY ([Id]),
    CONSTRAINT [IndustryOfServiceFK] FOREIGN KEY ([IndustryId]) REFERENCES [Industry] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [ServiceOfIndustryFK] FOREIGN KEY ([ServiceId]) REFERENCES [Service] ([Id]) ON DELETE NO ACTION
);
GO

CREATE TABLE [ServiceFile] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(100) NOT NULL,
    [Extention] nvarchar(20) NOT NULL,
    [Size] int NOT NULL,
    [ServiceId] int NOT NULL,
    CONSTRAINT [PK_ServiceFile] PRIMARY KEY ([Id]),
    CONSTRAINT [ServiceOfFileFK] FOREIGN KEY ([ServiceId]) REFERENCES [Service] ([Id]) ON DELETE NO ACTION
);
GO

CREATE TABLE [SubfieldOfService] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(200) NOT NULL,
    [ServiceId] int NOT NULL,
    CONSTRAINT [PK_SubfieldOfService] PRIMARY KEY ([Id]),
    CONSTRAINT [ServiceOfFieldFK] FOREIGN KEY ([ServiceId]) REFERENCES [Service] ([Id]) ON DELETE NO ACTION
);
GO

CREATE TABLE [Subservice] (
    [Id] int NOT NULL IDENTITY,
    [Icon] nvarchar(50) NULL,
    [Name] nvarchar(50) NOT NULL,
    [Description] nvarchar(150) NOT NULL,
    [Type] nvarchar(50) NULL,
    [Url] nvarchar(max) NOT NULL,
    [ServiceId] int NOT NULL,
    CONSTRAINT [PK_Subservice] PRIMARY KEY ([Id]),
    CONSTRAINT [SubserviceOfServiceFK] FOREIGN KEY ([ServiceId]) REFERENCES [Service] ([Id]) ON DELETE NO ACTION
);
GO

CREATE TABLE [SocialMediaAccountOfMember] (
    [Id] int NOT NULL IDENTITY,
    [MemberId] int NOT NULL,
    [SocialMediaId] int NOT NULL,
    [Url] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_SocialMediaAccountOfMember] PRIMARY KEY ([Id]),
    CONSTRAINT [SMMemberFK] FOREIGN KEY ([MemberId]) REFERENCES [TeamMember] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [SocialMediaFK] FOREIGN KEY ([SocialMediaId]) REFERENCES [SocialMedia] ([Id]) ON DELETE NO ACTION
);
GO

CREATE TABLE [TechAndService] (
    [Id] int NOT NULL IDENTITY,
    [TechId] int NOT NULL,
    [ServiceId] int NOT NULL,
    [ShowPicture] bit NOT NULL,
    CONSTRAINT [PK_TechAndService] PRIMARY KEY ([Id]),
    CONSTRAINT [ServiceFK] FOREIGN KEY ([ServiceId]) REFERENCES [Service] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [TechFK] FOREIGN KEY ([TechId]) REFERENCES [Technology] ([Id]) ON DELETE NO ACTION
);
GO

CREATE TABLE [ProjectAndMember] (
    [Id] int NOT NULL IDENTITY,
    [ProjectId] int NOT NULL,
    [MemberId] int NOT NULL,
    CONSTRAINT [PK_ProjectAndMember] PRIMARY KEY ([Id]),
    CONSTRAINT [MemberOfProject] FOREIGN KEY ([MemberId]) REFERENCES [TeamMember] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [ProjectOfMember] FOREIGN KEY ([ProjectId]) REFERENCES [Project] ([Id]) ON DELETE NO ACTION
);
GO

CREATE TABLE [ProjectAndTech] (
    [Id] int NOT NULL IDENTITY,
    [ProjectId] int NOT NULL,
    [TechId] int NOT NULL,
    CONSTRAINT [PK_ProjectAndTech] PRIMARY KEY ([Id]),
    CONSTRAINT [ProjectOfTech] FOREIGN KEY ([ProjectId]) REFERENCES [Project] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [TechOfProject] FOREIGN KEY ([TechId]) REFERENCES [Technology] ([Id]) ON DELETE NO ACTION
);
GO

CREATE TABLE [StepOfProject] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(50) NOT NULL,
    [Description] nvarchar(500) NOT NULL,
    [Picture] nvarchar(100) NOT NULL,
    [ProjectId] int NOT NULL,
    CONSTRAINT [PK_StepOfProject] PRIMARY KEY ([Id]),
    CONSTRAINT [ProjectOfStep] FOREIGN KEY ([ProjectId]) REFERENCES [Project] ([Id]) ON DELETE NO ACTION
);
GO

CREATE INDEX [IX_Project_ClientId] ON [Project] ([ClientId]);
GO

CREATE INDEX [IX_Project_IndustyId] ON [Project] ([IndustyId]);
GO

CREATE INDEX [IX_ProjectAndMember_MemberId] ON [ProjectAndMember] ([MemberId]);
GO

CREATE INDEX [IX_ProjectAndMember_ProjectId] ON [ProjectAndMember] ([ProjectId]);
GO

CREATE INDEX [IX_ProjectAndTech_ProjectId] ON [ProjectAndTech] ([ProjectId]);
GO

CREATE INDEX [IX_ProjectAndTech_TechId] ON [ProjectAndTech] ([TechId]);
GO

CREATE UNIQUE INDEX [UQ__ReasonFo__B03D5134B2BD240E] ON [ReasonForChoosingUs] ([Icon]);
GO

CREATE UNIQUE INDEX [UQ__ReasonFo__EB3211CECF7247E8] ON [ReasonForChoosingUs] ([Header]);
GO

CREATE INDEX [IX_ServiceAndIndustry_IndustryId] ON [ServiceAndIndustry] ([IndustryId]);
GO

CREATE INDEX [IX_ServiceAndIndustry_ServiceId] ON [ServiceAndIndustry] ([ServiceId]);
GO

CREATE INDEX [IX_ServiceFile_ServiceId] ON [ServiceFile] ([ServiceId]);
GO

CREATE INDEX [IX_SocialMediaAccountOfMember_MemberId] ON [SocialMediaAccountOfMember] ([MemberId]);
GO

CREATE INDEX [IX_SocialMediaAccountOfMember_SocialMediaId] ON [SocialMediaAccountOfMember] ([SocialMediaId]);
GO

CREATE UNIQUE INDEX [UQ__StepOfHi__EB3211CE7251FA53] ON [StepOfHistory] ([Header]);
GO

CREATE INDEX [IX_StepOfProject_ProjectId] ON [StepOfProject] ([ProjectId]);
GO

CREATE INDEX [IX_SubfieldOfService_ServiceId] ON [SubfieldOfService] ([ServiceId]);
GO

CREATE INDEX [IX_Subservice_ServiceId] ON [Subservice] ([ServiceId]);
GO

CREATE INDEX [IX_TechAndService_ServiceId] ON [TechAndService] ([ServiceId]);
GO

CREATE INDEX [IX_TechAndService_TechId] ON [TechAndService] ([TechId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20211222140636_InitialMigration', N'5.0.13');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Client]') AND [c].[name] = N'ShowOnHomePage');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Client] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [Client] DROP COLUMN [ShowOnHomePage];
GO

ALTER TABLE [Service] ADD [ContactDescription] nvarchar(500) NULL;
GO

ALTER TABLE [Service] ADD [ContactHeader] nvarchar(100) NULL;
GO

ALTER TABLE [HomePage] ADD [FirstPicture] nvarchar(100) NULL;
GO

DECLARE @var1 sysname;
SELECT @var1 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Configuration]') AND [c].[name] = N'Logo');
IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [Configuration] DROP CONSTRAINT [' + @var1 + '];');
ALTER TABLE [Configuration] ALTER COLUMN [Logo] nvarchar(100) NOT NULL;
GO

ALTER TABLE [Configuration] ADD [SecondLogo] nvarchar(100) NULL;
GO

ALTER TABLE [Client] ADD [Url] nvarchar(max) NULL;
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

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220101104838_IdentityAdded', N'5.0.13');
GO

COMMIT;
GO

