using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;

namespace ToolKitMvvmTest03
{
    // 測試使用Token
    public partial class ReceiveViewModel02A : ObservableRecipient
    {
        public ReceiveViewModel02A()
        {
            IsActive = true;
        }

        protected override void OnActivated()
        {
            Messenger.Register<string, string>(
                this, "TestToken", (r, m) => Receive(m));
        }

        protected void Receive(string message)
        {
            var obj = message;
        }
    }
}
