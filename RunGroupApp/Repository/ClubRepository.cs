using Microsoft.EntityFrameworkCore;
using RunGroupApp.Data;
using RunGroupApp.Interfaces;
using RunGroupApp.Models;

namespace RunGroupApp.Repository
{
    public class ClubRepository : IClubRepository
    {
        private readonly ApplicationDbContext _context;

        public ClubRepository(ApplicationDbContext context)
        {
            this._context = context;
        }

        public async Task<IEnumerable<Club>> GetAll()
        {
            return await _context.Clubs.ToListAsync();
        }

        public async Task<Club> GetByIdAsync(int Id)
        {
            return await _context.Clubs.Include(a=>a.Address).FirstOrDefaultAsync(c => c.Id == Id);
        }
        public async Task<IEnumerable<Club>> GetClubByCityAsync(string city)
        {
            return await _context.Clubs.Where(a => a.Address.City.Contains(city)).ToListAsync();
        }
        public bool Add(Club club)
        {
            _context.Clubs.Add(club);
            return Save();
        }

        public bool Update(Club club)
        {
            _context.Clubs.Update(club);
            return Save();
        }

        public bool Delete(Club club)
        {
            _context.Clubs.Remove(club);
            return Save();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true: false;
        }

        
    }
}
