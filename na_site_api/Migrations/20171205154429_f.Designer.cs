﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using na_site_api.Models;
using System;

namespace na_site_api.Migrations
{
    [DbContext(typeof(TodoContext))]
    [Migration("20171205154429_f")]
    partial class f
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("na_site_api.Models.TodoItem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsComplete");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("TodoItems");
                });

            modelBuilder.Entity("na_site_api.Models.VoteTopic", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BODseconder");

                    b.Property<string>("Category");

                    b.Property<bool>("ProposalApproved");

                    b.Property<string>("Proposer");

                    b.Property<bool>("Seconded");

                    b.Property<string>("VoteTopicFullText");

                    b.Property<bool>("VotingIsComplete");

                    b.HasKey("Id");

                    b.ToTable("VoteTopics");
                });
#pragma warning restore 612, 618
        }
    }
}
