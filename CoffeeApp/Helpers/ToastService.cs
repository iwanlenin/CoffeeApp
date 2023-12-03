using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeApp.Helpers
{
    public class ToastService
    {
        public static async Task ShowToastAsync(string message, ToastDuration duration, CancellationTokenSource cancellationTokenSource, double fontSize = 14)
        {
        
            var toast = Toast.Make(message, duration, fontSize);

            await toast.Show(cancellationTokenSource.Token);
        }
    }
}
