using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NaxlyAI.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AboutCompany",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PageHeader = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Slogan = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    VideoTitle = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    VideoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FoundationYear = table.Column<int>(type: "int", nullable: true),
                    Picture1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Picture2 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Picture3 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    AboutOurHistory = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    WhyChooseUs = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    WhyChooseUsPicture1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    WhyChooseUsPicture2 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TeamMemberDesc = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    HomeCoverPicture = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutCompany", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Logo = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    ShowOnHomePage = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Configuration",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Logo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Slogan = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Configuration", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PageHeader = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    InnerHeader = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Slogan = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    LocationHeader = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    LocationDesc = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    PhoneHeader = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    PhoneDesc = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PhoneNum = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PhoneTime = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    EmailHeader = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    EmailDesc = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email1 = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Email2 = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    PagePicture = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HomePage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutServices = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ServicesPicture = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    AboutProjects = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    AboutWorkProcess = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    WorkProcessHeader1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    WorkProcessDesc1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    WorkProcessHeader2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    WorkProcessDesc2 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    WorkProcessHeader3 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    WorkProcessDesc3 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AboutWhyChooseUs = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    WhyChooseUsPicture = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClientDescription = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomePage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Industry",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Icon = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Industry", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReasonForChoosingUs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Icon = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Header = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Descrioption = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReasonForChoosingUs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Service",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PageHeader = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Intro = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    StartYourProjectUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstPicture = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SubservicesHeader = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SubservicesDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TechnologiesHeader = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TechnologiesDescription = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SecondPicture = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ApplicationHeader = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ApplicationDescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ProjectsHeader = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CoverPicture = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Icon = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServicesPage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PageHeader = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Explanation = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ExplanationAboutIndustries = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    VideoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AwardText = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    AwardPicture = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    AwardDescription = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServicesPage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SocialMedia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialMedia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SocialMediaOfCompany",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialMediaOfCompany", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StepOfHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Header = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StepOfHistory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TeamMember",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Photo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Fullname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Designation = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamMember", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Technology",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Picture = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Technology", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Testimonial",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Photo = table.Column<string>(type: "text", nullable: false),
                    Review = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Fullname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Designation = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    NumberOfStars = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Testimonial", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserMessage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserMessage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PageHeader = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IndustyId = table.Column<int>(type: "int", nullable: false),
                    TimePeriod = table.Column<int>(type: "int", nullable: false),
                    Website = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Header = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Challenge = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Solution = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CoverPicture = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PagePicture = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ProcessDescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ResultDescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.Id);
                    table.ForeignKey(
                        name: "ClientOfProjectFK",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "IndustryOfProject",
                        column: x => x.IndustyId,
                        principalTable: "Industry",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ServiceAndIndustry",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceId = table.Column<int>(type: "int", nullable: false),
                    IndustryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceAndIndustry", x => x.Id);
                    table.ForeignKey(
                        name: "IndustryOfServiceFK",
                        column: x => x.IndustryId,
                        principalTable: "Industry",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "ServiceOfIndustryFK",
                        column: x => x.ServiceId,
                        principalTable: "Service",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ServiceFile",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Extention = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Size = table.Column<int>(type: "int", nullable: false),
                    ServiceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceFile", x => x.Id);
                    table.ForeignKey(
                        name: "ServiceOfFileFK",
                        column: x => x.ServiceId,
                        principalTable: "Service",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SubfieldOfService",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ServiceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubfieldOfService", x => x.Id);
                    table.ForeignKey(
                        name: "ServiceOfFieldFK",
                        column: x => x.ServiceId,
                        principalTable: "Service",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Subservice",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Icon = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServiceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subservice", x => x.Id);
                    table.ForeignKey(
                        name: "SubserviceOfServiceFK",
                        column: x => x.ServiceId,
                        principalTable: "Service",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SocialMediaAccountOfMember",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberId = table.Column<int>(type: "int", nullable: false),
                    SocialMediaId = table.Column<int>(type: "int", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialMediaAccountOfMember", x => x.Id);
                    table.ForeignKey(
                        name: "SMMemberFK",
                        column: x => x.MemberId,
                        principalTable: "TeamMember",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "SocialMediaFK",
                        column: x => x.SocialMediaId,
                        principalTable: "SocialMedia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TechAndService",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TechId = table.Column<int>(type: "int", nullable: false),
                    ServiceId = table.Column<int>(type: "int", nullable: false),
                    ShowPicture = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TechAndService", x => x.Id);
                    table.ForeignKey(
                        name: "ServiceFK",
                        column: x => x.ServiceId,
                        principalTable: "Service",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "TechFK",
                        column: x => x.TechId,
                        principalTable: "Technology",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectAndMember",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    MemberId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectAndMember", x => x.Id);
                    table.ForeignKey(
                        name: "MemberOfProject",
                        column: x => x.MemberId,
                        principalTable: "TeamMember",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "ProjectOfMember",
                        column: x => x.ProjectId,
                        principalTable: "Project",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectAndTech",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    TechId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectAndTech", x => x.Id);
                    table.ForeignKey(
                        name: "ProjectOfTech",
                        column: x => x.ProjectId,
                        principalTable: "Project",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "TechOfProject",
                        column: x => x.TechId,
                        principalTable: "Technology",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StepOfProject",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Picture = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ProjectId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StepOfProject", x => x.Id);
                    table.ForeignKey(
                        name: "ProjectOfStep",
                        column: x => x.ProjectId,
                        principalTable: "Project",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Project_ClientId",
                table: "Project",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Project_IndustyId",
                table: "Project",
                column: "IndustyId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectAndMember_MemberId",
                table: "ProjectAndMember",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectAndMember_ProjectId",
                table: "ProjectAndMember",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectAndTech_ProjectId",
                table: "ProjectAndTech",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectAndTech_TechId",
                table: "ProjectAndTech",
                column: "TechId");

            migrationBuilder.CreateIndex(
                name: "UQ__ReasonFo__B03D5134B2BD240E",
                table: "ReasonForChoosingUs",
                column: "Icon",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__ReasonFo__EB3211CECF7247E8",
                table: "ReasonForChoosingUs",
                column: "Header",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ServiceAndIndustry_IndustryId",
                table: "ServiceAndIndustry",
                column: "IndustryId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceAndIndustry_ServiceId",
                table: "ServiceAndIndustry",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceFile_ServiceId",
                table: "ServiceFile",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_SocialMediaAccountOfMember_MemberId",
                table: "SocialMediaAccountOfMember",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_SocialMediaAccountOfMember_SocialMediaId",
                table: "SocialMediaAccountOfMember",
                column: "SocialMediaId");

            migrationBuilder.CreateIndex(
                name: "UQ__StepOfHi__EB3211CE7251FA53",
                table: "StepOfHistory",
                column: "Header",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StepOfProject_ProjectId",
                table: "StepOfProject",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_SubfieldOfService_ServiceId",
                table: "SubfieldOfService",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Subservice_ServiceId",
                table: "Subservice",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_TechAndService_ServiceId",
                table: "TechAndService",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_TechAndService_TechId",
                table: "TechAndService",
                column: "TechId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutCompany");

            migrationBuilder.DropTable(
                name: "Configuration");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "HomePage");

            migrationBuilder.DropTable(
                name: "ProjectAndMember");

            migrationBuilder.DropTable(
                name: "ProjectAndTech");

            migrationBuilder.DropTable(
                name: "ReasonForChoosingUs");

            migrationBuilder.DropTable(
                name: "ServiceAndIndustry");

            migrationBuilder.DropTable(
                name: "ServiceFile");

            migrationBuilder.DropTable(
                name: "ServicesPage");

            migrationBuilder.DropTable(
                name: "SocialMediaAccountOfMember");

            migrationBuilder.DropTable(
                name: "SocialMediaOfCompany");

            migrationBuilder.DropTable(
                name: "StepOfHistory");

            migrationBuilder.DropTable(
                name: "StepOfProject");

            migrationBuilder.DropTable(
                name: "SubfieldOfService");

            migrationBuilder.DropTable(
                name: "Subservice");

            migrationBuilder.DropTable(
                name: "TechAndService");

            migrationBuilder.DropTable(
                name: "Testimonial");

            migrationBuilder.DropTable(
                name: "UserMessage");

            migrationBuilder.DropTable(
                name: "TeamMember");

            migrationBuilder.DropTable(
                name: "SocialMedia");

            migrationBuilder.DropTable(
                name: "Project");

            migrationBuilder.DropTable(
                name: "Service");

            migrationBuilder.DropTable(
                name: "Technology");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "Industry");
        }
    }
}
