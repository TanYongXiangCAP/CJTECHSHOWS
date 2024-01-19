using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CJTechShow.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddApplicationTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VendorPages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VendorID = table.Column<int>(type: "int", nullable: false),
                    VendorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VendorContactDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoothNumber = table.Column<int>(type: "int", nullable: false),
                    VendorDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Products = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SocialMedia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendorPages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Visitors",
                columns: table => new
                {
                    VisitorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VisitorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VisitorContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VisitorEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VisitorCompany = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visitors", x => x.VisitorID);
                });

            migrationBuilder.CreateTable(
                name: "Organizers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrganizerID = table.Column<int>(type: "int", nullable: false),
                    OrganizerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrganizerContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrganizerPosition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrganizerEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrganizerPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VendorIDId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Organizers_VendorPages_VendorIDId",
                        column: x => x.VendorIDId,
                        principalTable: "VendorPages",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Mains",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventID = table.Column<int>(type: "int", nullable: false),
                    EventName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EventDuration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EventLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EventDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EventTicketPrice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EventContactInformation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EventRegistration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrganizerIDId = table.Column<int>(type: "int", nullable: true),
                    VendorIDId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mains", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mains_Organizers_OrganizerIDId",
                        column: x => x.OrganizerIDId,
                        principalTable: "Organizers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Mains_VendorPages_VendorIDId",
                        column: x => x.VendorIDId,
                        principalTable: "VendorPages",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SponsorPages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SponsorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SponsorContactInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EventIDId = table.Column<int>(type: "int", nullable: true),
                    OrganizerIDId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SponsorPages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SponsorPages_Mains_EventIDId",
                        column: x => x.EventIDId,
                        principalTable: "Mains",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SponsorPages_Organizers_OrganizerIDId",
                        column: x => x.OrganizerIDId,
                        principalTable: "Organizers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Mains_OrganizerIDId",
                table: "Mains",
                column: "OrganizerIDId");

            migrationBuilder.CreateIndex(
                name: "IX_Mains_VendorIDId",
                table: "Mains",
                column: "VendorIDId");

            migrationBuilder.CreateIndex(
                name: "IX_Organizers_VendorIDId",
                table: "Organizers",
                column: "VendorIDId");

            migrationBuilder.CreateIndex(
                name: "IX_SponsorPages_EventIDId",
                table: "SponsorPages",
                column: "EventIDId");

            migrationBuilder.CreateIndex(
                name: "IX_SponsorPages_OrganizerIDId",
                table: "SponsorPages",
                column: "OrganizerIDId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SponsorPages");

            migrationBuilder.DropTable(
                name: "Visitors");

            migrationBuilder.DropTable(
                name: "Mains");

            migrationBuilder.DropTable(
                name: "Organizers");

            migrationBuilder.DropTable(
                name: "VendorPages");
        }
    }
}
