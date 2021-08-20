using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ContactManagementSystem.Migrations
{
    public partial class updatedatetimenullability : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: new Guid("0c4d0709-33eb-48b7-88b9-3d5989891f66"));

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: new Guid("4997d69e-5e81-4847-b018-747d33d2ed15"));

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: new Guid("5cad74dc-70fa-4aa9-a697-9062e2474a59"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDate",
                table: "Contacts",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "TEXT");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDate",
                table: "Contacts",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "BirthDate", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { new Guid("5cad74dc-70fa-4aa9-a697-9062e2474a59"), new DateTime(1999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", "Johnson", "555-555-5555" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "BirthDate", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { new Guid("0c4d0709-33eb-48b7-88b9-3d5989891f66"), new DateTime(1975, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sherlock", "Holmes", "123-456-7890" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "BirthDate", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { new Guid("4997d69e-5e81-4847-b018-747d33d2ed15"), new DateTime(1992, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Linda", "Lee", "248-867-5309" });
        }
    }
}
