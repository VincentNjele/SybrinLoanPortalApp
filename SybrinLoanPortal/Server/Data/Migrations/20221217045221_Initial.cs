using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SybrinLoanPortal.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClientDoc",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductTypeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientDoc", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClientDoc_ProductType_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "ProductType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Loan",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    GrossAmount = table.Column<double>(type: "float", nullable: false),
                    NetAmount = table.Column<double>(type: "float", nullable: false),
                    FixedAmount = table.Column<double>(type: "float", nullable: false),
                    PaymentPeriod = table.Column<int>(type: "int", nullable: false),
                    Interest = table.Column<int>(type: "int", nullable: false),
                    ClientDocId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Loan_ClientDoc_ClientDocId",
                        column: x => x.ClientDocId,
                        principalTable: "ClientDoc",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "ProductType",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Loan Account" },
                    { 2, "Cheque Account" },
                    { 3, "Savings Account" }
                });

            migrationBuilder.InsertData(
                table: "ClientDoc",
                columns: new[] { "Id", "CountryOfBirth", "FirstName", "Gender", "LastName", "Nationality", "ProductTypeId", "Status" },
                values: new object[,]
                {
                    { 1, "Zambia", "Vincent", "Male", "Njele", "Zambian", 1, "Active" },
                    { 2, "Zambia", "Sarah", "Female", "Njele", "Zambian", 1, "Active" },
                    { 3, "Zambia", "Muze", "Male", "Oda", "Zambian", 1, "Active" },
                    { 4, "Zambia", "Faith", "Female", "Kabandula", "Zambian", 1, "Active" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClientDoc_ProductTypeId",
                table: "ClientDoc",
                column: "ProductTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Loan_ClientDocId",
                table: "Loan",
                column: "ClientDocId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Loan");

            migrationBuilder.DropTable(
                name: "ClientDoc");

            migrationBuilder.DropTable(
                name: "ProductType");
        }
    }
}
