using System.Collections.Generic;

namespace FE_Heroes_Text_Simulator
{
    public class Lists
    {
        private readonly List<string> backgrounds = new List<string>()
        {
            "Aether Raids 1",
            "Aether Raids 2",
            "Aether Raids 3",
            "Aether Raids 4",
            "Aether Raids 5",
            "Allies Menu",
            "Arena",
            "Castle 1",
            "Castle 2",
            "Castle 3",
            "Castle 4",
            "Castle 5",
            "Castle 6",
            "Dialogue",
            "Forging Bonds",
            "Grand Conquests",
            "Hero Page (Summoner Support)",
            "Hero Page",
            "Map Title",
            "Misc. Menu",
            "Shop",
            "Summon",
            "Summoning Altar",
            "Tap Battle",
            "Tempest Trials",
            "Training Tower",
            "Voting Gauntlet",
            "World Map 1",
            "World Map 2"
        };

        public List<string> GetBackgrounds()
        {
            return backgrounds;
        }

        private readonly List<string> conversationBackgrounds = new List<string>()
        {
            "Brave",
            "Brave (Forest)",
            "Castle",
            "Dream Valla",
            "Forest (Night)",
            "Gaiden Castle",
            "Hoshido Castle",
            "Hoshido Summer",
            "Múspell",
            "Múspell Castle",
            "Múspell Forest (Night)",
            "Múspell Temple",
            "Plains Forest",
            "Plains Forest (Inside)",
            "Plains Sea",
            "Volcano"
        };

        public List<string> GetConversationBackgrounds()
        {
            return conversationBackgrounds;
        }
    }
}
