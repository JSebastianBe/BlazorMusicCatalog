using System;
using BlazorMusicCatalog.Models;

namespace BlazorMusicCatalog.Data.Services;

public interface IAlbumServices
{
    Task<IEnumerable<Album>> GetAlbums();
    Task<Album> GetAlbumDetails(int id);
    Task<bool> InsertAlbum(Album album);
    Task<bool> UpdateAlbum(Album album);
    Task<bool> DeleteAlbum(int id);
}
