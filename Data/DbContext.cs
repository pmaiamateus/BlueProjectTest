using BlueProjectTest.Models;
using Microsoft.EntityFrameworkCore;

namespace BlueProjectTest.Data;

public class AppDbContext : DbContext
{
    public DbSet<Produto> Produtos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer("Server=MTS\\SQLEXPRESS;Database=TaskingOutDB;Trust Server Certificate=true;Integrated Security=true;User ID=****");
}
