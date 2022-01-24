using System.Collections.Generic;
using System.Threading.Tasks;

namespace Music.Core.Services
{
    public interface IMusicService
    {
        Task<IEnumerable<Music.Core.Models.Music>> GetAllWithArtist();
        Task<Music.Core.Models.Music> GetMusicById(int id);
        Task<IEnumerable<Music.Core.Models.Music>> GetMusicsByArtistId(int artistId);
        Task<Music.Core.Models.Music> CreateMusic(Music.Core.Models.Music newMusic);
        Task UpdateMusic(Music.Core.Models.Music musicToBeUpdated, Music.Core.Models.Music music);
        Task DeleteMusic(Music.Core.Models.Music music);
    }
}