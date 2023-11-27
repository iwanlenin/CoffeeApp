using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using CoffeeApp.Helpers;

namespace CoffeeApp.ViewModel
{
    public partial class CoffeeUIViewModel: BaseViewModel 
    {
   


        public CoffeeUIViewModel()
        {
                this.GoBackToolTip = "Go back";
            
        }


        public string GoBackToolTip { get; set; }
        

        [RelayCommand]
        public async Task GoBackAsync() 
        {
            await Shell.Current.GoToAsync("//MainPage");
        }

        [RelayCommand]
        public async Task AddToCardAsync() 
        {

            await ToastService.ShowToastAsync("Added to card", ToastDuration.Short, new System.Threading.CancellationTokenSource());
        }

        [RelayCommand]
        public async Task BuyNowAsync()
        {
            await ToastService.ShowToastAsync("Buying now", ToastDuration.Short, new System.Threading.CancellationTokenSource());
        }
    }
}
