using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobLearning.Api.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc 
        /// Method Up(MigrationBuilder migrationBuilder) is called when applying the migration to create the database schema. 
        /// It defines the operations to be performed on the database, such as creating tables, columns, and constraints. 
        /// In this case, it creates a table named "Courses" with columns for Id, Title, Description, Category, and DurationMinutes.
        /// />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DurationMinutes = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });
        }

        /// <inheritdoc 
        /// Down(MigrationBuilder migrationBuilder) is called when rolling back the migration.
        /// It defines the operations to revert the changes made in the Up method.
        /// />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Courses");
        }
    }
}
