using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SaramentMeetingPlanner.Models;

namespace SaramentMeetingPlanner.Data
{
    public class SaramentMeetingPlannerContext : DbContext
    {
        public SaramentMeetingPlannerContext (DbContextOptions<SaramentMeetingPlannerContext> options)
            : base(options)
        {
        }

        public DbSet<SaramentMeetingPlanner.Models.Planner> Planner { get; set; } = default!;
    }
}
