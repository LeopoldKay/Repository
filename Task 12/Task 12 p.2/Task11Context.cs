using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12_p._2
{
    public class Task11Context : DbContext
    {
        public DbSet<Director> Directors { get; set; }
        public DbSet<Character> Characters { get; set; }
    }
}
