using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;

namespace ToolKitMvvmTest03
{
    // 測試使用Token
    public partial class SendViewModel02A : ObservableRecipient
    {
        [ObservableProperty]
        [NotifyPropertyChangedRecipients]
        private string? _name;

        [ObservableProperty]
        //[NotifyPropertyChangedRecipients]
        private string? _phone;

        public SendViewModel02A()
        {

        }

        [RelayCommand]
        private void TestClick()
        {
            Messenger.Send("Test");
        }

        [RelayCommand]
        private void TestClick2()
        {
            Messenger.Send("Test", "TestToken");
        }
    }
}
