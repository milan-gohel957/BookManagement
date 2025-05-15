using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestProject.Entity.Migrations
{
    /// <inheritdoc />
    public partial class SoftDelete : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Users",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IsDeleted", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 14, 12, 4, 31, 811, DateTimeKind.Local).AddTicks(2628), false, new DateTime(2025, 5, 14, 12, 4, 31, 811, DateTimeKind.Local).AddTicks(2639) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "IsDeleted", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 14, 12, 4, 31, 811, DateTimeKind.Local).AddTicks(2641), false, new DateTime(2025, 5, 14, 12, 4, 31, 811, DateTimeKind.Local).AddTicks(2641) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "IsDeleted", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 14, 12, 4, 31, 811, DateTimeKind.Local).AddTicks(2643), false, new DateTime(2025, 5, 14, 12, 4, 31, 811, DateTimeKind.Local).AddTicks(2643) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "IsDeleted", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 14, 12, 4, 31, 811, DateTimeKind.Local).AddTicks(2644), false, new DateTime(2025, 5, 14, 12, 4, 31, 811, DateTimeKind.Local).AddTicks(2645) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "IsDeleted", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 14, 12, 4, 31, 811, DateTimeKind.Local).AddTicks(2646), false, new DateTime(2025, 5, 14, 12, 4, 31, 811, DateTimeKind.Local).AddTicks(2647) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "IsDeleted", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 14, 12, 4, 31, 811, DateTimeKind.Local).AddTicks(2648), false, new DateTime(2025, 5, 14, 12, 4, 31, 811, DateTimeKind.Local).AddTicks(2649) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "IsDeleted", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 14, 12, 4, 31, 811, DateTimeKind.Local).AddTicks(2650), false, new DateTime(2025, 5, 14, 12, 4, 31, 811, DateTimeKind.Local).AddTicks(2651) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "IsDeleted", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 14, 12, 4, 31, 811, DateTimeKind.Local).AddTicks(2652), false, new DateTime(2025, 5, 14, 12, 4, 31, 811, DateTimeKind.Local).AddTicks(2652) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "IsDeleted", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 14, 12, 4, 31, 811, DateTimeKind.Local).AddTicks(2654), false, new DateTime(2025, 5, 14, 12, 4, 31, 811, DateTimeKind.Local).AddTicks(2654) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "IsDeleted", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 14, 12, 4, 31, 811, DateTimeKind.Local).AddTicks(2656), false, new DateTime(2025, 5, 14, 12, 4, 31, 811, DateTimeKind.Local).AddTicks(2656) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "IsDeleted", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 14, 12, 4, 31, 811, DateTimeKind.Local).AddTicks(2657), false, new DateTime(2025, 5, 14, 12, 4, 31, 811, DateTimeKind.Local).AddTicks(2658) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "IsDeleted", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 14, 12, 4, 31, 811, DateTimeKind.Local).AddTicks(2659), false, new DateTime(2025, 5, 14, 12, 4, 31, 811, DateTimeKind.Local).AddTicks(2660) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 14, 11, 54, 18, 116, DateTimeKind.Local).AddTicks(3251), new DateTime(2025, 5, 14, 11, 54, 18, 116, DateTimeKind.Local).AddTicks(3265) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 14, 11, 54, 18, 116, DateTimeKind.Local).AddTicks(3267), new DateTime(2025, 5, 14, 11, 54, 18, 116, DateTimeKind.Local).AddTicks(3268) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 14, 11, 54, 18, 116, DateTimeKind.Local).AddTicks(3269), new DateTime(2025, 5, 14, 11, 54, 18, 116, DateTimeKind.Local).AddTicks(3270) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 14, 11, 54, 18, 116, DateTimeKind.Local).AddTicks(3271), new DateTime(2025, 5, 14, 11, 54, 18, 116, DateTimeKind.Local).AddTicks(3272) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 14, 11, 54, 18, 116, DateTimeKind.Local).AddTicks(3273), new DateTime(2025, 5, 14, 11, 54, 18, 116, DateTimeKind.Local).AddTicks(3274) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 14, 11, 54, 18, 116, DateTimeKind.Local).AddTicks(3275), new DateTime(2025, 5, 14, 11, 54, 18, 116, DateTimeKind.Local).AddTicks(3276) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 14, 11, 54, 18, 116, DateTimeKind.Local).AddTicks(3277), new DateTime(2025, 5, 14, 11, 54, 18, 116, DateTimeKind.Local).AddTicks(3278) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 14, 11, 54, 18, 116, DateTimeKind.Local).AddTicks(3280), new DateTime(2025, 5, 14, 11, 54, 18, 116, DateTimeKind.Local).AddTicks(3280) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 14, 11, 54, 18, 116, DateTimeKind.Local).AddTicks(3282), new DateTime(2025, 5, 14, 11, 54, 18, 116, DateTimeKind.Local).AddTicks(3283) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 14, 11, 54, 18, 116, DateTimeKind.Local).AddTicks(3284), new DateTime(2025, 5, 14, 11, 54, 18, 116, DateTimeKind.Local).AddTicks(3285) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 14, 11, 54, 18, 116, DateTimeKind.Local).AddTicks(3286), new DateTime(2025, 5, 14, 11, 54, 18, 116, DateTimeKind.Local).AddTicks(3287) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 14, 11, 54, 18, 116, DateTimeKind.Local).AddTicks(3289), new DateTime(2025, 5, 14, 11, 54, 18, 116, DateTimeKind.Local).AddTicks(3289) });
        }
    }
}
