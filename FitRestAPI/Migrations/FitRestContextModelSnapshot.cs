﻿// <auto-generated />
using System;
using FitRestAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FitRestAPI.Migrations
{
    [DbContext(typeof(FitRestContext))]
    partial class FitRestContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FitRestAPI.Models.Activity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CaloriesPerMinute")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Activity");
                });

            modelBuilder.Entity("FitRestAPI.Models.ActivityWithDuration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DurationInMinutes")
                        .HasColumnType("int");

                    b.Property<int>("IdActivity")
                        .HasColumnType("int");

                    b.Property<int>("IdDay")
                        .HasColumnType("int");

                    b.Property<double>("Intensity")
                        .HasColumnType("float");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("IdActivity");

                    b.HasIndex("IdDay");

                    b.ToTable("ActivityWithDuration");
                });

            modelBuilder.Entity("FitRestAPI.Models.Day", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double>("CaloriesGoal")
                        .HasColumnType("float");

                    b.Property<double>("CarbohydratesGoal")
                        .HasColumnType("float");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<double>("FatsGoal")
                        .HasColumnType("float");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("ProteinGoal")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Day");
                });

            modelBuilder.Entity("FitRestAPI.Models.Meal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DayId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TimeOfEating")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("DayId");

                    b.ToTable("Meal");
                });

            modelBuilder.Entity("FitRestAPI.Models.MealIngredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Calories")
                        .HasColumnType("int");

                    b.Property<int>("Carbohydrates")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Fats")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PortionName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Proteins")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("MealIngredient");
                });

            modelBuilder.Entity("FitRestAPI.Models.MealIngredientWithPortion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdMeal")
                        .HasColumnType("int");

                    b.Property<int>("IdMealIngredient")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("PortionSize")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("IdMeal");

                    b.HasIndex("IdMealIngredient");

                    b.ToTable("MealIngredientWithPortion");
                });

            modelBuilder.Entity("FitRestAPI.Models.Sleep", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DurationInMinutes")
                        .HasColumnType("int");

                    b.Property<int>("DurationInMinutesOfDeepSleep")
                        .HasColumnType("int");

                    b.Property<DateTime?>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdDay")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("RatingOfSleep")
                        .HasColumnType("int");

                    b.Property<DateTime?>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("IdDay");

                    b.ToTable("Sleep");
                });

            modelBuilder.Entity("FitRestAPI.Models.ActivityWithDuration", b =>
                {
                    b.HasOne("FitRestAPI.Models.Activity", "Activity")
                        .WithMany("ActivityDuration")
                        .HasForeignKey("IdActivity")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FitRestAPI.Models.Day", "Day")
                        .WithMany("ActivityWithDuration")
                        .HasForeignKey("IdDay")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Activity");

                    b.Navigation("Day");
                });

            modelBuilder.Entity("FitRestAPI.Models.Meal", b =>
                {
                    b.HasOne("FitRestAPI.Models.Day", null)
                        .WithMany("Meals")
                        .HasForeignKey("DayId");
                });

            modelBuilder.Entity("FitRestAPI.Models.MealIngredientWithPortion", b =>
                {
                    b.HasOne("FitRestAPI.Models.Meal", "Meal")
                        .WithMany("MealIngredientWithPortions")
                        .HasForeignKey("IdMeal")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FitRestAPI.Models.MealIngredient", "MealIngredient")
                        .WithMany()
                        .HasForeignKey("IdMealIngredient")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Meal");

                    b.Navigation("MealIngredient");
                });

            modelBuilder.Entity("FitRestAPI.Models.Sleep", b =>
                {
                    b.HasOne("FitRestAPI.Models.Day", "Day")
                        .WithMany("Sleep")
                        .HasForeignKey("IdDay")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Day");
                });

            modelBuilder.Entity("FitRestAPI.Models.Activity", b =>
                {
                    b.Navigation("ActivityDuration");
                });

            modelBuilder.Entity("FitRestAPI.Models.Day", b =>
                {
                    b.Navigation("ActivityWithDuration");

                    b.Navigation("Meals");

                    b.Navigation("Sleep");
                });

            modelBuilder.Entity("FitRestAPI.Models.Meal", b =>
                {
                    b.Navigation("MealIngredientWithPortions");
                });
#pragma warning restore 612, 618
        }
    }
}
