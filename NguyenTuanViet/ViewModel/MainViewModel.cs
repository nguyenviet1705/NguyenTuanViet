using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using static System.Net.Mime.MediaTypeNames;


namespace NguyenTuanViet.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<string> items;

        [ObservableProperty]
        string text;

        public MainViewModel()
        {
            items = new ObservableCollection<string>();
        }

        [RelayCommand]
        void Add()
        {
            if (string.IsNullOrWhiteSpace(text))
                return;

            items.Add(text);
            
        }

        [RelayCommand]
        void Delete(string s)
        {
            if (items.Contains(s))
            {
                items.Remove(s);
            }
        }
        [RelayCommand]
        async Task Tap(string s)
        {
            if (items.Contains(s))
            {

                await Shell.Current.GoToAsync($"{nameof(DetailPage)}?id={s}");


            }
        }
    
    }
}
