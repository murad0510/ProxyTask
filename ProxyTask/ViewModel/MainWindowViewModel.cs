using ProxyTask.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ProxyTask.ViewModel
{

    public class MainWindowViewModel : BaseViewModel
    {
        private string txtBoxText;

        public string TxtBoxText
        {
            get { return txtBoxText; }
            set { txtBoxText = value; OnPropertyChanged(); TextChange(value); }
        }

        public MainWindowViewModel()
        {

        }

        public void TextChange(string text)
        {
            MessageBox.Show($"{text}");
            //IMovieSearch movieSearch = new LocalSearch(new GlobalMovieSearch());
        }
    }
}
