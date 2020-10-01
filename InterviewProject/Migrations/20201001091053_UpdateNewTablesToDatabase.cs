using Microsoft.EntityFrameworkCore.Migrations;

namespace InterviewProject.Migrations
{
    public partial class UpdateNewTablesToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Countries",
                table: "Countries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cities",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "CountryName",
                table: "Cities");

            migrationBuilder.AddColumn<int>(
                name: "Country_Id",
                table: "Countries",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "City_Id",
                table: "Cities",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Country_Id",
                table: "Cities",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Country_Id1",
                table: "Cities",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Countries",
                table: "Countries",
                column: "Country_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cities",
                table: "Cities",
                column: "City_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_Country_Id1",
                table: "Cities",
                column: "Country_Id1");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Countries_Country_Id1",
                table: "Cities",
                column: "Country_Id1",
                principalTable: "Countries",
                principalColumn: "Country_Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Countries_Country_Id1",
                table: "Cities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Countries",
                table: "Countries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cities",
                table: "Cities");

            migrationBuilder.DropIndex(
                name: "IX_Cities_Country_Id1",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "Country_Id",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "City_Id",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "Country_Id",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "Country_Id1",
                table: "Cities");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Countries",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Cities",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "CountryName",
                table: "Cities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Countries",
                table: "Countries",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cities",
                table: "Cities",
                column: "Id");
        }
    }
}
