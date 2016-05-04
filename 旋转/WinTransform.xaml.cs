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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfHeatMap
{
    /// <summary>
    /// WinTransform.xaml 的交互逻辑
    /// </summary>
    public partial class WinTransform : Window
    {
        public WinTransform()
        {
            InitializeComponent();
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            RoteTransformGrid(90, 0);
        }

        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            RoteTransformGrid(0, 90);
        }

        private void RoteTransformGrid(double from,double to)
        {
            RotateTransform rtf = new RotateTransform();
            btn_transForm.RenderTransform = rtf;
            DoubleAnimation dbAscending = new DoubleAnimation(from, to, new Duration(TimeSpan.FromSeconds(1)));
            rtf.BeginAnimation(RotateTransform.AngleProperty, dbAscending);
        }
    }
}
