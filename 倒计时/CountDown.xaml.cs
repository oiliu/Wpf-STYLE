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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WpfHeatMap
{
    /// <summary>
    /// CountDown.xaml 的交互逻辑
    /// </summary>
    public partial class CountDown : UserControl
    {
        DispatcherTimer timer = null;
        public CountDown()
        {
            InitializeComponent();
            CountDownP();
        }
        private void CountDownP()
        {
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += new EventHandler(timer_tick);
            timer.Start();
        }
        private void timer_tick(object sender, EventArgs e)
        {
            if (textblockCount.Text != "00:00")
            {
                int hour = Convert.ToInt32(textblockCount.Text.Split(':')[0]);
                int second = Convert.ToInt32(textblockCount.Text.Split(':')[1]);
                second--;
                if (hour == 0 && second == 0)
                {
                    timer.Stop();
                    if(MessageBox.Show("比赛结束！是否加时！", "提示", MessageBoxButton.YesNo, MessageBoxImage.Question)==MessageBoxResult.Yes)
                    {
                        ExtraTimeWindow w = new ExtraTimeWindow();
                        w.t = textblockCount;
                        w.timer = timer;
                        w.ShowDialog();
                        hour = Convert.ToInt32(textblockCount.Text.Split(':')[0]);
                        second = Convert.ToInt32(textblockCount.Text.Split(':')[1]);
                    }
                }
                if (second == 0 && hour != 0)
                {
                    hour--;
                    second = 10;
                }
                string h = hour <= 9 ? "0" + hour.ToString() : hour.ToString();
                string s = second <= 9 ? "0" + second.ToString() : second.ToString();
                this.textblockCount.Text = h + ":" + s;
            }
        }
    }
}
