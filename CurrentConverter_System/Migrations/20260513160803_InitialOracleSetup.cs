using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CurrentConverter_System.Migrations
{
    /// <inheritdoc />
    public partial class InitialOracleSetup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Conversions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Amount = table.Column<decimal>(type: "DECIMAL(18, 2)", nullable: false),
                    FromCurrency = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    ToCurrency = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Result = table.Column<decimal>(type: "DECIMAL(18, 2)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conversions", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Conversions");
        }
    }
}
