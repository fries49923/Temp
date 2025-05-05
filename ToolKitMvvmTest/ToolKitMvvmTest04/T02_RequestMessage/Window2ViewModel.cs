using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;

namespace ToolKitMvvmTest04
{
    // 測試
    // 1. 傳送  類型訊息
    public partial class Window2ViewModel : ObservableRecipient
    {
        private T02ReceiveObject t02ReceiveObj;

        public Window2ViewModel()
        {
            t02ReceiveObj = new();
        }

        [RelayCommand]
        private void TestClick()
        {
            //TestClick01();
            TestClick02();
        }

        // 單次讀取是否有回覆，如果時序一個不對會漏接
        private void TestClick01()
        {
            var req = new RequestMessage<double>();

            Messenger.Send(req);

            if (req.HasReceivedResponse is true)
            {
                Console.WriteLine($"HasReceivedResponse: true");
                Console.WriteLine($"Response: {req.Response}");
            }
            else
            {
                Console.WriteLine($"HasReceivedResponse: false");
            }
        }

        // 持續讀取是否有回覆
        private void TestClick02()
        {
            var req = new RequestMessage<double>();

            Messenger.Send(req);

            while (req.HasReceivedResponse is false)
            {
                Console.WriteLine($"HasReceivedResponse: false");
                Thread.Sleep(500);
            }

            Console.WriteLine($"HasReceivedResponse: true");
            Console.WriteLine($"Response: {req.Response}");
        }
    }
}
