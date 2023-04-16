using ProxyTask.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ProxyTask.ViewModel
{

    public class MainWindowViewModel : BaseViewModel
    {
        private string txtBoxText;

        public string TxtBoxText
        {
            get { return txtBoxText; }
            set { txtBoxText = value; OnPropertyChanged(); TextChange(); }
        }

        private List<string> listBoxItemSource;

        public List<string> ListBoxItemSource
        {
            get { return listBoxItemSource; }
            set { listBoxItemSource = value; OnPropertyChanged(); }
        }

        public RelayCommand SelectionChanged { get; set; }

        private string selectedItem;

        public string SelectedItem
        {
            get { return selectedItem; }
            set { selectedItem = value; OnPropertyChanged(); }
        }

        private string txtBlockText;

        public string TxtBlockText
        {
            get { return txtBlockText; }
            set { txtBlockText = value; OnPropertyChanged(); }
        }

        public RelayCommand ButtonClicked { get; set; }

        public MainWindowViewModel()
        {
            SelectionChanged = new RelayCommand((a) =>
            {
                if (SelectedItem != null)
                {
                    TxtBlockText += $"{SelectedItem}\n";
                }
            });

            ButtonClicked = new RelayCommand((a) =>
            {
                TxtBlockText += $"{TxtBoxText}\n";
            });
        }

        public void TextChange()
        {
            if (TxtBoxText != string.Empty)
            {
                IMovieSearch search = new LocalSearch(new GlobalMovieSearch());
                ShowWordData(search.SearchWord(TxtBoxText));
            }
            else
            {
                ListBoxItemSource = new List<string>();
            }
        }

        private void ShowWordData(List<string> foundWords)
        {
            ListBoxItemSource = new List<string>();
            ListBoxItemSource = foundWords;
            if (foundWords.Count == 0)
            {
                MessageBox.Show("I don't know word");
            }
        }
    }
}
