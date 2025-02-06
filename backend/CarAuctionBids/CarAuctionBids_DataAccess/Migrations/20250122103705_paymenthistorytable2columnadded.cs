using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarAuctionBids_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class paymenthistorytable2columnadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ClientSecret",
                table: "PaymentHistories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "StripePaymentIntentId",
                table: "PaymentHistories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 3, 11, 13, 37, 2, 62, DateTimeKind.Local).AddTicks(1529), new DateTime(2025, 1, 22, 13, 37, 2, 62, DateTimeKind.Local).AddTicks(1514) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 2, 15, 13, 37, 2, 62, DateTimeKind.Local).AddTicks(1538), new DateTime(2025, 1, 22, 13, 37, 2, 62, DateTimeKind.Local).AddTicks(1537) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 4, 13, 37, 2, 62, DateTimeKind.Local).AddTicks(1543), new DateTime(2025, 1, 22, 13, 37, 2, 62, DateTimeKind.Local).AddTicks(1542) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 4,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 3, 11, 13, 37, 2, 62, DateTimeKind.Local).AddTicks(1548), new DateTime(2025, 1, 22, 13, 37, 2, 62, DateTimeKind.Local).AddTicks(1547) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 5,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 4, 13, 37, 2, 62, DateTimeKind.Local).AddTicks(1553), new DateTime(2025, 1, 22, 13, 37, 2, 62, DateTimeKind.Local).AddTicks(1552) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 6,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 3, 11, 13, 37, 2, 62, DateTimeKind.Local).AddTicks(1558), new DateTime(2025, 1, 22, 13, 37, 2, 62, DateTimeKind.Local).AddTicks(1557) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 7,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 4, 13, 37, 2, 62, DateTimeKind.Local).AddTicks(1563), new DateTime(2025, 1, 22, 13, 37, 2, 62, DateTimeKind.Local).AddTicks(1562) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 8,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 3, 11, 13, 37, 2, 62, DateTimeKind.Local).AddTicks(1573), new DateTime(2025, 1, 22, 13, 37, 2, 62, DateTimeKind.Local).AddTicks(1573) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 9,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 4, 13, 37, 2, 62, DateTimeKind.Local).AddTicks(1578), new DateTime(2025, 1, 22, 13, 37, 2, 62, DateTimeKind.Local).AddTicks(1577) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 10,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 3, 11, 13, 37, 2, 62, DateTimeKind.Local).AddTicks(1638), new DateTime(2025, 1, 22, 13, 37, 2, 62, DateTimeKind.Local).AddTicks(1637) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 11,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 4, 13, 37, 2, 62, DateTimeKind.Local).AddTicks(1643), new DateTime(2025, 1, 22, 13, 37, 2, 62, DateTimeKind.Local).AddTicks(1642) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 12,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 3, 11, 13, 37, 2, 62, DateTimeKind.Local).AddTicks(1648), new DateTime(2025, 1, 22, 13, 37, 2, 62, DateTimeKind.Local).AddTicks(1647) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 13,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 4, 13, 37, 2, 62, DateTimeKind.Local).AddTicks(1652), new DateTime(2025, 1, 22, 13, 37, 2, 62, DateTimeKind.Local).AddTicks(1652) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 14,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 3, 11, 13, 37, 2, 62, DateTimeKind.Local).AddTicks(1657), new DateTime(2025, 1, 22, 13, 37, 2, 62, DateTimeKind.Local).AddTicks(1656) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 15,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 4, 13, 37, 2, 62, DateTimeKind.Local).AddTicks(1662), new DateTime(2025, 1, 22, 13, 37, 2, 62, DateTimeKind.Local).AddTicks(1661) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 16,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 4, 13, 37, 2, 62, DateTimeKind.Local).AddTicks(1667), new DateTime(2025, 1, 22, 13, 37, 2, 62, DateTimeKind.Local).AddTicks(1666) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 17,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 3, 11, 13, 37, 2, 62, DateTimeKind.Local).AddTicks(1672), new DateTime(2025, 1, 22, 13, 37, 2, 62, DateTimeKind.Local).AddTicks(1671) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 18,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 4, 13, 37, 2, 62, DateTimeKind.Local).AddTicks(1677), new DateTime(2025, 1, 22, 13, 37, 2, 62, DateTimeKind.Local).AddTicks(1676) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 19,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 3, 11, 13, 37, 2, 62, DateTimeKind.Local).AddTicks(1681), new DateTime(2025, 1, 22, 13, 37, 2, 62, DateTimeKind.Local).AddTicks(1681) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 20,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 4, 13, 37, 2, 62, DateTimeKind.Local).AddTicks(1686), new DateTime(2025, 1, 22, 13, 37, 2, 62, DateTimeKind.Local).AddTicks(1686) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 21,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 3, 11, 13, 37, 2, 62, DateTimeKind.Local).AddTicks(1691), new DateTime(2025, 1, 22, 13, 37, 2, 62, DateTimeKind.Local).AddTicks(1690) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClientSecret",
                table: "PaymentHistories");

            migrationBuilder.DropColumn(
                name: "StripePaymentIntentId",
                table: "PaymentHistories");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 3, 10, 15, 3, 53, 235, DateTimeKind.Local).AddTicks(7011), new DateTime(2025, 1, 21, 15, 3, 53, 235, DateTimeKind.Local).AddTicks(6996) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 2, 14, 15, 3, 53, 235, DateTimeKind.Local).AddTicks(7022), new DateTime(2025, 1, 21, 15, 3, 53, 235, DateTimeKind.Local).AddTicks(7021) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 3, 15, 3, 53, 235, DateTimeKind.Local).AddTicks(7027), new DateTime(2025, 1, 21, 15, 3, 53, 235, DateTimeKind.Local).AddTicks(7026) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 4,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 3, 10, 15, 3, 53, 235, DateTimeKind.Local).AddTicks(7032), new DateTime(2025, 1, 21, 15, 3, 53, 235, DateTimeKind.Local).AddTicks(7031) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 5,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 3, 15, 3, 53, 235, DateTimeKind.Local).AddTicks(7037), new DateTime(2025, 1, 21, 15, 3, 53, 235, DateTimeKind.Local).AddTicks(7036) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 6,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 3, 10, 15, 3, 53, 235, DateTimeKind.Local).AddTicks(7042), new DateTime(2025, 1, 21, 15, 3, 53, 235, DateTimeKind.Local).AddTicks(7041) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 7,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 3, 15, 3, 53, 235, DateTimeKind.Local).AddTicks(7046), new DateTime(2025, 1, 21, 15, 3, 53, 235, DateTimeKind.Local).AddTicks(7046) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 8,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 3, 10, 15, 3, 53, 235, DateTimeKind.Local).AddTicks(7051), new DateTime(2025, 1, 21, 15, 3, 53, 235, DateTimeKind.Local).AddTicks(7050) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 9,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 3, 15, 3, 53, 235, DateTimeKind.Local).AddTicks(7056), new DateTime(2025, 1, 21, 15, 3, 53, 235, DateTimeKind.Local).AddTicks(7055) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 10,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 3, 10, 15, 3, 53, 235, DateTimeKind.Local).AddTicks(7061), new DateTime(2025, 1, 21, 15, 3, 53, 235, DateTimeKind.Local).AddTicks(7060) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 11,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 3, 15, 3, 53, 235, DateTimeKind.Local).AddTicks(7067), new DateTime(2025, 1, 21, 15, 3, 53, 235, DateTimeKind.Local).AddTicks(7066) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 12,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 3, 10, 15, 3, 53, 235, DateTimeKind.Local).AddTicks(7072), new DateTime(2025, 1, 21, 15, 3, 53, 235, DateTimeKind.Local).AddTicks(7072) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 13,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 3, 15, 3, 53, 235, DateTimeKind.Local).AddTicks(7077), new DateTime(2025, 1, 21, 15, 3, 53, 235, DateTimeKind.Local).AddTicks(7076) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 14,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 3, 10, 15, 3, 53, 235, DateTimeKind.Local).AddTicks(7082), new DateTime(2025, 1, 21, 15, 3, 53, 235, DateTimeKind.Local).AddTicks(7081) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 15,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 3, 15, 3, 53, 235, DateTimeKind.Local).AddTicks(7087), new DateTime(2025, 1, 21, 15, 3, 53, 235, DateTimeKind.Local).AddTicks(7086) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 16,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 3, 15, 3, 53, 235, DateTimeKind.Local).AddTicks(7091), new DateTime(2025, 1, 21, 15, 3, 53, 235, DateTimeKind.Local).AddTicks(7090) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 17,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 3, 10, 15, 3, 53, 235, DateTimeKind.Local).AddTicks(7096), new DateTime(2025, 1, 21, 15, 3, 53, 235, DateTimeKind.Local).AddTicks(7095) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 18,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 3, 15, 3, 53, 235, DateTimeKind.Local).AddTicks(7101), new DateTime(2025, 1, 21, 15, 3, 53, 235, DateTimeKind.Local).AddTicks(7100) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 19,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 3, 10, 15, 3, 53, 235, DateTimeKind.Local).AddTicks(7105), new DateTime(2025, 1, 21, 15, 3, 53, 235, DateTimeKind.Local).AddTicks(7105) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 20,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 3, 15, 3, 53, 235, DateTimeKind.Local).AddTicks(7110), new DateTime(2025, 1, 21, 15, 3, 53, 235, DateTimeKind.Local).AddTicks(7109) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 21,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 3, 10, 15, 3, 53, 235, DateTimeKind.Local).AddTicks(7115), new DateTime(2025, 1, 21, 15, 3, 53, 235, DateTimeKind.Local).AddTicks(7114) });
        }
    }
}
