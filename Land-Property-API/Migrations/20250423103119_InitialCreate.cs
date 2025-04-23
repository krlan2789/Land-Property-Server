using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Land_Property.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdvertisementTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Slug = table.Column<string>(type: "TEXT", maxLength: 64, nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 64, nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "GETDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvertisementTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PropertyTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Slug = table.Column<string>(type: "TEXT", maxLength: 64, nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 64, nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "GETDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    Email = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", maxLength: 32, nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "GETDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Properties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    Slug = table.Column<string>(type: "TEXT", maxLength: 512, nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false),
                    BuildingArea = table.Column<double>(type: "REAL", nullable: false),
                    LandArea = table.Column<string>(type: "TEXT", nullable: false),
                    Bedroom = table.Column<byte>(type: "INTEGER", nullable: false),
                    Bathroom = table.Column<byte>(type: "INTEGER", nullable: false),
                    Floor = table.Column<byte>(type: "INTEGER", nullable: false),
                    Price = table.Column<ulong>(type: "INTEGER", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Images = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    BuildingTypeId = table.Column<int>(type: "INTEGER", nullable: false),
                    AdvertisementTypeId = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "GETDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Properties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Properties_AdvertisementTypes_AdvertisementTypeId",
                        column: x => x.AdvertisementTypeId,
                        principalTable: "AdvertisementTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Properties_PropertyTypes_BuildingTypeId",
                        column: x => x.BuildingTypeId,
                        principalTable: "PropertyTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Properties_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserSessionLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    IpAddress = table.Column<string>(type: "TEXT", maxLength: 64, nullable: true),
                    UserAgent = table.Column<string>(type: "TEXT", nullable: true),
                    Action = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSessionLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserSessionLogs_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PropertyViewLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PropertyId = table.Column<int>(type: "INTEGER", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyViewLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PropertyViewLogs_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PropertyViewLogs_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AdvertisementTypes",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "Slug", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 4, 23, 17, 31, 19, 80, DateTimeKind.Local).AddTicks(9748), null, "Rent", "rent", new DateTime(2025, 4, 23, 17, 31, 19, 81, DateTimeKind.Local).AddTicks(24) },
                    { 2, new DateTime(2025, 4, 23, 17, 31, 19, 81, DateTimeKind.Local).AddTicks(640), null, "Sell", "sell", new DateTime(2025, 4, 23, 17, 31, 19, 81, DateTimeKind.Local).AddTicks(642) },
                    { 3, new DateTime(2025, 4, 23, 17, 31, 19, 81, DateTimeKind.Local).AddTicks(643), null, "Credit", "credit", new DateTime(2025, 4, 23, 17, 31, 19, 81, DateTimeKind.Local).AddTicks(644) }
                });

            migrationBuilder.InsertData(
                table: "PropertyTypes",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "Slug", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 4, 23, 17, 31, 19, 78, DateTimeKind.Local).AddTicks(5547), null, "House", "house", new DateTime(2025, 4, 23, 17, 31, 19, 79, DateTimeKind.Local).AddTicks(7894) },
                    { 2, new DateTime(2025, 4, 23, 17, 31, 19, 79, DateTimeKind.Local).AddTicks(8896), null, "Apartment", "apartment", new DateTime(2025, 4, 23, 17, 31, 19, 79, DateTimeKind.Local).AddTicks(8899) },
                    { 3, new DateTime(2025, 4, 23, 17, 31, 19, 79, DateTimeKind.Local).AddTicks(8900), null, "Guesthouse", "guesthouse", new DateTime(2025, 4, 23, 17, 31, 19, 79, DateTimeKind.Local).AddTicks(8901) },
                    { 4, new DateTime(2025, 4, 23, 17, 31, 19, 79, DateTimeKind.Local).AddTicks(8902), null, "Warehouse", "warehouse", new DateTime(2025, 4, 23, 17, 31, 19, 79, DateTimeKind.Local).AddTicks(8903) },
                    { 5, new DateTime(2025, 4, 23, 17, 31, 19, 79, DateTimeKind.Local).AddTicks(8904), null, "Commercial", "commercial", new DateTime(2025, 4, 23, 17, 31, 19, 79, DateTimeKind.Local).AddTicks(8905) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdvertisementTypes_Slug",
                table: "AdvertisementTypes",
                column: "Slug",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Properties_AdvertisementTypeId",
                table: "Properties",
                column: "AdvertisementTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_BuildingTypeId",
                table: "Properties",
                column: "BuildingTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_Slug",
                table: "Properties",
                column: "Slug",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Properties_UserId",
                table: "Properties",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyTypes_Slug",
                table: "PropertyTypes",
                column: "Slug",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PropertyViewLogs_PropertyId",
                table: "PropertyViewLogs",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyViewLogs_UserId",
                table: "PropertyViewLogs",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserSessionLogs_UserId",
                table: "UserSessionLogs",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PropertyViewLogs");

            migrationBuilder.DropTable(
                name: "UserSessionLogs");

            migrationBuilder.DropTable(
                name: "Properties");

            migrationBuilder.DropTable(
                name: "AdvertisementTypes");

            migrationBuilder.DropTable(
                name: "PropertyTypes");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
