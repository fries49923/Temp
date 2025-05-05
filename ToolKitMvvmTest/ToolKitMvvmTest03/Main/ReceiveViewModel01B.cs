using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;

namespace ToolKitMvvmTest03
{
    // 測試 ObservableRecipient
    public partial class ReceiveViewModel01B : ObservableRecipient
    {
        public ReceiveViewModel01B()
        {
            IsActive = true;
        }

        protected override void OnActivated()
        {
            Messenger.Register<PropertyChangedMessage<string>>(
                this, (r, m) => Receive(m));

            Messenger.Register<string>(
                this, (r, m) => Receive(m));

        }

        protected void Receive(PropertyChangedMessage<string> message)
        {
            var obj = message.NewValue;
        }

        protected void Receive(string message)
        {
            var obj = message;
        }
    }
}
