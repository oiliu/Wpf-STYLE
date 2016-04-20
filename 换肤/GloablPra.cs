using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace WpfHeatMap
{
    public static class GloablPra
    {
        public static string skinDictPath = "";
        public static void ChangeSkin()
        {   
            Uri skinDictUri = new Uri(skinDictPath, UriKind.Relative);
            // Tell the Application to load the skin resources.
            App app = Application.Current as App;
            app.ApplySkin(skinDictUri);
        }
    }
}
