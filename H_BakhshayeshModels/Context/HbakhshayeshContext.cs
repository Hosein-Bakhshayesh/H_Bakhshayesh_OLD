using System;
using System.Collections.Generic;
using H_BakhshayeshModels.Models;
using Microsoft.EntityFrameworkCore;

namespace H_BakhshayeshModels.Context;

public partial class HbakhshayeshContext : DbContext
{
    public HbakhshayeshContext()
    {
    }

    public HbakhshayeshContext(DbContextOptions<HbakhshayeshContext> options)
        : base(options)
    {
    }

    public virtual DbSet<BaseInformation> BaseInformations { get; set; }

    public virtual DbSet<Document> Documents { get; set; }

    public virtual DbSet<Experience> Experiences { get; set; }

    public virtual DbSet<Message> Messages { get; set; }

    public virtual DbSet<Skill> Skills { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=193.141.65.234,2019;Initial Catalog=Hbakhshayesh;User ID=ResumeUser;Password=Adminbol2Q&212;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BaseInformation>(entity =>
        {
            entity.ToTable("BaseInformation");

            entity.Property(e => e.BaseInformationId)
                .ValueGeneratedNever()
                .HasColumnName("BaseInformation_ID");
            entity.Property(e => e.Code).HasMaxLength(150);
            entity.Property(e => e.TextField).HasMaxLength(150);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<Document>(entity =>
        {
            entity.ToTable("Document");

            entity.Property(e => e.DocumentId)
                .ValueGeneratedNever()
                .HasColumnName("Document_ID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Title).HasMaxLength(150);
        });

        modelBuilder.Entity<Experience>(entity =>
        {
            entity.ToTable("Experience");

            entity.Property(e => e.ExperienceId)
                .ValueGeneratedNever()
                .HasColumnName("Experience_ID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Icon).HasMaxLength(50);
            entity.Property(e => e.Title).HasMaxLength(150);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<Message>(entity =>
        {
            entity.ToTable("Message");

            entity.Property(e => e.MessageId)
                .ValueGeneratedNever()
                .HasColumnName("Message_ID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(150);
            entity.Property(e => e.FullName).HasMaxLength(500);
        });

        modelBuilder.Entity<Skill>(entity =>
        {
            entity.ToTable("Skill");

            entity.Property(e => e.SkillId)
                .ValueGeneratedNever()
                .HasColumnName("Skill_ID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(150);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
