using System;
using ExampleAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExampleAPI.Context;

public class ExampleDbContext : DbContext
{
    protected IConfiguration _configuration;

    public ExampleDbContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

        var configrationString = _configuration.GetValue<string>("ConnectionStrings:Developer");
        optionsBuilder.UseSqlServer(configrationString);
    }

    public DbSet<User> Users { get; set; }
   
}


