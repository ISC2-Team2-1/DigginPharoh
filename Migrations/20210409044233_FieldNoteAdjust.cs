using Microsoft.EntityFrameworkCore.Migrations;

namespace DigginPharoh.Migrations
{
    public partial class FieldNoteAdjust : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Tomb",
                table: "Field_Notes",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "To_Be_Confirmed",
                table: "Field_Notes",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<string>(
                name: "Temporal_Mandibular_Joint_Osteoarthritis",
                table: "Field_Notes",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<string>(
                name: "Skull_Trauma",
                table: "Field_Notes",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<string>(
                name: "Skull_At_Magazine",
                table: "Field_Notes",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<string>(
                name: "Postcrania_Trauma",
                table: "Field_Notes",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<string>(
                name: "Postcrania_At_Magazine",
                table: "Field_Notes",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<string>(
                name: "Metopic_Suture",
                table: "Field_Notes",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<string>(
                name: "Linear_Hypoplasia_Enamel",
                table: "Field_Notes",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<string>(
                name: "Field_Book_Page_Number",
                table: "Field_Notes",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "Cribra_Orbitala",
                table: "Field_Notes",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<string>(
                name: "Button_Osteoma",
                table: "Field_Notes",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<string>(
                name: "Area_Hill_Burials",
                table: "Field_Notes",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "Area_Hill_Burials",
                table: "Burials",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Body_Analysis_Year",
                table: "Burials",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Button_Osteoma",
                table: "Burials",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Cluster",
                table: "Burials",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Cribra_Orbitala",
                table: "Burials",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Face_Bundle",
                table: "Burials",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Field_Book",
                table: "Burials",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Field_Book_Page_Number",
                table: "Burials",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Goods",
                table: "Burials",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Linear_Hypoplasia_Enamel",
                table: "Burials",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Metopic_Suture",
                table: "Burials",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Osteology_Unknown_Comment",
                table: "Burials",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Porotic_Hyperostosis",
                table: "Burials",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Porotic_Hyperostosis_Locations",
                table: "Burials",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Postcrania_At_Magazine",
                table: "Burials",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Postcrania_Trauma",
                table: "Burials",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Rack_And_Shelf",
                table: "Burials",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Skull_At_Magazine",
                table: "Burials",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Skull_Trauma",
                table: "Burials",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Temporal_Mandibular_Joint_Osteoarthritis",
                table: "Burials",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "To_Be_Confirmed",
                table: "Burials",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Tomb",
                table: "Burials",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Area_Hill_Burials",
                table: "Burials");

            migrationBuilder.DropColumn(
                name: "Body_Analysis_Year",
                table: "Burials");

            migrationBuilder.DropColumn(
                name: "Button_Osteoma",
                table: "Burials");

            migrationBuilder.DropColumn(
                name: "Cluster",
                table: "Burials");

            migrationBuilder.DropColumn(
                name: "Cribra_Orbitala",
                table: "Burials");

            migrationBuilder.DropColumn(
                name: "Face_Bundle",
                table: "Burials");

            migrationBuilder.DropColumn(
                name: "Field_Book",
                table: "Burials");

            migrationBuilder.DropColumn(
                name: "Field_Book_Page_Number",
                table: "Burials");

            migrationBuilder.DropColumn(
                name: "Goods",
                table: "Burials");

            migrationBuilder.DropColumn(
                name: "Linear_Hypoplasia_Enamel",
                table: "Burials");

            migrationBuilder.DropColumn(
                name: "Metopic_Suture",
                table: "Burials");

            migrationBuilder.DropColumn(
                name: "Osteology_Unknown_Comment",
                table: "Burials");

            migrationBuilder.DropColumn(
                name: "Porotic_Hyperostosis",
                table: "Burials");

            migrationBuilder.DropColumn(
                name: "Porotic_Hyperostosis_Locations",
                table: "Burials");

            migrationBuilder.DropColumn(
                name: "Postcrania_At_Magazine",
                table: "Burials");

            migrationBuilder.DropColumn(
                name: "Postcrania_Trauma",
                table: "Burials");

            migrationBuilder.DropColumn(
                name: "Rack_And_Shelf",
                table: "Burials");

            migrationBuilder.DropColumn(
                name: "Skull_At_Magazine",
                table: "Burials");

            migrationBuilder.DropColumn(
                name: "Skull_Trauma",
                table: "Burials");

            migrationBuilder.DropColumn(
                name: "Temporal_Mandibular_Joint_Osteoarthritis",
                table: "Burials");

            migrationBuilder.DropColumn(
                name: "To_Be_Confirmed",
                table: "Burials");

            migrationBuilder.DropColumn(
                name: "Tomb",
                table: "Burials");

            migrationBuilder.AlterColumn<int>(
                name: "Tomb",
                table: "Field_Notes",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "To_Be_Confirmed",
                table: "Field_Notes",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Temporal_Mandibular_Joint_Osteoarthritis",
                table: "Field_Notes",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Skull_Trauma",
                table: "Field_Notes",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Skull_At_Magazine",
                table: "Field_Notes",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Postcrania_Trauma",
                table: "Field_Notes",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Postcrania_At_Magazine",
                table: "Field_Notes",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Metopic_Suture",
                table: "Field_Notes",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Linear_Hypoplasia_Enamel",
                table: "Field_Notes",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Field_Book_Page_Number",
                table: "Field_Notes",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Cribra_Orbitala",
                table: "Field_Notes",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Button_Osteoma",
                table: "Field_Notes",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Area_Hill_Burials",
                table: "Field_Notes",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
