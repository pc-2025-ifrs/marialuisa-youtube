using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace trab1.Migrations
{
    /// <inheritdoc />
    public partial class SimplifyModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Musics_MusicId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Musics_Channels_ChannelId",
                table: "Musics");

            migrationBuilder.DropIndex(
                name: "IX_Musics_ChannelId",
                table: "Musics");

            migrationBuilder.DropIndex(
                name: "IX_Comments_MusicId",
                table: "Comments");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Musics_ChannelId",
                table: "Musics",
                column: "ChannelId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_MusicId",
                table: "Comments",
                column: "MusicId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Musics_MusicId",
                table: "Comments",
                column: "MusicId",
                principalTable: "Musics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Musics_Channels_ChannelId",
                table: "Musics",
                column: "ChannelId",
                principalTable: "Channels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
