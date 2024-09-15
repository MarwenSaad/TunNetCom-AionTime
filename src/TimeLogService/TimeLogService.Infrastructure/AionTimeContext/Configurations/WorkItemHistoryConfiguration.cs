﻿namespace TimeLogService.Infrastructure.AionTimeContext.Configurations
{
    public partial class WorkItemHistoryConfiguration : IEntityTypeConfiguration<WorkItemHistory>
    {
        public void Configure(EntityTypeBuilder<WorkItemHistory> entity)
        {
            entity.ToTable("WorkItemHistory");

            entity.Property(e => e.History)
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.HasOne(d => d.WorkItem).WithMany(p => p.WorkItemHistories)
                .HasForeignKey(d => d.WorkItemId)
                .HasConstraintName("FKTicketHistory");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<WorkItemHistory> entity);
    }
}