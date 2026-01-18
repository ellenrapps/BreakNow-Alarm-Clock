using System.Windows;


namespace alarm_vs_preview61825at113pm
{
    
    public partial class TimerKani : Window
    {
        public TimerKani()
        {
            InitializeComponent();
            this.Topmost = true;
        }

        private void TimerNoticeXButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void TimerNoticeOkButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
