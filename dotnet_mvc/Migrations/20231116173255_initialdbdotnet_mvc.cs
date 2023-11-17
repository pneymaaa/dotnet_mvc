using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotnet_mvc.Migrations
{
    /// <inheritdoc />
    public partial class initialdbdotnet_mvc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblM_Genders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblM_Genders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblM_Hobbies",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblM_Hobbies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblT_Ages",
                columns: table => new
                {
                    Age = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Total = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblT_Ages", x => x.Age);
                });

            migrationBuilder.CreateTable(
                name: "tblT_Personals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdHobby = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    IdGender = table.Column<int>(type: "int", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblT_Personals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblT_Personals_tblM_Genders_IdGender",
                        column: x => x.IdGender,
                        principalTable: "tblM_Genders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblT_Personals_tblM_Hobbies_IdHobby",
                        column: x => x.IdHobby,
                        principalTable: "tblM_Hobbies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblT_Personals_tblT_Ages_Age",
                        column: x => x.Age,
                        principalTable: "tblT_Ages",
                        principalColumn: "Age",
                        onDelete: ReferentialAction.Cascade);
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblT_Personals");

            migrationBuilder.DropTable(
                name: "tblM_Genders");

            migrationBuilder.DropTable(
                name: "tblM_Hobbies");

            migrationBuilder.DropTable(
                name: "tblT_Ages");
        }
    }
}
