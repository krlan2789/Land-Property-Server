using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Land_Property.API.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEntityRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AdvertisementTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 28, 19, 5, 4, 335, DateTimeKind.Local).AddTicks(7410), new DateTime(2024, 12, 28, 19, 5, 4, 335, DateTimeKind.Local).AddTicks(7632) });

            migrationBuilder.UpdateData(
                table: "AdvertisementTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 28, 19, 5, 4, 335, DateTimeKind.Local).AddTicks(8160), new DateTime(2024, 12, 28, 19, 5, 4, 335, DateTimeKind.Local).AddTicks(8161) });

            migrationBuilder.UpdateData(
                table: "AdvertisementTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 28, 19, 5, 4, 335, DateTimeKind.Local).AddTicks(8162), new DateTime(2024, 12, 28, 19, 5, 4, 335, DateTimeKind.Local).AddTicks(8163) });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 28, 19, 5, 4, 333, DateTimeKind.Local).AddTicks(8052), new DateTime(2024, 12, 28, 19, 5, 4, 334, DateTimeKind.Local).AddTicks(9048) });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 28, 19, 5, 4, 334, DateTimeKind.Local).AddTicks(9692), new DateTime(2024, 12, 28, 19, 5, 4, 334, DateTimeKind.Local).AddTicks(9693) });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 28, 19, 5, 4, 334, DateTimeKind.Local).AddTicks(9696), new DateTime(2024, 12, 28, 19, 5, 4, 334, DateTimeKind.Local).AddTicks(9696) });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 28, 19, 5, 4, 334, DateTimeKind.Local).AddTicks(9698), new DateTime(2024, 12, 28, 19, 5, 4, 334, DateTimeKind.Local).AddTicks(9698) });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 28, 19, 5, 4, 334, DateTimeKind.Local).AddTicks(9699), new DateTime(2024, 12, 28, 19, 5, 4, 334, DateTimeKind.Local).AddTicks(9700) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
