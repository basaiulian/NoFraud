using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PaymentManagement.Data.Migrations
{
    public partial class Create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    cvvCode = table.Column<string>(type: "string", nullable: true),
                    owner_id = table.Column<string>(type: "string", nullable: true),
                    bank_name = table.Column<string>(type: "string", nullable: true),
                    bank_account_id = table.Column<string>(type: "string", nullable: true),
                    BankAccountId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Card", x => x.id);
                    table.ForeignKey(
                        name: "FK_Card_BankAccount_BankAccountId1",
                        column: x => x.BankAccountId1,
                        principalTable: "BankAccount",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BankAccount_user_id",
                table: "BankAccount",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_Card_BankAccountId1",
                table: "Card",
                column: "BankAccountId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Card");

            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "BankAccount");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
