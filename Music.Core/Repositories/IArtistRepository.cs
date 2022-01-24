using System.Collections.Generic;
using System.Threading.Tasks;
using Music.Core.Models;

namespace Music.Core.Repositories
{
    public interface IArtistRepository
    {
        Task<IEnumerable<Artist>> GetAllWithMusicsAsync();
        Task<Artist> GetWithMusicsByIdAsync(int id);
    }
}