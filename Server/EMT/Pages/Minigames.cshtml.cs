using EMT.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EMT.Pages
{
    public class MinigamesModel : PageModel
    {
        public List<Minigame>? Minigames;
        public void OnGet()
        {
            Minigames = new List<Minigame>() { };

        }



    }
}
