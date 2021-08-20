using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ContactManagementSystem.Migrations
{
    public partial class makephonenullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: new Guid("0d321072-0552-4e5f-becb-3b66ea7eb64c"));

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: new Guid("62d0bcb5-16f0-4765-9453-f4ba988e9595"));

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: new Guid("67b04eef-3f65-49c7-bd78-ad79b6680ff1"));

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Contacts",
                type: "TEXT",
                maxLength: 15,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Contacts",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "TEXT",
                oldDefaultValueSql: "NEWID()");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Contacts",
                type: "TEXT",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 15,
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Contacts",
                type: "TEXT",
                nullable: false,
                defaultValueSql: "NEWID()",
                oldClrType: typeof(Guid),
                oldType: "TEXT");

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "BirthDate", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { new Guid("67b04eef-3f65-49c7-bd78-ad79b6680ff1"), new DateTime(1999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", "Johnson", "555-555-5555" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "BirthDate", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { new Guid("0d321072-0552-4e5f-becb-3b66ea7eb64c"), new DateTime(1975, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sherlock", "Holmes", "123-456-7890" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "BirthDate", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { new Guid("62d0bcb5-16f0-4765-9453-f4ba988e9595"), new DateTime(1992, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Linda", "Lee", "248-867-5309" });
        }
    }
}
