﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.SqliteDB.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "processingGoodExportOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    orderId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_processingGoodExportOrders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdProduct = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "formulaListGoodIssues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductId = table.Column<string>(type: "TEXT", nullable: false),
                    ProductName = table.Column<string>(type: "TEXT", nullable: false),
                    PlannedMass = table.Column<string>(type: "TEXT", nullable: false),
                    PlannedQuantity = table.Column<string>(type: "TEXT", nullable: false),
                    Actual = table.Column<string>(type: "TEXT", nullable: true),
                    ProcessingGoodExportOrderId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_formulaListGoodIssues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_formulaListGoodIssues_processingGoodExportOrders_ProcessingGoodExportOrderId",
                        column: x => x.ProcessingGoodExportOrderId,
                        principalTable: "processingGoodExportOrders",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "issueBasketLists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProcessingGoodExportOrderId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_issueBasketLists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_issueBasketLists_processingGoodExportOrders_ProcessingGoodExportOrderId",
                        column: x => x.ProcessingGoodExportOrderId,
                        principalTable: "processingGoodExportOrders",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "issueBaskets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BasketId = table.Column<string>(type: "TEXT", nullable: false),
                    ProductionDate = table.Column<string>(type: "TEXT", nullable: false),
                    Quantity = table.Column<string>(type: "TEXT", nullable: false),
                    Mass = table.Column<string>(type: "TEXT", nullable: false),
                    Actual = table.Column<string>(type: "TEXT", nullable: true),
                    IsChecked = table.Column<bool>(type: "INTEGER", nullable: true),
                    IssueBasketListId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_issueBaskets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_issueBaskets_issueBasketLists_IssueBasketListId",
                        column: x => x.IssueBasketListId,
                        principalTable: "issueBasketLists",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_formulaListGoodIssues_ProcessingGoodExportOrderId",
                table: "formulaListGoodIssues",
                column: "ProcessingGoodExportOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_issueBasketLists_ProcessingGoodExportOrderId",
                table: "issueBasketLists",
                column: "ProcessingGoodExportOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_issueBaskets_IssueBasketListId",
                table: "issueBaskets",
                column: "IssueBasketListId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "formulaListGoodIssues");

            migrationBuilder.DropTable(
                name: "issueBaskets");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "issueBasketLists");

            migrationBuilder.DropTable(
                name: "processingGoodExportOrders");
        }
    }
}
