using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyTask.ViewModel
{
    public interface IMovieSearch
    {
        List<string> SearchWord(string word);
    }
}
