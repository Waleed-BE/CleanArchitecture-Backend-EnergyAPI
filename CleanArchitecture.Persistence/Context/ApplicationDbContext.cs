using CleanArchitecture.Domain.Common;
using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Entities.Auth;
using CleanArchitecture.Domain.Enums;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Persistence.Context
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        private readonly string _currentUserId;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, string currentUserId) : base(options)
        {
            _currentUserId = currentUserId;
        }

        public DbSet<Status> TblStatus { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<BaseEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedDate = DateTime.UtcNow;
                        entry.Entity.CreatedBy = _currentUserId ?? "System";
                        break;
                    case EntityState.Modified:
                        entry.Entity.LastModifiedDate = DateTime.UtcNow;
                        entry.Entity.LastModifiedBy = _currentUserId ?? "System";
                        break;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure Status Entity
            modelBuilder.Entity<Status>()
                .HasKey(s => s.StatusId);

            modelBuilder.Entity<Status>()
                .Property(s => s.StatusId)
                .HasConversion<int>();

            // Seed Status data
            modelBuilder.Entity<Status>().HasData(
                new Status { StatusId = StatusEnum.Inactive, Name = "Inactive", Description = "Inactive status", Id = Guid.NewGuid(), CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                new Status { StatusId = StatusEnum.Active, Name = "Active", Description = "Active status", Id = Guid.NewGuid(), CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                new Status { StatusId = StatusEnum.Pending, Name = "Pending", Description = "Pending status", Id = Guid.NewGuid(), CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                new Status { StatusId = StatusEnum.Locked, Name = "Locked", Description = "Locked status", Id = Guid.NewGuid(), CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                new Status { StatusId = StatusEnum.Deleted, Name = "Deleted", Description = "Deleted status", Id = Guid.NewGuid(), CreatedDate = DateTime.UtcNow, CreatedBy = "System" }
            );
        }
    }
}
