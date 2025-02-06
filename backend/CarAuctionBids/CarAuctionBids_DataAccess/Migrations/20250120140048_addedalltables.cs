using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarAuctionBids_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addedalltables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProfilePicture",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    VehicleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandAndModel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ManufacturingYear = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EngineCapacity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Millage = table.Column<int>(type: "int", nullable: false),
                    PlateNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuctionPrice = table.Column<double>(type: "float", nullable: false),
                    AdditionalInformation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SellerId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.VehicleId);
                    table.ForeignKey(
                        name: "FK_Vehicles_AspNetUsers_SellerId",
                        column: x => x.SellerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bids",
                columns: table => new
                {
                    BidId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BidAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BidDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BidStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    VehicleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bids", x => x.BidId);
                    table.ForeignKey(
                        name: "FK_Bids_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Bids_Vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicles",
                        principalColumn: "VehicleId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "PaymentHistories",
                columns: table => new
                {
                    PaymentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    PayDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    VehicleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentHistories", x => x.PaymentId);
                    table.ForeignKey(
                        name: "FK_PaymentHistories_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaymentHistories_Vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicles",
                        principalColumn: "VehicleId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bids_UserId",
                table: "Bids",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Bids_VehicleId",
                table: "Bids",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentHistories_UserId",
                table: "PaymentHistories",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentHistories_VehicleId",
                table: "PaymentHistories",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_SellerId",
                table: "Vehicles",
                column: "SellerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bids");

            migrationBuilder.DropTable(
                name: "PaymentHistories");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ProfilePicture",
                table: "AspNetUsers");
        }
    }
}
