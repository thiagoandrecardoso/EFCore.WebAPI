using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCore.WebAPI.Migrations
{
    public partial class HeroBattle_Identity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Heros_Battles_BattleId",
                table: "Heros");

            migrationBuilder.DropIndex(
                name: "IX_Heros_BattleId",
                table: "Heros");

            migrationBuilder.DropColumn(
                name: "BattleId",
                table: "Heros");

            migrationBuilder.CreateTable(
                name: "HeroBattleMtoM",
                columns: table => new
                {
                    HeroId = table.Column<int>(type: "int", nullable: false),
                    BattleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeroBattleMtoM", x => new { x.BattleId, x.HeroId });
                    table.ForeignKey(
                        name: "FK_HeroBattleMtoM_Battles_BattleId",
                        column: x => x.BattleId,
                        principalTable: "Battles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HeroBattleMtoM_Heros_HeroId",
                        column: x => x.HeroId,
                        principalTable: "Heros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SecretIdentity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RealName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeroId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecretIdentity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SecretIdentity_Heros_HeroId",
                        column: x => x.HeroId,
                        principalTable: "Heros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HeroBattleMtoM_HeroId",
                table: "HeroBattleMtoM",
                column: "HeroId");

            migrationBuilder.CreateIndex(
                name: "IX_SecretIdentity_HeroId",
                table: "SecretIdentity",
                column: "HeroId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HeroBattleMtoM");

            migrationBuilder.DropTable(
                name: "SecretIdentity");

            migrationBuilder.AddColumn<int>(
                name: "BattleId",
                table: "Heros",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Heros_BattleId",
                table: "Heros",
                column: "BattleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Heros_Battles_BattleId",
                table: "Heros",
                column: "BattleId",
                principalTable: "Battles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}