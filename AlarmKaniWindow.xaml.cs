using System.Windows;

namespace alarm_vs_preview61825at113pm
{
    
    public partial class AlarmKaniWindow : Window
    {
        public string myText { get; set; }
        public AlarmKaniWindow(string myText)
        {
            InitializeComponent();
            this.Topmost = true;
            Mb1_0Tb.Text = myText;
        }


        private void AlarmNoticeXButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        private void AlarmNoticeOkButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
