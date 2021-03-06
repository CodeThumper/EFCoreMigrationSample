﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyApp.Data;

namespace MyApp.Data.Migrations
{
    [DbContext(typeof(MyAppContext))]
    partial class MyAppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyApp.Domain.Customer", b =>
                {
                    b.Property<Guid>("TenantId");

                    b.Property<Guid>("ProviderId");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("DisplayName")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("TenantId", "ProviderId", "ProviderKey");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("MyApp.Domain.Customer", b =>
                {
                    b.OwnsOne("MyApp.Domain.ReferencePoint", "Created", b1 =>
                        {
                            b1.Property<Guid>("CustomerTenantId");

                            b1.Property<Guid>("CustomerProviderId");

                            b1.Property<string>("CustomerProviderKey");

                            b1.Property<DateTimeOffset?>("At");

                            b1.Property<string>("Reason")
                                .HasMaxLength(255)
                                .IsUnicode(false);

                            b1.Property<Guid?>("SessionId");

                            b1.ToTable("Customer");

                            b1.HasOne("MyApp.Domain.Customer")
                                .WithOne("Created")
                                .HasForeignKey("MyApp.Domain.ReferencePoint", "CustomerTenantId", "CustomerProviderId", "CustomerProviderKey")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
