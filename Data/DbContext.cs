﻿using BlueProjectTest.Models;
using Microsoft.EntityFrameworkCore;

namespace BlueProjectTest.Data;

public class AppDbContext : DbContext
{
    public DbSet<Produto> Produtos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer("Server=****\\SQLEXPRESS;Database=TechStore;Trust Server Certificate=true;Integrated Security=true;User ID=****");
}
