using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestProject.Entity.Migrations
{
    /// <inheritdoc />
    public partial class ChangeDefaultIsissued : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 17, 36, 49, 342, DateTimeKind.Local).AddTicks(4345), new DateTime(2025, 5, 15, 17, 36, 49, 342, DateTimeKind.Local).AddTicks(4347) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 17, 36, 49, 342, DateTimeKind.Local).AddTicks(4350), new DateTime(2025, 5, 15, 17, 36, 49, 342, DateTimeKind.Local).AddTicks(4351) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 17, 36, 48, 509, DateTimeKind.Local).AddTicks(1906), "LWEPjvu8H8u0KOIeumUnJg==:drm/eUIEMVYTGUmnSwcHExzjOYMCnlN6130jWdDrHnw=", new DateTime(2025, 5, 15, 17, 36, 48, 509, DateTimeKind.Local).AddTicks(1921) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 17, 36, 48, 586, DateTimeKind.Local).AddTicks(1079), "QDeIU/OV1wuvFsw9F69FqQ==:NDaAMCdFqEhlOpXx02nFA6qC+Z9s5lu3IqFyXxHVwGg=", new DateTime(2025, 5, 15, 17, 36, 48, 586, DateTimeKind.Local).AddTicks(1102) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 17, 36, 48, 662, DateTimeKind.Local).AddTicks(3880), "xmyHkTRpQq3DzUn1KgLN7A==:nmlaEZZ1/UTcomluLFR/yoNS+HXxJdD/IUf8Lg2Vvbg=", new DateTime(2025, 5, 15, 17, 36, 48, 662, DateTimeKind.Local).AddTicks(3886) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 17, 36, 48, 737, DateTimeKind.Local).AddTicks(2246), "XdbASLNOZqHvNUQ2MXZjbA==:VTVUzxm63CT6cFK1DCRnbyBjAcEVO3x9dDbmWHUJsD8=", new DateTime(2025, 5, 15, 17, 36, 48, 737, DateTimeKind.Local).AddTicks(2251) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 17, 36, 48, 813, DateTimeKind.Local).AddTicks(5722), "pZBpWCL/CczS3HtSbSa3hQ==:VW/+q8Qd8xBpYADKFFIk7WO7hRbNT45PXX/0MxXGgDQ=", new DateTime(2025, 5, 15, 17, 36, 48, 813, DateTimeKind.Local).AddTicks(5750) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 17, 36, 48, 890, DateTimeKind.Local).AddTicks(1079), "4jknTy5f0nuF8DAY/Bo6EA==:s0/NThlsnlKXZfE1uEzDaZMBDZWicvYX+odSyXAZ188=", new DateTime(2025, 5, 15, 17, 36, 48, 890, DateTimeKind.Local).AddTicks(1095) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 17, 36, 48, 967, DateTimeKind.Local).AddTicks(1507), "sY5lHz/a6Au56BzWasu5NA==:X6i3+uDtwCLYAV7r8+x/1IOQCz4IG535gs53yRH5MdQ=", new DateTime(2025, 5, 15, 17, 36, 48, 967, DateTimeKind.Local).AddTicks(1514) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 17, 36, 49, 43, DateTimeKind.Local).AddTicks(5862), "UhqueVTBexswhcKaxzM8TQ==:NKBCHItXH4aS+VClozL5/Q14v9+i8yNRokrP2qo942M=", new DateTime(2025, 5, 15, 17, 36, 49, 43, DateTimeKind.Local).AddTicks(5867) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 17, 36, 49, 118, DateTimeKind.Local).AddTicks(3830), "G272ledhVN6/ueXu6SP6/A==:zg1VMjXugBim/Eb/HlRHK5V3G+iZJSBvOYHBMFEXiUw=", new DateTime(2025, 5, 15, 17, 36, 49, 118, DateTimeKind.Local).AddTicks(3832) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 17, 36, 49, 193, DateTimeKind.Local).AddTicks(945), "p0IRKES+OzorlZH0pIVQnw==:ZgieBEykhE3Z0zAxznqdDqQOEkUTl7KS2Z2oniYRQpg=", new DateTime(2025, 5, 15, 17, 36, 49, 193, DateTimeKind.Local).AddTicks(947) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 17, 36, 49, 267, DateTimeKind.Local).AddTicks(4017), "/9atWHcv7M9IbmYdYDs0Sg==:3uqdHlogs0pkqyF8ZmnLfR7G65hOxvMKsjAVnqHotks=", new DateTime(2025, 5, 15, 17, 36, 49, 267, DateTimeKind.Local).AddTicks(4023) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 15, 17, 36, 49, 342, DateTimeKind.Local).AddTicks(3441), "VpCuHrXtJ8TIqJEhW2q0GA==:DnQbsibT8bfXCaky5ronHpNPVimaSrJxR3u4YvfnBLo=", new DateTime(2025, 5, 15, 17, 36, 49, 342, DateTimeKind.Local).AddTicks(3448) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
