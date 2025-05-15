using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestProject.Entity.Migrations
{
    /// <inheritdoc />
    public partial class HashPassword : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 14, 12, 4, 31, 811, DateTimeKind.Local).AddTicks(2628), "123456", new DateTime(2025, 5, 14, 12, 4, 31, 811, DateTimeKind.Local).AddTicks(2639) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 14, 12, 4, 31, 811, DateTimeKind.Local).AddTicks(2641), "123456", new DateTime(2025, 5, 14, 12, 4, 31, 811, DateTimeKind.Local).AddTicks(2641) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 14, 12, 4, 31, 811, DateTimeKind.Local).AddTicks(2643), "123456", new DateTime(2025, 5, 14, 12, 4, 31, 811, DateTimeKind.Local).AddTicks(2643) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 14, 12, 4, 31, 811, DateTimeKind.Local).AddTicks(2644), "123456", new DateTime(2025, 5, 14, 12, 4, 31, 811, DateTimeKind.Local).AddTicks(2645) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 14, 12, 4, 31, 811, DateTimeKind.Local).AddTicks(2646), "123456", new DateTime(2025, 5, 14, 12, 4, 31, 811, DateTimeKind.Local).AddTicks(2647) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 14, 12, 4, 31, 811, DateTimeKind.Local).AddTicks(2648), "123456", new DateTime(2025, 5, 14, 12, 4, 31, 811, DateTimeKind.Local).AddTicks(2649) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 14, 12, 4, 31, 811, DateTimeKind.Local).AddTicks(2650), "123456", new DateTime(2025, 5, 14, 12, 4, 31, 811, DateTimeKind.Local).AddTicks(2651) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 14, 12, 4, 31, 811, DateTimeKind.Local).AddTicks(2652), "123456", new DateTime(2025, 5, 14, 12, 4, 31, 811, DateTimeKind.Local).AddTicks(2652) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 14, 12, 4, 31, 811, DateTimeKind.Local).AddTicks(2654), "123456", new DateTime(2025, 5, 14, 12, 4, 31, 811, DateTimeKind.Local).AddTicks(2654) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 14, 12, 4, 31, 811, DateTimeKind.Local).AddTicks(2656), "123456", new DateTime(2025, 5, 14, 12, 4, 31, 811, DateTimeKind.Local).AddTicks(2656) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 14, 12, 4, 31, 811, DateTimeKind.Local).AddTicks(2657), "123456", new DateTime(2025, 5, 14, 12, 4, 31, 811, DateTimeKind.Local).AddTicks(2658) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 14, 12, 4, 31, 811, DateTimeKind.Local).AddTicks(2659), "123456", new DateTime(2025, 5, 14, 12, 4, 31, 811, DateTimeKind.Local).AddTicks(2660) });
        }
    }
}
