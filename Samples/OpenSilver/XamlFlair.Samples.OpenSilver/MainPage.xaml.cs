using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace XamlFlair.Samples.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public static Frame RootFrame { get; private set; }

        public MainPage()
        {
            InitializeComponent();

            this.Loaded += (_, __) =>
            {
                RootFrame = MainFrame;

                RootFrame.Navigate(new Uri("/XamlFlair.Samples.OpenSilver;component/StartPage.xaml", UriKind.RelativeOrAbsolute));
            };
        }
    }
}
