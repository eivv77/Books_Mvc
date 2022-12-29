﻿using BoolkyBookWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BoolkyBookWeb.Data.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }

    }
}