// Ignore Spelling: App

using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeApp.ViewModel
{
    public partial class BaseViewModel : ObservableObject
    {
        [ObservableProperty]
        string title;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsNotBusy))]
        bool isBusy;

        public bool IsNotBusy => !isBusy;
    }
}
