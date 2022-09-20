using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Economy.Domain.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    password = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    phone = table.Column<string>(type: "varchar(16)", unicode: false, maxLength: 16, nullable: true),
                    email = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userId = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    creation = table.Column<DateTime>(type: "date", nullable: false),
                    type = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.id);
                    table.ForeignKey(
                        name: "fk_user",
                        column: x => x.userId,
                        principalTable: "User",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Annuity",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    projectId = table.Column<int>(type: "int", nullable: false),
                    initial = table.Column<int>(type: "int", nullable: false),
                    end = table.Column<int>(type: "int", nullable: false),
                    payment = table.Column<decimal>(type: "decimal(9,2)", nullable: true),
                    present = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    future = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    type = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    flowType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    rate = table.Column<decimal>(type: "decimal(9,2)", nullable: false),
                    totalPeriod = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Annuity", x => x.id);
                    table.ForeignKey(
                        name: "fk_projects",
                        column: x => x.projectId,
                        principalTable: "Project",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Interest",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    projectId = table.Column<int>(type: "int", nullable: false),
                    initial = table.Column<int>(type: "int", nullable: false),
                    end = table.Column<int>(type: "int", nullable: false),
                    present = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    future = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    flowType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    rate = table.Column<decimal>(type: "decimal(9,2)", nullable: false),
                    payment = table.Column<decimal>(type: "decimal(9,2)", nullable: false),
                    totalPeriod = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interest", x => x.id);
                    table.ForeignKey(
                        name: "fk_projectss",
                        column: x => x.projectId,
                        principalTable: "Project",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Serie",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    projectId = table.Column<int>(type: "int", nullable: false),
                    initial = table.Column<int>(type: "int", nullable: false),
                    end = table.Column<int>(type: "int", nullable: false),
                    downPayment = table.Column<decimal>(type: "decimal(9,2)", nullable: true),
                    finalPayment = table.Column<decimal>(type: "decimal(9,2)", nullable: true),
                    quantity = table.Column<decimal>(type: "decimal(9,2)", nullable: false),
                    present = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    future = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    type = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    flowType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    rate = table.Column<decimal>(type: "decimal(9,2)", nullable: false),
                    incremental = table.Column<bool>(type: "bit", nullable: false),
                    totalPeriod = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Serie", x => x.id);
                    table.ForeignKey(
                        name: "fk_project",
                        column: x => x.projectId,
                        principalTable: "Project",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Annuity_projectId",
                table: "Annuity",
                column: "projectId");

            migrationBuilder.CreateIndex(
                name: "IX_Interest_projectId",
                table: "Interest",
                column: "projectId");

            migrationBuilder.CreateIndex(
                name: "IX_Project_userId",
                table: "Project",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_Serie_projectId",
                table: "Serie",
                column: "projectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Annuity");

            migrationBuilder.DropTable(
                name: "Interest");

            migrationBuilder.DropTable(
                name: "Serie");

            migrationBuilder.DropTable(
                name: "Project");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
