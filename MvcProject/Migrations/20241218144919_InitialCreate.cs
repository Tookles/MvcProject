using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MvcProject.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Name", "Nationality" },
                values: new object[,]
                {
                    { 1, "George Orwell", "British" },
                    { 3, "Evie Pom", "German" },
                    { 4, "Leo Tolstoy", "Russian" },
                    { 5, "Jane Austen", "British" },
                    { 6, "Gabriel Garcia Marquez", "Colombian" },
                    { 7, "Homer", "Ancient Greek" },
                    { 8, "Mark Twain", "American" },
                    { 9, "Virginia Woolf", "British" },
                    { 10, "Haruki Murakami", "Japanese" },
                    { 11, "Kurt Vonnegut", "American" },
                    { 12, "Emily Bronte", "English" },
                    { 13, "Raymond Chandler", "American" },
                    { 14, "Thomas Pynchon", "American" },
                    { 15, "Marlon James", "American" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Authors");
        }
    }
}
