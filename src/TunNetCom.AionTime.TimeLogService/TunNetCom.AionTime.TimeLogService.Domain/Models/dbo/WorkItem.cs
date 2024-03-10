﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using TunNetCom.AionTime.TimeLogService.Domain.Models.dbo;


namespace TunNetCom.AionTime.TimeLogService.Domain.Models;

[Table("WorkItem")]


public partial class WorkItem : BaseEntity
{
    [StringLength(1000)]
    [Unicode(false)]
    public string? Discription { get; set; }

    public int ProjectId { get; set; }

    [ForeignKey("ProjectId")]
    [InverseProperty("WorkItems")]
    [JsonIgnore]
    public virtual Project? Project { get; set; }

    [InverseProperty("WorkItem")]
    [JsonIgnore]
    public virtual ICollection<WorkItemHistory>?  WorkItemHistories { get; set; } //= new List<WorkItemHistory>();

    [InverseProperty("WorkItem")]
    [JsonIgnore]
    public virtual ICollection<WorkItemTimeLog>?  WorkItemTimeLogs { get; set; } //= new List<WorkItemTimeLog>();
}


