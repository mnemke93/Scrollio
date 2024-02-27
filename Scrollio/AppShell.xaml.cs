using Scrollio.Views;

namespace Scrollio
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
            Routing.RegisterRoute(nameof(CreateProfilePage), typeof(CreateProfilePage));
        }
    }
}
