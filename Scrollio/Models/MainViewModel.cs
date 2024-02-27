using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrollio.Models
{
    public partial class MainViewModel : ObservableObject
    {
        [RelayCommand]
        async Task CreateProfilePage()
        {
            try
            {
                await Shell.Current.GoToAsync(nameof(CreateProfilePage));
            }
            catch (Exception ex)
            {
                // Log or handle the navigation error
                Console.WriteLine($"Navigation error: {ex.Message}");
            }

        }
    }
}
