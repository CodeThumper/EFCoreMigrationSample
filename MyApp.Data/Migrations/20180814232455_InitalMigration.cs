using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyApp.Data.Migrations
{
    public partial class InitalMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    TenantId = table.Column<Guid>(nullable: false),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Created_SessionId = table.Column<Guid>(nullable: true),
                    Created_At = table.Column<DateTimeOffset>(nullable: true),
                    Created_Reason = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    ProviderId = table.Column<Guid>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    DisplayName = table.Column<string>(unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => new { x.TenantId, x.ProviderId, x.ProviderKey });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
