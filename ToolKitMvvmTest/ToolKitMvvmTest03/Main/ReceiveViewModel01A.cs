using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;

namespace ToolKitMvvmTest03
{
    // 測試 IRecipient
    public partial class ReceiveViewModel01A : ObservableObject, IRecipient<PropertyChangedMessage<string>>
    {
        public ReceiveViewModel01A()
        {
            WeakReferenceMessenger.Default.Register(this);
        }

        // PropertyChangedMessage<object>
        public void Receive(PropertyChangedMessage<string> message)
        {
            var obj = message.NewValue;
        }
    }
}
