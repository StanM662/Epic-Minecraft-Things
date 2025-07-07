using DataAccessLayer;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EMT.Pages
{
    public class MinigamesModel : PageModel
    {
        private readonly IMinigameRepository _repository;

        public List<Minigame> Minigames { get; private set; } = new();

        public MinigamesModel(IMinigameRepository repository)
        {
            _repository = repository;
        }

        public void OnGet()
        {
            Minigames = _repository.GetAllMinigames().ToList();
        }
    }
}
