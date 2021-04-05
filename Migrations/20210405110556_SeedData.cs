using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Quotes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quotes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "InsertDate", "Text" },
                values: new object[,]
                {
                    { 1, "akmal199601", new DateTime(2021, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Волк не тот кто волк а тот кто волк тот волк" },
                    { 2, "akmal1996", new DateTime(2021, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Девушка будет по-настоящему счастлива,когда у неё будет два счастья: одно будет говорить ″Любимая″,а второе — ″Мама″" },
                    { 3, "Khurshed", new DateTime(2021, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Учись мой уный падаван" },
                    { 4, "Mr Azizojon", new DateTime(2021, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "А на собеседовании что будишь делать " },
                    { 5, "Azizov Akmal", new DateTime(2021, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Обычно, девочки любят куколок, а мальчики — красивые машинки. Но это только до 17 лет. А потом всё становится наоборот " }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Quotes");
        }
    }
}
