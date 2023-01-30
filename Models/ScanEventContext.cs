using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ScanEventAPI.Models
{
    public class ScanEventContext : DbContext
    {
        public ScanEventContext(DbContextOptions<ScanEventContext> options)
            : base(options)
        {
        }

        public DbSet<ScanEventItem> ScanEventItems { get; set; } = null!;
    }
}

