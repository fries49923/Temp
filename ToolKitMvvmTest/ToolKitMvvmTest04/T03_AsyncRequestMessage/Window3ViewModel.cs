using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;

namespace ToolKitMvvmTest04
{
    // 測試
    // 1. 傳送 AsyncRequestMessage 類型訊息
    public partial class Window3ViewModel : ObservableRecipient
    {
        private T03ReceiveObject t03ReceiveObj;

        public Window3ViewModel()
        {
            t03ReceiveObj = new();
        }

        [RelayCommand]
        private async Task TestClick()
        {
            // TODO: 使用方式是不是怪怪的?
            // TODO: HasReceivedResponse & GetAwaiter 的必要性?
            var req = new AsyncRequestMessage<Task<double>>();

            var repos = await Messenger.Send(req);

            var result = await repos;
            Console.WriteLine($"Task completed with result: {result}");
        }
    }
}

