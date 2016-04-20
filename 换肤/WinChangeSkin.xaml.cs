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
using MahApps.Metro.Controls;
using System.Windows.Media.Animation;

namespace WpfHeatMap
{
    /// <summary>
    /// WinChangeSkin.xaml 的交互逻辑
    /// </summary>
    public partial class WinChangeSkin : MetroWindow
    {
        public WinChangeSkin()
        {
            InitializeComponent();

            btnChangeSkin(blackBtn);
        }

        private void whiteBtn_Click(object sender, RoutedEventArgs e)
        {
            btnChangeSkin(sender);
        }

        private void blackBtn_Click(object sender, RoutedEventArgs e)
        {
            btnChangeSkin(sender);
        }

        private void btnChangeSkin(object sender)
        {
            Button btnSkin = (Button)sender;
            string skinDictPath = btnSkin.Tag as string;
            GloablPra.skinDictPath = skinDictPath;
            GloablPra.ChangeSkin();
        }

        private void win2Btn_Click(object sender, RoutedEventArgs e)
        {
            WinSkin2 w2 = new WinSkin2();
            w2.ShowDialog();
        }

        private bool isSkin = true;
        private void btnTitleBarSkin_Click(object sender, RoutedEventArgs e)
        {

            if (isSkin)
            {
                canvasSkin.Visibility = Visibility.Visible;
                isSkin = false;
                DoubleAnimation d = new DoubleAnimation();
                d.Duration = new Duration(TimeSpan.FromSeconds(2));
                d.From = 0;
                d.To = 1;
                canvasSkin.BeginAnimation(OpacityProperty, d);
            }
            else
            {
                canvasSkin.Visibility = Visibility.Collapsed;
                isSkin = true;
            }

        }
    }
}
