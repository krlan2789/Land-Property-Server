using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Land_Property.API.Migrations
{
    /// <inheritdoc />
    public partial class AddEntityRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "BuildingArea",
                table: "Properties",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.UpdateData(
                table: "AdvertisementTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 28, 18, 39, 1, 547, DateTimeKind.Local).AddTicks(7702), new DateTime(2024, 12, 28, 18, 39, 1, 547, DateTimeKind.Local).AddTicks(7932) });

            migrationBuilder.UpdateData(
                table: "AdvertisementTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 28, 18, 39, 1, 547, DateTimeKind.Local).AddTicks(8500), new DateTime(2024, 12, 28, 18, 39, 1, 547, DateTimeKind.Local).AddTicks(8501) });

            migrationBuilder.UpdateData(
                table: "AdvertisementTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 28, 18, 39, 1, 547, DateTimeKind.Local).AddTicks(8503), new DateTime(2024, 12, 28, 18, 39, 1, 547, DateTimeKind.Local).AddTicks(8503) });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 28, 18, 39, 1, 545, DateTimeKind.Local).AddTicks(7974), new DateTime(2024, 12, 28, 18, 39, 1, 546, DateTimeKind.Local).AddTicks(9610) });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 28, 18, 39, 1, 547, DateTimeKind.Local).AddTicks(279), new DateTime(2024, 12, 28, 18, 39, 1, 547, DateTimeKind.Local).AddTicks(281) });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 28, 18, 39, 1, 547, DateTimeKind.Local).AddTicks(282), new DateTime(2024, 12, 28, 18, 39, 1, 547, DateTimeKind.Local).AddTicks(282) });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 28, 18, 39, 1, 547, DateTimeKind.Local).AddTicks(283), new DateTime(2024, 12, 28, 18, 39, 1, 547, DateTimeKind.Local).AddTicks(284) });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 28, 18, 39, 1, 547, DateTimeKind.Local).AddTicks(285), new DateTime(2024, 12, 28, 18, 39, 1, 547, DateTimeKind.Local).AddTicks(285) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "BuildingArea",
                table: "Properties",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

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
        }
    }
}
