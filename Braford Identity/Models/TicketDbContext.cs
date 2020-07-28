using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Braford_Identity.Models
{
    public class TicketDbContext : DbContext
    {
        public TicketDbContext(DbContextOptions<TicketDbContext> options): base(options)
        {
        }

        public DbSet<Ticket> Ticket { get; set; }

    }
}
