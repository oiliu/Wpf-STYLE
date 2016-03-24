using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfHeatMap
{
    /// <summary>
    /// ExtraTimeWindow.xaml 的交互逻辑
    /// </summary>
    public partial class ExtraTimeWindow : Window
    {
        public ExtraTimeWindow()
        {
            InitializeComponent();
        }
        public TextBlock t = null;
        public System.Windows.Threading.DispatcherTimer timer = null;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            t.Text = (Convert.ToInt32(this.combox_ExtraTime.SelectionBoxItem) - 1).ToString() + ":59";
            timer.Start();
            this.Close();
        }
    }
}
