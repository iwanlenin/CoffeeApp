

using CoffeeApp.ViewModel.DalleChallengeVM;

namespace CoffeeApp.View.DalleChallenge
{
public partial class DashboardView : ContentPage
{
	public DashboardView()
	{
		InitializeComponent();
	    BindingContext = new DashboardViewModel();
	}
}
}