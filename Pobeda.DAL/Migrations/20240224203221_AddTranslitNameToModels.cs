using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pobeda.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddTranslitNameToModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TranslitName",
                table: "SubCategories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TranslitName",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TranslitName",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "TranslitName",
                value: "telefony");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "TranslitName",
                value: "kompyuternaya-tehnika");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "TranslitName",
                value: "instrument");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "TranslitName",
                value: "igry-i-pristavki");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "TranslitName",
                value: "tovary-dlya-doma");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "TranslitName",
                value: "avto");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "TranslitName",
                value: "foto-i-videotehnika");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "TranslitName",
                value: "hobbi-i-otdyh");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "TranslitName",
                value: "lichnye-vecshi");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "TranslitName",
                value: "audiotehnika");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "TranslitName",
                value: "tv-i-video");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "TranslitName",
                value: "tovary-dlya-detei");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "TranslitName",
                value: "sistemnyj-blok");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "TranslitName",
                value: "apple-iphone-se-128gb");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "TranslitName",
                value: "sotovye-telefony");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "TranslitName",
                value: "umnye-chasy-i-braslety");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "TranslitName",
                value: "naushniki-dlya-telefonov");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "TranslitName",
                value: "racii");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "TranslitName",
                value: "zaryadnye-ustroistva");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "TranslitName",
                value: "aksessuary-dlya-telefonov");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "TranslitName",
                value: "noutbuki");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "TranslitName",
                value: "sistemnye-bloki");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "TranslitName",
                value: "monitory");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "TranslitName",
                value: "monobloki");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 11,
                column: "TranslitName",
                value: "kompyuternye-myshi");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 12,
                column: "TranslitName",
                value: "klaviatury");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 13,
                column: "TranslitName",
                value: "kompyuternye-garnitury-i-naushniki");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 14,
                column: "TranslitName",
                value: "webkamery");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 15,
                column: "TranslitName",
                value: "planshetnye-pk");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 16,
                column: "TranslitName",
                value: "elektronnye-knigi");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 17,
                column: "TranslitName",
                value: "printery-i-mfu");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 18,
                column: "TranslitName",
                value: "routery-i-modemy");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 19,
                column: "TranslitName",
                value: "jestkie-diski");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 20,
                column: "TranslitName",
                value: "prochaya-orgtehnika");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 21,
                column: "TranslitName",
                value: "setevye-filtry-i-udliniteli");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 22,
                column: "TranslitName",
                value: "aksessuary-dlya-kompyuterov");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 23,
                column: "TranslitName",
                value: "aksessuary-i-rashodnye-materialy");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 24,
                column: "TranslitName",
                value: "izmeritelnye-instrumenty");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 25,
                column: "TranslitName",
                value: "specodejda");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 26,
                column: "TranslitName",
                value: "elektroinstrument");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 27,
                column: "TranslitName",
                value: "ruchnoi-instrument");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 28,
                column: "TranslitName",
                value: "svarochnoe-oborudovanie");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 29,
                column: "TranslitName",
                value: "benzoinstrument");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 30,
                column: "TranslitName",
                value: "pnevmoinstrument");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 31,
                column: "TranslitName",
                value: "svetotehnika");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 32,
                column: "TranslitName",
                value: "tehnika-dlya-sada");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 33,
                column: "TranslitName",
                value: "igrovye-pristavki");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 34,
                column: "TranslitName",
                value: "igry-dlya-pristavok");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 35,
                column: "TranslitName",
                value: "aksessuary-dlya-igrovyh-pristavok");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 36,
                column: "TranslitName",
                value: "nastolnye-igry");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 37,
                column: "TranslitName",
                value: "hozyaistvennye-tovary");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 38,
                column: "TranslitName",
                value: "multivarki");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 39,
                column: "TranslitName",
                value: "klimaticheskoe-oborudovanie");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 40,
                column: "TranslitName",
                value: "mebel-i-interer");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 41,
                column: "TranslitName",
                value: "mikrovolnovye-pechi");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 42,
                column: "TranslitName",
                value: "pylesosy");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 43,
                column: "TranslitName",
                value: "stiralnye-mashiny");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 44,
                column: "TranslitName",
                value: "tovary-dlya-krasoty-i-zdorovya");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 45,
                column: "TranslitName",
                value: "tovary-dlya-kuhni");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 46,
                column: "TranslitName",
                value: "utyugi-i-otparivateli");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 47,
                column: "TranslitName",
                value: "chainiki-i-kofevarki");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 48,
                column: "TranslitName",
                value: "holodilniki-i-morozilniki");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 49,
                column: "TranslitName",
                value: "shveinye-mashiny");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 50,
                column: "TranslitName",
                value: "britvy-i-mashinki-dlya-strijki");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 51,
                column: "TranslitName",
                value: "feny-i-ploiki");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 52,
                column: "TranslitName",
                value: "vesy");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 53,
                column: "TranslitName",
                value: "elektricheskie-plity");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 54,
                column: "TranslitName",
                value: "moiki-vysokogo-davleniya");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 55,
                column: "TranslitName",
                value: "nasosy-i-kompressory");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 56,
                column: "TranslitName",
                value: "avtomagnitoly");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 57,
                column: "TranslitName",
                value: "avtomobilnye-aksessuary-i-komplektuyucshie");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 58,
                column: "TranslitName",
                value: "avtomobilnye-kolonki");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 59,
                column: "TranslitName",
                value: "avtomobilnye-sabvufery");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 60,
                column: "TranslitName",
                value: "avtomobilnye-usiliteli");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 61,
                column: "TranslitName",
                value: "parktroniki-i-signalizaciya");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 62,
                column: "TranslitName",
                value: "videoregistratory");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 63,
                column: "TranslitName",
                value: "navigatory");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 64,
                column: "TranslitName",
                value: "shiny-i-diski");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 65,
                column: "TranslitName",
                value: "fotoapparaty");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 66,
                column: "TranslitName",
                value: "videokamery");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 67,
                column: "TranslitName",
                value: "aksessuary-dlya-foto-i-videokamer");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 68,
                column: "TranslitName",
                value: "zimnii-sportivnyi-inventar");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 69,
                column: "TranslitName",
                value: "metalloiskateli");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 70,
                column: "TranslitName",
                value: "binokli-i-optika");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 71,
                column: "TranslitName",
                value: "vodnyi-inventar");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 72,
                column: "TranslitName",
                value: "tatumashinki");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 73,
                column: "TranslitName",
                value: "velosipedy-i-samokaty");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 74,
                column: "TranslitName",
                value: "pnevmatika-i-elektroshokery");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 75,
                column: "TranslitName",
                value: "trenajery");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 76,
                column: "TranslitName",
                value: "rolikovye-i-ledovye-konki");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 77,
                column: "TranslitName",
                value: "turizm");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 78,
                column: "TranslitName",
                value: "kanctovary");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 79,
                column: "TranslitName",
                value: "chasy");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 80,
                column: "TranslitName",
                value: "koshelki-i-sumki");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 81,
                column: "TranslitName",
                value: "muzykalnye-instrumenty");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 82,
                column: "TranslitName",
                value: "mp3-pleery");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 83,
                column: "TranslitName",
                value: "kolonki");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 84,
                column: "TranslitName",
                value: "domashnie-kinoteatry");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 85,
                column: "TranslitName",
                value: "muzykalnye-centry");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 86,
                column: "TranslitName",
                value: "televizory");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 87,
                column: "TranslitName",
                value: "video");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 88,
                column: "TranslitName",
                value: "proektory");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 89,
                column: "TranslitName",
                value: "cifrovoe-televidenie");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 90,
                column: "TranslitName",
                value: "aksessuary-dlya-tv-i-video");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 91,
                column: "TranslitName",
                value: "detskie-avtokresla");

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 92,
                column: "TranslitName",
                value: "detskie-igrushki");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TranslitName",
                table: "SubCategories");

            migrationBuilder.DropColumn(
                name: "TranslitName",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "TranslitName",
                table: "Categories");
        }
    }
}
