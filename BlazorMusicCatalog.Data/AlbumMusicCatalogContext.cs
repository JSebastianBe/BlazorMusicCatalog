using System;
using Microsoft.EntityFrameworkCore;
using BlazorMusicCatalog.Models;

namespace BlazorMusicCatalog.Data;

public class AlbumMusicCatalogContext : DbContext
{   
    public DbSet<Album> Albums { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=localhost;User ID=SA;Password=Root123456;Initial Catalog=AlbumMusicCatalog;Connect Timeout=30;Trust Server Certificate=True;Authentication=SqlPassword;Application Name=vscode-mssql");
    }
}
