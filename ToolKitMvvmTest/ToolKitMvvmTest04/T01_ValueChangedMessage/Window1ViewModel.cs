using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;

namespace ToolKitMvvmTest04
{
    // 測試
    // 1. 傳送 ValueChangedMessage 類型訊息
    public partial class Window1ViewModel : ObservableRecipient
    {
        private T01ReceiveObject t01ReceiveObj;

        public Window1ViewModel()
        {
            t01ReceiveObj = new();
        }

        [RelayCommand]
        private void TestClick()
        {
            var random = new Random();
            double randomNum = Math.Round(random.NextDouble() * 100, 2);

            Messenger.Send(
                new ValueChangedMessage<double>(randomNum));
        }
    }
}
