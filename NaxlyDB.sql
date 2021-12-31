CREATE DATABASE NaxlyAI;
PRINT'CREATED DATABASE NaxlyAI'
GO
USE NaxlyAI

CREATE TABLE AboutCompany(
Id int IDENTITY(1, 1) PRIMARY KEY,
PageHeader nvarchar(40) NOT NULL,
Slogan nvarchar(150),
Description nvarchar(300) NOT NULL,
VideoTitle nvarchar(70),
VideoUrl nvarchar(max),
FoundationYear integer,
Picture1 nvarchar(100),
Picture2 nvarchar(100),
Picture3 nvarchar(100),
AboutOurHistory nvarchar(100),
WhyChooseUs nvarchar(120),
WhyChooseUsPicture1 nvarchar(100),
WhyChooseUsPicture2 nvarchar(100),
TeamMemberDesc nvarchar(150),
HomeCoverPicture nvarchar(100)
);

CREATE TABLE ReasonForChoosingUs(
Id int IDENTITY(1, 1) PRIMARY KEY,
Icon nvarchar(250) UNIQUE NOT NULL,
Header nvarchar(100) UNIQUE NOT NULL,
Descrioption nvarchar(300) NOT NULL
);

CREATE TABLE StepOfHistory(
Id int IDENTITY(1, 1) PRIMARY KEY,
Header nvarchar(50) UNIQUE NOT NULL,
Year integer NOT NULL,
Description nvarchar(200) NOT NULL
);

CREATE TABLE Testimonial(
Id int IDENTITY(1, 1) PRIMARY KEY,
Photo text NOT NULL,
Review nvarchar(150) NOT NULL,
Fullname nvarchar(50) NOT NULL,
Designation nvarchar(70) NOT NULL,
NumberOfStars integer NOT NULL,
Date datetime
);

CREATE TABLE TeamMember(
Id int IDENTITY(1, 1) PRIMARY KEY,
Photo nvarchar(100) NOT NULL,
Fullname nvarchar(50) NOT NULL,
Designation nvarchar(70) NOT NULL,
Email nvarchar(300) NOT NULL
);

CREATE TABLE SocialMedia(
Id int IDENTITY(1, 1) PRIMARY KEY,
Name nvarchar(20) NOT NULL,
Icon nvarchar(30) NOT NULL
);

CREATE TABLE SocialMediaAccountOfMember(
Id int IDENTITY(1, 1) PRIMARY KEY,
MemberId int NOT NULL,
SocialMediaId int NOT NULL,
CONSTRAINT SocialMediaFK
	FOREIGN KEY (SocialMediaId) REFERENCES SocialMedia(Id),
CONSTRAINT SMMemberFK
	FOREIGN KEY (MemberId) REFERENCES TeamMember(Id),
Url nvarchar(max) NOT NULL
);

CREATE TABLE Contact(
Id int IDENTITY(1, 1) PRIMARY KEY,
PageHeader nvarchar(50) NOT NULL,
InnerHeader nvarchar(50) NOT NULL,
Slogan nvarchar(150),
Description nvarchar(400) NOT NULL,
LocationHeader nvarchar(40) NOT NULL,
LocationDesc nvarchar(100) NOT NULL,
Address nvarchar(200) NOT NULL,
PhoneHeader nvarchar(40) NOT NULL,
PhoneDesc nvarchar(100) NOT NULL,
PhoneNum nvarchar(20) NOT NULL,
PhoneTime nvarchar(60) NOT NULL,
EmailHeader nvarchar(40) NOT NULL,
EmailDesc nvarchar(100) NOT NULL,
Email1 nvarchar(300) NOT NULL,
Email2 nvarchar(300),
PagePicture text
);

CREATE TABLE UserMessage(
Id int IDENTITY(1, 1) PRIMARY KEY,
Name nvarchar(60) NOT NULL,
Email nvarchar(300) NOT NULL,
Subject nvarchar(50),
Message nvarchar(max) NOT NULL,
Date datetime NOT NULL
);

CREATE TABLE HomePage(
Id int IDENTITY(1, 1) PRIMARY KEY,
FirstPicture nvarchar(100),
AboutServices nvarchar(150),
ServicesPicture nvarchar(100),
AboutProjects nvarchar(150),
AboutWorkProcess nvarchar(150),
WorkProcessHeader1 nvarchar(50) NOT NULL,
WorkProcessDesc1 nvarchar(100) NOT NULL,
WorkProcessHeader2 nvarchar(50) NOT NULL,
WorkProcessDesc2 nvarchar(100) NOT NULL,
WorkProcessHeader3 nvarchar(50) NOT NULL,
WorkProcessDesc3 nvarchar(100) NOT NULL,
AboutWhyChooseUs nvarchar(100),
WhyChooseUsPicture nvarchar(100),
ClientDescription nvarchar(100)
);

CREATE TABLE Industry(
Id int IDENTITY(1, 1) PRIMARY KEY,
Icon nvarchar(50),
Name nvarchar(50) NOT NULL,
Description nvarchar(300) NOT NULL
);

CREATE TABLE ServicesPage(
Id int IDENTITY(1, 1) PRIMARY KEY,
PageHeader nvarchar(40) NOT NULL,
Explanation nvarchar(100),
ExplanationAboutIndustries nvarchar(100),
VideoUrl nvarchar(max),
AwardText nvarchar(40),
AwardPicture nvarchar(100),
AwardDescription nvarchar(150)
);


CREATE TABLE Service(
Id int IDENTITY(1, 1) PRIMARY KEY,
Name nvarchar(100) NOT NULL,
PageHeader nvarchar(150) NOT NULL,
Intro nvarchar(60),
Description nvarchar(300),
StartYourProjectUrl nvarchar(max),
FirstPicture nvarchar(100),
SubservicesHeader nvarchar(100),
SubservicesDescription nvarchar(max),
TechnologiesHeader nvarchar(100),
TechnologiesDescription nvarchar(200),
SecondPicture nvarchar(100),
ApplicationHeader nvarchar(100),
ApplicationDescription nvarchar(500),
ProjectsHeader nvarchar(100) NOT NULL,
CoverPicture nvarchar(100),
Icon nvarchar(50),
ContactHeader nvarchar(100),
ContactDesc nvarchar(500)
);

CREATE TABLE Technology(
Id int IDENTITY(1, 1) PRIMARY KEY,
Name nvarchar(100) NOT NULL,
Picture nvarchar(100)
);

CREATE TABLE TechAndService(
Id int IDENTITY(1, 1) PRIMARY KEY,
TechId int NOT NULL,
ServiceId int NOT NULL,
CONSTRAINT TechFK
	FOREIGN KEY (TechId) REFERENCES Technology(Id),
CONSTRAINT ServiceFK
	FOREIGN KEY (ServiceId) REFERENCES Service(Id),
ShowPicture bit NOT NULL
);

CREATE TABLE ServiceFile(
Id int IDENTITY(1, 1) PRIMARY KEY,
Name nvarchar(100) NOT NULL,
Extention nvarchar(20) NOT NULL,
Size int NOT NULL,
ServiceId int NOT NULL,
CONSTRAINT ServiceOfFileFK
	FOREIGN KEY (ServiceId) REFERENCES Service(Id)
);

CREATE TABLE Subservice(
Id int IDENTITY(1, 1) PRIMARY KEY,
Icon nvarchar(50),
Name nvarchar(50) NOT NULL,
Description nvarchar(150) NOT NULL,
Type nvarchar(50),
Url nvarchar(max) NOT NULL,
ServiceId int NOT NULL,
CONSTRAINT SubserviceOfServiceFK
	FOREIGN KEY (ServiceId) REFERENCES Service(Id)
);

CREATE TABLE ServiceAndIndustry(
Id int IDENTITY(1, 1) PRIMARY KEY,
ServiceId int NOT NULL,
IndustryId int NOT NULL,
CONSTRAINT ServiceOfIndustryFK
	FOREIGN KEY (ServiceId) REFERENCES Service(Id),
CONSTRAINT IndustryOfServiceFK
	FOREIGN KEY (IndustryId) REFERENCES Industry(Id)
);

CREATE TABLE Client(
Id int IDENTITY(1, 1) PRIMARY KEY,
Name nvarchar(50) NOT NULL,
Logo nvarchar(70) NOT NULL,
Url nvarchar(max)
);

CREATE TABLE Project(
Id int IDENTITY(1, 1) PRIMARY KEY,
ClientId int NOT NULL,
CONSTRAINT ClientOfProjectFK
	FOREIGN KEY(ClientId) REFERENCES Client(Id),
Name nvarchar(100) NOT NULL,
PageHeader nvarchar(200),
IndustyId int NOT NULL,
CONSTRAINT IndustryOfProject
	FOREIGN KEY(IndustyId) REFERENCES Industry(Id),
TimePeriod int NOT NULL,
Website nvarchar(150),
Header nvarchar(150) NOT NULL,
Description nvarchar(500),
Challenge nvarchar(200),
Solution nvarchar(200),
CoverPicture nvarchar(100) NOT NULL,
PagePicture nvarchar(100),
ProcessDescription nvarchar(500),
ResultDescription nvarchar(500)
);

CREATE TABLE ProjectAndMember(
Id int IDENTITY(1, 1) PRIMARY KEY,
ProjectId int NOT NULL,
MemberId int NOT NULL,
CONSTRAINT MemberOfProject
	FOREIGN KEY(MemberId) REFERENCES TeamMember(Id),
CONSTRAINT ProjectOfMember
	FOREIGN KEY(ProjectId) REFERENCES Project(Id)
);

CREATE TABLE ProjectAndTech(
Id int IDENTITY(1, 1) PRIMARY KEY,
ProjectId int NOT NULL,
TechId int NOT NULL,
CONSTRAINT TechOfProject
	FOREIGN KEY(TechId) REFERENCES Technology(Id),
CONSTRAINT ProjectOfTech
	FOREIGN KEY(ProjectId) REFERENCES Project(Id)
);

CREATE TABLE StepOfProject(
Id int IDENTITY(1, 1) PRIMARY KEY,
Name nvarchar(50) NOT NULL,
Description nvarchar(500) NOT NULL,
Picture nvarchar(100) NOT NULL,
ProjectId int NOT NULL,
CONSTRAINT ProjectOfStep
	FOREIGN KEY(ProjectId) REFERENCES Project(Id)
);

CREATE TABLE SubfieldOfService(
Id int IDENTITY(1, 1) PRIMARY KEY,
Name nvarchar(200) NOT NULL,
ServiceId int NOT NULL,
CONSTRAINT ServiceOfFieldFK
	FOREIGN KEY(ServiceId) REFERENCES Service(Id)
);

CREATE TABLE Configuration(
Id int IDENTITY(1, 1) PRIMARY KEY,
Logo nvarchar(100) NOT NULL,
SecondLogo nvarchar(100),
PhoneNumber nvarchar(20) NOT NULL,
Slogan nvarchar(150),
Description nvarchar(400)
);

CREATE TABLE SocialMediaOfCompany(
Id int IDENTITY(1, 1) PRIMARY KEY,
Name nvarchar(50) NOT NULL,
Icon nvarchar(50),
Url nvarchar(max) NOT NULL
);