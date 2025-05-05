using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;

namespace ToolKitMvvmTest04
{
    // 測試
    // 1. 普通類別使用 Weak 接收
    // 2. 接收 ValueChangedMessage 類型訊息
    public class T01ReceiveObject
    {
        public T01ReceiveObject()
        {
            WeakReferenceMessenger.Default
                .Register<ValueChangedMessage<double>>(
                this, (r, m) => Receive(m));
        }

        private void Receive(ValueChangedMessage<double> m)
        {
            Console.WriteLine($"T01ReceiveObject Receive m = {m.Value}");
        }
    }
}
