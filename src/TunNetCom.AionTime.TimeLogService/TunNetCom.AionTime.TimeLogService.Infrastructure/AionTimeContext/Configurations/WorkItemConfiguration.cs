﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using TunNetCom.AionTime.TimeLogService.Infrastructure.AionTimeContext;

#nullable disable

namespace TunNetCom.AionTime.TimeLogService.Infrastructure.AionTimeContext.Configurations
{
    public partial class WorkItemConfiguration : IEntityTypeConfiguration<WorkItem>
    {
        public void Configure(EntityTypeBuilder<WorkItem> entity)
        {
            entity.HasOne(d => d.Project).WithMany(p => p.WorkItems).HasConstraintName("FKProjectTicket");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<WorkItem> entity);
    }
}