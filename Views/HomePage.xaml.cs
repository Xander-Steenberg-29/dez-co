using Dez_Co.ViewModels;

namespace Dez_Co.Views;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
		BindingContext = new HomeViewModel();
	}
}
