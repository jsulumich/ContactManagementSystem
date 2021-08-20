using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ContactManagementSystem.Migrations
{
    public partial class InitialCommit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false, defaultValueSql: "NEWID()"),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");
        }
    }
}
