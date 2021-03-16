using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ComputerCenterEntity.DataLayer;

namespace ComputerCenterEntity.Models
{
    public class ComputerCenterEntityContext : DbContext
    {
        public ComputerCenterEntityContext (DbContextOptions<ComputerCenterEntityContext> options)
            : base(options)
        {
        }

        public DbSet<ComputerCenterEntity.DataLayer.Student> Student { get; set; }

        public DbSet<ComputerCenterEntity.DataLayer.Staff> Staff { get; set; }

        public DbSet<ComputerCenterEntity.DataLayer.Course> Course { get; set; }
    }
}
