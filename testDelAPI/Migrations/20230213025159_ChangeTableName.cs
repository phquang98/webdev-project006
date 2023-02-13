using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace testDelAPI.Migrations
{
    /// <inheritdoc />
    public partial class ChangeTableName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OwnerDbClt_CountryDbClt_CountryId",
                table: "OwnerDbClt");

            migrationBuilder.DropForeignKey(
                name: "FK_PokemonCategoryDbClt_CategoryDbClt_CategoryId",
                table: "PokemonCategoryDbClt");

            migrationBuilder.DropForeignKey(
                name: "FK_PokemonCategoryDbClt_PokemonDbClt_PokemonId",
                table: "PokemonCategoryDbClt");

            migrationBuilder.DropForeignKey(
                name: "FK_PokemonOwnerDbClt_OwnerDbClt_OwnerId",
                table: "PokemonOwnerDbClt");

            migrationBuilder.DropForeignKey(
                name: "FK_PokemonOwnerDbClt_PokemonDbClt_PokemonId",
                table: "PokemonOwnerDbClt");

            migrationBuilder.DropForeignKey(
                name: "FK_ReviewDbClt_PokemonDbClt_PokemonId",
                table: "ReviewDbClt");

            migrationBuilder.DropForeignKey(
                name: "FK_ReviewDbClt_ReviewerDbClt_ReviewerId",
                table: "ReviewDbClt");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReviewerDbClt",
                table: "ReviewerDbClt");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReviewDbClt",
                table: "ReviewDbClt");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PokemonOwnerDbClt",
                table: "PokemonOwnerDbClt");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PokemonDbClt",
                table: "PokemonDbClt");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PokemonCategoryDbClt",
                table: "PokemonCategoryDbClt");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OwnerDbClt",
                table: "OwnerDbClt");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CountryDbClt",
                table: "CountryDbClt");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CategoryDbClt",
                table: "CategoryDbClt");

            migrationBuilder.RenameTable(
                name: "ReviewerDbClt",
                newName: "ReviewerTable");

            migrationBuilder.RenameTable(
                name: "ReviewDbClt",
                newName: "ReviewTable");

            migrationBuilder.RenameTable(
                name: "PokemonOwnerDbClt",
                newName: "PokemonOwnerTable");

            migrationBuilder.RenameTable(
                name: "PokemonDbClt",
                newName: "PokemonTable");

            migrationBuilder.RenameTable(
                name: "PokemonCategoryDbClt",
                newName: "PokemonCategoryTable");

            migrationBuilder.RenameTable(
                name: "OwnerDbClt",
                newName: "OwnerTable");

            migrationBuilder.RenameTable(
                name: "CountryDbClt",
                newName: "CountryTable");

            migrationBuilder.RenameTable(
                name: "CategoryDbClt",
                newName: "CategoryTable");

            migrationBuilder.RenameIndex(
                name: "IX_ReviewDbClt_ReviewerId",
                table: "ReviewTable",
                newName: "IX_ReviewTable_ReviewerId");

            migrationBuilder.RenameIndex(
                name: "IX_ReviewDbClt_PokemonId",
                table: "ReviewTable",
                newName: "IX_ReviewTable_PokemonId");

            migrationBuilder.RenameIndex(
                name: "IX_PokemonOwnerDbClt_OwnerId",
                table: "PokemonOwnerTable",
                newName: "IX_PokemonOwnerTable_OwnerId");

            migrationBuilder.RenameIndex(
                name: "IX_PokemonCategoryDbClt_CategoryId",
                table: "PokemonCategoryTable",
                newName: "IX_PokemonCategoryTable_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_OwnerDbClt_CountryId",
                table: "OwnerTable",
                newName: "IX_OwnerTable_CountryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReviewerTable",
                table: "ReviewerTable",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReviewTable",
                table: "ReviewTable",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PokemonOwnerTable",
                table: "PokemonOwnerTable",
                columns: new[] { "PokemonId", "OwnerId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_PokemonTable",
                table: "PokemonTable",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PokemonCategoryTable",
                table: "PokemonCategoryTable",
                columns: new[] { "PokemonId", "CategoryId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_OwnerTable",
                table: "OwnerTable",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CountryTable",
                table: "CountryTable",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategoryTable",
                table: "CategoryTable",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OwnerTable_CountryTable_CountryId",
                table: "OwnerTable",
                column: "CountryId",
                principalTable: "CountryTable",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PokemonCategoryTable_CategoryTable_CategoryId",
                table: "PokemonCategoryTable",
                column: "CategoryId",
                principalTable: "CategoryTable",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PokemonCategoryTable_PokemonTable_PokemonId",
                table: "PokemonCategoryTable",
                column: "PokemonId",
                principalTable: "PokemonTable",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PokemonOwnerTable_OwnerTable_OwnerId",
                table: "PokemonOwnerTable",
                column: "OwnerId",
                principalTable: "OwnerTable",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PokemonOwnerTable_PokemonTable_PokemonId",
                table: "PokemonOwnerTable",
                column: "PokemonId",
                principalTable: "PokemonTable",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReviewTable_PokemonTable_PokemonId",
                table: "ReviewTable",
                column: "PokemonId",
                principalTable: "PokemonTable",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReviewTable_ReviewerTable_ReviewerId",
                table: "ReviewTable",
                column: "ReviewerId",
                principalTable: "ReviewerTable",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OwnerTable_CountryTable_CountryId",
                table: "OwnerTable");

            migrationBuilder.DropForeignKey(
                name: "FK_PokemonCategoryTable_CategoryTable_CategoryId",
                table: "PokemonCategoryTable");

            migrationBuilder.DropForeignKey(
                name: "FK_PokemonCategoryTable_PokemonTable_PokemonId",
                table: "PokemonCategoryTable");

            migrationBuilder.DropForeignKey(
                name: "FK_PokemonOwnerTable_OwnerTable_OwnerId",
                table: "PokemonOwnerTable");

            migrationBuilder.DropForeignKey(
                name: "FK_PokemonOwnerTable_PokemonTable_PokemonId",
                table: "PokemonOwnerTable");

            migrationBuilder.DropForeignKey(
                name: "FK_ReviewTable_PokemonTable_PokemonId",
                table: "ReviewTable");

            migrationBuilder.DropForeignKey(
                name: "FK_ReviewTable_ReviewerTable_ReviewerId",
                table: "ReviewTable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReviewTable",
                table: "ReviewTable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReviewerTable",
                table: "ReviewerTable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PokemonTable",
                table: "PokemonTable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PokemonOwnerTable",
                table: "PokemonOwnerTable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PokemonCategoryTable",
                table: "PokemonCategoryTable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OwnerTable",
                table: "OwnerTable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CountryTable",
                table: "CountryTable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CategoryTable",
                table: "CategoryTable");

            migrationBuilder.RenameTable(
                name: "ReviewTable",
                newName: "ReviewDbClt");

            migrationBuilder.RenameTable(
                name: "ReviewerTable",
                newName: "ReviewerDbClt");

            migrationBuilder.RenameTable(
                name: "PokemonTable",
                newName: "PokemonDbClt");

            migrationBuilder.RenameTable(
                name: "PokemonOwnerTable",
                newName: "PokemonOwnerDbClt");

            migrationBuilder.RenameTable(
                name: "PokemonCategoryTable",
                newName: "PokemonCategoryDbClt");

            migrationBuilder.RenameTable(
                name: "OwnerTable",
                newName: "OwnerDbClt");

            migrationBuilder.RenameTable(
                name: "CountryTable",
                newName: "CountryDbClt");

            migrationBuilder.RenameTable(
                name: "CategoryTable",
                newName: "CategoryDbClt");

            migrationBuilder.RenameIndex(
                name: "IX_ReviewTable_ReviewerId",
                table: "ReviewDbClt",
                newName: "IX_ReviewDbClt_ReviewerId");

            migrationBuilder.RenameIndex(
                name: "IX_ReviewTable_PokemonId",
                table: "ReviewDbClt",
                newName: "IX_ReviewDbClt_PokemonId");

            migrationBuilder.RenameIndex(
                name: "IX_PokemonOwnerTable_OwnerId",
                table: "PokemonOwnerDbClt",
                newName: "IX_PokemonOwnerDbClt_OwnerId");

            migrationBuilder.RenameIndex(
                name: "IX_PokemonCategoryTable_CategoryId",
                table: "PokemonCategoryDbClt",
                newName: "IX_PokemonCategoryDbClt_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_OwnerTable_CountryId",
                table: "OwnerDbClt",
                newName: "IX_OwnerDbClt_CountryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReviewDbClt",
                table: "ReviewDbClt",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReviewerDbClt",
                table: "ReviewerDbClt",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PokemonDbClt",
                table: "PokemonDbClt",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PokemonOwnerDbClt",
                table: "PokemonOwnerDbClt",
                columns: new[] { "PokemonId", "OwnerId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_PokemonCategoryDbClt",
                table: "PokemonCategoryDbClt",
                columns: new[] { "PokemonId", "CategoryId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_OwnerDbClt",
                table: "OwnerDbClt",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CountryDbClt",
                table: "CountryDbClt",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategoryDbClt",
                table: "CategoryDbClt",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OwnerDbClt_CountryDbClt_CountryId",
                table: "OwnerDbClt",
                column: "CountryId",
                principalTable: "CountryDbClt",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PokemonCategoryDbClt_CategoryDbClt_CategoryId",
                table: "PokemonCategoryDbClt",
                column: "CategoryId",
                principalTable: "CategoryDbClt",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PokemonCategoryDbClt_PokemonDbClt_PokemonId",
                table: "PokemonCategoryDbClt",
                column: "PokemonId",
                principalTable: "PokemonDbClt",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PokemonOwnerDbClt_OwnerDbClt_OwnerId",
                table: "PokemonOwnerDbClt",
                column: "OwnerId",
                principalTable: "OwnerDbClt",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PokemonOwnerDbClt_PokemonDbClt_PokemonId",
                table: "PokemonOwnerDbClt",
                column: "PokemonId",
                principalTable: "PokemonDbClt",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReviewDbClt_PokemonDbClt_PokemonId",
                table: "ReviewDbClt",
                column: "PokemonId",
                principalTable: "PokemonDbClt",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReviewDbClt_ReviewerDbClt_ReviewerId",
                table: "ReviewDbClt",
                column: "ReviewerId",
                principalTable: "ReviewerDbClt",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
