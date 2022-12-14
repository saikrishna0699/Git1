// <auto-generated />
using FoodDonationManagmentSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FoodDonationManagmentSystem.Migrations
{
    [DbContext(typeof(DonarDbContext))]
    [Migration("20220926123304_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FoodDonationManagmentSystem.Models.DonarsModule", b =>
                {
                    b.Property<int>("DonarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DonarCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DonarName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhNo")
                        .HasColumnType("int");

                    b.HasKey("DonarId");

                    b.ToTable("Donars");
                });
#pragma warning restore 612, 618
        }
    }
}
