using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiHollowKnight.Migrations
{
    /// <inheritdoc />
    public partial class ApiHollowKnight : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NameCharacterTypeDescription",
                table: "CharactersTypes");

            migrationBuilder.AddColumn<string>(
                name: "PlaceDescription",
                table: "Places",
                type: "varchar(512)",
                maxLength: 512,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "NameCharacterType",
                table: "CharactersTypes",
                type: "varchar(64)",
                maxLength: 64,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldMaxLength: 20)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "CharacterTypeDescription",
                table: "CharactersTypes",
                type: "varchar(512)",
                maxLength: 512,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PlaceDescription",
                table: "Places");

            migrationBuilder.DropColumn(
                name: "CharacterTypeDescription",
                table: "CharactersTypes");

            migrationBuilder.AlterColumn<string>(
                name: "NameCharacterType",
                table: "CharactersTypes",
                type: "varchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(64)",
                oldMaxLength: 64)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "NameCharacterTypeDescription",
                table: "CharactersTypes",
                type: "varchar(140)",
                maxLength: 140,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
