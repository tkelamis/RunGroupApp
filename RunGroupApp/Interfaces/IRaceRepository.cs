using RunGroupApp.Models;

namespace RunGroupApp.Interfaces
{
    public interface IRaceRepository
    {
        Task<IEnumerable<Race>> GetAll();
        Task<Race> GetByIdAsync(int Id);
        Task<IEnumerable<Race>> GetAllRacesByCityAsync(string city);
        bool Add(Race race);
        bool Update(Race race);
        bool Delete(Race race);
        bool Save();
    }
}
