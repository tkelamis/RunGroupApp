using RunGroupApp.Models;

namespace RunGroupApp.Interfaces
{
    public interface IClubRepository
    {
        Task<IEnumerable<Club>> GetAll();
        Task<Club> GetByIdAsync(int Id);
        Task<IEnumerable<Club>> GetClubByCityAsync(string city);
        bool Add(Club club);
        bool Update(Club club);
        bool Delete(Club club);
        bool Save();
    }
}
