using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyTask.ViewModel
{
    public class LocalSearch : IMovieSearch
    {
        List<string> localWords;
        IMovieSearch globalWordSearch;

        public LocalSearch(IMovieSearch movieSearcher)
        {
            globalWordSearch = movieSearcher;
            localWords = new List<string>
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

        public List<string> SearchWord(string word)
        {
            bool globalWordSearchPeriod = true;
            List<string> list = new List<string>();
            for (int i = 0; i < localWords.Count; i++)
            {
                if (localWords[i].Contains(word))
                {
                    list.Add(localWords[i]);
                }
                else
                {
                    if (globalWordSearchPeriod)
                    {
                        globalWordSearch = new GlobalMovieSearch();
                        var result = globalWordSearch.SearchWord(word);
                        for (int k = 0; k < result.Count; k++)
                        {
                            list.Add(result[k]);
                        }
                        globalWordSearchPeriod = false;
                    }
                }
            }
            return list;
        }
    }
}
