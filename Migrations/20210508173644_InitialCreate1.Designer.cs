﻿// <auto-generated />
using System;
using FptCoApp.Models.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FptCoApp.Migrations
{
    [DbContext(typeof(FptCoAppDbContext))]
    [Migration("20210508173644_InitialCreate1")]
    partial class InitialCreate1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FptCoApp.Models.Admin", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("FptCoApp.Models.Course", b =>
                {
                    b.Property<int>("CourseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CourseCategoriesCategoryID")
                        .HasColumnType("int");

                    b.Property<string>("CourseDescriptions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CourseName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CourseID");

                    b.HasIndex("CourseCategoriesCategoryID");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("FptCoApp.Models.CourseCategory", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryDescriptions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TrainingStaffsID")
                        .HasColumnType("int");

                    b.HasKey("CategoryID");

                    b.HasIndex("TrainingStaffsID");

                    b.ToTable("CourseCategories");
                });

            modelBuilder.Entity("FptCoApp.Models.Topic", b =>
                {
                    b.Property<int>("TopicID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CoursesCourseID")
                        .HasColumnType("int");

                    b.Property<string>("TopicDescriptions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TopicName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TopicID");

                    b.HasIndex("CoursesCourseID");

                    b.ToTable("Topics");
                });

            modelBuilder.Entity("FptCoApp.Models.Trainee", b =>
                {
                    b.Property<int>("TraineeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Education")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProgrammingLanguage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TOEICScore")
                        .HasColumnType("decimal");

                    b.HasKey("TraineeID");

                    b.ToTable("Trainees");
                });

            modelBuilder.Entity("FptCoApp.Models.TraineeCourse", b =>
                {
                    b.Property<int>("TraineeID")
                        .HasColumnType("int");

                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<int>("TraineeCourseID")
                        .HasColumnType("int");

                    b.HasKey("TraineeID", "CourseID");

                    b.HasIndex("CourseID");

                    b.ToTable("TraineeCourses");
                });

            modelBuilder.Entity("FptCoApp.Models.Trainer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("emailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("phoneNumber")
                        .HasColumnType("int");

                    b.Property<string>("workingPlace")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Trainers");
                });

            modelBuilder.Entity("FptCoApp.Models.TrainerTopic", b =>
                {
                    b.Property<int>("TrainerID")
                        .HasColumnType("int");

                    b.Property<int>("TopicID")
                        .HasColumnType("int");

                    b.Property<int>("TrainerTopicID")
                        .HasColumnType("int");

                    b.HasKey("TrainerID", "TopicID");

                    b.HasIndex("TopicID");

                    b.ToTable("TrainerTopics");
                });

            modelBuilder.Entity("FptCoApp.Models.TrainingStaff", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("TrainingStaffs");
                });

            modelBuilder.Entity("FptCoApp.Models.Course", b =>
                {
                    b.HasOne("FptCoApp.Models.CourseCategory", "CourseCategories")
                        .WithMany("Courses")
                        .HasForeignKey("CourseCategoriesCategoryID");

                    b.Navigation("CourseCategories");
                });

            modelBuilder.Entity("FptCoApp.Models.CourseCategory", b =>
                {
                    b.HasOne("FptCoApp.Models.TrainingStaff", "TrainingStaffs")
                        .WithMany("CourseCategories")
                        .HasForeignKey("TrainingStaffsID");

                    b.Navigation("TrainingStaffs");
                });

            modelBuilder.Entity("FptCoApp.Models.Topic", b =>
                {
                    b.HasOne("FptCoApp.Models.Course", "Courses")
                        .WithMany("Topics")
                        .HasForeignKey("CoursesCourseID");

                    b.Navigation("Courses");
                });

            modelBuilder.Entity("FptCoApp.Models.TraineeCourse", b =>
                {
                    b.HasOne("FptCoApp.Models.Course", "Courses")
                        .WithMany("TraineeCourses")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FptCoApp.Models.Trainee", "Trainees")
                        .WithMany("TraineeCourses")
                        .HasForeignKey("TraineeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Courses");

                    b.Navigation("Trainees");
                });

            modelBuilder.Entity("FptCoApp.Models.TrainerTopic", b =>
                {
                    b.HasOne("FptCoApp.Models.Topic", "Topics")
                        .WithMany("TrainerTopics")
                        .HasForeignKey("TopicID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FptCoApp.Models.Trainer", "Trainers")
                        .WithMany("TrainerTopics")
                        .HasForeignKey("TrainerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Topics");

                    b.Navigation("Trainers");
                });

            modelBuilder.Entity("FptCoApp.Models.Course", b =>
                {
                    b.Navigation("Topics");

                    b.Navigation("TraineeCourses");
                });

            modelBuilder.Entity("FptCoApp.Models.CourseCategory", b =>
                {
                    b.Navigation("Courses");
                });

            modelBuilder.Entity("FptCoApp.Models.Topic", b =>
                {
                    b.Navigation("TrainerTopics");
                });

            modelBuilder.Entity("FptCoApp.Models.Trainee", b =>
                {
                    b.Navigation("TraineeCourses");
                });

            modelBuilder.Entity("FptCoApp.Models.Trainer", b =>
                {
                    b.Navigation("TrainerTopics");
                });

            modelBuilder.Entity("FptCoApp.Models.TrainingStaff", b =>
                {
                    b.Navigation("CourseCategories");
                });
#pragma warning restore 612, 618
        }
    }
}
