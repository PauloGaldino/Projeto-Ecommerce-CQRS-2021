using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ecommerce.Infra.CrossCotting.Identity.Migrations
{
    public partial class Alter_Table_Name_IDentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserRoles",
                table: "AspNetUserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims");

            migrationBuilder.RenameTable(
                name: "AspNetUserTokens",
                newName: "UsuarioTokens_Identity");

            migrationBuilder.RenameTable(
                name: "AspNetUserRoles",
                newName: "UsuarioFuncao_Identity");

            migrationBuilder.RenameTable(
                name: "AspNetUserLogins",
                newName: "UsuarioLogins_Identity");

            migrationBuilder.RenameTable(
                name: "AspNetUserClaims",
                newName: "UsuarioDeclaracao_Identity");

            migrationBuilder.RenameTable(
                name: "AspNetRoles",
                newName: "Funcao_Identity");

            migrationBuilder.RenameTable(
                name: "AspNetRoleClaims",
                newName: "FuncaoDeclaracao_Identity");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "UsuarioFuncao_Identity",
                newName: "IX_UsuarioFuncao_Identity_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "UsuarioLogins_Identity",
                newName: "IX_UsuarioLogins_Identity_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "UsuarioDeclaracao_Identity",
                newName: "IX_UsuarioDeclaracao_Identity_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "FuncaoDeclaracao_Identity",
                newName: "IX_FuncaoDeclaracao_Identity_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsuarioTokens_Identity",
                table: "UsuarioTokens_Identity",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsuarioFuncao_Identity",
                table: "UsuarioFuncao_Identity",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsuarioLogins_Identity",
                table: "UsuarioLogins_Identity",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsuarioDeclaracao_Identity",
                table: "UsuarioDeclaracao_Identity",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Funcao_Identity",
                table: "Funcao_Identity",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FuncaoDeclaracao_Identity",
                table: "FuncaoDeclaracao_Identity",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Usuario_Identity",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario_Identity", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_FuncaoDeclaracao_Identity_Funcao_Identity_RoleId",
                table: "FuncaoDeclaracao_Identity",
                column: "RoleId",
                principalTable: "Funcao_Identity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioDeclaracao_Identity_AspNetUsers_UserId",
                table: "UsuarioDeclaracao_Identity",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioFuncao_Identity_AspNetUsers_UserId",
                table: "UsuarioFuncao_Identity",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioFuncao_Identity_Funcao_Identity_RoleId",
                table: "UsuarioFuncao_Identity",
                column: "RoleId",
                principalTable: "Funcao_Identity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioLogins_Identity_AspNetUsers_UserId",
                table: "UsuarioLogins_Identity",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioTokens_Identity_AspNetUsers_UserId",
                table: "UsuarioTokens_Identity",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FuncaoDeclaracao_Identity_Funcao_Identity_RoleId",
                table: "FuncaoDeclaracao_Identity");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioDeclaracao_Identity_AspNetUsers_UserId",
                table: "UsuarioDeclaracao_Identity");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioFuncao_Identity_AspNetUsers_UserId",
                table: "UsuarioFuncao_Identity");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioFuncao_Identity_Funcao_Identity_RoleId",
                table: "UsuarioFuncao_Identity");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioLogins_Identity_AspNetUsers_UserId",
                table: "UsuarioLogins_Identity");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioTokens_Identity_AspNetUsers_UserId",
                table: "UsuarioTokens_Identity");

            migrationBuilder.DropTable(
                name: "Usuario_Identity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UsuarioTokens_Identity",
                table: "UsuarioTokens_Identity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UsuarioLogins_Identity",
                table: "UsuarioLogins_Identity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UsuarioFuncao_Identity",
                table: "UsuarioFuncao_Identity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UsuarioDeclaracao_Identity",
                table: "UsuarioDeclaracao_Identity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FuncaoDeclaracao_Identity",
                table: "FuncaoDeclaracao_Identity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Funcao_Identity",
                table: "Funcao_Identity");

            migrationBuilder.RenameTable(
                name: "UsuarioTokens_Identity",
                newName: "AspNetUserTokens");

            migrationBuilder.RenameTable(
                name: "UsuarioLogins_Identity",
                newName: "AspNetUserLogins");

            migrationBuilder.RenameTable(
                name: "UsuarioFuncao_Identity",
                newName: "AspNetUserRoles");

            migrationBuilder.RenameTable(
                name: "UsuarioDeclaracao_Identity",
                newName: "AspNetUserClaims");

            migrationBuilder.RenameTable(
                name: "FuncaoDeclaracao_Identity",
                newName: "AspNetRoleClaims");

            migrationBuilder.RenameTable(
                name: "Funcao_Identity",
                newName: "AspNetRoles");

            migrationBuilder.RenameIndex(
                name: "IX_UsuarioLogins_Identity_UserId",
                table: "AspNetUserLogins",
                newName: "IX_AspNetUserLogins_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UsuarioFuncao_Identity_RoleId",
                table: "AspNetUserRoles",
                newName: "IX_AspNetUserRoles_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_UsuarioDeclaracao_Identity_UserId",
                table: "AspNetUserClaims",
                newName: "IX_AspNetUserClaims_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_FuncaoDeclaracao_Identity_RoleId",
                table: "AspNetRoleClaims",
                newName: "IX_AspNetRoleClaims_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserRoles",
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
