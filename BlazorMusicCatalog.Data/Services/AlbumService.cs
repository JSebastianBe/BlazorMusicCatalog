using System;
using BlazorMusicCatalog.Models;

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

    public Task<Album> GetAlbumDetails(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> InsertAlbum(Album album)
    {
        throw new NotImplementedException();
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
