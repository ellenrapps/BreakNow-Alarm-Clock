using System.Windows;


namespace alarm_vs_preview61825at113pm
{
    
    public partial class WindowFaq : Window
    {
        public WindowFaq()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.Manual;
            var desktopWorkingArea = System.Windows.SystemParameters.WorkArea;
            this.Left = desktopWorkingArea.Right - this.Width;
            this.Top = desktopWorkingArea.Bottom - this.Height;
        }

        private void WindowFaqCloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void WindowFaqMinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

    }
}
