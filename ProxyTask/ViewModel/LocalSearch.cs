using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyTask.ViewModel
{
    public class LocalSearch : IMovieSearch
    {
        List<string> localWord;
        IMovieSearch globalWordSearch;

        public LocalSearch(IMovieSearch movieSearcher)
        {
            localWord = new List<string>
            {
                "a",
                "aa",
                "aaa",
                "aaron",
                "ab",
                "abandoned",
                "banana",
                "band",
                "bands",
                "bandwidth",
                "bang",
                "bangbus",
                "calm",
                "calvin",
                "cam",
                "cambodia",
                "cambridge",
                "camcorder",
            };
        }

        public string SearchWord(string word)
        {
            if (localWord.Any(x => x == word))
            {
                return localWord.FirstOrDefault(x => x == word);
            }
            else
            {
                var result = globalWordSearch.SearchWord(word);
                localWord.Add(result);
                return result;
            }
        }
    }
}
