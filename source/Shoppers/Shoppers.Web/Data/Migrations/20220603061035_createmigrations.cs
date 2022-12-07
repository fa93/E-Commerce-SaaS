using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shoppers.Web.Data.Migrations
{
    public partial class createmigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d1fcbb14-e907-4c05-9605-74c54fd6391f"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("fd3d46a1-57d3-4424-86d2-de265aa4e9c1"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("507f74f3-16c8-4084-9772-f017f64e3667"),
                column: "ConcurrencyStamp",
                value: "637898550349632375");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("03147668-9743-4a4f-893e-f0d3f9680d6e"), "637898550949632425", "Customer", "CUSTOMER" },
                    { new Guid("d8f82539-8f7a-49af-96d4-b61818a77ab9"), "637898550349632414", "StoreAdmin", "STOREADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("103eff56-6fa7-4a42-848b-2ca7f4cd2610"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "637898550349632584", "AQAAAAEAACcQAAAAEIelsrcZQgOlZ2HBymdSeqrYmrE59UihPRZ8tXIEXhmnazCtqgExZBq5dUWRk0VeZA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("03147668-9743-4a4f-893e-f0d3f9680d6e"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d8f82539-8f7a-49af-96d4-b61818a77ab9"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("507f74f3-16c8-4084-9772-f017f64e3667"),
                column: "ConcurrencyStamp",
                value: "637897563821740731");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("d1fcbb14-e907-4c05-9605-74c54fd6391f"), "637897563821740793", "StoreAdmin", "STOREADMIN" },
                    { new Guid("fd3d46a1-57d3-4424-86d2-de265aa4e9c1"), "637897564421740798", "Customer", "CUSTOMER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("103eff56-6fa7-4a42-848b-2ca7f4cd2610"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "637897563821740911", "AQAAAAEAACcQAAAAEP7iIVJmsxq47jYZYAWgrZqtuG1jUb4MWPiSsYHCpczjxVzh+GSJjrNP+c7rAuQIPQ==" });
        }
    }
}
