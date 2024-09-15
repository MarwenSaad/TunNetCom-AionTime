﻿namespace TimeLogService.Infrastructure.AionTimeContext.Configurations
{
    public partial class WorkItemTimeLogConfiguration : IEntityTypeConfiguration<WorkItemTimeLog>
    {
        public void Configure(EntityTypeBuilder<WorkItemTimeLog> entity)
        {
            entity.ToTable("WorkItemTimeLog");

            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Time).HasColumnType("datetime");

            entity.HasOne(d => d.WorkItem).WithMany(p => p.WorkItemTimeLogs)
                .HasForeignKey(d => d.WorkItemId)
                .HasConstraintName("FKProjectTicketLog");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<WorkItemTimeLog> entity);
    }
}