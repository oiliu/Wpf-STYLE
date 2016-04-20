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
using System.Windows.Threading;
using MahApps.Metro.Controls;

namespace WpfHeatMap
{
    /// <summary>
    /// Win2.xaml 的交互逻辑
    /// </summary>
    public partial class WinSkin2 : Window
    {
        private DispatcherTimer timer = null;
        private int timer_i = 5;
        public WinSkin2()
        {
            InitializeComponent();
            GloablPra.ChangeSkin();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer_i--;
            label_timerJ.Content = timer_i;
            if (timer_i == 0)
            {
                timer.Stop();
                this.Close();
            }
        }
    }
}
