using CommunityToolkit.Mvvm.ComponentModel;

namespace ToolKitMvvmTest03
{
    public partial class MainWindowViewModel : ObservableObject
    {
        public SendViewModel02A SendViewModel
        { get; protected set; }

        public ReceiveViewModel02A RecViewModel
        { get; protected set; }

        public MainWindowViewModel()
        {
            SendViewModel = new();
            RecViewModel = new();
        }
    }
}
