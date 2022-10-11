using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthMeasurement.Data.Migrations
{
    public partial class Update_Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "b8a606df-ad7b-41f3-86bc-70a21babcf18");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6e654983-2167-4411-9d21-b10ade84076d", "AQAAAAEAACcQAAAAECYGqTkLt5/aaMaekjDmAEOnCx+bzbr9Rbjkmb7PjDu0m/7fZxOj0d7G0JRNSUEJGQ==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 10, 3, 14, 46, 28, 267, DateTimeKind.Local).AddTicks(2232));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "37fd1c7e-8d85-4375-bd3f-49e05e4884e9");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c2c5adf8-c610-4388-9ef4-0c5ee53521eb", "AQAAAAEAACcQAAAAEM5W4ig7ZLu7IAktKOmfztVsluwsNuyJahpY+292T0amym6WRWUGph8oBP/mo7KSxw==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 9, 2, 22, 8, 8, 182, DateTimeKind.Local).AddTicks(7084));
        }
    }
}
