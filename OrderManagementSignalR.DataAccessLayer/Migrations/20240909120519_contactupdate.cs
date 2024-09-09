﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrderManagementSignalR.DataAccessLayer.Migrations
{
    public partial class contactupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FooterDescription",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FooterDescription",
                table: "Contacts");
        }
    }
}
