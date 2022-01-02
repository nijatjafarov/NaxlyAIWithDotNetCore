using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace NaxlyAI.Models
{
    public partial class NaxlyAIContext : IdentityDbContext
    {
        public NaxlyAIContext()
        {
        }

        public NaxlyAIContext(DbContextOptions<NaxlyAIContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AboutCompany> AboutCompanies { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Configuration> Configurations { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<HomePage> HomePages { get; set; }
        public virtual DbSet<Industry> Industries { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<ProjectAndMember> ProjectAndMembers { get; set; }
        public virtual DbSet<ProjectAndTech> ProjectAndTeches { get; set; }
        public virtual DbSet<ReasonForChoosingU> ReasonForChoosingUs { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<ServiceAndIndustry> ServiceAndIndustries { get; set; }
        public virtual DbSet<ServiceFile> ServiceFiles { get; set; }
        public virtual DbSet<ServicesPage> ServicesPages { get; set; }
        public virtual DbSet<SocialMediaAccountOfMember> SocialMediaAccountOfMembers { get; set; }
        public virtual DbSet<SocialMediaOfCompany> SocialMediaOfCompanies { get; set; }
        public virtual DbSet<SocialMedium> SocialMedia { get; set; }
        public virtual DbSet<StepOfHistory> StepOfHistories { get; set; }
        public virtual DbSet<StepOfProject> StepOfProjects { get; set; }
        public virtual DbSet<SubfieldOfService> SubfieldOfServices { get; set; }
        public virtual DbSet<Subservice> Subservices { get; set; }
        public virtual DbSet<TeamMember> TeamMembers { get; set; }
        public virtual DbSet<TechAndService> TechAndServices { get; set; }
        public virtual DbSet<Technology> Technologies { get; set; }
        public virtual DbSet<Testimonial> Testimonials { get; set; }
        public virtual DbSet<UserMessage> UserMessages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("data source=DESKTOP-P6NV8LT\\SQLEXPRESS;initial catalog=NaxlyAI;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Project>(entity =>
            {
                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Projects)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ClientOfProjectFK");

                entity.HasOne(d => d.Industy)
                    .WithMany(p => p.Projects)
                    .HasForeignKey(d => d.IndustyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IndustryOfProject");
            });

            modelBuilder.Entity<ProjectAndMember>(entity =>
            {
                entity.HasOne(d => d.Member)
                    .WithMany(p => p.ProjectAndMembers)
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MemberOfProject");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjectAndMembers)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ProjectOfMember");
            });

            modelBuilder.Entity<ProjectAndTech>(entity =>
            {
                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjectAndTeches)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ProjectOfTech");

                entity.HasOne(d => d.Tech)
                    .WithMany(p => p.ProjectAndTeches)
                    .HasForeignKey(d => d.TechId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("TechOfProject");
            });

            modelBuilder.Entity<ServiceAndIndustry>(entity =>
            {
                entity.HasOne(d => d.Industry)
                    .WithMany(p => p.ServiceAndIndustries)
                    .HasForeignKey(d => d.IndustryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IndustryOfServiceFK");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.ServiceAndIndustries)
                    .HasForeignKey(d => d.ServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ServiceOfIndustryFK");
            });

            modelBuilder.Entity<ServiceFile>(entity =>
            {
                entity.HasOne(d => d.Service)
                    .WithMany(p => p.ServiceFiles)
                    .HasForeignKey(d => d.ServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ServiceOfFileFK");
            });

            modelBuilder.Entity<SocialMediaAccountOfMember>(entity =>
            {
                entity.HasOne(d => d.Member)
                    .WithMany(p => p.SocialMediaAccountOfMembers)
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SMMemberFK");

                entity.HasOne(d => d.SocialMedia)
                    .WithMany(p => p.SocialMediaAccountOfMembers)
                    .HasForeignKey(d => d.SocialMediaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SocialMediaFK");
            });

            modelBuilder.Entity<StepOfProject>(entity =>
            {
                entity.HasOne(d => d.Project)
                    .WithMany(p => p.StepOfProjects)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ProjectOfStep");
            });

            modelBuilder.Entity<SubfieldOfService>(entity =>
            {
                entity.HasOne(d => d.Service)
                    .WithMany(p => p.SubfieldOfServices)
                    .HasForeignKey(d => d.ServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ServiceOfFieldFK");
            });

            modelBuilder.Entity<Subservice>(entity =>
            {
                entity.HasOne(d => d.Service)
                    .WithMany(p => p.Subservices)
                    .HasForeignKey(d => d.ServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SubserviceOfServiceFK");
            });

            modelBuilder.Entity<TechAndService>(entity =>
            {
                entity.HasOne(d => d.Service)
                    .WithMany(p => p.TechAndServices)
                    .HasForeignKey(d => d.ServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ServiceFK");

                entity.HasOne(d => d.Tech)
                    .WithMany(p => p.TechAndServices)
                    .HasForeignKey(d => d.TechId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("TechFK");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
