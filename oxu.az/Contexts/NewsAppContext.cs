using Microsoft.EntityFrameworkCore;
using oxuAz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace oxuAz.Contexts
{
    public class NewsAppContext : DbContext
    {
        public NewsAppContext(DbContextOptions<NewsAppContext> option)
           : base(option)
        {

        }
        public DbSet<News> News { get; set; }
    }
}
