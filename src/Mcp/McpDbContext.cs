﻿using BugTracker.DbModels.Try;
using BugTracker.DbModels.Mcp;
using Microsoft.EntityFrameworkCore;

namespace BugTracker
{
    public class McpDbContext : DbContext
    {
        public McpDbContext(DbContextOptions<McpDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
            //context.Database.Migrate();
        }

        //List of Models
        //Dummy Data
            public DbSet<User> Users { get; set; }
            public DbSet<Post> Posts { get; set; }
        //Real Data
            public DbSet<Image> Image { get; set; }
            public DbSet<Description> Description { get; set; }
            public DbSet<Bulletin> Bulletin { get; set; }
    }
}