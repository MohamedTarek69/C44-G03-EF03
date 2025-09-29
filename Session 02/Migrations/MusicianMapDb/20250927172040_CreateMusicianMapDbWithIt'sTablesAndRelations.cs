using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Session_02.Migrations.MusicianMapDb
{
    /// <inheritdoc />
    public partial class CreateMusicianMapDbWithItsTablesAndRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Instruments",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instruments", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Musicians",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false),
                    Ph_Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musicians", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Songs",
                columns: table => new
                {
                    Tittle = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Songs", x => x.Tittle);
                });

            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tittle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Mus_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Albums_Musicians_Mus_Id",
                        column: x => x.Mus_Id,
                        principalTable: "Musicians",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MusInstruments",
                columns: table => new
                {
                    Mus_Id = table.Column<int>(type: "int", nullable: false),
                    Inst_Name = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusInstruments", x => new { x.Mus_Id, x.Inst_Name });
                    table.ForeignKey(
                        name: "FK_MusInstruments_Instruments_Inst_Name",
                        column: x => x.Inst_Name,
                        principalTable: "Instruments",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MusInstruments_Musicians_Mus_Id",
                        column: x => x.Mus_Id,
                        principalTable: "Musicians",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MusSongs",
                columns: table => new
                {
                    Mus_Id = table.Column<int>(type: "int", nullable: false),
                    Song_Tittle = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusSongs", x => new { x.Mus_Id, x.Song_Tittle });
                    table.ForeignKey(
                        name: "FK_MusSongs_Musicians_Mus_Id",
                        column: x => x.Mus_Id,
                        principalTable: "Musicians",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MusSongs_Songs_Song_Tittle",
                        column: x => x.Song_Tittle,
                        principalTable: "Songs",
                        principalColumn: "Tittle",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AlbumSongs",
                columns: table => new
                {
                    Song_Title = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Album_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlbumSongs", x => x.Song_Title);
                    table.ForeignKey(
                        name: "FK_AlbumSongs_Albums_Album_Id",
                        column: x => x.Album_Id,
                        principalTable: "Albums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AlbumSongs_Songs_Song_Title",
                        column: x => x.Song_Title,
                        principalTable: "Songs",
                        principalColumn: "Tittle",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Albums_Mus_Id",
                table: "Albums",
                column: "Mus_Id");

            migrationBuilder.CreateIndex(
                name: "IX_AlbumSongs_Album_Id",
                table: "AlbumSongs",
                column: "Album_Id");

            migrationBuilder.CreateIndex(
                name: "IX_MusInstruments_Inst_Name",
                table: "MusInstruments",
                column: "Inst_Name");

            migrationBuilder.CreateIndex(
                name: "IX_MusSongs_Song_Tittle",
                table: "MusSongs",
                column: "Song_Tittle");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlbumSongs");

            migrationBuilder.DropTable(
                name: "MusInstruments");

            migrationBuilder.DropTable(
                name: "MusSongs");

            migrationBuilder.DropTable(
                name: "Albums");

            migrationBuilder.DropTable(
                name: "Instruments");

            migrationBuilder.DropTable(
                name: "Songs");

            migrationBuilder.DropTable(
                name: "Musicians");
        }
    }
}
