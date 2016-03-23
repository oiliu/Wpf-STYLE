using System.Windows;
using System.Windows.Input;

namespace WpfHeatMap
{
    /// <summary>
    /// ShowSelfWindow.xaml 的交互逻辑
    /// </summary>
    public partial class ShowSelfWindow : Window
    {
        public ShowSelfWindow()
        {
            InitializeComponent();
        }
        public new string Title
        {
            get { return this.lblTitle.Text; }
            set { this.lblTitle.Text = value; }
        }

        public string Message
        {
            get { return this.lblMsg.Text; }
            set { this.lblMsg.Text = value; }
        }
        public static bool? ShowSelf(string msg, string title = "提示")
        {
            ShowSelfWindow msgBox = new ShowSelfWindow();
            msgBox.Title = title;
            msgBox.Message = msg;
            return msgBox.ShowDialog();
        }

        private void Yes_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DialogResult = true;
            this.Close();
        }
        private void No_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }
    }
}
