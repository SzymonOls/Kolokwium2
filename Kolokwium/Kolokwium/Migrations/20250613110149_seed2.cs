using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Kolokwium.Migrations
{
    /// <inheritdoc />
    public partial class seed2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "FirstName", "HireDate", "LastName" },
                values: new object[,]
                {
                    { 1, "name1", new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "lastname1" },
                    { 2, "name2", new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "lastname2" },
                    { 3, "name3", new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "lastname3" }
                });

            migrationBuilder.InsertData(
                table: "Nursery",
                columns: new[] { "NurseryId", "EstablishedDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "name1" },
                    { 2, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "name2" },
                    { 3, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "name3" }
                });

            migrationBuilder.InsertData(
                table: "Tree_Species",
                columns: new[] { "SpeciesId", "GrowthTimeInYears", "LatinName" },
                values: new object[,]
                {
                    { 1, 1, "name1" },
                    { 2, 2, "name2" },
                    { 3, 3, "name3" }
                });

            migrationBuilder.InsertData(
                table: "Seedling_Batch",
                columns: new[] { "BatchId", "NurseryId", "Quantity", "ReadyDate", "SownDate", "SpeciesId" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2027, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, 2, 1, new DateTime(2029, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 3, 3, 1, new DateTime(2028, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 }
                });

            migrationBuilder.InsertData(
                table: "Responsible",
                columns: new[] { "BatchId", "Employee", "Role" },
                values: new object[,]
                {
                    { 1, 1, "role1" },
                    { 2, 2, "role2" },
                    { 3, 3, "role3" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Responsible",
                keyColumns: new[] { "BatchId", "Employee" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Responsible",
                keyColumns: new[] { "BatchId", "Employee" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "Responsible",
                keyColumns: new[] { "BatchId", "Employee" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Seedling_Batch",
                keyColumn: "BatchId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Seedling_Batch",
                keyColumn: "BatchId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Seedling_Batch",
                keyColumn: "BatchId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Nursery",
                keyColumn: "NurseryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Nursery",
                keyColumn: "NurseryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Nursery",
                keyColumn: "NurseryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tree_Species",
                keyColumn: "SpeciesId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tree_Species",
                keyColumn: "SpeciesId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tree_Species",
                keyColumn: "SpeciesId",
                keyValue: 3);
        }
    }
}
