using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PaymentManagement.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    NickName = table.Column<string>(type: "TEXT", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    amount = table.Column<float>(type: "float", nullable: false),
                    currency = table.Column<string>(type: "string", nullable: true),
                    source_ = table.Column<string>(type: "string", nullable: true),
                    date_ = table.Column<DateTime>(type: "date", nullable: false),
                    destination = table.Column<string>(type: "string", nullable: true),
                    status = table.Column<string>(type: "string", nullable: true),
                    latitude = table.Column<float>(type: "float", nullable: false),
                    longitude = table.Column<float>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    username = table.Column<string>(type: "string", nullable: true),
                    password = table.Column<string>(type: "string", nullable: true),
                    email = table.Column<string>(type: "string", nullable: true),
                    phone_number = table.Column<string>(type: "string", nullable: true),
                    address = table.Column<string>(type: "string", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "BankAccount",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    token_id = table.Column<int>(type: "int", nullable: false),
                    balance = table.Column<double>(type: "double", nullable: false),
                    account_type = table.Column<string>(type: "string", nullable: true),
                    user_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankAccount", x => x.id);
                    table.ForeignKey(
                        name: "FK_BankAccount_User_user_id",
                        column: x => x.user_id,
                        principalTable: "User",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Card",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    number = table.Column<string>(type: "string", nullable: true),
                    expiration_date = table.Column<DateTime>(type: "DateTime", nullable: false),
                    pin_code = table.Column<string>(type: "string", nullable: true),
                    cvvCode = table.Column<int>(type: "string", nullable: false),
                    owner_id = table.Column<int>(type: "int", nullable: false),
                    bank_name = table.Column<string>(type: "string", nullable: true),
                    bank_account_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Card", x => x.id);
                    table.ForeignKey(
                        name: "FK_Card_BankAccount_bank_account_id",
                        column: x => x.bank_account_id,
                        principalTable: "BankAccount",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BankAccount_user_id",
                table: "BankAccount",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_Card_bank_account_id",
                table: "Card",
                column: "bank_account_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Card");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "BankAccount");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
