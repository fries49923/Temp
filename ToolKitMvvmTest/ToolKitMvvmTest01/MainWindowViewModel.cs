using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows;

namespace ToolKitMvvmTest01
{
    public partial class MainWindowViewModel : ObservableObject
    {
        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(ShowInfoCommand))]
        private string? _name;

        [ObservableProperty]
        private string? _phone;

        private bool CanShowInfo()
        {
            return !string.IsNullOrEmpty(Name);
        }

        [RelayCommand(CanExecute = nameof(CanShowInfo))]
        private async Task ShowInfo()
        {
            await Task.Delay(500);
            string info = $"Name: {Name}\nPhone: {Phone}";
            MessageBox.Show(info, "MessageBox");
        }

        [RelayCommand]
        private async Task ShowNote(string? str)
        {
            await Task.Delay(500);
            string info = $"Note: {str}";
            MessageBox.Show(info, "MessageBox");
        }
    }
}
