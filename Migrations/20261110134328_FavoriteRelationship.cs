using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace back_end.Migrations
{
    /// <inheritdoc />
    public partial class FavoriteRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_PersonItems_DonorId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_PersonItems_RecipientId",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonItems",
                table: "PersonItems");

            migrationBuilder.RenameTable(
                name: "PersonItems",
                newName: "People");

            migrationBuilder.RenameColumn(
                name: "Donor",
                table: "ElectronicEquipments",
                newName: "DonorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_People",
                table: "People",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Favorites_AdvertisementId",
                table: "Favorites",
                column: "AdvertisementId");

            migrationBuilder.CreateIndex(
                name: "IX_ElectronicEquipments_DonorId",
                table: "ElectronicEquipments",
                column: "DonorId");

            migrationBuilder.AddForeignKey(
                name: "FK_ElectronicEquipments_People_DonorId",
                table: "ElectronicEquipments",
                column: "DonorId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Favorites_Advertisements_AdvertisementId",
                table: "Favorites",
                column: "AdvertisementId",
                principalTable: "Advertisements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Favorites_People_UserId",
                table: "Favorites",
                column: "UserId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_People_DonorId",
                table: "Orders",
                column: "DonorId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_People_RecipientId",
                table: "Orders",
                column: "RecipientId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ElectronicEquipments_People_DonorId",
                table: "ElectronicEquipments");

            migrationBuilder.DropForeignKey(
                name: "FK_Favorites_Advertisements_AdvertisementId",
                table: "Favorites");

            migrationBuilder.DropForeignKey(
                name: "FK_Favorites_People_UserId",
                table: "Favorites");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_People_DonorId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_People_RecipientId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Favorites_AdvertisementId",
                table: "Favorites");

            migrationBuilder.DropIndex(
                name: "IX_ElectronicEquipments_DonorId",
                table: "ElectronicEquipments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_People",
                table: "People");

            migrationBuilder.RenameTable(
                name: "People",
                newName: "PersonItems");

            migrationBuilder.RenameColumn(
                name: "DonorId",
                table: "ElectronicEquipments",
                newName: "Donor");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonItems",
                table: "PersonItems",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_PersonItems_DonorId",
                table: "Orders",
                column: "DonorId",
                principalTable: "PersonItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_PersonItems_RecipientId",
                table: "Orders",
                column: "RecipientId",
                principalTable: "PersonItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
