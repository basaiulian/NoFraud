﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PaymentManagement.Model;

namespace PaymentManagement.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0-rc.2.20475.6");

            modelBuilder.Entity("PaymentManagement.Entities.BankAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("AccountType")
                        .HasColumnType("string")
                        .HasColumnName("account_type");

                    b.Property<double>("Balance")
                        .HasColumnType("double")
                        .HasColumnName("balance");

                    b.Property<int>("TokenID")
                        .HasColumnType("int")
                        .HasColumnName("token_id");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("BankAccount");
                });

            modelBuilder.Entity("PaymentManagement.Entities.Card", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("BankAccountId")
                        .HasColumnType("string")
                        .HasColumnName("bank_account_id");

                    b.Property<int?>("BankAccountId1")
                        .HasColumnType("int");

                    b.Property<string>("BankName")
                        .HasColumnType("string")
                        .HasColumnName("bank_name");

                    b.Property<string>("CvvCode")
                        .HasColumnType("string")
                        .HasColumnName("cvvCode");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("DateTime")
                        .HasColumnName("expiration_date");

                    b.Property<string>("Number")
                        .HasColumnType("string")
                        .HasColumnName("number");

                    b.Property<string>("OwnerId")
                        .HasColumnType("string")
                        .HasColumnName("owner_id");

                    b.Property<string>("PinCode")
                        .HasColumnType("string")
                        .HasColumnName("pin_code");

                    b.HasKey("Id");

                    b.HasIndex("BankAccountId1");

                    b.ToTable("Card");
                });

            modelBuilder.Entity("PaymentManagement.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Address")
                        .HasColumnType("string")
                        .HasColumnName("address");

                    b.Property<string>("Email")
                        .HasColumnType("string")
                        .HasColumnName("email");

                    b.Property<string>("Password")
                        .HasColumnType("string")
                        .HasColumnName("password");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("string")
                        .HasColumnName("phone_number");

                    b.Property<string>("Username")
                        .HasColumnType("string")
                        .HasColumnName("username");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("PaymentManagement.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<float>("Amount")
                        .HasColumnType("float")
                        .HasColumnName("amount");

                    b.Property<string>("Currency")
                        .HasColumnType("string")
                        .HasColumnName("currency");

                    b.Property<DateTime>("Date")
                        .HasColumnType("date")
                        .HasColumnName("date_");

                    b.Property<string>("Destination")
                        .HasColumnType("string")
                        .HasColumnName("destination");

                    b.Property<string>("Source")
                        .HasColumnType("string")
                        .HasColumnName("source_");

                    b.Property<string>("Status")
                        .HasColumnType("string")
                        .HasColumnName("status");

                    b.Property<float>("latitude")
                        .HasColumnType("float")
                        .HasColumnName("latitude");

                    b.Property<float>("longitude")
                        .HasColumnType("float")
                        .HasColumnName("longitude");

                    b.Property<string>("IsFraud")
                        .HasColumnType("string")
                        .HasColumnName("is_fraud");

                    b.HasKey("Id");

                    b.ToTable("Payment");
                });

            modelBuilder.Entity("PaymentManagement.Entities.BankAccount", b =>
                {
                    b.HasOne("PaymentManagement.Entities.User", null)
                        .WithMany("BankAccounts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PaymentManagement.Entities.Card", b =>
                {
                    b.HasOne("PaymentManagement.Entities.BankAccount", null)
                        .WithMany("CardList")
                        .HasForeignKey("BankAccountId1");
                });

            modelBuilder.Entity("PaymentManagement.Entities.BankAccount", b =>
                {
                    b.Navigation("CardList");
                });

            modelBuilder.Entity("PaymentManagement.Entities.User", b =>
                {
                    b.Navigation("BankAccounts");
                });
#pragma warning restore 612, 618
        }
    }
}
