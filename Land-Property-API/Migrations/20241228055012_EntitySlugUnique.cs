using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Land_Property.API.Migrations
{
    /// <inheritdoc />
    public partial class EntitySlugUnique : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AdvertisementTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 28, 12, 50, 12, 79, DateTimeKind.Local).AddTicks(3174), new DateTime(2024, 12, 28, 12, 50, 12, 79, DateTimeKind.Local).AddTicks(3437) });

            migrationBuilder.UpdateData(
                table: "AdvertisementTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 28, 12, 50, 12, 79, DateTimeKind.Local).AddTicks(4177), new DateTime(2024, 12, 28, 12, 50, 12, 79, DateTimeKind.Local).AddTicks(4179) });

            migrationBuilder.UpdateData(
                table: "AdvertisementTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 28, 12, 50, 12, 79, DateTimeKind.Local).AddTicks(4181), new DateTime(2024, 12, 28, 12, 50, 12, 79, DateTimeKind.Local).AddTicks(4182) });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 28, 12, 50, 12, 77, DateTimeKind.Local).AddTicks(3536), new DateTime(2024, 12, 28, 12, 50, 12, 78, DateTimeKind.Local).AddTicks(5625) });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 28, 12, 50, 12, 78, DateTimeKind.Local).AddTicks(6337), new DateTime(2024, 12, 28, 12, 50, 12, 78, DateTimeKind.Local).AddTicks(6340) });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 28, 12, 50, 12, 78, DateTimeKind.Local).AddTicks(6341), new DateTime(2024, 12, 28, 12, 50, 12, 78, DateTimeKind.Local).AddTicks(6342) });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 28, 12, 50, 12, 78, DateTimeKind.Local).AddTicks(6343), new DateTime(2024, 12, 28, 12, 50, 12, 78, DateTimeKind.Local).AddTicks(6343) });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 28, 12, 50, 12, 78, DateTimeKind.Local).AddTicks(6344), new DateTime(2024, 12, 28, 12, 50, 12, 78, DateTimeKind.Local).AddTicks(6345) });

            migrationBuilder.CreateIndex(
                name: "IX_Properties_Slug",
                table: "Properties",
                column: "Slug",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Properties_Slug",
                table: "Properties");

            migrationBuilder.UpdateData(
                table: "AdvertisementTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 28, 12, 15, 54, 803, DateTimeKind.Local).AddTicks(5856), new DateTime(2024, 12, 28, 12, 15, 54, 803, DateTimeKind.Local).AddTicks(6093) });

            migrationBuilder.UpdateData(
                table: "AdvertisementTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 28, 12, 15, 54, 803, DateTimeKind.Local).AddTicks(6731), new DateTime(2024, 12, 28, 12, 15, 54, 803, DateTimeKind.Local).AddTicks(6732) });

            migrationBuilder.UpdateData(
                table: "AdvertisementTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 28, 12, 15, 54, 803, DateTimeKind.Local).AddTicks(6733), new DateTime(2024, 12, 28, 12, 15, 54, 803, DateTimeKind.Local).AddTicks(6734) });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 28, 12, 15, 54, 801, DateTimeKind.Local).AddTicks(6311), new DateTime(2024, 12, 28, 12, 15, 54, 802, DateTimeKind.Local).AddTicks(8846) });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 28, 12, 15, 54, 802, DateTimeKind.Local).AddTicks(9735), new DateTime(2024, 12, 28, 12, 15, 54, 802, DateTimeKind.Local).AddTicks(9738) });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 28, 12, 15, 54, 802, DateTimeKind.Local).AddTicks(9739), new DateTime(2024, 12, 28, 12, 15, 54, 802, DateTimeKind.Local).AddTicks(9740) });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 28, 12, 15, 54, 802, DateTimeKind.Local).AddTicks(9741), new DateTime(2024, 12, 28, 12, 15, 54, 802, DateTimeKind.Local).AddTicks(9742) });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 28, 12, 15, 54, 802, DateTimeKind.Local).AddTicks(9743), new DateTime(2024, 12, 28, 12, 15, 54, 802, DateTimeKind.Local).AddTicks(9744) });
        }
    }
}
