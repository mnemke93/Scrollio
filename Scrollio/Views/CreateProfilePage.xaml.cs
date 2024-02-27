using Scrollio.Models;

namespace Scrollio.Views;

public partial class CreateProfilePage : ContentPage
{
	public CreateProfilePage(CreateProfileModel vm)
	{
		InitializeComponent();
        BindingContext = vm;
    }
}