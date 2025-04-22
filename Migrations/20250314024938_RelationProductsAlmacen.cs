using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiPOS.Migrations
{
    /// <inheritdoc />
    public partial class RelationProductsAlmacen : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AlmacenId",
                table: "Productos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Productos_AlmacenId",
                table: "Productos",
                column: "AlmacenId");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Almacenes_AlmacenId",
                table: "Productos",
                column: "AlmacenId",
                principalTable: "Almacenes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Almacenes_AlmacenId",
                table: "Productos");

            migrationBuilder.DropIndex(
                name: "IX_Productos_AlmacenId",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "AlmacenId",
                table: "Productos");
        }
    }
}
