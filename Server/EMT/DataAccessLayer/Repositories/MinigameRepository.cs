using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer
{
    public class MinigameRepository : IMinigameRepository
    {
        private readonly EMTDbContext _context;

        public MinigameRepository(EMTDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Minigame> GetAllMinigames()
        {
            return _context.Minigames.ToList(); // No navigation needed
        }

        public Minigame? GetMinigameById(int id)
        {
            return _context.Minigames.FirstOrDefault(m => m.Id == id);
        }

        public void AddMinigame(Minigame minigame)
        {
            _context.Minigames.Add(minigame);
            _context.SaveChanges();
        }

        public void UpdateMinigame(Minigame minigame)
        {
            _context.Minigames.Update(minigame);
            _context.SaveChanges();
        }

        public void DeleteMinigame(Minigame minigame)
        {
            _context.Minigames.Remove(minigame);
            _context.SaveChanges();
        }
    }
}
