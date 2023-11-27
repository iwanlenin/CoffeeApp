using CoffeeApp.View;

namespace CoffeeApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            //Routing.RegisterRoute(nameof(CoffeeUI), typeof(CoffeeUI));
        }
    }
}