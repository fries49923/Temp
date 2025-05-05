using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.ComponentModel.DataAnnotations;
using System.Windows;

namespace ToolKitMvvmTest02
{
    public partial class MainWindowViewModel : ObservableValidator
    {
        [ObservableProperty]
        [NotifyDataErrorInfo]
        [Required]
        private string? _name;

        [ObservableProperty]
        [NotifyDataErrorInfo]
        [Required]
        [Phone]
        private string? _phone;

        [ObservableProperty]
        [NotifyDataErrorInfo]
        [Required]
        [EmailAddress]
        private string? _email;

        public MainWindowViewModel()
        {
            ValidateAllProperties();
        }

        [RelayCommand]
        private void ShowInfo()
        {
            if (HasErrors)
            {
                MessageBox.Show("HasErrors", "MessageBox");
                return;
            }

            string info = $"Name: {Name}\nPhone: {Phone}\nEmail: {Email}";
            MessageBox.Show(info, "MessageBox");
        }
    }
}
