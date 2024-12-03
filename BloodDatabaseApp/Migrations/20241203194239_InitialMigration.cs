using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BloodDatabaseApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BloodTypes",
                columns: table => new
                {
                    BloodTypeID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BloodTypeName = table.Column<string>(type: "TEXT", nullable: false),
                    ABO = table.Column<string>(type: "TEXT", nullable: false),
                    Resus = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BloodTypes", x => x.BloodTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    PatientID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PatientName = table.Column<string>(type: "TEXT", nullable: false),
                    PatientGender = table.Column<string>(type: "TEXT", nullable: false),
                    BloodTypeID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.PatientID);
                    table.ForeignKey(
                        name: "FK_Patients_BloodTypes_BloodTypeID",
                        column: x => x.BloodTypeID,
                        principalTable: "BloodTypes",
                        principalColumn: "BloodTypeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Records",
                columns: table => new
                {
                    RecordID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PatientID = table.Column<int>(type: "INTEGER", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false),
                    DateTime = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Records", x => x.RecordID);
                    table.ForeignKey(
                        name: "FK_Records_Patients_PatientID",
                        column: x => x.PatientID,
                        principalTable: "Patients",
                        principalColumn: "PatientID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "BloodTypes",
                columns: new[] { "BloodTypeID", "ABO", "BloodTypeName", "Resus" },
                values: new object[,]
                {
                    { 1, "0", "1-", false },
                    { 2, "0", "1+", true },
                    { 3, "A", "2-", false },
                    { 4, "A", "2+", true },
                    { 5, "B", "3-", false },
                    { 6, "B", "3+", true },
                    { 7, "AB", "4-", false },
                    { 8, "AB", "4+", true }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "PatientID", "BloodTypeID", "PatientGender", "PatientName" },
                values: new object[,]
                {
                    { 1, 1, "Male", "Alex Smith" },
                    { 2, 2, "Female", "Jenna Johnson" },
                    { 3, 1, "Female", "Hanna Williams" },
                    { 4, 7, "Male", "Mike Brown" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Patients_BloodTypeID",
                table: "Patients",
                column: "BloodTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Records_PatientID",
                table: "Records",
                column: "PatientID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Records");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "BloodTypes");
        }
    }
}
