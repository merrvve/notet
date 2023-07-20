 using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace notet.DAL.Migrations
{
    /// <inheritdoc />
    public partial class pass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(8)",
                oldMaxLength: 8);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2023, 1, 31, 15, 29, 56, 477, DateTimeKind.Local).AddTicks(1200), "$2b$10$eyE6ab2YLV3jsCh60yg7HuXo2eKGfhg5adc2BPjch8.s5AJn9r60G" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2023, 1, 31, 15, 29, 56, 477, DateTimeKind.Local).AddTicks(1219), "$2b$10$DOaZK/Kduj8L.sYNsfGjN.FphuhJpPx4VozPiPrSkR7JedTvJZ9Ji" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2023, 1, 31, 15, 15, 13, 240, DateTimeKind.Local).AddTicks(4643), "$2b$10$YehSQ4UevIxZ0605JgmQie5Tr.wRUOFUCYDqLQ.JFF.C47zqqT7Ty" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2023, 1, 31, 15, 15, 13, 240, DateTimeKind.Local).AddTicks(4659), "$2b$10$Yw.mVDfXFE2FJzd50mIzb.ecCtKnEbxYoaX.9LYSFDKfemdc8GH9W" });
        }
    }
}
