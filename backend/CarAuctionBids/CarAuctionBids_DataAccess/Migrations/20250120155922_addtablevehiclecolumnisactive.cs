﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarAuctionBids_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addtablevehiclecolumnisactive : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Vehicles",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Vehicles");
        }
    }
}
