using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Scrollio.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrollio.Models
{
    public partial class CreateProfileModel : ObservableObject
    {
        private string _profileName;
        public string ProfileName
        {
            get => _profileName;
            set => SetProperty(ref _profileName, value);
        }

        [RelayCommand]
        async Task SubmitProfile()
        {
            var directoryPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), ProfileName);

            // Attempt to create the directory and navigate only if directory creation is successful
            try
            {
                if (Directory.Exists(directoryPath))
                {
                    // Directory already exists
                    System.Diagnostics.Debug.WriteLine("Directory already exists.");
                    return; // Early return to prevent further execution
                }

                // Directory does not exist, create it
                Directory.CreateDirectory(directoryPath);
                System.Diagnostics.Debug.WriteLine("Directory created successfully.");

                // Navigation or success message logic here
                await Shell.Current.GoToAsync("..");
            }
            catch (Exception ex)
            {
                // Log or handle the error
                System.Diagnostics.Debug.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
