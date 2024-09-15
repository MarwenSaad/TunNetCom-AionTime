﻿namespace TimeLogService.Domain.Models;

public partial class WorkItemHistory : BaseEntity
{
    public string? History { get; set; }

    public int WorkItemId { get; set; }

    public virtual WorkItem? WorkItem { get; set; }
}