using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TestProject.Entity.Migrations
{
    /// <inheritdoc />
    public partial class BookDataSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    AuthorName = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    PublishedYear = table.Column<int>(type: "integer", nullable: false),
                    ISBN = table.Column<int>(type: "integer", nullable: false),
                    TotalPages = table.Column<int>(type: "integer", nullable: false),
                    BookImageUrl = table.Column<string>(type: "text", nullable: true),
                    BookStatus = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "now()"),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "now()"),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IssuedBooks",
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

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorName", "BookImageUrl", "BookStatus", "CreatedAt", "ISBN", "IsDeleted", "PublishedYear", "Title", "TotalPages", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Chinua Achebe", "https://unsplash.com/photos/9DaOYUYnOls", 2, new DateTime(2025, 5, 15, 10, 38, 54, 971, DateTimeKind.Local).AddTicks(9505), 0, false, 1958, "Things Fall Apart", 209, new DateTime(2025, 5, 15, 10, 38, 54, 971, DateTimeKind.Local).AddTicks(9507) },
                    { 2, "Hans Christian Andersen", "https://unsplash.com/photos/CXYPfveiuis", 2, new DateTime(2025, 5, 15, 10, 38, 54, 971, DateTimeKind.Local).AddTicks(9509), 0, false, 1836, "Fairy tales", 784, new DateTime(2025, 5, 15, 10, 38, 54, 971, DateTimeKind.Local).AddTicks(9510) }
                });

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

            migrationBuilder.InsertData(
                table: "IssuedBooks",
                columns: new[] { "Id", "BookId", "IsDeleted", "IsIssued", "UserId" },
                values: new object[] { 1, 1, false, true, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_IssuedBooks_BookId",
                table: "IssuedBooks",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_IssuedBooks_UserId",
                table: "IssuedBooks",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IssuedBooks");

            migrationBuilder.DropTable(
                name: "Book");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 14, 15, 50, 18, 659, DateTimeKind.Local).AddTicks(2792), "E2xLjiA8xHMP8lJIXuofAA==:Rj/oJ1ZfkdZJdJH9EIf7Wbo3y3SBNpPnpGQK+ntEGaI=", new DateTime(2025, 5, 14, 15, 50, 18, 659, DateTimeKind.Local).AddTicks(2804) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 14, 15, 50, 18, 735, DateTimeKind.Local).AddTicks(4137), "lNb4kGSHCuzR++cSO/2IHQ==:J1EuK5A/lrmAgxJGbXl3SobqSYqP6cQp2yhfrxwKnUg=", new DateTime(2025, 5, 14, 15, 50, 18, 735, DateTimeKind.Local).AddTicks(4153) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 14, 15, 50, 18, 810, DateTimeKind.Local).AddTicks(7164), "eDjbKcTBMLS2QCTIB0/wcw==:0LtET7k4vuTPiS10aEQI2Prew75tGn7X707mhc4qaMs=", new DateTime(2025, 5, 14, 15, 50, 18, 810, DateTimeKind.Local).AddTicks(7181) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 14, 15, 50, 18, 887, DateTimeKind.Local).AddTicks(6428), "S5QAq+XTbHElgNh2yOu/gQ==:lohzjdYisHDIeNcz+QsD5OWplk2i7G9i6SsleDLO+gA=", new DateTime(2025, 5, 14, 15, 50, 18, 887, DateTimeKind.Local).AddTicks(6443) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 14, 15, 50, 18, 966, DateTimeKind.Local).AddTicks(3889), "Qeh+Bq156b6eglXKzfT3/A==:ORGZFQrSbUwIZP4kKaavZHBC+whdda1lkAvk8MEy6Zk=", new DateTime(2025, 5, 14, 15, 50, 18, 966, DateTimeKind.Local).AddTicks(3904) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 14, 15, 50, 19, 42, DateTimeKind.Local).AddTicks(9033), "mS3iLYlCzmFLDmeum2+1ZQ==:QGB+FISj8KX2HyzczUgi5OcVBjo32xal2mR/PhGQpC0=", new DateTime(2025, 5, 14, 15, 50, 19, 42, DateTimeKind.Local).AddTicks(9049) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 14, 15, 50, 19, 117, DateTimeKind.Local).AddTicks(7379), "g+mZNXmu/6hCr2NacwlHfA==:nW8mqxldBS3V0uOMLYBL2amBVxZiEMCtKjhUm6ue3Ws=", new DateTime(2025, 5, 14, 15, 50, 19, 117, DateTimeKind.Local).AddTicks(7506) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 14, 15, 50, 19, 192, DateTimeKind.Local).AddTicks(6586), "PUmIE+UJxjHX5/Or6WAcew==:qL5o9Z/KX2eqH9t77mvKFSos9embtdexJvo4U0DQOfI=", new DateTime(2025, 5, 14, 15, 50, 19, 192, DateTimeKind.Local).AddTicks(6592) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 14, 15, 50, 19, 267, DateTimeKind.Local).AddTicks(6376), "qRbH+ZJ+JW5I4de9WvkwTg==:N4YXPk63cIYvgna6jIyIUUw+ICpAJRGL8yqMDg4V5dA=", new DateTime(2025, 5, 14, 15, 50, 19, 267, DateTimeKind.Local).AddTicks(6380) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 14, 15, 50, 19, 342, DateTimeKind.Local).AddTicks(2060), "empYNB1T6qz/o9hJwuJRUQ==:Ldp2wKHtVorbhg3epFlK8OwkYTdu+V88tT0SezliwDk=", new DateTime(2025, 5, 14, 15, 50, 19, 342, DateTimeKind.Local).AddTicks(2064) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 14, 15, 50, 19, 416, DateTimeKind.Local).AddTicks(7526), "e0EKMU0JjP70StoKHCHglw==:oHE1e0BgLY5ZyjSxoRyDxt5aNL3nWaaNIALBKlcXyrQ=", new DateTime(2025, 5, 14, 15, 50, 19, 416, DateTimeKind.Local).AddTicks(7527) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 14, 15, 50, 19, 492, DateTimeKind.Local).AddTicks(5707), "BOQER9jSKEF1jsQg1B3FWA==:XxlB5Dv+rLH3t6EoVrNGm2WBwWKk3F1cU0J4jAtN8UY=", new DateTime(2025, 5, 14, 15, 50, 19, 492, DateTimeKind.Local).AddTicks(5715) });
        }
    }
}
