using Microsoft.EntityFrameworkCore.Migrations;

namespace BookTask.Migrations
{
    public partial class CreateBooksGenresTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BooksGenres",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BooksId = table.Column<int>(nullable: false),
                    GenreId = table.Column<int>(nullable: false),
                    BookId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BooksGenres", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BooksGenres_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BooksGenres_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BooksGenres_BookId",
                table: "BooksGenres",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BooksGenres_GenreId",
                table: "BooksGenres",
                column: "GenreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BooksGenres");
        }
    }
}
