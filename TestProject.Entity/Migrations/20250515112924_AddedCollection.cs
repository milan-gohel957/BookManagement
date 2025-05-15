using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestProject.Entity.Migrations
{
    /// <inheritdoc />
    public partial class AddedCollection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BookUser",
                columns: table => new
                {
                    IssuedBooksId = table.Column<int>(type: "integer", nullable: false),
                    UsersIssuedId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookUser", x => new { x.IssuedBooksId, x.UsersIssuedId });
                    table.ForeignKey(
                        name: "FK_BookUser_Book_IssuedBooksId",
                        column: x => x.IssuedBooksId,
                        principalTable: "Book",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookUser_Users_UsersIssuedId",
                        column: x => x.UsersIssuedId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 16, 59, 24, 339, DateTimeKind.Local).AddTicks(5724), new DateTime(2025, 5, 15, 16, 59, 24, 339, DateTimeKind.Local).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 16, 59, 24, 339, DateTimeKind.Local).AddTicks(5728), new DateTime(2025, 5, 15, 16, 59, 24, 339, DateTimeKind.Local).AddTicks(5728) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 16, 59, 23, 501, DateTimeKind.Local).AddTicks(5735), "+QD80/+XpA98Pqy5b4TtCw==:HBTg67eylv41LO9zqnB8gpUzrqOluNQ7L3GvmFof7+s=", new DateTime(2025, 5, 15, 16, 59, 23, 501, DateTimeKind.Local).AddTicks(5746) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 16, 59, 23, 576, DateTimeKind.Local).AddTicks(1090), "4TxxwZPPZ/9fQt1FZHVzaQ==:HJ0A5g8Izv3Irr9bgIFyjx7Lo6jpSAcjo39s04cSxlU=", new DateTime(2025, 5, 15, 16, 59, 23, 576, DateTimeKind.Local).AddTicks(1095) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 16, 59, 23, 654, DateTimeKind.Local).AddTicks(227), "b34ACUvUVRBVl2QnUYHOXQ==:ZHP3a+9mWLMYe3oFXw+bJVwkoKxKp6F2S7/BGSbtJE4=", new DateTime(2025, 5, 15, 16, 59, 23, 654, DateTimeKind.Local).AddTicks(241) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 16, 59, 23, 732, DateTimeKind.Local).AddTicks(5355), "Zo540Prgc8L5QuzMO2OpPw==:R29xr7oFVGsg/vaPcJBTysGXD5Qs2XX/KanrKfT84+I=", new DateTime(2025, 5, 15, 16, 59, 23, 732, DateTimeKind.Local).AddTicks(5370) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 16, 59, 23, 810, DateTimeKind.Local).AddTicks(4723), "/yIS48s8G2FtyQvUGnTouQ==:ZzTiWvE59hrKp1oFGHsfZEokxMEEfbsK84Qf82/o3XQ=", new DateTime(2025, 5, 15, 16, 59, 23, 810, DateTimeKind.Local).AddTicks(4748) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 16, 59, 23, 886, DateTimeKind.Local).AddTicks(9151), "EdsGrZ6OJJLg4GxOBssXpg==:GkpwZ2zQpcRT8r+W20L3t9mf5PXAS96dWEAzom27JU4=", new DateTime(2025, 5, 15, 16, 59, 23, 886, DateTimeKind.Local).AddTicks(9157) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 16, 59, 23, 964, DateTimeKind.Local).AddTicks(3909), "Wlk0WLMbqHgOCaKt8qcz4A==:OFcmzFJomXfzb/uDEK2GWb/vU/2AGrpBfMQnQ+YnEm4=", new DateTime(2025, 5, 15, 16, 59, 23, 964, DateTimeKind.Local).AddTicks(3922) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 16, 59, 24, 40, DateTimeKind.Local).AddTicks(6287), "rEdPsRizOM9wUkUFeEuEhA==:dH7EeZgUGPQcIEucfcmImJBP/H5wTo5zkThYj3qbTPA=", new DateTime(2025, 5, 15, 16, 59, 24, 40, DateTimeKind.Local).AddTicks(6292) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 16, 59, 24, 115, DateTimeKind.Local).AddTicks(742), "n2vxtz98sE+3q6sf3Btdqw==:/eXBxaqA0O8wROCckm7ymVRlL/CmgdrxU2fETVqA0n4=", new DateTime(2025, 5, 15, 16, 59, 24, 115, DateTimeKind.Local).AddTicks(744) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 16, 59, 24, 189, DateTimeKind.Local).AddTicks(5670), "9lfFbXiFuBYZRq0De4bBTQ==:9YTuUCh9pXrTkwnCDW+mC8BVkyWVP+lT6kRzy2vtbSU=", new DateTime(2025, 5, 15, 16, 59, 24, 189, DateTimeKind.Local).AddTicks(5671) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 16, 59, 24, 265, DateTimeKind.Local).AddTicks(253), "vVIsQe+GeEdha7k4bT8CcQ==:/YQKuJ7xljURsRlWlDziU9aLkFNsjUvgBn5+vt5Dt1k=", new DateTime(2025, 5, 15, 16, 59, 24, 265, DateTimeKind.Local).AddTicks(257) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 16, 59, 24, 339, DateTimeKind.Local).AddTicks(4929), "o1OxeRt7AYN/QgEBHyafyg==:8a2rEm2tPyEeNGm4k1ADZNubjBlUkGbFQ5JKmN3+WiU=", new DateTime(2025, 5, 15, 16, 59, 24, 339, DateTimeKind.Local).AddTicks(4929) });

            migrationBuilder.CreateIndex(
                name: "IX_BookUser_UsersIssuedId",
                table: "BookUser",
                column: "UsersIssuedId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookUser");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 12, 52, 41, 823, DateTimeKind.Local).AddTicks(7551), new DateTime(2025, 5, 15, 12, 52, 41, 823, DateTimeKind.Local).AddTicks(7552) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 12, 52, 41, 823, DateTimeKind.Local).AddTicks(7555), new DateTime(2025, 5, 15, 12, 52, 41, 823, DateTimeKind.Local).AddTicks(7555) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 12, 52, 40, 961, DateTimeKind.Local).AddTicks(4388), "mY4cq1krtDoYWHr5/W9Ozg==:cypTNgfQ2ojfIaDyo1D15f5Td/MDgJi7KRxKxqPUT3c=", new DateTime(2025, 5, 15, 12, 52, 40, 961, DateTimeKind.Local).AddTicks(4403) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 12, 52, 41, 36, DateTimeKind.Local).AddTicks(6061), "oECAUMH8DrUjt67G/riI3A==:6/NyTlQjsuzDA/j7gTwpsZw2/D9Bqnxxp9tZ6EzX7tQ=", new DateTime(2025, 5, 15, 12, 52, 41, 36, DateTimeKind.Local).AddTicks(6071) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 12, 52, 41, 111, DateTimeKind.Local).AddTicks(6613), "n1VKuLhOoclL3Lr8YWl8kQ==:yYgW0Bvoil0WkABldaBTLVXXb9Rd23qhOD7ouiiYj3I=", new DateTime(2025, 5, 15, 12, 52, 41, 111, DateTimeKind.Local).AddTicks(6625) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 12, 52, 41, 187, DateTimeKind.Local).AddTicks(6934), "UQoW3T/SYDBtdNzhgYMn1w==:s0DQlbW5PXp9hyKy34yTNIyN0QRbtbTfkM0L6GmH/Q4=", new DateTime(2025, 5, 15, 12, 52, 41, 187, DateTimeKind.Local).AddTicks(6958) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 12, 52, 41, 264, DateTimeKind.Local).AddTicks(1330), "80UrdUq7pV8Z1H8cpN5Gcg==:LEt48k8TBVpwwF7cmrxW9TVvS3ijetWimKGtImtX2Aw=", new DateTime(2025, 5, 15, 12, 52, 41, 264, DateTimeKind.Local).AddTicks(1341) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 12, 52, 41, 339, DateTimeKind.Local).AddTicks(7596), "+lJw1U4PgFNnN9Z1TRN4Dw==:5Cl+6rhtqmLpPvyUdCWUYoSHp1h9Q8TkhZHMzfLthGI=", new DateTime(2025, 5, 15, 12, 52, 41, 339, DateTimeKind.Local).AddTicks(7607) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 12, 52, 41, 418, DateTimeKind.Local).AddTicks(61), "cRDkszhIl8PAdf/1HwhFFQ==:9p0AaOYpwkWrNsfuZCdfvXJYoi/6aXcvIH6YzMhRUTc=", new DateTime(2025, 5, 15, 12, 52, 41, 418, DateTimeKind.Local).AddTicks(83) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 12, 52, 41, 512, DateTimeKind.Local).AddTicks(809), "5A2fYUxDPxbZUA+GiYky7w==:wXGm3UQ3Wt3K58PGA6/47EPv0vtakbiHj/ASYlNJ6/A=", new DateTime(2025, 5, 15, 12, 52, 41, 512, DateTimeKind.Local).AddTicks(817) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 12, 52, 41, 594, DateTimeKind.Local).AddTicks(1078), "mHt7JFuEnTo46pYo1NZe3g==:05EN9lPqrzxxScueW7syE6qOftRQ5H/eTEKtM35TRYI=", new DateTime(2025, 5, 15, 12, 52, 41, 594, DateTimeKind.Local).AddTicks(1084) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 12, 52, 41, 669, DateTimeKind.Local).AddTicks(3370), "tdNp7vphsAgqI5TafjPUyw==:Cu+aVVWH1v+2Nkz4LzJIqDzNDHSFfpAxRlxSBeGQqZs=", new DateTime(2025, 5, 15, 12, 52, 41, 669, DateTimeKind.Local).AddTicks(3378) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 12, 52, 41, 745, DateTimeKind.Local).AddTicks(4368), "sO2cRhtlsfMLD5dxuraf1w==:HRPZVa7Fxh/G4zc2EQR9Sh/dqKqs7UcnDNe5S9V6msg=", new DateTime(2025, 5, 15, 12, 52, 41, 745, DateTimeKind.Local).AddTicks(4375) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 12, 52, 41, 823, DateTimeKind.Local).AddTicks(6700), "Bz+gjQS8t2nYv5F4nCupfQ==:Qh2c9q46xHUvJ7P/PPZWaW4zfFJtG9ENb7vN4Tgc4JY=", new DateTime(2025, 5, 15, 12, 52, 41, 823, DateTimeKind.Local).AddTicks(6708) });
        }
    }
}
