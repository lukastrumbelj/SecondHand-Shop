using Microsoft.EntityFrameworkCore;
using System.Drawing;

namespace SecondHand.Controllers.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { 
        }
    }
}
