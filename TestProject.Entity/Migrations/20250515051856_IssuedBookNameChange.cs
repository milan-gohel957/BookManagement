using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace TestProject.Entity.Migrations
{
    /// <inheritdoc />
    public partial class IssuedBookNameChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IssuedBooks");

            migrationBuilder.CreateTable(
                name: "IssuedBook",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    BookId = table.Column<int>(type: "integer", nullable: false),
                    IsIssued = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "now()"),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "now()"),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IssuedBook", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IssuedBook_Book_BookId",
                        column: x => x.BookId,
                        principalTable: "Book",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IssuedBook_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 10, 48, 56, 607, DateTimeKind.Local).AddTicks(4065), new DateTime(2025, 5, 15, 10, 48, 56, 607, DateTimeKind.Local).AddTicks(4066) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 10, 48, 56, 607, DateTimeKind.Local).AddTicks(4069), new DateTime(2025, 5, 15, 10, 48, 56, 607, DateTimeKind.Local).AddTicks(4070) });

            migrationBuilder.InsertData(
                table: "IssuedBook",
                columns: new[] { "Id", "BookId", "IsDeleted", "IsIssued", "UserId" },
                values: new object[] { 1, 1, false, true, 1 });

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

            migrationBuilder.CreateIndex(
                name: "IX_IssuedBook_BookId",
                table: "IssuedBook",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_IssuedBook_UserId",
                table: "IssuedBook",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IssuedBook");

            migrationBuilder.CreateTable(
                name: "IssuedBooks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BookId = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "now()"),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    IsIssued = table.Column<bool>(type: "boolean", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "now()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IssuedBooks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IssuedBooks_Book_BookId",
                        column: x => x.BookId,
                        principalTable: "Book",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IssuedBooks_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 10, 42, 36, 867, DateTimeKind.Local).AddTicks(981), new DateTime(2025, 5, 15, 10, 42, 36, 867, DateTimeKind.Local).AddTicks(982) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 10, 42, 36, 867, DateTimeKind.Local).AddTicks(984), new DateTime(2025, 5, 15, 10, 42, 36, 867, DateTimeKind.Local).AddTicks(985) });

            migrationBuilder.InsertData(
                table: "IssuedBooks",
                columns: new[] { "Id", "BookId", "IsDeleted", "IsIssued", "UserId" },
                values: new object[] { 1, 1, false, true, 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 10, 42, 36, 36, DateTimeKind.Local).AddTicks(3806), "hcJENWKaOt72FhuIwx895w==:4E96m/k19i03Re88mTzQCep+FWsT7IgBKivBxnZpv/E=", new DateTime(2025, 5, 15, 10, 42, 36, 36, DateTimeKind.Local).AddTicks(3825) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 10, 42, 36, 111, DateTimeKind.Local).AddTicks(5990), "dtiKYpDaBJgYK0eUsiq85Q==:s18u3cHTX+sF+qz+vj+gfvYEOiCVkWtPDpFtllpjhzg=", new DateTime(2025, 5, 15, 10, 42, 36, 111, DateTimeKind.Local).AddTicks(5998) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 10, 42, 36, 187, DateTimeKind.Local).AddTicks(9994), "tYIgOplqfVcU5OS3i1ql8A==:ibDCALYyfB3pmJKnrHDoP8spSMRtGuAzp5qB8lLAaDk=", new DateTime(2025, 5, 15, 10, 42, 36, 188, DateTimeKind.Local).AddTicks(14) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 10, 42, 36, 263, DateTimeKind.Local).AddTicks(7705), "T0CufuQNNdsSF78viectzw==:8hFiTAos4GDq90sriV+R4Pw4hGxdEM6U4ia/JFggLd4=", new DateTime(2025, 5, 15, 10, 42, 36, 263, DateTimeKind.Local).AddTicks(7722) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 10, 42, 36, 339, DateTimeKind.Local).AddTicks(9536), "tQRjzOSupjwKGsj6qSivAg==:6tIuhDn6q81Y2LJXB2J1b6baeggF2RHO5PzPgt9Dg/w=", new DateTime(2025, 5, 15, 10, 42, 36, 339, DateTimeKind.Local).AddTicks(9558) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 10, 42, 36, 414, DateTimeKind.Local).AddTicks(6230), "hxjWIh67TBw/xwIjnwmCdA==:vlPxNUE5X8bcukVkMZIbND1JFt/VmM7WFAwUnJbg/HM=", new DateTime(2025, 5, 15, 10, 42, 36, 414, DateTimeKind.Local).AddTicks(6238) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 10, 42, 36, 490, DateTimeKind.Local).AddTicks(7418), "so/zj96gHUSMvkOhTqsKlg==:NUkMk7fFCY7ivdTL7UQlbjqKU14IWKYQo6OsoZUCz+M=", new DateTime(2025, 5, 15, 10, 42, 36, 490, DateTimeKind.Local).AddTicks(7431) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 10, 42, 36, 567, DateTimeKind.Local).AddTicks(7865), "X2iJYTMTD1SY56zfaxIg0A==:FzR+Nr9bVpdyBPqOEPSjT0+/VdUAHsc3kOPb1uTSysQ=", new DateTime(2025, 5, 15, 10, 42, 36, 567, DateTimeKind.Local).AddTicks(7871) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 10, 42, 36, 643, DateTimeKind.Local).AddTicks(4831), "q3H2S/sk6nJQQcR+vql48w==:ScDXookvwPwngmkuqhDdnOYNKFDTjLcBXr3unIhZQvs=", new DateTime(2025, 5, 15, 10, 42, 36, 643, DateTimeKind.Local).AddTicks(4833) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 10, 42, 36, 718, DateTimeKind.Local).AddTicks(924), "b9j3Bk3iLasqpchc/Jrh3Q==:jwrqsXbHXVYl3yRJmAj9ecVXbg2PJZPAQ25h7nQWawg=", new DateTime(2025, 5, 15, 10, 42, 36, 718, DateTimeKind.Local).AddTicks(926) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 10, 42, 36, 792, DateTimeKind.Local).AddTicks(5117), "w5HyFx+yjtwqO5UkrbMJeg==:oGuXLnDqU6qDyHmke/YMjsmvP8DZ/heIilW/GcMBJZU=", new DateTime(2025, 5, 15, 10, 42, 36, 792, DateTimeKind.Local).AddTicks(5118) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 10, 42, 36, 867, DateTimeKind.Local).AddTicks(38), "FjhbhEWSs04LSq7YJbgJLQ==:clS+ozzqsJwSks6aaelNOfuQCtQ86s5ZVm48UjEr79w=", new DateTime(2025, 5, 15, 10, 42, 36, 867, DateTimeKind.Local).AddTicks(39) });

            migrationBuilder.CreateIndex(
                name: "IX_IssuedBooks_BookId",
                table: "IssuedBooks",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_IssuedBooks_UserId",
                table: "IssuedBooks",
                column: "UserId");
        }
    }
}
