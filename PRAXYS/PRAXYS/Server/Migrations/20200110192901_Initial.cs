using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PRAXYS.Server.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adress",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Street = table.Column<string>(nullable: true),
                    Colony = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    PostalCode = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    AddressType = table.Column<string>(nullable: true),
                    StreetAddress = table.Column<string>(nullable: true),
                    ApartmentNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adress", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BondPayments",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    UserEditedID = table.Column<int>(nullable: false),
                    DateEdited = table.Column<DateTime>(nullable: false),
                    BondID = table.Column<int>(nullable: false),
                    PayedDate = table.Column<DateTime>(nullable: false),
                    PremiumPayed = table.Column<decimal>(nullable: false),
                    CommissionPayed = table.Column<bool>(nullable: false),
                    LiquidationNumber = table.Column<int>(nullable: false),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BondPayments", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Branch",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Alias = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branch", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    SecondLastName = table.Column<string>(nullable: true),
                    DayOfBirth = table.Column<DateTime>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    RFC = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    PersonType = table.Column<string>(nullable: true),
                    IssueDate = table.Column<DateTime>(nullable: false),
                    CompanyName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CommissionPayments",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCrated = table.Column<DateTime>(nullable: false),
                    UserEditedID = table.Column<int>(nullable: false),
                    DateEdited = table.Column<DateTime>(nullable: false),
                    BondPaymentID = table.Column<int>(nullable: false),
                    PayedDate = table.Column<DateTime>(nullable: false),
                    AmountPayed = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommissionPayments", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(nullable: true),
                    RFC = table.Column<string>(nullable: true),
                    CompanyClassification = table.Column<string>(nullable: true),
                    CompanyType = table.Column<string>(nullable: true),
                    ConstitutionDate = table.Column<DateTime>(nullable: true),
                    IssueDate = table.Column<DateTime>(nullable: false),
                    Alias = table.Column<string>(nullable: true),
                    Days_Payment_First_Recibe_New = table.Column<int>(nullable: false),
                    Days_Payment_First_Recibe_Renewal = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Coverage",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(nullable: true),
                    Deductible = table.Column<decimal>(nullable: false),
                    CovergaPlanID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coverage", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DocumentType",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentType", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "EndorsementType",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(nullable: true),
                    Transaction = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EndorsementType", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PaymentType",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true),
                    TotalPayments = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentType", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SubAgent",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    SecondLastName = table.Column<string>(nullable: true),
                    PersonType = table.Column<string>(nullable: true),
                    PersonalEmail = table.Column<string>(nullable: true),
                    RFC = table.Column<string>(nullable: true),
                    IdentificationNumber = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Bank = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    IssueDate = table.Column<DateTime>(nullable: true),
                    ExpirationDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubAgent", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CoveragePlan",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    RamoID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoveragePlan", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CoveragePlan_Branch_RamoID",
                        column: x => x.RamoID,
                        principalTable: "Branch",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubBranch",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Alias = table.Column<string>(nullable: true),
                    MenuLetter = table.Column<string>(nullable: true),
                    InputForm = table.Column<string>(nullable: true),
                    RamoID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubBranch", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SubBranch_Branch_RamoID",
                        column: x => x.RamoID,
                        principalTable: "Branch",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Client_Address",
                columns: table => new
                {
                    ClientID = table.Column<int>(nullable: false),
                    AddressID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client_Address", x => new { x.AddressID, x.ClientID });
                    table.ForeignKey(
                        name: "FK_Client_Address_Adress_AddressID",
                        column: x => x.AddressID,
                        principalTable: "Adress",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Client_Address_Clients_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Clients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClientDocumentation",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientID = table.Column<int>(nullable: false),
                    FileName = table.Column<string>(nullable: true),
                    SavedDate = table.Column<DateTime>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    FileExtension = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientDocumentation", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ClientDocumentation_Clients_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Clients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastName = table.Column<string>(nullable: true),
                    SecondLastName = table.Column<string>(nullable: true),
                    DayOfBirth = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<string>(nullable: true),
                    ClientID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Contact_Clients_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Clients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Agent",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    SecondLastName = table.Column<string>(nullable: true),
                    IdentificationCardNumber = table.Column<string>(nullable: true),
                    ExpirationDate = table.Column<DateTime>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    PersonalEmail = table.Column<string>(nullable: true),
                    PersonType = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    IssueDate = table.Column<DateTime>(nullable: false),
                    CompanyName = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    CompanyID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agent", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Agent_Company_CompanyID",
                        column: x => x.CompanyID,
                        principalTable: "Company",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Company_Address",
                columns: table => new
                {
                    CompanyID = table.Column<int>(nullable: false),
                    AddressID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company_Address", x => new { x.AddressID, x.CompanyID });
                    table.ForeignKey(
                        name: "FK_Company_Address_Adress_AddressID",
                        column: x => x.AddressID,
                        principalTable: "Adress",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Company_Address_Company_CompanyID",
                        column: x => x.CompanyID,
                        principalTable: "Company",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ramo_Coverage",
                columns: table => new
                {
                    CoverageID = table.Column<int>(nullable: false),
                    BranchID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ramo_Coverage", x => new { x.CoverageID, x.BranchID });
                    table.ForeignKey(
                        name: "FK_Ramo_Coverage_Branch_BranchID",
                        column: x => x.BranchID,
                        principalTable: "Branch",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ramo_Coverage_Coverage_CoverageID",
                        column: x => x.CoverageID,
                        principalTable: "Coverage",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Agent_PaymentTypes",
                columns: table => new
                {
                    CompanyID = table.Column<int>(nullable: false),
                    PaymenTypeID = table.Column<int>(nullable: false),
                    PaymentID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agent_PaymentTypes", x => new { x.CompanyID, x.PaymenTypeID });
                    table.ForeignKey(
                        name: "FK_Agent_PaymentTypes_Company_CompanyID",
                        column: x => x.CompanyID,
                        principalTable: "Company",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Agent_PaymentTypes_PaymentType_PaymentID",
                        column: x => x.PaymentID,
                        principalTable: "PaymentType",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CoveragePlan_Coverage",
                columns: table => new
                {
                    CoveragePlanID = table.Column<int>(nullable: false),
                    CoverageID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoveragePlan_Coverage", x => new { x.CoverageID, x.CoveragePlanID });
                    table.ForeignKey(
                        name: "FK_CoveragePlan_Coverage_Coverage_CoverageID",
                        column: x => x.CoverageID,
                        principalTable: "Coverage",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CoveragePlan_Coverage_CoveragePlan_CoveragePlanID",
                        column: x => x.CoveragePlanID,
                        principalTable: "CoveragePlan",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Agent_Address",
                columns: table => new
                {
                    AgentID = table.Column<int>(nullable: false),
                    AddressID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agent_Address", x => new { x.AddressID, x.AgentID });
                    table.ForeignKey(
                        name: "FK_Agent_Address_Adress_AddressID",
                        column: x => x.AddressID,
                        principalTable: "Adress",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Agent_Address_Agent_AgentID",
                        column: x => x.AgentID,
                        principalTable: "Agent",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bond",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    UserEditedID = table.Column<int>(nullable: false),
                    DateEdited = table.Column<DateTime>(nullable: false),
                    CompanyID = table.Column<int>(nullable: false),
                    SubAgentID = table.Column<int>(nullable: false),
                    ClientID = table.Column<int>(nullable: false),
                    BeneficiaryID = table.Column<int>(nullable: false),
                    RiskTypeID = table.Column<int>(nullable: false),
                    MovementID = table.Column<int>(nullable: false),
                    BranchID = table.Column<int>(nullable: false),
                    OfficeID = table.Column<int>(nullable: false),
                    StatusID = table.Column<int>(nullable: false),
                    Branch = table.Column<string>(nullable: true),
                    BondNumber = table.Column<string>(nullable: true),
                    BillingNumber = table.Column<string>(nullable: true),
                    IssueDate = table.Column<DateTime>(nullable: false),
                    Start = table.Column<DateTime>(nullable: false),
                    End = table.Column<DateTime>(nullable: false),
                    CovergeAmount = table.Column<decimal>(nullable: false),
                    Premium = table.Column<decimal>(nullable: false),
                    Fee = table.Column<decimal>(nullable: false),
                    IssueCost = table.Column<decimal>(nullable: false),
                    BureauCost = table.Column<decimal>(nullable: false),
                    TaxPercentage = table.Column<decimal>(nullable: false),
                    Tax = table.Column<decimal>(nullable: false),
                    PremiumTotal = table.Column<decimal>(nullable: false),
                    Payed = table.Column<bool>(nullable: false),
                    CommissionPercentage = table.Column<decimal>(nullable: false),
                    GroupCommissionPercentage = table.Column<decimal>(nullable: false),
                    ClientsID = table.Column<int>(nullable: true),
                    AgentID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bond", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Bond_Agent_AgentID",
                        column: x => x.AgentID,
                        principalTable: "Agent",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bond_Clients_ClientsID",
                        column: x => x.ClientsID,
                        principalTable: "Clients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bond_Company_CompanyID",
                        column: x => x.CompanyID,
                        principalTable: "Company",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bond_SubAgent_SubAgentID",
                        column: x => x.SubAgentID,
                        principalTable: "SubAgent",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Insurance",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InsuranceNumber = table.Column<string>(nullable: true),
                    ValidFrom = table.Column<DateTime>(nullable: true),
                    ValidThrought = table.Column<DateTime>(nullable: true),
                    SeniorityDate = table.Column<DateTime>(nullable: true),
                    Renewal = table.Column<decimal>(nullable: true),
                    ClientID = table.Column<int>(nullable: false),
                    AgentID = table.Column<int>(nullable: false),
                    SubBranchID = table.Column<int>(nullable: false),
                    CompanyID = table.Column<int>(nullable: false),
                    SubAgentID = table.Column<int>(nullable: false),
                    PaymentTypeID = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    Payed = table.Column<bool>(nullable: false),
                    CurrencyType = table.Column<string>(nullable: true),
                    NetPremium = table.Column<decimal>(nullable: false),
                    Discount = table.Column<decimal>(nullable: false),
                    DiscountPercentage = table.Column<decimal>(nullable: false),
                    Surcharges = table.Column<decimal>(nullable: false),
                    Rights = table.Column<decimal>(nullable: false),
                    tax = table.Column<decimal>(nullable: false),
                    TaxPercentage = table.Column<decimal>(nullable: false),
                    SubTotal = table.Column<decimal>(nullable: false),
                    TotalPremium = table.Column<decimal>(nullable: false),
                    ExchangeRate = table.Column<decimal>(nullable: false),
                    Endorsement = table.Column<bool>(nullable: false),
                    EndorsementNumber = table.Column<string>(nullable: true),
                    ReferenceName = table.Column<string>(nullable: true),
                    ReferenceNumber = table.Column<string>(nullable: true),
                    ReferenceEmail = table.Column<string>(nullable: true),
                    Brand = table.Column<string>(maxLength: 30, nullable: true),
                    Car_Plates = table.Column<string>(maxLength: 30, nullable: true),
                    Car_Use = table.Column<string>(maxLength: 30, nullable: true),
                    Capacity = table.Column<int>(maxLength: 30, nullable: false),
                    Car_Motor = table.Column<string>(maxLength: 30, nullable: true),
                    Model = table.Column<string>(maxLength: 30, nullable: true),
                    Transmission = table.Column<string>(maxLength: 30, nullable: true),
                    Car_Description = table.Column<string>(maxLength: 150, nullable: true),
                    Insuree_LastName = table.Column<string>(maxLength: 30, nullable: true),
                    Insuree_SecondLastName = table.Column<string>(maxLength: 30, nullable: true),
                    Insuree_Name = table.Column<string>(maxLength: 50, nullable: true),
                    Insuree_BirthDate = table.Column<DateTime>(nullable: false),
                    Insuree_RFC = table.Column<string>(maxLength: 20, nullable: true),
                    Insuree_CURP = table.Column<string>(maxLength: 20, nullable: true),
                    Insuree_Gender = table.Column<string>(maxLength: 20, nullable: true),
                    Secondary_Insuree_LastName = table.Column<string>(maxLength: 30, nullable: true),
                    Secondary_Insuree_SecondLastName = table.Column<string>(maxLength: 30, nullable: true),
                    Secondary_Insuree_Name = table.Column<string>(maxLength: 50, nullable: true),
                    Secondary_Insuree_BirthDate = table.Column<DateTime>(nullable: false),
                    Secondary_Insuree_RFC = table.Column<string>(maxLength: 20, nullable: true),
                    Secondary_Insuree_CURP = table.Column<string>(maxLength: 20, nullable: true),
                    Secondary_Insuree_Gender = table.Column<string>(maxLength: 20, nullable: true),
                    Comission_NetPremium = table.Column<decimal>(nullable: false),
                    Comission_NetPremium_Percentage = table.Column<decimal>(nullable: false),
                    Comission_Surcharges = table.Column<decimal>(nullable: false),
                    Comission_Surcharges_Percentage = table.Column<decimal>(nullable: false),
                    Comission_Rights = table.Column<decimal>(nullable: false),
                    Comission_Rights_Percentage = table.Column<decimal>(nullable: false),
                    Comission_Special = table.Column<decimal>(nullable: false),
                    Comission_Special_Percentage = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Insurance", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Insurance_Agent_AgentID",
                        column: x => x.AgentID,
                        principalTable: "Agent",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Insurance_Clients_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Clients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Insurance_Company_CompanyID",
                        column: x => x.CompanyID,
                        principalTable: "Company",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Insurance_PaymentType_PaymentTypeID",
                        column: x => x.PaymentTypeID,
                        principalTable: "PaymentType",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Insurance_SubAgent_SubAgentID",
                        column: x => x.SubAgentID,
                        principalTable: "SubAgent",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Insurance_SubBranch_SubBranchID",
                        column: x => x.SubBranchID,
                        principalTable: "SubBranch",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Endorsement",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InsuranceID = table.Column<int>(nullable: false),
                    ValidFrom = table.Column<DateTime>(nullable: false),
                    ValidThrought = table.Column<DateTime>(nullable: false),
                    EndosementTypeID = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    EndorsementTypeID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endorsement", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Endorsement_EndorsementType_EndorsementTypeID",
                        column: x => x.EndorsementTypeID,
                        principalTable: "EndorsementType",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Endorsement_Insurance_InsuranceID",
                        column: x => x.InsuranceID,
                        principalTable: "Insurance",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InsuranceDocumentation",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InsuranceID = table.Column<int>(nullable: false),
                    FileName = table.Column<string>(nullable: true),
                    SavedDate = table.Column<DateTime>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    FileExtension = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InsuranceDocumentation", x => x.ID);
                    table.ForeignKey(
                        name: "FK_InsuranceDocumentation_Insurance_InsuranceID",
                        column: x => x.InsuranceID,
                        principalTable: "Insurance",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaymentInformation",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Premium = table.Column<decimal>(nullable: false),
                    InsuranceID = table.Column<int>(nullable: false),
                    PaymentExpirationDate = table.Column<DateTime>(nullable: false),
                    PaymentNumber = table.Column<string>(nullable: true),
                    Payed = table.Column<bool>(nullable: false),
                    Canceled = table.Column<bool>(nullable: false),
                    Disabled = table.Column<bool>(nullable: false),
                    IssueDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentInformation", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PaymentInformation_Insurance_InsuranceID",
                        column: x => x.InsuranceID,
                        principalTable: "Insurance",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RegisterPayment",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bank = table.Column<string>(nullable: true),
                    PaymentAmount = table.Column<decimal>(nullable: false),
                    DateRegistered = table.Column<DateTime>(nullable: true),
                    DocumentType = table.Column<string>(nullable: true),
                    DatePayment = table.Column<DateTime>(nullable: false),
                    PaymentInformationID = table.Column<int>(nullable: false),
                    InsuranceID = table.Column<int>(nullable: false),
                    IssueDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegisterPayment", x => x.ID);
                    table.ForeignKey(
                        name: "FK_RegisterPayment_Insurance_InsuranceID",
                        column: x => x.InsuranceID,
                        principalTable: "Insurance",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RegisterPayment_PaymentInformation_PaymentInformationID",
                        column: x => x.PaymentInformationID,
                        principalTable: "PaymentInformation",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Agent_CompanyID",
                table: "Agent",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_Agent_Address_AgentID",
                table: "Agent_Address",
                column: "AgentID");

            migrationBuilder.CreateIndex(
                name: "IX_Agent_PaymentTypes_PaymentID",
                table: "Agent_PaymentTypes",
                column: "PaymentID");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Bond_AgentID",
                table: "Bond",
                column: "AgentID");

            migrationBuilder.CreateIndex(
                name: "IX_Bond_ClientsID",
                table: "Bond",
                column: "ClientsID");

            migrationBuilder.CreateIndex(
                name: "IX_Bond_CompanyID",
                table: "Bond",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_Bond_SubAgentID",
                table: "Bond",
                column: "SubAgentID");

            migrationBuilder.CreateIndex(
                name: "IX_Client_Address_ClientID",
                table: "Client_Address",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientDocumentation_ClientID",
                table: "ClientDocumentation",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_Company_Address_CompanyID",
                table: "Company_Address",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_ClientID",
                table: "Contact",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_CoveragePlan_RamoID",
                table: "CoveragePlan",
                column: "RamoID");

            migrationBuilder.CreateIndex(
                name: "IX_CoveragePlan_Coverage_CoveragePlanID",
                table: "CoveragePlan_Coverage",
                column: "CoveragePlanID");

            migrationBuilder.CreateIndex(
                name: "IX_Endorsement_EndorsementTypeID",
                table: "Endorsement",
                column: "EndorsementTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Endorsement_InsuranceID",
                table: "Endorsement",
                column: "InsuranceID");

            migrationBuilder.CreateIndex(
                name: "IX_Insurance_AgentID",
                table: "Insurance",
                column: "AgentID");

            migrationBuilder.CreateIndex(
                name: "IX_Insurance_ClientID",
                table: "Insurance",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_Insurance_CompanyID",
                table: "Insurance",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_Insurance_PaymentTypeID",
                table: "Insurance",
                column: "PaymentTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Insurance_SubAgentID",
                table: "Insurance",
                column: "SubAgentID");

            migrationBuilder.CreateIndex(
                name: "IX_Insurance_SubBranchID",
                table: "Insurance",
                column: "SubBranchID");

            migrationBuilder.CreateIndex(
                name: "IX_InsuranceDocumentation_InsuranceID",
                table: "InsuranceDocumentation",
                column: "InsuranceID");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentInformation_InsuranceID",
                table: "PaymentInformation",
                column: "InsuranceID");

            migrationBuilder.CreateIndex(
                name: "IX_Ramo_Coverage_BranchID",
                table: "Ramo_Coverage",
                column: "BranchID");

            migrationBuilder.CreateIndex(
                name: "IX_RegisterPayment_InsuranceID",
                table: "RegisterPayment",
                column: "InsuranceID");

            migrationBuilder.CreateIndex(
                name: "IX_RegisterPayment_PaymentInformationID",
                table: "RegisterPayment",
                column: "PaymentInformationID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SubBranch_RamoID",
                table: "SubBranch",
                column: "RamoID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agent_Address");

            migrationBuilder.DropTable(
                name: "Agent_PaymentTypes");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Bond");

            migrationBuilder.DropTable(
                name: "BondPayments");

            migrationBuilder.DropTable(
                name: "Client_Address");

            migrationBuilder.DropTable(
                name: "ClientDocumentation");

            migrationBuilder.DropTable(
                name: "CommissionPayments");

            migrationBuilder.DropTable(
                name: "Company_Address");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "CoveragePlan_Coverage");

            migrationBuilder.DropTable(
                name: "DocumentType");

            migrationBuilder.DropTable(
                name: "Endorsement");

            migrationBuilder.DropTable(
                name: "InsuranceDocumentation");

            migrationBuilder.DropTable(
                name: "Ramo_Coverage");

            migrationBuilder.DropTable(
                name: "RegisterPayment");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Adress");

            migrationBuilder.DropTable(
                name: "CoveragePlan");

            migrationBuilder.DropTable(
                name: "EndorsementType");

            migrationBuilder.DropTable(
                name: "Coverage");

            migrationBuilder.DropTable(
                name: "PaymentInformation");

            migrationBuilder.DropTable(
                name: "Insurance");

            migrationBuilder.DropTable(
                name: "Agent");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "PaymentType");

            migrationBuilder.DropTable(
                name: "SubAgent");

            migrationBuilder.DropTable(
                name: "SubBranch");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "Branch");
        }
    }
}
