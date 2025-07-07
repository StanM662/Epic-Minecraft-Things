using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer
{
    public static class EMTDbInitializer
    {
        public static void Initialize(EMTDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Minigames.Any())
                return;

            var minigames = new Minigame[]
            {
                new Minigame
                {
                    Name = "Kitpvp",
                    Description = "Game",
                    Tags = new List<string> { "PvP", "Quick", "Classes", "2+ Players" },
                },
                new Minigame
                {
                    Name = "Assasins",
                    Description = "Game",
                    Tags = new List<string> { "PvP", "2 Teams", "6+ Players", "Popular", "Quick", "Rounds", "Classes", "2 Gamemodes", "Multiple Maps" },
                },
                new Minigame
                {
                    Name = "Counter Strike: But Worse",
                    Description = "Game",
                    Tags = new List<string> { "PvP", "2-4 Teams", "2+ Players", "Quick", "Rounds" },
                },
                new Minigame
                {
                    Name = "Counter Strike: But Better",
                    Description = "Game",
                    Tags = new List<string> { "PvP", "2 Teams", "6+ Players", "Quick", "Multiple Maps", "Rounds" },
                },
                new Minigame
                {
                    Name = "Payload",
                    Description = "Game",
                    Tags = new List<string> { "PvP", "2 Teams", "6+ Players", "Popular", "Classes", "Multiple Maps", "Long" },
                },
                new Minigame
                {
                    Name = "Murder Mystery",
                    Description = "Game",
                    Tags = new List<string> { "4+ Players", "Popular", "Quick", "Rounds" },
                },
                new Minigame
                {
                    Name = "Bathrooms",
                    Description = "Game",
                    Tags = new List<string> { "PvE", "4+ Players", "Survival" },
                },
                new Minigame
                {
                    Name = "Vietnam",
                    Description = "Game",
                    Tags = new List<string> { "Hide And Seek", "4+ Players", "Quick" },
                },
                new Minigame
                {
                    Name = "Castle Siege",
                    Description = "Game",
                    Tags = new List<string> { "PvP", "2 Teams", "4+ Players", "Popular", "Classes", "Long" },
                },
                new Minigame
                {
                    Name = "Slasher",
                    Description = "Game",
                    Tags = new List<string> { "PvP", "4+ Players", "Quick", "Rounds" },
                },
                new Minigame
                {
                    Name = "Intruder",
                    Description = "Game",
                    Tags = new List<string> { "PvP", "2 Teams", "4+ Players", "Popular", "Quick", "Rounds" },
                },
                new Minigame
                {
                    Name = "Rebellion",
                    Description = "Game",
                    Tags = new List<string> { "PvP", "2 Teams", "8+ Players", "Popular", "Classes", "Long" },
                },
                new Minigame
                {
                    Name = "Mystic Tower",
                    Description = "Game",
                    Tags = new List<string> { "PvE", "1+ Players", "Long", "Story", "Grindy" },
                },
                new Minigame
                {
                    Name = "The Final Fucking Straw",
                    Description = "Game",
                    Tags = new List<string> { "PvE", "1+ Players", "Grindy", "Survival" },
                }
            };

            context.Minigames.AddRange(minigames);
            context.SaveChanges();
        }
    }
}
