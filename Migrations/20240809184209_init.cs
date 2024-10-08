﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace XitiqueAPI.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ClientId = table.Column<Guid>(type: "uuid", nullable: false),
                    TotalDays = table.Column<int>(type: "integer", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Location = table.Column<string>(type: "text", nullable: false),
                    DailyAmount = table.Column<decimal>(type: "numeric", nullable: false),
                    TotalAvailable = table.Column<decimal>(type: "numeric", nullable: false),
                    TotalDebt = table.Column<decimal>(type: "numeric", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false),
                    RegistryDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ClientId);
                });

            migrationBuilder.CreateTable(
                name: "DailyDeposits",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    DailyAccumulated = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyDeposits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TotalAllClientsBalances",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    TotalAvailable = table.Column<decimal>(type: "numeric", nullable: false),
                    TotalDebt = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TotalAllClientsBalances", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TotalDailyDeposits",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Amount = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TotalDailyDeposits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    TransactionId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClientID = table.Column<Guid>(type: "uuid", nullable: false),
                    ClientAmount = table.Column<decimal>(type: "numeric", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.TransactionId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "DailyDeposits");

            migrationBuilder.DropTable(
                name: "TotalAllClientsBalances");

            migrationBuilder.DropTable(
                name: "TotalDailyDeposits");

            migrationBuilder.DropTable(
                name: "Transactions");
        }
    }
}
