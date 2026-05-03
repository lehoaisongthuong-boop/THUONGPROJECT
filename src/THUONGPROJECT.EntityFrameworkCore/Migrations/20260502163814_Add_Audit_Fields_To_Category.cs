using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace THUONGPROJECT.Migrations
{
    /// <inheritdoc />
    public partial class Add_Audit_Fields_To_Category : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "AppCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                table: "AppCategories",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "AppCategories",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "AppCategories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "AppCategories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "AppCategories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                table: "AppCategories",
                type: "bigint",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "AppCategories");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "AppCategories");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "AppCategories");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "AppCategories");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "AppCategories");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "AppCategories");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                table: "AppCategories");
        }
    }
}
