using Microsoft.EntityFrameworkCore.Migrations;

namespace Prj.Migrations
{
    public partial class Databasecreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Act",
                columns: table => new
                {
                    ActId = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Actname = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Act", x => x.ActId);
                });

            migrationBuilder.CreateTable(
                name: "Date",
                columns: table => new
                {
                    DateId = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Year = table.Column<string>(nullable: true),
                    month = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Date", x => x.DateId);
                });

            migrationBuilder.CreateTable(
                name: "Zarps",
                columns: table => new
                {
                    MinZarId = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Zarplata = table.Column<long>(nullable: false),
                    ActId = table.Column<long>(nullable: false),
                    DateId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zarps", x => x.MinZarId);
                    table.ForeignKey(
                        name: "FK_Zarps_Act_ActId",
                        column: x => x.ActId,
                        principalTable: "Act",
                        principalColumn: "ActId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Zarps_Date_DateId",
                        column: x => x.DateId,
                        principalTable: "Date",
                        principalColumn: "DateId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Act",
                columns: new[] { "ActId", "Actname" },
                values: new object[] { 1L, "\"Московское трехстороннее соглашение на 2002 год между Правительством Москвы, московскими объединениями профсоюзов и московскими объединениями промышленников и предпринимателей (работодателей)\" от 04.12.2001" });

            migrationBuilder.InsertData(
                table: "Act",
                columns: new[] { "ActId", "Actname" },
                values: new object[] { 2L, "\"Московское трехстороннее соглашение на 2003 год между Правительством Москвы, московскими объединениями профсоюзов и московскими объединениями промышленников и предпринимателей (работодателей)\" от 15.12.2002" });

            migrationBuilder.InsertData(
                table: "Date",
                columns: new[] { "DateId", "Year", "month" },
                values: new object[] { 1L, "2002", 0 });

            migrationBuilder.InsertData(
                table: "Date",
                columns: new[] { "DateId", "Year", "month" },
                values: new object[] { 2L, "2002", 8 });

            migrationBuilder.InsertData(
                table: "Zarps",
                columns: new[] { "MinZarId", "ActId", "DateId", "Zarplata" },
                values: new object[] { 1L, 1L, 1L, 1100L });

            migrationBuilder.InsertData(
                table: "Zarps",
                columns: new[] { "MinZarId", "ActId", "DateId", "Zarplata" },
                values: new object[] { 2L, 2L, 2L, 1270L });

            migrationBuilder.CreateIndex(
                name: "IX_Zarps_ActId",
                table: "Zarps",
                column: "ActId");

            migrationBuilder.CreateIndex(
                name: "IX_Zarps_DateId",
                table: "Zarps",
                column: "DateId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Zarps");

            migrationBuilder.DropTable(
                name: "Act");

            migrationBuilder.DropTable(
                name: "Date");
        }
    }
}
