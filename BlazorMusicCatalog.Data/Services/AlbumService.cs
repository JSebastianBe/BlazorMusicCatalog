using System;
using BlazorMusicCatalog.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorMusicCatalog.Data.Services;

public class AlbumService : IAlbumServices
{
    private readonly AlbumMusicCatalogContext _context;
    public AlbumService(AlbumMusicCatalogContext context)
    {
        _context = context;
    }
    
    public Task<IEnumerable<Album>> GetAlbums()
    {
        throw new NotImplementedException();
    }

    public async Task<Album> GetAlbumDetails(int id)
    {
        return await _context.Albums
                        .Where(a => a.Id == id)
                        .Include(a => a.Songs)
                        .FirstOrDefaultAsync();
    }

    public async Task<bool> InsertAlbum(Album album)
    {
        _context.Albums.Add(album);
        return await _context.SaveChangesAsync() > 0;
    }

    public Task<bool> UpdateAlbum(Album album)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteAlbum(int id)
    {
        throw new NotImplementedException();
    }

}
