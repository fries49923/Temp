using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;

namespace ToolKitMvvmTest04
{
    // 測試
    // 1. 普通類別使用 Weak 接收
    // 2. 接收 AsyncRequestMessage 類型訊息並回覆
    public class T03ReceiveObject
    {
        public T03ReceiveObject()
        {
            WeakReferenceMessenger.Default
                .Register<AsyncRequestMessage<Task<double>>>(
                this, (r, m) => m.Reply(Receive()));
        }

        private async Task<double> Receive()
        {
            Console.WriteLine($"T03ReceiveObj Receive a RequestMessage");

            // 模擬處理中，沒有馬上回覆的狀況
            await Task.Delay(TimeSpan.FromSeconds(2));

            var random = new Random();
            double randomNum = Math.Round(random.NextDouble() * 100, 2);

            Console.WriteLine($"T03ReceiveObj Prepare Reply: {randomNum}");

            return randomNum;
        }
    }
}
