using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BoatService.Web.Migrations
{
    public partial class added_triporderrequests : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TripOrderRequest",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    TripOrderId = table.Column<Guid>(nullable: true),
                    PersonId = table.Column<Guid>(nullable: true),
                    PlacesQty = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TripOrderRequest", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TripOrderRequest_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TripOrderRequest_TripOrders_TripOrderId",
                        column: x => x.TripOrderId,
                        principalTable: "TripOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TripOrderRequest_PersonId",
                table: "TripOrderRequest",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_TripOrderRequest_TripOrderId",
                table: "TripOrderRequest",
                column: "TripOrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TripOrderRequest");
        }
    }
}
