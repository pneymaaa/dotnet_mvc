using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotnet_mvc.Migrations
{
    /// <inheritdoc />
    public partial class modifiedTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblT_Personals_tblM_Genders_tblM_GenderId",
                table: "tblT_Personals");

            migrationBuilder.DropForeignKey(
                name: "FK_tblT_Personals_tblM_Hobbies_tblM_HobbyId",
                table: "tblT_Personals");

            migrationBuilder.DropForeignKey(
                name: "FK_tblT_Personals_tblT_Ages_tblT_AgeAge",
                table: "tblT_Personals");

            migrationBuilder.DropIndex(
                name: "IX_tblT_Personals_tblM_GenderId",
                table: "tblT_Personals");

            migrationBuilder.DropIndex(
                name: "IX_tblT_Personals_tblM_HobbyId",
                table: "tblT_Personals");

            migrationBuilder.DropIndex(
                name: "IX_tblT_Personals_tblT_AgeAge",
                table: "tblT_Personals");

            migrationBuilder.DropColumn(
                name: "tblM_GenderId",
                table: "tblT_Personals");

            migrationBuilder.DropColumn(
                name: "tblM_HobbyId",
                table: "tblT_Personals");

            migrationBuilder.DropColumn(
                name: "tblT_AgeAge",
                table: "tblT_Personals");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "tblT_Personals",
                type: "VARCHAR(25)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(25)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IdHobby",
                table: "tblT_Personals",
                type: "CHAR(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(1)");

            migrationBuilder.CreateTable(
                name: "udt_Personal",
                columns: table => new
                {
                    Name = table.Column<string>(type: "varchar(25)", nullable: true),
                    IdHobby = table.Column<string>(type: "char(1)", nullable: false),
                    NameHobby = table.Column<string>(type: "varchar(50)", nullable: true),
                    IdGender = table.Column<int>(type: "int", nullable: false),
                    GenderName = table.Column<string>(type: "varchar(10)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblT_Personals_Age",
                table: "tblT_Personals",
                column: "Age");

            migrationBuilder.CreateIndex(
                name: "IX_tblT_Personals_IdGender",
                table: "tblT_Personals",
                column: "IdGender");

            migrationBuilder.CreateIndex(
                name: "IX_tblT_Personals_IdHobby",
                table: "tblT_Personals",
                column: "IdHobby");

            migrationBuilder.AddForeignKey(
                name: "FK_tblT_Personals_tblM_Genders_IdGender",
                table: "tblT_Personals",
                column: "IdGender",
                principalTable: "tblM_Genders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblT_Personals_tblM_Hobbies_IdHobby",
                table: "tblT_Personals",
                column: "IdHobby",
                principalTable: "tblM_Hobbies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblT_Personals_tblT_Ages_Age",
                table: "tblT_Personals",
                column: "Age",
                principalTable: "tblT_Ages",
                principalColumn: "Age",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblT_Personals_tblM_Genders_IdGender",
                table: "tblT_Personals");

            migrationBuilder.DropForeignKey(
                name: "FK_tblT_Personals_tblM_Hobbies_IdHobby",
                table: "tblT_Personals");

            migrationBuilder.DropForeignKey(
                name: "FK_tblT_Personals_tblT_Ages_Age",
                table: "tblT_Personals");

            migrationBuilder.DropTable(
                name: "udt_Personal");

            migrationBuilder.DropIndex(
                name: "IX_tblT_Personals_Age",
                table: "tblT_Personals");

            migrationBuilder.DropIndex(
                name: "IX_tblT_Personals_IdGender",
                table: "tblT_Personals");

            migrationBuilder.DropIndex(
                name: "IX_tblT_Personals_IdHobby",
                table: "tblT_Personals");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "tblT_Personals",
                type: "varchar(25)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(25)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IdHobby",
                table: "tblT_Personals",
                type: "char(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "CHAR(1)");

            migrationBuilder.AddColumn<int>(
                name: "tblM_GenderId",
                table: "tblT_Personals",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tblM_HobbyId",
                table: "tblT_Personals",
                type: "char(1)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tblT_AgeAge",
                table: "tblT_Personals",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tblT_Personals_tblM_GenderId",
                table: "tblT_Personals",
                column: "tblM_GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_tblT_Personals_tblM_HobbyId",
                table: "tblT_Personals",
                column: "tblM_HobbyId");

            migrationBuilder.CreateIndex(
                name: "IX_tblT_Personals_tblT_AgeAge",
                table: "tblT_Personals",
                column: "tblT_AgeAge");

            migrationBuilder.AddForeignKey(
                name: "FK_tblT_Personals_tblM_Genders_tblM_GenderId",
                table: "tblT_Personals",
                column: "tblM_GenderId",
                principalTable: "tblM_Genders",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tblT_Personals_tblM_Hobbies_tblM_HobbyId",
                table: "tblT_Personals",
                column: "tblM_HobbyId",
                principalTable: "tblM_Hobbies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tblT_Personals_tblT_Ages_tblT_AgeAge",
                table: "tblT_Personals",
                column: "tblT_AgeAge",
                principalTable: "tblT_Ages",
                principalColumn: "Age");
        }
    }
}
