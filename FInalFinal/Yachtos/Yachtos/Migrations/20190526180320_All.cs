using Microsoft.EntityFrameworkCore.Migrations;

namespace Yachtos.Migrations
{
    public partial class All : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Packages",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Packages", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Storage",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Item = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    kiekis = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Storage", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Teises = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    fk_storageid = table.Column<int>(nullable: true),
                    price = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.id);
                    table.ForeignKey(
                        name: "FK_Items_Storage_fk_storageid",
                        column: x => x.fk_storageid,
                        principalTable: "Storage",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmployeeId = table.Column<string>(nullable: false),
                    fk_UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Employee_User_fk_UserId",
                        column: x => x.fk_UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PackagesItems",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fk_packagesid = table.Column<int>(nullable: true),
                    Fk_itemid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackagesItems", x => x.id);
                    table.ForeignKey(
                        name: "FK_PackagesItems_Items_Fk_itemid",
                        column: x => x.Fk_itemid,
                        principalTable: "Items",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PackagesItems_Packages_Fk_packagesid",
                        column: x => x.Fk_packagesid,
                        principalTable: "Packages",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_fk_UserId",
                table: "Employee",
                column: "fk_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_fk_storageid",
                table: "Items",
                column: "fk_storageid");

            migrationBuilder.CreateIndex(
                name: "IX_PackagesItems_Fk_itemid",
                table: "PackagesItems",
                column: "Fk_itemid");

            migrationBuilder.CreateIndex(
                name: "IX_PackagesItems_Fk_packagesid",
                table: "PackagesItems",
                column: "Fk_packagesid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "PackagesItems");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Packages");

            migrationBuilder.DropTable(
                name: "Storage");
        }
    }
}
