﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TunNetCom.AionTime.TimeLogService.Domain.Models;

[Table("TicketHistory")]
public partial class TicketHistory
{
    [Key]
    public int TicketHistoryId { get; set; }

    [Required]
    [Column("TicketHistory")]
    [StringLength(1000)]
    [Unicode(false)]
    public string TicketHistory1 { get; set; }

    public int TicketId { get; set; }

    [ForeignKey("TicketId")]
    [InverseProperty("TicketHistories")]
    public virtual Ticket Ticket { get; set; }
}