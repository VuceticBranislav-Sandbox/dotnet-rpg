using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace dotnet_rpg.Migrations
{
    public partial class FinalSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { 1, new byte[] { 29, 39, 234, 9, 40, 84, 168, 9, 192, 120, 164, 139, 133, 212, 140, 206, 218, 0, 136, 219, 138, 115, 170, 175, 151, 192, 148, 66, 122, 140, 106, 191, 87, 144, 146, 103, 239, 205, 38, 237, 164, 10, 188, 55, 225, 118, 185, 91, 218, 1, 74, 108, 178, 21, 157, 176, 90, 83, 205, 4, 201, 25, 146, 70 }, new byte[] { 85, 184, 56, 149, 166, 55, 226, 18, 113, 43, 24, 177, 95, 232, 139, 73, 84, 198, 107, 26, 235, 142, 105, 118, 144, 78, 42, 254, 51, 69, 203, 112, 37, 220, 131, 32, 104, 211, 170, 49, 251, 232, 148, 6, 144, 198, 32, 2, 244, 143, 97, 236, 253, 52, 200, 221, 176, 87, 218, 69, 37, 64, 86, 129, 77, 126, 119, 170, 75, 45, 24, 74, 205, 130, 11, 82, 0, 175, 129, 107, 249, 156, 226, 199, 107, 122, 47, 99, 159, 215, 160, 92, 148, 225, 92, 76, 171, 200, 156, 26, 255, 100, 175, 180, 157, 7, 253, 187, 1, 60, 34, 165, 210, 235, 165, 113, 1, 76, 169, 19, 143, 95, 168, 25, 222, 26, 111, 14 }, "User1" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { 2, new byte[] { 29, 39, 234, 9, 40, 84, 168, 9, 192, 120, 164, 139, 133, 212, 140, 206, 218, 0, 136, 219, 138, 115, 170, 175, 151, 192, 148, 66, 122, 140, 106, 191, 87, 144, 146, 103, 239, 205, 38, 237, 164, 10, 188, 55, 225, 118, 185, 91, 218, 1, 74, 108, 178, 21, 157, 176, 90, 83, 205, 4, 201, 25, 146, 70 }, new byte[] { 85, 184, 56, 149, 166, 55, 226, 18, 113, 43, 24, 177, 95, 232, 139, 73, 84, 198, 107, 26, 235, 142, 105, 118, 144, 78, 42, 254, 51, 69, 203, 112, 37, 220, 131, 32, 104, 211, 170, 49, 251, 232, 148, 6, 144, 198, 32, 2, 244, 143, 97, 236, 253, 52, 200, 221, 176, 87, 218, 69, 37, 64, 86, 129, 77, 126, 119, 170, 75, 45, 24, 74, 205, 130, 11, 82, 0, 175, 129, 107, 249, 156, 226, 199, 107, 122, 47, 99, 159, 215, 160, 92, 148, 225, 92, 76, 171, 200, 156, 26, 255, 100, 175, 180, 157, 7, 253, 187, 1, 60, 34, 165, 210, 235, 165, 113, 1, 76, 169, 19, 143, 95, 168, 25, 222, 26, 111, 14 }, "User2" });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "Class", "Defeats", "Defense", "Fights", "HitPoints", "Intelligence", "Name", "Strength", "UserId", "Victories" },
                values: new object[] { 1, 0, 0, 10, 0, 100, 10, "Frodo", 15, 1, 0 });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "Class", "Defeats", "Defense", "Fights", "HitPoints", "Intelligence", "Name", "Strength", "UserId", "Victories" },
                values: new object[] { 2, 1, 0, 5, 0, 100, 20, "Raistlin", 5, 2, 0 });

            migrationBuilder.InsertData(
                table: "CharacterSkill",
                columns: new[] { "CharactersId", "SkillsId" },
                values: new object[] { 1, 2 });

            migrationBuilder.InsertData(
                table: "CharacterSkill",
                columns: new[] { "CharactersId", "SkillsId" },
                values: new object[] { 2, 1 });

            migrationBuilder.InsertData(
                table: "CharacterSkill",
                columns: new[] { "CharactersId", "SkillsId" },
                values: new object[] { 2, 3 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "CharacterId", "Damage", "Name" },
                values: new object[] { 1, 1, 20, "The Master Sword" });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "CharacterId", "Damage", "Name" },
                values: new object[] { 2, 2, 5, "Crystal Wand" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CharacterSkill",
                keyColumns: new[] { "CharactersId", "SkillsId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "CharacterSkill",
                keyColumns: new[] { "CharactersId", "SkillsId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "CharacterSkill",
                keyColumns: new[] { "CharactersId", "SkillsId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
