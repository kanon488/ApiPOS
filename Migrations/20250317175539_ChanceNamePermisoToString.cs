using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiPOS.Migrations
{
    /// <inheritdoc />
    public partial class ChanceNamePermisoToString : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PermisoId1",
                table: "RolPermisos",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Permisos",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 50);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_Email",
                table: "Usuarios",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RolPermisos_PermisoId1",
                table: "RolPermisos",
                column: "PermisoId1");

            migrationBuilder.AddForeignKey(
                name: "FK_RolPermisos_Permisos_PermisoId1",
                table: "RolPermisos",
                column: "PermisoId1",
                principalTable: "Permisos",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RolPermisos_Permisos_PermisoId1",
                table: "RolPermisos");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_Email",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_RolPermisos_PermisoId1",
                table: "RolPermisos");

            migrationBuilder.DropColumn(
                name: "PermisoId1",
                table: "RolPermisos");

            migrationBuilder.AlterColumn<int>(
                name: "Nombre",
                table: "Permisos",
                type: "int",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);
        }
    }
}
