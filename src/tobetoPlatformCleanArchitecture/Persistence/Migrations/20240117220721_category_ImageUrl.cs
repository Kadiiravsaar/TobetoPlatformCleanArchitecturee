﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class category_ImageUrl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 173, 180, 127, 69, 146, 65, 152, 60, 59, 210, 152, 83, 109, 42, 76, 248, 80, 194, 97, 10, 114, 146, 129, 18, 70, 248, 203, 24, 218, 174, 133, 31, 101, 41, 82, 142, 104, 119, 149, 213, 218, 47, 4, 198, 72, 105, 102, 137, 59, 98, 172, 50, 204, 34, 131, 125, 184, 206, 159, 171, 78, 145, 77, 62 }, new byte[] { 14, 35, 150, 219, 114, 222, 191, 60, 50, 104, 158, 188, 22, 4, 223, 180, 227, 49, 27, 132, 144, 209, 217, 241, 135, 43, 51, 75, 253, 91, 149, 208, 220, 129, 54, 115, 84, 231, 160, 27, 119, 208, 175, 124, 99, 61, 24, 6, 62, 134, 40, 161, 215, 126, 237, 255, 169, 129, 120, 188, 65, 240, 65, 186, 235, 68, 88, 206, 30, 196, 207, 210, 211, 7, 48, 126, 222, 213, 238, 114, 125, 47, 245, 255, 127, 204, 125, 164, 166, 175, 7, 63, 2, 238, 159, 102, 122, 158, 189, 42, 40, 108, 50, 254, 44, 196, 69, 72, 161, 236, 87, 0, 131, 46, 73, 113, 178, 82, 170, 236, 95, 66, 169, 145, 133, 147, 223, 77 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Categories");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 34, 174, 142, 193, 184, 150, 141, 142, 127, 244, 198, 3, 15, 212, 180, 182, 116, 215, 174, 21, 207, 165, 219, 15, 150, 213, 250, 206, 33, 76, 4, 200, 243, 237, 119, 209, 111, 35, 107, 242, 57, 57, 78, 76, 108, 120, 84, 79, 6, 112, 144, 149, 134, 184, 108, 234, 175, 227, 231, 38, 24, 2, 191, 18 }, new byte[] { 165, 193, 252, 175, 208, 161, 79, 172, 247, 69, 208, 15, 193, 182, 203, 84, 185, 146, 154, 86, 83, 128, 245, 7, 28, 111, 75, 204, 227, 40, 200, 163, 95, 112, 182, 209, 70, 26, 87, 55, 163, 218, 59, 82, 64, 91, 50, 41, 240, 219, 35, 142, 82, 140, 236, 58, 118, 8, 108, 138, 2, 174, 189, 23, 220, 99, 157, 14, 154, 97, 64, 66, 68, 5, 80, 41, 193, 159, 242, 55, 97, 125, 25, 6, 159, 241, 210, 32, 182, 108, 190, 56, 106, 148, 116, 53, 42, 160, 221, 231, 111, 137, 171, 35, 29, 58, 196, 147, 191, 200, 61, 121, 1, 126, 171, 254, 225, 105, 32, 165, 69, 107, 255, 178, 37, 157, 213, 249 } });
        }
    }
}
