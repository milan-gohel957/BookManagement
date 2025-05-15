using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TestProject.Entity.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "now()"),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "now()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "RoleName" },
                values: new object[,]
                {
                    { 1, "Admin" },
                    { 2, "User" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "Password", "RoleId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 5, 14, 11, 54, 18, 116, DateTimeKind.Local).AddTicks(3251), "user1@email.com", "123456", 2, new DateTime(2025, 5, 14, 11, 54, 18, 116, DateTimeKind.Local).AddTicks(3265) },
                    { 2, new DateTime(2025, 5, 14, 11, 54, 18, 116, DateTimeKind.Local).AddTicks(3267), "user2@email.com", "123456", 2, new DateTime(2025, 5, 14, 11, 54, 18, 116, DateTimeKind.Local).AddTicks(3268) },
                    { 3, new DateTime(2025, 5, 14, 11, 54, 18, 116, DateTimeKind.Local).AddTicks(3269), "user3@email.com", "123456", 2, new DateTime(2025, 5, 14, 11, 54, 18, 116, DateTimeKind.Local).AddTicks(3270) },
                    { 4, new DateTime(2025, 5, 14, 11, 54, 18, 116, DateTimeKind.Local).AddTicks(3271), "user4@email.com", "123456", 2, new DateTime(2025, 5, 14, 11, 54, 18, 116, DateTimeKind.Local).AddTicks(3272) },
                    { 5, new DateTime(2025, 5, 14, 11, 54, 18, 116, DateTimeKind.Local).AddTicks(3273), "user5@email.com", "123456", 2, new DateTime(2025, 5, 14, 11, 54, 18, 116, DateTimeKind.Local).AddTicks(3274) },
                    { 6, new DateTime(2025, 5, 14, 11, 54, 18, 116, DateTimeKind.Local).AddTicks(3275), "user6@email.com", "123456", 2, new DateTime(2025, 5, 14, 11, 54, 18, 116, DateTimeKind.Local).AddTicks(3276) },
                    { 7, new DateTime(2025, 5, 14, 11, 54, 18, 116, DateTimeKind.Local).AddTicks(3277), "user7@email.com", "123456", 2, new DateTime(2025, 5, 14, 11, 54, 18, 116, DateTimeKind.Local).AddTicks(3278) },
                    { 8, new DateTime(2025, 5, 14, 11, 54, 18, 116, DateTimeKind.Local).AddTicks(3280), "user8@email.com", "123456", 2, new DateTime(2025, 5, 14, 11, 54, 18, 116, DateTimeKind.Local).AddTicks(3280) },
                    { 9, new DateTime(2025, 5, 14, 11, 54, 18, 116, DateTimeKind.Local).AddTicks(3282), "user9@email.com", "123456", 2, new DateTime(2025, 5, 14, 11, 54, 18, 116, DateTimeKind.Local).AddTicks(3283) },
                    { 10, new DateTime(2025, 5, 14, 11, 54, 18, 116, DateTimeKind.Local).AddTicks(3284), "user10@email.com", "123456", 2, new DateTime(2025, 5, 14, 11, 54, 18, 116, DateTimeKind.Local).AddTicks(3285) },
                    { 11, new DateTime(2025, 5, 14, 11, 54, 18, 116, DateTimeKind.Local).AddTicks(3286), "user10@email.com", "123456", 2, new DateTime(2025, 5, 14, 11, 54, 18, 116, DateTimeKind.Local).AddTicks(3287) },
                    { 12, new DateTime(2025, 5, 14, 11, 54, 18, 116, DateTimeKind.Local).AddTicks(3289), "admin1@email.com", "123456", 1, new DateTime(2025, 5, 14, 11, 54, 18, 116, DateTimeKind.Local).AddTicks(3289) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
