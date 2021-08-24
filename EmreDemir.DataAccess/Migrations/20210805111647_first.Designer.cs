﻿// <auto-generated />
using EmreDemir.DataAccess.Contexts.PostgreSql;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EmreDemir.DataAccess.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20210805111647_first")]
    partial class first
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EmreDemir.Entities.Concrete.WhoAmI", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImgName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MyPhotoName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pdf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("WhoAmI");
                });

            modelBuilder.Entity("EmreDemir.Entities.Conrete.PostCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PostCategory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostHeader")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostOwner")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostText")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("postCards");
                });
#pragma warning restore 612, 618
        }
    }
}
