using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;

namespace ToolKitMvvmTest03
{
    // 測試 ObservableRecipient & NotifyPropertyChangedRecipients
    public partial class SendViewModel01A : ObservableRecipient
    {
        [ObservableProperty]
        [NotifyPropertyChangedRecipients]
        private string? _name;

        //[ObservableProperty]
        //[NotifyPropertyChangedRecipients]
        //private object _name;

        [ObservableProperty]
        //[NotifyPropertyChangedRecipients]
        private string? _phone;

        public SendViewModel01A()
        {

        }

        [RelayCommand]
        private void TestClick()
        {
            Messenger.Send("Test");
        }
    }
}
