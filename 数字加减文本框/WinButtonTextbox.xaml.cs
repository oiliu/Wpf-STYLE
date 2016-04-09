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
    /// WinButtonTextbox.xaml 的交互逻辑
    /// </summary>
    public partial class WinButtonTextbox : Window
    {
        public WinButtonTextbox()
        {
            InitializeComponent();
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            txtBox2.Text = (Convert.ToInt32(txtBox2.Text) + 1).ToString();
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(txtBox2.Text) > 1)
                txtBox2.Text = (Convert.ToInt32(txtBox2.Text) - 1).ToString();
        }
    }
}
