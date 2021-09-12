using Microsoft.EntityFrameworkCore.Migrations;

namespace GestaoT.I.Migrations
{
    public partial class GestaoV3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_chamadosContext_usuarioContext_usuariosnomeUsuarioid",
                table: "chamadosContext");

            migrationBuilder.DropForeignKey(
                name: "FK_solicitacoesContext_perifericosContext_perifericosSolicitacoesid",
                table: "solicitacoesContext");

            migrationBuilder.DropForeignKey(
                name: "FK_solicitacoesContext_usuarioContext_nomeUsuarioSolicitacoesid",
                table: "solicitacoesContext");

            migrationBuilder.DropPrimaryKey(
                name: "PK_solicitacoesContext",
                table: "solicitacoesContext");

            migrationBuilder.DropPrimaryKey(
                name: "PK_perifericosContext",
                table: "perifericosContext");

            migrationBuilder.DropPrimaryKey(
                name: "PK_chamadosContext",
                table: "chamadosContext");

            migrationBuilder.RenameTable(
                name: "solicitacoesContext",
                newName: "Solicitacoes");

            migrationBuilder.RenameTable(
                name: "perifericosContext",
                newName: "Perifericos");

            migrationBuilder.RenameTable(
                name: "chamadosContext",
                newName: "Chamado");

            migrationBuilder.RenameIndex(
                name: "IX_solicitacoesContext_perifericosSolicitacoesid",
                table: "Solicitacoes",
                newName: "IX_Solicitacoes_perifericosSolicitacoesid");

            migrationBuilder.RenameIndex(
                name: "IX_solicitacoesContext_nomeUsuarioSolicitacoesid",
                table: "Solicitacoes",
                newName: "IX_Solicitacoes_nomeUsuarioSolicitacoesid");

            migrationBuilder.RenameIndex(
                name: "IX_chamadosContext_usuariosnomeUsuarioid",
                table: "Chamado",
                newName: "IX_Chamado_usuariosnomeUsuarioid");

            migrationBuilder.AlterColumn<string>(
                name: "setorUsuario",
                table: "usuarioContext",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nomeUsuario",
                table: "usuarioContext",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "maquinaUsuario",
                table: "usuarioContext",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "usuarioContext",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nomePerifericos",
                table: "Perifericos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "especificacaoPerifericos",
                table: "Perifericos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "descricaoChamados",
                table: "Chamado",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Solicitacoes",
                table: "Solicitacoes",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Perifericos",
                table: "Perifericos",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Chamado",
                table: "Chamado",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Chamado_usuarioContext_usuariosnomeUsuarioid",
                table: "Chamado",
                column: "usuariosnomeUsuarioid",
                principalTable: "usuarioContext",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Solicitacoes_Perifericos_perifericosSolicitacoesid",
                table: "Solicitacoes",
                column: "perifericosSolicitacoesid",
                principalTable: "Perifericos",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Solicitacoes_usuarioContext_nomeUsuarioSolicitacoesid",
                table: "Solicitacoes",
                column: "nomeUsuarioSolicitacoesid",
                principalTable: "usuarioContext",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chamado_usuarioContext_usuariosnomeUsuarioid",
                table: "Chamado");

            migrationBuilder.DropForeignKey(
                name: "FK_Solicitacoes_Perifericos_perifericosSolicitacoesid",
                table: "Solicitacoes");

            migrationBuilder.DropForeignKey(
                name: "FK_Solicitacoes_usuarioContext_nomeUsuarioSolicitacoesid",
                table: "Solicitacoes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Solicitacoes",
                table: "Solicitacoes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Perifericos",
                table: "Perifericos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Chamado",
                table: "Chamado");

            migrationBuilder.DropColumn(
                name: "email",
                table: "usuarioContext");

            migrationBuilder.RenameTable(
                name: "Solicitacoes",
                newName: "solicitacoesContext");

            migrationBuilder.RenameTable(
                name: "Perifericos",
                newName: "perifericosContext");

            migrationBuilder.RenameTable(
                name: "Chamado",
                newName: "chamadosContext");

            migrationBuilder.RenameIndex(
                name: "IX_Solicitacoes_perifericosSolicitacoesid",
                table: "solicitacoesContext",
                newName: "IX_solicitacoesContext_perifericosSolicitacoesid");

            migrationBuilder.RenameIndex(
                name: "IX_Solicitacoes_nomeUsuarioSolicitacoesid",
                table: "solicitacoesContext",
                newName: "IX_solicitacoesContext_nomeUsuarioSolicitacoesid");

            migrationBuilder.RenameIndex(
                name: "IX_Chamado_usuariosnomeUsuarioid",
                table: "chamadosContext",
                newName: "IX_chamadosContext_usuariosnomeUsuarioid");

            migrationBuilder.AlterColumn<string>(
                name: "setorUsuario",
                table: "usuarioContext",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(12)",
                oldMaxLength: 12,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nomeUsuario",
                table: "usuarioContext",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "maquinaUsuario",
                table: "usuarioContext",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nomePerifericos",
                table: "perifericosContext",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "especificacaoPerifericos",
                table: "perifericosContext",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "descricaoChamados",
                table: "chamadosContext",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_solicitacoesContext",
                table: "solicitacoesContext",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_perifericosContext",
                table: "perifericosContext",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_chamadosContext",
                table: "chamadosContext",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_chamadosContext_usuarioContext_usuariosnomeUsuarioid",
                table: "chamadosContext",
                column: "usuariosnomeUsuarioid",
                principalTable: "usuarioContext",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_solicitacoesContext_perifericosContext_perifericosSolicitacoesid",
                table: "solicitacoesContext",
                column: "perifericosSolicitacoesid",
                principalTable: "perifericosContext",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_solicitacoesContext_usuarioContext_nomeUsuarioSolicitacoesid",
                table: "solicitacoesContext",
                column: "nomeUsuarioSolicitacoesid",
                principalTable: "usuarioContext",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
