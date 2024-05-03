using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PlayerValidaton.Models;

namespace PlayerValidaton.Data
{
    public class PlayerValidatonContext : DbContext
    {
        public PlayerValidatonContext (DbContextOptions<PlayerValidatonContext> options)
            : base(options)
        {
        }

        public DbSet<PlayerValidaton.Models.Player> Player { get; set; } = default!;
        public DbSet<PlayerValidaton.Models.Users> User { get; set; } = default!;
    }
}
