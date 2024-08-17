using Microsoft.EntityFrameworkCore;
using RunGroupApp.Data;
using RunGroupApp.Interfaces;
using RunGroupApp.Models;

namespace RunGroupApp.Repository
{
    public class RaceRepository : IRaceRepository
    {
        private readonly ApplicationDbContext _context;

        public RaceRepository(ApplicationDbContext context)
        {
            this._context = context;
        }
        public async Task<IEnumerable<Race>> GetAll()
        {
            return await _context.Races.ToListAsync();
        }
        public async Task<Race> GetByIdAsync(int Id)
        {
            return await _context.Races.Include(a => a.Address).FirstOrDefaultAsync(c => c.Id == Id);
        }
        public async Task<IEnumerable<Race>> GetAllRacesByCityAsync(string city)
        {
            return await _context.Races.Where(a => a.Address.City.Contains(city)).ToListAsync();
        }
        public bool Add(Race race)
        {
            _context.Races.Add(race);
            return Save();
        }
        public bool Update(Race race)
        {
            _context.Races.Update(race);
            return Save();
        }
        public bool Delete(Race race)
        {
            _context.Races.Remove(race);
            return Save();
        }
        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }
    }
}
