using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoginPageAbhi.Migrations
{
    /// <inheritdoc />
    public partial class LogCreateDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "studentLogins",
                columns: table => new
                {
                    RollNum = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Enter_Name = table.Column<string>(type: "varchar(30)", nullable: false),
                    Enter_Email = table.Column<string>(type: "varchar(30)", nullable: false),
                    Enter_Password = table.Column<string>(type: "varchar(30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_studentLogins", x => x.RollNum);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "studentLogins");
        }
    }
}
