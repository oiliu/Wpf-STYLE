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
using MahApps.Metro.Controls;

namespace WpfHeatMap.ComboxImage
{
    /// <summary>
    /// Interaction logic for ComboxImage.xaml
    /// </summary>
    public partial class ComboxImage : MetroWindow
    {
        public ComboxImage()
        {
            InitializeComponent();
        }


        private void BindCombox()
        {
            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            ShowSelfWindow.ShowSelf("提示",this.comboBox1.SelectedValue.ToString());
        }
    }
}
