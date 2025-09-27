using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class CreateNewSettings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "Comment", "CreatedDate", "DeletedDate", "Key", "Type", "UpdatedDate", "Value" },
                values: new object[] { new Guid("8c6fcdf7-1952-4c34-a949-208e3962f77b"), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "home_slider_background_image", 4, null, "/assets/images/chef-bg.png" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: new Guid("8c6fcdf7-1952-4c34-a949-208e3962f77b"));
        }
    }
}
