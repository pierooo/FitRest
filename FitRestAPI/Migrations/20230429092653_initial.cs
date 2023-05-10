using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitRestAPI.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Activity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CaloriesPerMinute = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Day",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CaloriesGoal = table.Column<double>(type: "float", nullable: false),
                    CarbohydratesGoal = table.Column<double>(type: "float", nullable: false),
                    ProteinGoal = table.Column<double>(type: "float", nullable: false),
                    FatsGoal = table.Column<double>(type: "float", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Day", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MealIngredient",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Carbohydrates = table.Column<int>(type: "int", nullable: false),
                    Proteins = table.Column<int>(type: "int", nullable: false),
                    Fats = table.Column<int>(type: "int", nullable: false),
                    Calories = table.Column<int>(type: "int", nullable: false),
                    PortionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MealIngredient", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ActivityWithDuration",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DurationInMinutes = table.Column<int>(type: "int", nullable: false),
                    Intensity = table.Column<double>(type: "float", nullable: false),
                    IdDay = table.Column<int>(type: "int", nullable: false),
                    IdActivity = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityWithDuration", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActivityWithDuration_Activity_IdActivity",
                        column: x => x.IdActivity,
                        principalTable: "Activity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActivityWithDuration_Day_IdDay",
                        column: x => x.IdDay,
                        principalTable: "Day",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Meal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeOfEating = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DayId = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Meal_Day_DayId",
                        column: x => x.DayId,
                        principalTable: "Day",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Sleep",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DurationInMinutes = table.Column<int>(type: "int", nullable: false),
                    DurationInMinutesOfDeepSleep = table.Column<int>(type: "int", nullable: false),
                    RatingOfSleep = table.Column<int>(type: "int", nullable: false),
                    IdDay = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sleep", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sleep_Day_IdDay",
                        column: x => x.IdDay,
                        principalTable: "Day",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MealIngredientWithPortion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PortionSize = table.Column<double>(type: "float", nullable: false),
                    IdMeal = table.Column<int>(type: "int", nullable: false),
                    IdMealIngredient = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MealIngredientWithPortion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MealIngredientWithPortion_Meal_IdMeal",
                        column: x => x.IdMeal,
                        principalTable: "Meal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MealIngredientWithPortion_MealIngredient_IdMealIngredient",
                        column: x => x.IdMealIngredient,
                        principalTable: "MealIngredient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActivityWithDuration_IdActivity",
                table: "ActivityWithDuration",
                column: "IdActivity");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityWithDuration_IdDay",
                table: "ActivityWithDuration",
                column: "IdDay");

            migrationBuilder.CreateIndex(
                name: "IX_Meal_DayId",
                table: "Meal",
                column: "DayId");

            migrationBuilder.CreateIndex(
                name: "IX_MealIngredientWithPortion_IdMeal",
                table: "MealIngredientWithPortion",
                column: "IdMeal");

            migrationBuilder.CreateIndex(
                name: "IX_MealIngredientWithPortion_IdMealIngredient",
                table: "MealIngredientWithPortion",
                column: "IdMealIngredient");

            migrationBuilder.CreateIndex(
                name: "IX_Sleep_IdDay",
                table: "Sleep",
                column: "IdDay");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivityWithDuration");

            migrationBuilder.DropTable(
                name: "MealIngredientWithPortion");

            migrationBuilder.DropTable(
                name: "Sleep");

            migrationBuilder.DropTable(
                name: "Activity");

            migrationBuilder.DropTable(
                name: "Meal");

            migrationBuilder.DropTable(
                name: "MealIngredient");

            migrationBuilder.DropTable(
                name: "Day");
        }
    }
}
