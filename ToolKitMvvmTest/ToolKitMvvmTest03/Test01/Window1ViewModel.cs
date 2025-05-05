using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using System.Collections.ObjectModel;

namespace ToolKitMvvmTest03
{
    // 測試ViewModel使用空的Message Class
    public partial class Window1ViewModel : ObservableRecipient
    {
        public ObservableCollection<string> TestItemsCollection
        { get; private set; }

        public Window1ViewModel()
        {
            TestItemsCollection = new();
        }

        [RelayCommand]
        private void AddItemAndScrollToEnd()
        {
            int count = TestItemsCollection.Count;
            TestItemsCollection.Add($"Item{count}");

            // Send
            Messenger.Send<ScrollToEndMessage>();
        }
    }
}
