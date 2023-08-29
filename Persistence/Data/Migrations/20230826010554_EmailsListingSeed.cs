using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Beta_Tescat_0._1.Migrations
{
    /// <inheritdoc />
    public partial class EmailsListingSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserEmail",
                table: "UserEmails",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.InsertData(
                table: "UserEmails",
                columns: new[] { "Id", "UserEmail", "UserId" },
                values: new object[,]
                {
                    { 1, "gastos.ens@grupoaceves.com", 1 },
                    { 2, "m.ramirez@grupoaceves.com", 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserEmails",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserEmails",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<long>(
                name: "UserEmail",
                table: "UserEmails",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
