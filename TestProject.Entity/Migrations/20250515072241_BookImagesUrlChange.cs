using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestProject.Entity.Migrations
{
    /// <inheritdoc />
    public partial class BookImagesUrlChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BookImageUrl", "CreatedAt", "UpdatedAt" },
                values: new object[] { "https://images.unsplash.com/photo-1543002588-bfa74002ed7e?q=80&w=1974&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", new DateTime(2025, 5, 15, 12, 52, 41, 823, DateTimeKind.Local).AddTicks(7551), new DateTime(2025, 5, 15, 12, 52, 41, 823, DateTimeKind.Local).AddTicks(7552) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookImageUrl", "CreatedAt", "UpdatedAt" },
                values: new object[] { "https://images.unsplash.com/photo-1544947950-fa07a98d237f?q=80&w=1974&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", new DateTime(2025, 5, 15, 12, 52, 41, 823, DateTimeKind.Local).AddTicks(7555), new DateTime(2025, 5, 15, 12, 52, 41, 823, DateTimeKind.Local).AddTicks(7555) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BookImageUrl", "CreatedAt", "UpdatedAt" },
                values: new object[] { "https://unsplash.com/photos/9DaOYUYnOls", new DateTime(2025, 5, 15, 10, 48, 56, 607, DateTimeKind.Local).AddTicks(4065), new DateTime(2025, 5, 15, 10, 48, 56, 607, DateTimeKind.Local).AddTicks(4066) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookImageUrl", "CreatedAt", "UpdatedAt" },
                values: new object[] { "https://unsplash.com/photos/CXYPfveiuis", new DateTime(2025, 5, 15, 10, 48, 56, 607, DateTimeKind.Local).AddTicks(4069), new DateTime(2025, 5, 15, 10, 48, 56, 607, DateTimeKind.Local).AddTicks(4070) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 10, 48, 55, 743, DateTimeKind.Local).AddTicks(6195), "JvHv48waEmCI2AioWmn4bA==:NVIMc+FFr8ZOgoQHVzH+7ixy7XOtRCDOXjAiIJGx0ec=", new DateTime(2025, 5, 15, 10, 48, 55, 743, DateTimeKind.Local).AddTicks(6211) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 10, 48, 55, 818, DateTimeKind.Local).AddTicks(574), "k/5ugvtwJoBtVFB9+ClTQg==:RzEmVRH2/VlDDh3vEsT9IpRhrc/rbbkAKWSmAtp/e/s=", new DateTime(2025, 5, 15, 10, 48, 55, 818, DateTimeKind.Local).AddTicks(576) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 10, 48, 55, 895, DateTimeKind.Local).AddTicks(336), "MegY/IMEpXMgKCT4SjmzgA==:6/p1aEhWfNcJzwNMeANAutVe+FbwJ+2DiZzIbWeS4ME=", new DateTime(2025, 5, 15, 10, 48, 55, 895, DateTimeKind.Local).AddTicks(355) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 10, 48, 55, 971, DateTimeKind.Local).AddTicks(4577), "KcUmbY8A1KNTBC5OVvasEg==:/YKBnVGyQHld7ITST57yZjittfOIxuO6hkuIFsgZ5iU=", new DateTime(2025, 5, 15, 10, 48, 55, 971, DateTimeKind.Local).AddTicks(4583) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 10, 48, 56, 47, DateTimeKind.Local).AddTicks(8768), "OTiYbtLMps7m65A/1GmMfg==:m2IAdm0G4XkC+qb6bG3jdsf5Bw0FWJkgRHvLjLot5ss=", new DateTime(2025, 5, 15, 10, 48, 56, 47, DateTimeKind.Local).AddTicks(8796) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 10, 48, 56, 123, DateTimeKind.Local).AddTicks(4837), "X1TmcDNMycJQFCaE5FS8oQ==:ST02WEv+jUB3sLZsfE8NJCSKgLiBWWi0DnSSixRPB2E=", new DateTime(2025, 5, 15, 10, 48, 56, 123, DateTimeKind.Local).AddTicks(4853) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 10, 48, 56, 211, DateTimeKind.Local).AddTicks(6290), "Aghhia6ICko6WvO2k0TP7A==:fl/ZIb0UkQVaPo/5JRkAxrQkyCHBg15Ar9wYMTpY9Sw=", new DateTime(2025, 5, 15, 10, 48, 56, 211, DateTimeKind.Local).AddTicks(6303) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 10, 48, 56, 296, DateTimeKind.Local).AddTicks(2617), "VlmPJdeLoUuhsu58VpQrmQ==:9Q8on0q6SpSdNTYZf8kzHpB4v/+v58E9+j5IYymv4i4=", new DateTime(2025, 5, 15, 10, 48, 56, 296, DateTimeKind.Local).AddTicks(2622) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 10, 48, 56, 376, DateTimeKind.Local).AddTicks(2750), "oszIgfh22KCFvGXw14LO+Q==:fyiTmbI0Nd7k9qRQXOsmbcJ/v3mXGOStQ7eVDyqS7ng=", new DateTime(2025, 5, 15, 10, 48, 56, 376, DateTimeKind.Local).AddTicks(2754) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 10, 48, 56, 456, DateTimeKind.Local).AddTicks(7652), "6hIcoO9hSg5dV81ZNOzj8g==:bwLnsDHJXPPC1ajzTi1WWg4OAN+QL+2j9EzM+JWGiJ8=", new DateTime(2025, 5, 15, 10, 48, 56, 456, DateTimeKind.Local).AddTicks(7657) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 10, 48, 56, 532, DateTimeKind.Local).AddTicks(8654), "b1x31SVP27oEkyCEa4bcCg==:3zuRRbPdsgJOqmjzQhtKK+23/rxovVzs+ncQRqd6FdA=", new DateTime(2025, 5, 15, 10, 48, 56, 532, DateTimeKind.Local).AddTicks(8660) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 10, 48, 56, 607, DateTimeKind.Local).AddTicks(3108), "qC+WRyW+XPVaO0TNAZlR3A==:/n5yrxZoGwVUvgUWJTmQZ5YP2CI3fIF2Iv5eFmcHlzY=", new DateTime(2025, 5, 15, 10, 48, 56, 607, DateTimeKind.Local).AddTicks(3110) });
        }
    }
}
