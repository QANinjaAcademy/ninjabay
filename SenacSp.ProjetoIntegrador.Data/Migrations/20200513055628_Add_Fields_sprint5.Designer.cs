﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SenacSp.ProjetoIntegrador.Data;

namespace SenacSp.ProjetoIntegrador.Data.Migrations
{
    [DbContext(typeof(ECommerceDataContext))]
    [Migration("20200513055628_Add_Fields_sprint5")]
    partial class Add_Fields_sprint5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("senac_ecommerce")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("SenacSp.ProjetoIntegrador.Domain.Entities.KeyWord", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("uuid");

                    b.Property<string>("Word")
                        .HasColumnName("word")
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("Word")
                        .IsUnique();

                    b.ToTable("key_words");
                });

            modelBuilder.Entity("SenacSp.ProjetoIntegrador.Domain.Entities.Log", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("uuid");

                    b.Property<string>("Exception")
                        .HasColumnName("exception")
                        .HasColumnType("text");

                    b.Property<string>("Level")
                        .HasColumnName("level")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Logger")
                        .HasColumnName("logger")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Message")
                        .HasColumnName("message")
                        .HasColumnType("text");

                    b.Property<DateTime>("OccurredAt")
                        .HasColumnName("occurred_at")
                        .HasColumnType("timestamp");

                    b.HasKey("Id");

                    b.ToTable("logs");
                });

            modelBuilder.Entity("SenacSp.ProjetoIntegrador.Domain.Entities.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnName("created_at")
                        .HasColumnType("timestamp");

                    b.Property<long>("OrderIdentifier")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("PaymentMethod")
                        .IsRequired()
                        .HasColumnName("payment_method")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("PaymentStatus")
                        .IsRequired()
                        .HasColumnName("payment_status")
                        .HasColumnType("varchar(100)");

                    b.Property<Guid>("ShippingAddressId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ShopperId")
                        .HasColumnType("uuid");

                    b.Property<decimal>("Total")
                        .HasColumnName("price")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("ShippingAddressId");

                    b.HasIndex("ShopperId");

                    b.ToTable("orders");
                });

            modelBuilder.Entity("SenacSp.ProjetoIntegrador.Domain.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .HasColumnName("desciption")
                        .HasColumnType("Varchar(255)");

                    b.Property<bool>("IsActive")
                        .HasColumnName("is_active")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("Varchar(255)");

                    b.Property<decimal>("Price")
                        .HasColumnName("price")
                        .HasColumnType("numeric");

                    b.Property<int>("Quantity")
                        .HasColumnName("quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("products");
                });

            modelBuilder.Entity("SenacSp.ProjetoIntegrador.Domain.Entities.ProductImage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("uuid");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnName("image_path")
                        .HasColumnType("text");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("product_images");
                });

            modelBuilder.Entity("SenacSp.ProjetoIntegrador.Domain.Entities.ProductKeyWord", b =>
                {
                    b.Property<Guid>("ProductId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("KeyWordId")
                        .HasColumnType("uuid");

                    b.HasKey("ProductId", "KeyWordId");

                    b.HasIndex("KeyWordId");

                    b.ToTable("product_key_words");
                });

            modelBuilder.Entity("SenacSp.ProjetoIntegrador.Domain.Entities.ProductOrder", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("uuid");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uuid");

                    b.Property<int>("Quantity")
                        .HasColumnName("quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("product_orders");
                });

            modelBuilder.Entity("SenacSp.ProjetoIntegrador.Domain.Entities.ProductQA", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("product_question_answers");
                });

            modelBuilder.Entity("SenacSp.ProjetoIntegrador.Domain.Entities.Shopper", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnName("id")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.ToTable("shoppers");
                });

            modelBuilder.Entity("SenacSp.ProjetoIntegrador.Domain.Entities.ShopperAddress", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("Varchar(255)");

                    b.Property<Guid>("ShopperId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("ShopperId1")
                        .HasColumnType("uuid");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnName("type")
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("ShopperId");

                    b.HasIndex("ShopperId1");

                    b.ToTable("shopper_addresses");
                });

            modelBuilder.Entity("SenacSp.ProjetoIntegrador.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("uuid");

                    b.Property<bool>("Active")
                        .HasColumnName("active")
                        .HasColumnType("boolean");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("email")
                        .HasColumnType("Varchar(255)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("Varchar(255)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnName("senha")
                        .HasColumnType("Varchar(255)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnName("type")
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("Senha")
                        .IsUnique();

                    b.ToTable("users");
                });

            modelBuilder.Entity("SenacSp.ProjetoIntegrador.Domain.Entities.Order", b =>
                {
                    b.HasOne("SenacSp.ProjetoIntegrador.Domain.Entities.ShopperAddress", "ShippingAddress")
                        .WithMany("Orders")
                        .HasForeignKey("ShippingAddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SenacSp.ProjetoIntegrador.Domain.Entities.Shopper", "Shopper")
                        .WithMany("Orders")
                        .HasForeignKey("ShopperId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SenacSp.ProjetoIntegrador.Domain.Entities.ProductImage", b =>
                {
                    b.HasOne("SenacSp.ProjetoIntegrador.Domain.Entities.Product", "Product")
                        .WithMany("Images")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SenacSp.ProjetoIntegrador.Domain.Entities.ProductKeyWord", b =>
                {
                    b.HasOne("SenacSp.ProjetoIntegrador.Domain.Entities.KeyWord", "KeyWord")
                        .WithMany("Products")
                        .HasForeignKey("KeyWordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SenacSp.ProjetoIntegrador.Domain.Entities.Product", "Product")
                        .WithMany("KeyWords")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SenacSp.ProjetoIntegrador.Domain.Entities.ProductOrder", b =>
                {
                    b.HasOne("SenacSp.ProjetoIntegrador.Domain.Entities.Order", "Order")
                        .WithMany("Products")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SenacSp.ProjetoIntegrador.Domain.Entities.Product", "Product")
                        .WithMany("Orders")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SenacSp.ProjetoIntegrador.Domain.Entities.ProductQA", b =>
                {
                    b.HasOne("SenacSp.ProjetoIntegrador.Domain.Entities.Product", "Product")
                        .WithMany("QuestionsAndAnswers")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("SenacSp.ProjetoIntegrador.Shared.ValueObjects.QuestionAnswer", "QuestionAndAnswer", b1 =>
                        {
                            b1.Property<Guid>("ProductQAId")
                                .HasColumnType("uuid");

                            b1.Property<string>("Answer")
                                .HasColumnName("answer")
                                .HasColumnType("varchar(525)");

                            b1.Property<string>("Question")
                                .HasColumnName("question")
                                .HasColumnType("varchar(255)");

                            b1.HasKey("ProductQAId");

                            b1.ToTable("product_question_answers");

                            b1.WithOwner()
                                .HasForeignKey("ProductQAId");
                        });
                });

            modelBuilder.Entity("SenacSp.ProjetoIntegrador.Domain.Entities.Shopper", b =>
                {
                    b.HasOne("SenacSp.ProjetoIntegrador.Domain.Entities.User", "User")
                        .WithOne()
                        .HasForeignKey("SenacSp.ProjetoIntegrador.Domain.Entities.Shopper", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("SenacSp.ProjetoIntegrador.Shared.ValueObjects.Identification", "Cpf", b1 =>
                        {
                            b1.Property<Guid>("ShopperId")
                                .HasColumnType("uuid");

                            b1.Property<string>("Number")
                                .HasColumnName("Identification_Number")
                                .HasColumnType("varchar(100)");

                            b1.Property<string>("Type")
                                .HasColumnName("Identification_Type")
                                .HasColumnType("varchar(100)");

                            b1.HasKey("ShopperId");

                            b1.HasIndex("Number")
                                .IsUnique();

                            b1.ToTable("shoppers");

                            b1.WithOwner()
                                .HasForeignKey("ShopperId");
                        });
                });

            modelBuilder.Entity("SenacSp.ProjetoIntegrador.Domain.Entities.ShopperAddress", b =>
                {
                    b.HasOne("SenacSp.ProjetoIntegrador.Domain.Entities.Shopper", "Shopper")
                        .WithMany("Addresses")
                        .HasForeignKey("ShopperId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SenacSp.ProjetoIntegrador.Domain.Entities.Shopper", null)
                        .WithMany("ShopperAddresses")
                        .HasForeignKey("ShopperId1");

                    b.OwnsOne("SenacSp.ProjetoIntegrador.Shared.ValueObjects.Address", "Address", b1 =>
                        {
                            b1.Property<Guid>("ShopperAddressId")
                                .HasColumnType("uuid");

                            b1.Property<string>("City")
                                .HasColumnName("addres_information_city")
                                .HasColumnType("varchar(255)");

                            b1.Property<string>("Complement")
                                .HasColumnName("addres_information_complement")
                                .HasColumnType("varchar(100)");

                            b1.Property<string>("Country")
                                .HasColumnType("text");

                            b1.Property<string>("District")
                                .HasColumnName("addres_information_district")
                                .HasColumnType("varchar(100)");

                            b1.Property<string>("Number")
                                .HasColumnName("addres_information_number")
                                .HasColumnType("varchar(100)");

                            b1.Property<string>("PlaceName")
                                .HasColumnName("addres_information_place_name")
                                .HasColumnType("varchar(255)");

                            b1.Property<string>("State")
                                .HasColumnName("addres_information_state")
                                .HasColumnType("varchar(255)");

                            b1.Property<string>("ZipCode")
                                .HasColumnName("addres_information_zipcode")
                                .HasColumnType("varchar(100)");

                            b1.HasKey("ShopperAddressId");

                            b1.ToTable("shopper_addresses");

                            b1.WithOwner()
                                .HasForeignKey("ShopperAddressId");
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
