using System.Collections;
using System.Collections.Generic;
using System.Windows.Documents;

namespace ProxyTask.ViewModel
{
    public class GlobalMovieSearch : IMovieSearch
    {
        public List<string> GlobalWordList { get; set; }
        public List<string> SearchWord(string word)
        {
            List<string> globalWords = new List<string>
            {
                "americanom",
                "zshops",
                "zu",
                "zum",
                "zus",
                "zealand",
                "zen",
                "zero",
                "zimbabwe",
                "zinc",
                "zip",
                "zoloft",
                "zone",
                "zones",
                "zoning",
                "za",
                "zambia",
                "zdnet",
                "yugoslavia",
                "yukon",
                "z",
                "yr",
                "yrs",
                "yu",
                "yours",
                "yourself",
                "youth",
                "wood",
                "wooden",
                "woods",
                "woman",
                "women",
                "womens",
                "won",
                "wonder",
                "voices",
                "void",
                "voip",
                "vol",
                "volkswagen",
                "volleyball",
                "volt",
                "voltage",
                "superior",
                "supervision",
                "supervisor",
                "supervisors",
                "supplement",
                "supplemental",
                "supplements",
                "supplied",
                "supplier",
                "suppliers",
                "supplies",
                "supply",
                "support",
                "rom",
                "roman",
                "romance",
                "romania",
                "romantic",
                "rome",
                "ron",
                "ronald",
                "roof",
                "room",
                "roommate",
                "roommates",
                "rooms",
                "root",
                "roots",
                "rope",
                "rosa",
                "rose",
                "racks",
                "radar",
                "radiation",
                "quite",
                "quiz",
                "quizzes",
                "quotations",
                "quote",
                "quoted",
                "quotes",
                "equilibrium",
                "equipment",
                "equipped",
                "equity",
                "equivalent",
                "er",
                "era",
                "eric",
                "herself",
                "hewlett",
                "hey",
                "hh",
                "heroes",
            };
            GlobalWordList = globalWords;
            List<string> words = new List<string>();
            for (int i = 0; i < globalWords.Count; i++)
            {
                if (globalWords[i].Contains(word))
                {
                    words.Add(globalWords[i]);
                }
            }
            return words;
        }
    }
}