// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(DealContext))]
    partial class DealContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Data.Model.Announces", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("AnunData")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("AnunDescri")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<byte[]>("AnunImage")
                        .IsRequired()
                        .HasColumnType("BYTEA");

                    b.Property<string>("AnunTitulo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("AnunValor")
                        .HasColumnType("double precision");

                    b.Property<int>("CategoriesId")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CategoriesId");

                    b.HasIndex("UserId");

                    b.ToTable("Announce");
                });

            modelBuilder.Entity("Data.Model.Categories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Categorie");
                });

            modelBuilder.Entity("Data.Model.FavoriteAnnounces", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AnnounceId")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AnnounceId");

                    b.HasIndex("UserId");

                    b.ToTable("FavoriteAnnounce");
                });

            modelBuilder.Entity("Data.Model.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("UserApelido")
                        .HasColumnType("text");

                    b.Property<string>("UserBairro")
                        .HasColumnType("text");

                    b.Property<string>("UserCep")
                        .HasColumnType("text");

                    b.Property<string>("UserCidade")
                        .HasColumnType("text");

                    b.Property<string>("UserComplemento")
                        .HasColumnType("text");

                    b.Property<string>("UserCpf")
                        .HasColumnType("text");

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserEstado")
                        .HasColumnType("text");

                    b.Property<byte[]>("UserImage")
                        .HasColumnType("BYTEA");

                    b.Property<string>("UserNomeCompleto")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("UserNumero")
                        .HasColumnType("integer");

                    b.Property<string>("UserRua")
                        .HasColumnType("text");

                    b.Property<string>("UserSenha")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserTelefone")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Data.Model.Announces", b =>
                {
                    b.HasOne("Data.Model.Categories", "Categorie")
                        .WithMany("Announces")
                        .HasForeignKey("CategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Model.Users", "User")
                        .WithMany("Announces")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categorie");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Data.Model.FavoriteAnnounces", b =>
                {
                    b.HasOne("Data.Model.Announces", "Announce")
                        .WithMany()
                        .HasForeignKey("AnnounceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Model.Users", "User")
                        .WithMany("FavoriteAnnounces")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Announce");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Data.Model.Categories", b =>
                {
                    b.Navigation("Announces");
                });

            modelBuilder.Entity("Data.Model.Users", b =>
                {
                    b.Navigation("Announces");

                    b.Navigation("FavoriteAnnounces");
                });
#pragma warning restore 612, 618
        }
    }
}
