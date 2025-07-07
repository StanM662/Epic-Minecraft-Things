namespace DataAccessLayer
{
    public interface IMinigameRepository
    {
        IEnumerable<Minigame> GetAllMinigames();
        Minigame? GetMinigameById(int id);
        void AddMinigame(Minigame minigame);
        void UpdateMinigame(Minigame minigame);
        void DeleteMinigame(Minigame minigame);
    }
}
