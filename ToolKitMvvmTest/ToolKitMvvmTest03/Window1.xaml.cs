using CommunityToolkit.Mvvm.Messaging;
using System.Windows;

namespace ToolKitMvvmTest03
{
    /// <summary>
    /// Window1.xaml 的互動邏輯
    /// </summary>

    // 測試View使用WeakReferenceMessenger
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();

            WeakReferenceMessenger.Default.Register<ScrollToEndMessage>(
                this, (r, m) => ScrollToEndTest());
        }

        private void ScrollToEndTest()
        {
            var listBox = listBoxTest;
            if (listBox.Items.Count > 0)
            {
                var lastItem = listBox.Items[^1];
                listBox.ScrollIntoView(lastItem);
            }
        }
    }
}
