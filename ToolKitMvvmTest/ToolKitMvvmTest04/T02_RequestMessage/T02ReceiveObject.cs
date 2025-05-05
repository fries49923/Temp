using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;

namespace ToolKitMvvmTest04
{
    // 測試
    // 1. 普通類別使用 Weak 接收
    // 2. 接收 RequestMessage 類型訊息並回覆
    public class T02ReceiveObject
    {
        public T02ReceiveObject()
        {
            WeakReferenceMessenger.Default
                .Register<RequestMessage<double>>(
                this, (r, m) => Receive(m));

            // TODO: 這樣好像一樣?
            //WeakReferenceMessenger.Default
            //    .Register<RequestMessage<double>>(
            //    this, (r, m) =>
            //    {
            //        m.Reply(Receive2());
            //    });
        }

        //private void Receive(RequestMessage<double> m)
        //{
        //    Console.WriteLine($"T02ReceiveObj Receive a RequestMessage");

        //    Thread.Sleep(TimeSpan.FromSeconds(2));

        //    var random = new Random();
        //    double randomNum = Math.Round(random.NextDouble() * 100, 2);

        //    Console.WriteLine($"T02ReceiveObj Prepare Reply: {randomNum}");

        //    m.Reply(randomNum);
        //}

        private void Receive(RequestMessage<double> m)
        {
            Console.WriteLine($"T02ReceiveObj Receive a RequestMessage");

            // 模擬處理中，沒有馬上回覆的狀況
            _ = Task.Run(() =>
            {
                Thread.Sleep(TimeSpan.FromSeconds(2));

                var random = new Random();
                double randomNum = Math.Round(random.NextDouble() * 100, 2);

                Console.WriteLine($"T02ReceiveObj Prepare Reply: {randomNum}");

                m.Reply(randomNum);
            });
        }

        private double Receive2()
        {
            var random = new Random();
            return Math.Round(random.NextDouble() * 100, 2);
        }
    }
}
