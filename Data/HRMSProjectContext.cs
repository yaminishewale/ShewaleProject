using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HRMSProject.Models;

namespace HRMSProject.Data
{
    public class HRMSProjectContext : DbContext
    {
        public HRMSProjectContext (DbContextOptions<HRMSProjectContext> options)
            : base(options)
        {
        }

        public DbSet<HRMSProject.Models.House>? House { get; set; }
    }
}
