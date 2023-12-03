using CoffeeApp.ViewModel;

namespace CoffeeApp.View
{
    public partial class CoffeeUI : ContentPage
    {
        public CoffeeUI()
        {
            InitializeComponent();
            this.BindingContext = new CoffeeUIViewModel();
        }

    
    }
}