using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Land_Property.API.Migrations
{
    /// <inheritdoc />
    public partial class AddEntitySlug : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Code",
                table: "PropertyTypes",
                newName: "Slug");

            migrationBuilder.RenameIndex(
                name: "IX_PropertyTypes_Code",
                table: "PropertyTypes",
                newName: "IX_PropertyTypes_Slug");

            migrationBuilder.RenameColumn(
                name: "Code",
                table: "AdvertisementTypes",
                newName: "Slug");

            migrationBuilder.RenameIndex(
                name: "IX_AdvertisementTypes_Code",
                table: "AdvertisementTypes",
                newName: "IX_AdvertisementTypes_Slug");

            migrationBuilder.AddColumn<string>(
                name: "Slug",
                table: "Properties",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                defaultValue: "");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Slug",
                table: "Properties");

            migrationBuilder.RenameColumn(
                name: "Slug",
                table: "PropertyTypes",
                newName: "Code");

            migrationBuilder.RenameIndex(
                name: "IX_PropertyTypes_Slug",
                table: "PropertyTypes",
                newName: "IX_PropertyTypes_Code");

            migrationBuilder.RenameColumn(
                name: "Slug",
                table: "AdvertisementTypes",
                newName: "Code");

            migrationBuilder.RenameIndex(
                name: "IX_AdvertisementTypes_Slug",
                table: "AdvertisementTypes",
                newName: "IX_AdvertisementTypes_Code");

            migrationBuilder.UpdateData(
                table: "AdvertisementTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 28, 4, 1, 18, 205, DateTimeKind.Local).AddTicks(3541), new DateTime(2024, 12, 28, 4, 1, 18, 205, DateTimeKind.Local).AddTicks(3766) });

            migrationBuilder.UpdateData(
                table: "AdvertisementTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 28, 4, 1, 18, 205, DateTimeKind.Local).AddTicks(4326), new DateTime(2024, 12, 28, 4, 1, 18, 205, DateTimeKind.Local).AddTicks(4328) });

            migrationBuilder.UpdateData(
                table: "AdvertisementTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 28, 4, 1, 18, 205, DateTimeKind.Local).AddTicks(4329), new DateTime(2024, 12, 28, 4, 1, 18, 205, DateTimeKind.Local).AddTicks(4330) });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 28, 4, 1, 18, 203, DateTimeKind.Local).AddTicks(6580), new DateTime(2024, 12, 28, 4, 1, 18, 204, DateTimeKind.Local).AddTicks(7059) });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 28, 4, 1, 18, 204, DateTimeKind.Local).AddTicks(7705), new DateTime(2024, 12, 28, 4, 1, 18, 204, DateTimeKind.Local).AddTicks(7707) });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 28, 4, 1, 18, 204, DateTimeKind.Local).AddTicks(7708), new DateTime(2024, 12, 28, 4, 1, 18, 204, DateTimeKind.Local).AddTicks(7708) });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 28, 4, 1, 18, 204, DateTimeKind.Local).AddTicks(7709), new DateTime(2024, 12, 28, 4, 1, 18, 204, DateTimeKind.Local).AddTicks(7710) });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 28, 4, 1, 18, 204, DateTimeKind.Local).AddTicks(7711), new DateTime(2024, 12, 28, 4, 1, 18, 204, DateTimeKind.Local).AddTicks(7711) });
        }
    }
}
