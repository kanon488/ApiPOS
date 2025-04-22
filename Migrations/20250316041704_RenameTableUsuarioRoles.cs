using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiPOS.Migrations
{
    /// <inheritdoc />
    public partial class RenameTableUsuarioRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_usuarioRoles_Roles_RolId",
                table: "usuarioRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_usuarioRoles_Usuarios_UsuarioId",
                table: "usuarioRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_usuarioRoles",
                table: "usuarioRoles");

            migrationBuilder.RenameTable(
                name: "usuarioRoles",
                newName: "UsuarioRoles");

            migrationBuilder.RenameIndex(
                name: "IX_usuarioRoles_RolId",
                table: "UsuarioRoles",
                newName: "IX_UsuarioRoles_RolId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsuarioRoles",
                table: "UsuarioRoles",
                columns: new[] { "UsuarioId", "RolId" });

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioRoles_Roles_RolId",
                table: "UsuarioRoles",
                column: "RolId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioRoles_Usuarios_UsuarioId",
                table: "UsuarioRoles",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioRoles_Roles_RolId",
                table: "UsuarioRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioRoles_Usuarios_UsuarioId",
                table: "UsuarioRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UsuarioRoles",
                table: "UsuarioRoles");

            migrationBuilder.RenameTable(
                name: "UsuarioRoles",
                newName: "usuarioRoles");

            migrationBuilder.RenameIndex(
                name: "IX_UsuarioRoles_RolId",
                table: "usuarioRoles",
                newName: "IX_usuarioRoles_RolId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_usuarioRoles",
                table: "usuarioRoles",
                columns: new[] { "UsuarioId", "RolId" });

            migrationBuilder.AddForeignKey(
                name: "FK_usuarioRoles_Roles_RolId",
                table: "usuarioRoles",
                column: "RolId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_usuarioRoles_Usuarios_UsuarioId",
                table: "usuarioRoles",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
