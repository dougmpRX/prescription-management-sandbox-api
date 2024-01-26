using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace prescription_management_sandbox_api.Migrations
{
    /// <inheritdoc />
    public partial class PopulateMedicineTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DosageUnit",
                table: "Medicines",
                type: "character varying(2)",
                maxLength: 2,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Medicines",
                columns: new[] { "Id", "Category", "Dosage", "DosageUnit", "Name", "UsageDescription" },
                values: new object[] { 1, "WITHOUT_RETENTION", 500.0, "mg", "Dipirona", "Tomar 1 comprimido a cada 6 horas em caso de dor." });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "DosageUnit",
                table: "Medicines");
        }
    }
}
