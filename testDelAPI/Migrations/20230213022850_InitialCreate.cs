using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace testDelAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoryDbClt",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryDbClt", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CountryDbClt",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryDbClt", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PokemonDbClt",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonDbClt", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReviewerDbClt",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReviewerDbClt", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OwnerDbClt",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryId = table.Column<int>(type: "int", nullable: true),
                    Gym = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OwnerDbClt", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OwnerDbClt_CountryDbClt_CountryId",
                        column: x => x.CountryId,
                        principalTable: "CountryDbClt",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PokemonCategoryDbClt",
                columns: table => new
                {
                    PokemonId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonCategoryDbClt", x => new { x.PokemonId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_PokemonCategoryDbClt_CategoryDbClt_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "CategoryDbClt",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PokemonCategoryDbClt_PokemonDbClt_PokemonId",
                        column: x => x.PokemonId,
                        principalTable: "PokemonDbClt",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReviewDbClt",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    ReviewerId = table.Column<int>(type: "int", nullable: false),
                    PokemonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReviewDbClt", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReviewDbClt_PokemonDbClt_PokemonId",
                        column: x => x.PokemonId,
                        principalTable: "PokemonDbClt",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReviewDbClt_ReviewerDbClt_ReviewerId",
                        column: x => x.ReviewerId,
                        principalTable: "ReviewerDbClt",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PokemonOwnerDbClt",
                columns: table => new
                {
                    PokemonId = table.Column<int>(type: "int", nullable: false),
                    OwnerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonOwnerDbClt", x => new { x.PokemonId, x.OwnerId });
                    table.ForeignKey(
                        name: "FK_PokemonOwnerDbClt_OwnerDbClt_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "OwnerDbClt",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PokemonOwnerDbClt_PokemonDbClt_PokemonId",
                        column: x => x.PokemonId,
                        principalTable: "PokemonDbClt",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OwnerDbClt_CountryId",
                table: "OwnerDbClt",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonCategoryDbClt_CategoryId",
                table: "PokemonCategoryDbClt",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonOwnerDbClt_OwnerId",
                table: "PokemonOwnerDbClt",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_ReviewDbClt_PokemonId",
                table: "ReviewDbClt",
                column: "PokemonId");

            migrationBuilder.CreateIndex(
                name: "IX_ReviewDbClt_ReviewerId",
                table: "ReviewDbClt",
                column: "ReviewerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PokemonCategoryDbClt");

            migrationBuilder.DropTable(
                name: "PokemonOwnerDbClt");

            migrationBuilder.DropTable(
                name: "ReviewDbClt");

            migrationBuilder.DropTable(
                name: "CategoryDbClt");

            migrationBuilder.DropTable(
                name: "OwnerDbClt");

            migrationBuilder.DropTable(
                name: "PokemonDbClt");

            migrationBuilder.DropTable(
                name: "ReviewerDbClt");

            migrationBuilder.DropTable(
                name: "CountryDbClt");
        }
    }
}
