using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace na_site_api.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
          : base(options)
        {
        }
        public DbSet<VoteTopic> VoteTopics { get; set; }
        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
