using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aiursoft.WeChatExamV2.Sqlite.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    DisplayName = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    AvatarRelativePath = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    MiniProgramOpenId = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    SessionKey = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    IsFree = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ParentId = table.Column<Guid>(type: "TEXT", nullable: true),
                    OrderIndex = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_Categories_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DistributionChannels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AgencyName = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    IsEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DistributionChannels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GlobalSettings",
                columns: table => new
                {
                    Key = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GlobalSettings", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "KnowledgePoints",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    AudioUrl = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: true),
                    Content = table.Column<string>(type: "TEXT", maxLength: 10000, nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LastUpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Embedding = table.Column<byte[]>(type: "BLOB", nullable: true),
                    LastEmbeddedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ParentId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KnowledgePoints", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KnowledgePoints_KnowledgePoints_ParentId",
                        column: x => x.ParentId,
                        principalTable: "KnowledgePoints",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Papers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    TimeLimit = table.Column<int>(type: "INTEGER", nullable: false),
                    IsFree = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsRealExam = table.Column<bool>(type: "INTEGER", nullable: false),
                    Status = table.Column<int>(type: "INTEGER", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Papers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Taxonomies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Taxonomies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
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
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Content = table.Column<string>(type: "TEXT", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    AuthorId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Articles_AspNetUsers_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
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
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
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
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
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
                name: "Feedbacks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    Content = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    Contact = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    Type = table.Column<int>(type: "INTEGER", nullable: false),
                    Status = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Feedbacks_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Content = table.Column<string>(type: "TEXT", maxLength: 2000, nullable: false),
                    QuestionType = table.Column<int>(type: "INTEGER", nullable: false),
                    GradingStrategy = table.Column<int>(type: "INTEGER", nullable: false),
                    Metadata = table.Column<string>(type: "TEXT", maxLength: 5000, nullable: false),
                    StandardAnswer = table.Column<string>(type: "TEXT", maxLength: 5000, nullable: false),
                    Explanation = table.Column<string>(type: "TEXT", maxLength: 3000, nullable: false),
                    CategoryId = table.Column<Guid>(type: "TEXT", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LastUpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Embedding = table.Column<byte[]>(type: "BLOB", nullable: true),
                    LastEmbeddedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    OrderIndex = table.Column<decimal>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Questions_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "VipProducts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Type = table.Column<int>(type: "INTEGER", nullable: false),
                    CategoryId = table.Column<Guid>(type: "TEXT", nullable: true),
                    PriceInFen = table.Column<int>(type: "INTEGER", nullable: false),
                    DurationDays = table.Column<int>(type: "INTEGER", nullable: false),
                    IsEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VipProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VipProducts_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Coupons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Code = table.Column<string>(type: "TEXT", maxLength: 32, nullable: false),
                    DistributionChannelId = table.Column<Guid>(type: "TEXT", nullable: false),
                    AmountInFen = table.Column<int>(type: "INTEGER", nullable: false),
                    IsSingleUse = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UsedByUserId = table.Column<string>(type: "TEXT", nullable: true),
                    UsedAt = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coupons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Coupons_DistributionChannels_DistributionChannelId",
                        column: x => x.DistributionChannelId,
                        principalTable: "DistributionChannels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserDistributionChannels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    DistributionChannelId = table.Column<Guid>(type: "TEXT", nullable: false),
                    BoundAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDistributionChannels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserDistributionChannels_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserDistributionChannels_DistributionChannels_DistributionChannelId",
                        column: x => x.DistributionChannelId,
                        principalTable: "DistributionChannels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoryKnowledgePoints",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    CategoryId = table.Column<Guid>(type: "TEXT", nullable: false),
                    KnowledgePointId = table.Column<Guid>(type: "TEXT", nullable: false),
                    OrderIndex = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryKnowledgePoints", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategoryKnowledgePoints_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryKnowledgePoints_KnowledgePoints_KnowledgePointId",
                        column: x => x.KnowledgePointId,
                        principalTable: "KnowledgePoints",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaperCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    PaperId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CategoryId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaperCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaperCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaperCategories_Papers_PaperId",
                        column: x => x.PaperId,
                        principalTable: "Papers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaperSnapshots",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    PaperId = table.Column<Guid>(type: "TEXT", nullable: true),
                    Version = table.Column<int>(type: "INTEGER", nullable: false),
                    Title = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    TimeLimit = table.Column<int>(type: "INTEGER", nullable: false),
                    IsFree = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaperSnapshots", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaperSnapshots_Papers_PaperId",
                        column: x => x.PaperId,
                        principalTable: "Papers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CategoryTaxonomies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    TaxonomyId = table.Column<int>(type: "INTEGER", nullable: false),
                    CategoryId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryTaxonomies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategoryTaxonomies_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryTaxonomies_Taxonomies_TaxonomyId",
                        column: x => x.TaxonomyId,
                        principalTable: "Taxonomies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DisplayName = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    IsFree = table.Column<bool>(type: "INTEGER", nullable: false),
                    TaxonomyId = table.Column<int>(type: "INTEGER", nullable: true),
                    OrderIndex = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tags_Taxonomies_TaxonomyId",
                        column: x => x.TaxonomyId,
                        principalTable: "Taxonomies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "KnowledgePointQuestions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    KnowledgePointId = table.Column<Guid>(type: "TEXT", nullable: false),
                    QuestionId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KnowledgePointQuestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KnowledgePointQuestions_KnowledgePoints_KnowledgePointId",
                        column: x => x.KnowledgePointId,
                        principalTable: "KnowledgePoints",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KnowledgePointQuestions_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaperQuestions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PaperId = table.Column<Guid>(type: "TEXT", nullable: false),
                    QuestionId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Order = table.Column<int>(type: "INTEGER", nullable: false),
                    Score = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaperQuestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaperQuestions_Papers_PaperId",
                        column: x => x.PaperId,
                        principalTable: "Papers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaperQuestions_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserPracticeHistories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    UserId = table.Column<string>(type: "TEXT", maxLength: 64, nullable: false),
                    QuestionId = table.Column<Guid>(type: "TEXT", nullable: false),
                    UserAnswer = table.Column<string>(type: "TEXT", maxLength: 1024, nullable: false),
                    IsCorrect = table.Column<bool>(type: "INTEGER", nullable: false),
                    PracticeType = table.Column<int>(type: "INTEGER", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPracticeHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserPracticeHistories_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserPracticeHistories_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Changes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Type = table.Column<int>(type: "INTEGER", nullable: false),
                    TriggerUserId = table.Column<string>(type: "TEXT", maxLength: 450, nullable: true),
                    TargetUserId = table.Column<string>(type: "TEXT", maxLength: 450, nullable: false),
                    VipProductId = table.Column<Guid>(type: "TEXT", nullable: true),
                    CouponId = table.Column<Guid>(type: "TEXT", nullable: true),
                    Details = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    CreateTime = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Changes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Changes_AspNetUsers_TargetUserId",
                        column: x => x.TargetUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Changes_AspNetUsers_TriggerUserId",
                        column: x => x.TriggerUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Changes_Coupons_CouponId",
                        column: x => x.CouponId,
                        principalTable: "Coupons",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Changes_VipProducts_VipProductId",
                        column: x => x.VipProductId,
                        principalTable: "VipProducts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CouponVipProducts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    CouponId = table.Column<Guid>(type: "TEXT", nullable: false),
                    VipProductId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CouponVipProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CouponVipProducts_Coupons_CouponId",
                        column: x => x.CouponId,
                        principalTable: "Coupons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CouponVipProducts_VipProducts_VipProductId",
                        column: x => x.VipProductId,
                        principalTable: "VipProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaymentOrders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    OutTradeNo = table.Column<string>(type: "TEXT", maxLength: 64, nullable: false),
                    UserId = table.Column<string>(type: "TEXT", maxLength: 450, nullable: false),
                    VipProductId = table.Column<Guid>(type: "TEXT", nullable: true),
                    CouponId = table.Column<Guid>(type: "TEXT", nullable: true),
                    DiscountInFen = table.Column<int>(type: "INTEGER", nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 256, nullable: false),
                    AmountInFen = table.Column<int>(type: "INTEGER", nullable: false),
                    Status = table.Column<int>(type: "INTEGER", nullable: false),
                    WechatTransactionId = table.Column<string>(type: "TEXT", maxLength: 64, nullable: true),
                    PrepayId = table.Column<string>(type: "TEXT", maxLength: 128, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PaidAt = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ExpiredAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentOrders_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PaymentOrders_Coupons_CouponId",
                        column: x => x.CouponId,
                        principalTable: "Coupons",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PaymentOrders_VipProducts_VipProductId",
                        column: x => x.VipProductId,
                        principalTable: "VipProducts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserClaimedCoupons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    CouponId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ClaimedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsUsed = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaimedCoupons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaimedCoupons_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserClaimedCoupons_Coupons_CouponId",
                        column: x => x.CouponId,
                        principalTable: "Coupons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Exams",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    PaperId = table.Column<Guid>(type: "TEXT", nullable: true),
                    PaperSnapshotId = table.Column<Guid>(type: "TEXT", nullable: true),
                    StartTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EndTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DurationMinutes = table.Column<int>(type: "INTEGER", nullable: false),
                    AllowedAttempts = table.Column<int>(type: "INTEGER", nullable: false),
                    IsPublic = table.Column<bool>(type: "INTEGER", nullable: false),
                    ShowAnswerAfter = table.Column<DateTime>(type: "TEXT", nullable: true),
                    AllowReview = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Exams_PaperSnapshots_PaperSnapshotId",
                        column: x => x.PaperSnapshotId,
                        principalTable: "PaperSnapshots",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Exams_Papers_PaperId",
                        column: x => x.PaperId,
                        principalTable: "Papers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "QuestionSnapshots",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    PaperSnapshotId = table.Column<Guid>(type: "TEXT", nullable: false),
                    OriginalQuestionId = table.Column<Guid>(type: "TEXT", nullable: true),
                    Order = table.Column<int>(type: "INTEGER", nullable: false),
                    Score = table.Column<int>(type: "INTEGER", nullable: false),
                    Content = table.Column<string>(type: "TEXT", maxLength: 2000, nullable: false),
                    QuestionType = table.Column<int>(type: "INTEGER", nullable: false),
                    GradingStrategy = table.Column<int>(type: "INTEGER", nullable: false),
                    Metadata = table.Column<string>(type: "TEXT", maxLength: 5000, nullable: false),
                    StandardAnswer = table.Column<string>(type: "TEXT", maxLength: 5000, nullable: false),
                    Explanation = table.Column<string>(type: "TEXT", maxLength: 3000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionSnapshots", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuestionSnapshots_PaperSnapshots_PaperSnapshotId",
                        column: x => x.PaperSnapshotId,
                        principalTable: "PaperSnapshots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaperTags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PaperId = table.Column<Guid>(type: "TEXT", nullable: false),
                    TagId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaperTags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaperTags_Papers_PaperId",
                        column: x => x.PaperId,
                        principalTable: "Papers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaperTags_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuestionTags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    QuestionId = table.Column<Guid>(type: "TEXT", nullable: false),
                    TagId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionTags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuestionTags_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QuestionTags_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CouponUsages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    CouponId = table.Column<Guid>(type: "TEXT", nullable: false),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    PaymentOrderId = table.Column<Guid>(type: "TEXT", nullable: false),
                    UsedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DiscountInFen = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CouponUsages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CouponUsages_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CouponUsages_Coupons_CouponId",
                        column: x => x.CouponId,
                        principalTable: "Coupons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CouponUsages_PaymentOrders_PaymentOrderId",
                        column: x => x.PaymentOrderId,
                        principalTable: "PaymentOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaymentLogs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    PaymentOrderId = table.Column<Guid>(type: "TEXT", nullable: false),
                    EventType = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    RawData = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentLogs_PaymentOrders_PaymentOrderId",
                        column: x => x.PaymentOrderId,
                        principalTable: "PaymentOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VipMemberships",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    UserId = table.Column<string>(type: "TEXT", maxLength: 450, nullable: false),
                    VipProductId = table.Column<Guid>(type: "TEXT", nullable: false),
                    StartTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EndTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LastPaymentOrderId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VipMemberships", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VipMemberships_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VipMemberships_PaymentOrders_LastPaymentOrderId",
                        column: x => x.LastPaymentOrderId,
                        principalTable: "PaymentOrders",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VipMemberships_VipProducts_VipProductId",
                        column: x => x.VipProductId,
                        principalTable: "VipProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExamRecords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    ExamId = table.Column<Guid>(type: "TEXT", nullable: false),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    PaperSnapshotId = table.Column<Guid>(type: "TEXT", nullable: false),
                    AttemptIndex = table.Column<int>(type: "INTEGER", nullable: false),
                    StartTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    SubmitTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Status = table.Column<int>(type: "INTEGER", nullable: false),
                    TotalScore = table.Column<int>(type: "INTEGER", nullable: false),
                    TeacherComment = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamRecords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExamRecords_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExamRecords_Exams_ExamId",
                        column: x => x.ExamId,
                        principalTable: "Exams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExamRecords_PaperSnapshots_PaperSnapshotId",
                        column: x => x.PaperSnapshotId,
                        principalTable: "PaperSnapshots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnswerRecords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    ExamRecordId = table.Column<Guid>(type: "TEXT", nullable: false),
                    QuestionSnapshotId = table.Column<Guid>(type: "TEXT", nullable: false),
                    UserAnswer = table.Column<string>(type: "TEXT", maxLength: 5000, nullable: false),
                    Score = table.Column<int>(type: "INTEGER", nullable: false),
                    IsMarked = table.Column<bool>(type: "INTEGER", nullable: false),
                    GradingResult = table.Column<string>(type: "TEXT", maxLength: 5000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnswerRecords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnswerRecords_ExamRecords_ExamRecordId",
                        column: x => x.ExamRecordId,
                        principalTable: "ExamRecords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnswerRecords_QuestionSnapshots_QuestionSnapshotId",
                        column: x => x.QuestionSnapshotId,
                        principalTable: "QuestionSnapshots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnswerRecords_ExamRecordId",
                table: "AnswerRecords",
                column: "ExamRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_AnswerRecords_QuestionSnapshotId",
                table: "AnswerRecords",
                column: "QuestionSnapshotId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_AuthorId",
                table: "Articles",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

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
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ParentId",
                table: "Categories",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryKnowledgePoints_CategoryId",
                table: "CategoryKnowledgePoints",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryKnowledgePoints_KnowledgePointId",
                table: "CategoryKnowledgePoints",
                column: "KnowledgePointId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryTaxonomies_CategoryId",
                table: "CategoryTaxonomies",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryTaxonomies_TaxonomyId",
                table: "CategoryTaxonomies",
                column: "TaxonomyId");

            migrationBuilder.CreateIndex(
                name: "IX_Changes_CouponId",
                table: "Changes",
                column: "CouponId");

            migrationBuilder.CreateIndex(
                name: "IX_Changes_TargetUserId",
                table: "Changes",
                column: "TargetUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Changes_TriggerUserId",
                table: "Changes",
                column: "TriggerUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Changes_VipProductId",
                table: "Changes",
                column: "VipProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Coupons_Code",
                table: "Coupons",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Coupons_DistributionChannelId",
                table: "Coupons",
                column: "DistributionChannelId");

            migrationBuilder.CreateIndex(
                name: "IX_CouponUsages_CouponId",
                table: "CouponUsages",
                column: "CouponId");

            migrationBuilder.CreateIndex(
                name: "IX_CouponUsages_PaymentOrderId",
                table: "CouponUsages",
                column: "PaymentOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_CouponUsages_UserId",
                table: "CouponUsages",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CouponVipProducts_CouponId",
                table: "CouponVipProducts",
                column: "CouponId");

            migrationBuilder.CreateIndex(
                name: "IX_CouponVipProducts_VipProductId",
                table: "CouponVipProducts",
                column: "VipProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamRecords_ExamId",
                table: "ExamRecords",
                column: "ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamRecords_PaperSnapshotId",
                table: "ExamRecords",
                column: "PaperSnapshotId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamRecords_UserId",
                table: "ExamRecords",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Exams_PaperId",
                table: "Exams",
                column: "PaperId");

            migrationBuilder.CreateIndex(
                name: "IX_Exams_PaperSnapshotId",
                table: "Exams",
                column: "PaperSnapshotId");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_UserId",
                table: "Feedbacks",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_KnowledgePointQuestions_KnowledgePointId",
                table: "KnowledgePointQuestions",
                column: "KnowledgePointId");

            migrationBuilder.CreateIndex(
                name: "IX_KnowledgePointQuestions_QuestionId",
                table: "KnowledgePointQuestions",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_KnowledgePoints_ParentId",
                table: "KnowledgePoints",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_PaperCategories_CategoryId",
                table: "PaperCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PaperCategories_PaperId",
                table: "PaperCategories",
                column: "PaperId");

            migrationBuilder.CreateIndex(
                name: "IX_PaperQuestions_PaperId",
                table: "PaperQuestions",
                column: "PaperId");

            migrationBuilder.CreateIndex(
                name: "IX_PaperQuestions_QuestionId",
                table: "PaperQuestions",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_PaperSnapshots_PaperId",
                table: "PaperSnapshots",
                column: "PaperId");

            migrationBuilder.CreateIndex(
                name: "IX_PaperTags_PaperId",
                table: "PaperTags",
                column: "PaperId");

            migrationBuilder.CreateIndex(
                name: "IX_PaperTags_TagId",
                table: "PaperTags",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentLogs_PaymentOrderId",
                table: "PaymentLogs",
                column: "PaymentOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentOrders_CouponId",
                table: "PaymentOrders",
                column: "CouponId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentOrders_OutTradeNo",
                table: "PaymentOrders",
                column: "OutTradeNo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PaymentOrders_Status",
                table: "PaymentOrders",
                column: "Status");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentOrders_UserId",
                table: "PaymentOrders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentOrders_VipProductId",
                table: "PaymentOrders",
                column: "VipProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_CategoryId",
                table: "Questions",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionSnapshots_PaperSnapshotId",
                table: "QuestionSnapshots",
                column: "PaperSnapshotId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionTags_QuestionId",
                table: "QuestionTags",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionTags_TagId",
                table: "QuestionTags",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_Tags_TaxonomyId",
                table: "Tags",
                column: "TaxonomyId");

            migrationBuilder.CreateIndex(
                name: "IX_UserClaimedCoupons_CouponId",
                table: "UserClaimedCoupons",
                column: "CouponId");

            migrationBuilder.CreateIndex(
                name: "IX_UserClaimedCoupons_UserId",
                table: "UserClaimedCoupons",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDistributionChannels_DistributionChannelId",
                table: "UserDistributionChannels",
                column: "DistributionChannelId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDistributionChannels_UserId",
                table: "UserDistributionChannels",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPracticeHistories_QuestionId",
                table: "UserPracticeHistories",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPracticeHistories_UserId",
                table: "UserPracticeHistories",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_VipMemberships_LastPaymentOrderId",
                table: "VipMemberships",
                column: "LastPaymentOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_VipMemberships_UserId",
                table: "VipMemberships",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_VipMemberships_UserId_VipProductId",
                table: "VipMemberships",
                columns: new[] { "UserId", "VipProductId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_VipMemberships_VipProductId",
                table: "VipMemberships",
                column: "VipProductId");

            migrationBuilder.CreateIndex(
                name: "IX_VipProducts_CategoryId",
                table: "VipProducts",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_VipProducts_Type",
                table: "VipProducts",
                column: "Type");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnswerRecords");

            migrationBuilder.DropTable(
                name: "Articles");

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
                name: "CategoryKnowledgePoints");

            migrationBuilder.DropTable(
                name: "CategoryTaxonomies");

            migrationBuilder.DropTable(
                name: "Changes");

            migrationBuilder.DropTable(
                name: "CouponUsages");

            migrationBuilder.DropTable(
                name: "CouponVipProducts");

            migrationBuilder.DropTable(
                name: "Feedbacks");

            migrationBuilder.DropTable(
                name: "GlobalSettings");

            migrationBuilder.DropTable(
                name: "KnowledgePointQuestions");

            migrationBuilder.DropTable(
                name: "PaperCategories");

            migrationBuilder.DropTable(
                name: "PaperQuestions");

            migrationBuilder.DropTable(
                name: "PaperTags");

            migrationBuilder.DropTable(
                name: "PaymentLogs");

            migrationBuilder.DropTable(
                name: "QuestionTags");

            migrationBuilder.DropTable(
                name: "UserClaimedCoupons");

            migrationBuilder.DropTable(
                name: "UserDistributionChannels");

            migrationBuilder.DropTable(
                name: "UserPracticeHistories");

            migrationBuilder.DropTable(
                name: "VipMemberships");

            migrationBuilder.DropTable(
                name: "ExamRecords");

            migrationBuilder.DropTable(
                name: "QuestionSnapshots");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "KnowledgePoints");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "PaymentOrders");

            migrationBuilder.DropTable(
                name: "Exams");

            migrationBuilder.DropTable(
                name: "Taxonomies");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Coupons");

            migrationBuilder.DropTable(
                name: "VipProducts");

            migrationBuilder.DropTable(
                name: "PaperSnapshots");

            migrationBuilder.DropTable(
                name: "DistributionChannels");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Papers");
        }
    }
}
