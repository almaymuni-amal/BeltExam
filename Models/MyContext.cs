using Microsoft.EntityFrameworkCore;

namespace BeltExam.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Activityy> Activities { get; set; }
        public DbSet<Participate> Participates { get; set; }

    }
}