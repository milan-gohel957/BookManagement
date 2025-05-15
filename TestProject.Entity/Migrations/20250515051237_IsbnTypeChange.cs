using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestProject.Entity.Migrations
{
    /// <inheritdoc />
    public partial class IsbnTypeChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ISBN",
                table: "Book",
                type: "text",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ISBN", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 10, 42, 36, 867, DateTimeKind.Local).AddTicks(981), "7624133121", new DateTime(2025, 5, 15, 10, 42, 36, 867, DateTimeKind.Local).AddTicks(982) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ISBN", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 10, 42, 36, 867, DateTimeKind.Local).AddTicks(984), "9153676823", new DateTime(2025, 5, 15, 10, 42, 36, 867, DateTimeKind.Local).AddTicks(985) });

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ISBN",
                table: "Book",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ISBN", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 10, 38, 54, 971, DateTimeKind.Local).AddTicks(9505), 0, new DateTime(2025, 5, 15, 10, 38, 54, 971, DateTimeKind.Local).AddTicks(9507) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ISBN", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 10, 38, 54, 971, DateTimeKind.Local).AddTicks(9509), 0, new DateTime(2025, 5, 15, 10, 38, 54, 971, DateTimeKind.Local).AddTicks(9510) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 10, 38, 54, 105, DateTimeKind.Local).AddTicks(8675), "2JZlAqbEyVjFKneoDyvpXQ==:MYCWImMz5WG/0NYJ4z53NfwGC96unQRoodm2RDtsEFk=", new DateTime(2025, 5, 15, 10, 38, 54, 105, DateTimeKind.Local).AddTicks(8689) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 10, 38, 54, 180, DateTimeKind.Local).AddTicks(5078), "+RBU4DmhGl6l/HcnNIIYJw==:KtqwesrT3XKWGrQMo4yT2TQKYzRb7UF+ZEDKUgY1rXE=", new DateTime(2025, 5, 15, 10, 38, 54, 180, DateTimeKind.Local).AddTicks(5089) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 10, 38, 54, 256, DateTimeKind.Local).AddTicks(7295), "6RSZSQFK6tB6llfMf8pCrg==:sUq+c0gd3HBHKEgwAqlz4xhV+UXnd7ofi3CaxNjDtRE=", new DateTime(2025, 5, 15, 10, 38, 54, 256, DateTimeKind.Local).AddTicks(7318) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 10, 38, 54, 334, DateTimeKind.Local).AddTicks(7653), "BhaCsHdKoKI6ooHOIvDipQ==:Xn9yq9HyYyqEy3KBCo4pSut1x/5pef/h+ExEboRMYKc=", new DateTime(2025, 5, 15, 10, 38, 54, 334, DateTimeKind.Local).AddTicks(7667) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 10, 38, 54, 412, DateTimeKind.Local).AddTicks(6117), "2TNuHam+3YUgtoA7nZZk7Q==:C2f3Mfb6vfL9JA1JXQ1sMIHQHCgbEIuVH5TGlduZMXE=", new DateTime(2025, 5, 15, 10, 38, 54, 412, DateTimeKind.Local).AddTicks(6132) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 10, 38, 54, 489, DateTimeKind.Local).AddTicks(7931), "FAZsE9qwk6Q4qbu8qpeoKg==:PFBccGt3SVsXJTxrmf6OnZja4oE5YvKVcKC3AbSOhLs=", new DateTime(2025, 5, 15, 10, 38, 54, 489, DateTimeKind.Local).AddTicks(7943) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 10, 38, 54, 566, DateTimeKind.Local).AddTicks(4178), "RqDHKzmyPoRosfepT0d++A==:QssfS9jNbKelk/OSMar6RJ+c4f90LHXgeOx4Rhqc9Qc=", new DateTime(2025, 5, 15, 10, 38, 54, 566, DateTimeKind.Local).AddTicks(4182) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 10, 38, 54, 655, DateTimeKind.Local).AddTicks(9526), "DmU7OQmjKZbx30ZQPN6Hhg==:aHjirvGsjYnpE4mUTvdVhSUwKKDjizzmAazUhrN+F3g=", new DateTime(2025, 5, 15, 10, 38, 54, 655, DateTimeKind.Local).AddTicks(9533) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 10, 38, 54, 742, DateTimeKind.Local).AddTicks(8618), "m4/KsgOwx4rWRJiSfu4fGg==:U0i8oktEFOxWU3nmwzKNV42m/s4+KvUBOJPbawHvbQg=", new DateTime(2025, 5, 15, 10, 38, 54, 742, DateTimeKind.Local).AddTicks(8624) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 10, 38, 54, 817, DateTimeKind.Local).AddTicks(7070), "r6t6byjPGw9RpHbeBngASw==:XqRXzTb3kagYneHdV8yALNm+WdkJCPHuI0WVOCXkZ/A=", new DateTime(2025, 5, 15, 10, 38, 54, 817, DateTimeKind.Local).AddTicks(7074) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 10, 38, 54, 895, DateTimeKind.Local).AddTicks(9341), "bVU6nAY0KcqL+dFNJeC1YA==:LbjpainoTzhk59jKfGSIQ52yAJOzrYQCIvcfJLAADWY=", new DateTime(2025, 5, 15, 10, 38, 54, 895, DateTimeKind.Local).AddTicks(9350) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 10, 38, 54, 971, DateTimeKind.Local).AddTicks(8546), "pXcF8y2AM9WQhKuM8wrEWA==:hOm2Qk6ZU13XPsoYYbZBQHS/DmxMCPwLcvJpTFasb78=", new DateTime(2025, 5, 15, 10, 38, 54, 971, DateTimeKind.Local).AddTicks(8549) });
        }
    }
}
