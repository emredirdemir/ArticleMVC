using Microsoft.EntityFrameworkCore.Migrations;

namespace EmreDemir.DataAccess.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "postCards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostHeader = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostOwner = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostCategory = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_postCards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WhoAmI",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MyPhotoName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pdf = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WhoAmI", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "postCards");

            migrationBuilder.DropTable(
                name: "WhoAmI");
        }
    }
}
