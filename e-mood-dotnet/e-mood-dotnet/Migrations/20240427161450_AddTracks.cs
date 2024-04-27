using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace e_mood_dotnet.Migrations
{
    /// <inheritdoc />
    public partial class AddTracks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "User",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("1bc24198-284e-4695-bcb6-bf056ff56586"),
                oldClrType: typeof(Guid),
                oldType: "TEXT",
                oldDefaultValue: new Guid("7517e931-b46f-4f8d-ad01-02cbdccb88b5"));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Track",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("1f64c7f1-c556-406a-81ae-7db1ebf35cd6"),
                oldClrType: typeof(Guid),
                oldType: "TEXT",
                oldDefaultValue: new Guid("fb85a8b0-7464-4430-9317-722ebed2b3b0"));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Playlist",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("daced15b-ac5c-4529-98fb-fb53cc95baa3"),
                oldClrType: typeof(Guid),
                oldType: "TEXT",
                oldDefaultValue: new Guid("a90d0216-fdd0-43c6-b955-2eb9100b2f40"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "User",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("7517e931-b46f-4f8d-ad01-02cbdccb88b5"),
                oldClrType: typeof(Guid),
                oldType: "TEXT",
                oldDefaultValue: new Guid("1bc24198-284e-4695-bcb6-bf056ff56586"));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Track",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("fb85a8b0-7464-4430-9317-722ebed2b3b0"),
                oldClrType: typeof(Guid),
                oldType: "TEXT",
                oldDefaultValue: new Guid("1f64c7f1-c556-406a-81ae-7db1ebf35cd6"));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Playlist",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("a90d0216-fdd0-43c6-b955-2eb9100b2f40"),
                oldClrType: typeof(Guid),
                oldType: "TEXT",
                oldDefaultValue: new Guid("daced15b-ac5c-4529-98fb-fb53cc95baa3"));
        }
    }
}
