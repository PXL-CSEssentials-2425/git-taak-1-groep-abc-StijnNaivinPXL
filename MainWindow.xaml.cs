using System.Diagnostics;
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

namespace KleurAnalyse
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private Dictionary<string, string> Colors = new Dictionary<string, string>()
        {
            //Is this optimised? Nahh, but it is worth it.
            { "Green", "#008000" },
            { "Yellow", "#FFFF00" },
            { "Blue", "#0000FF" },
            { "Red", "#FF0000" }
        };

        public MainWindow()
        {
            InitializeComponent();
            Red.MouseEnter += Red_MouseEnter;
            Red.MouseLeave += SetColorToGray;
            Blue.MouseEnter += Blue_MouseEnter;
            Blue.MouseLeave += SetColorToGray;
            Yellow.MouseEnter += Yellow_MouseEnter;
            Yellow.MouseLeave += SetColorToGray;
            Green.MouseEnter += Green_MouseEnter;
            Green.MouseLeave += SetColorToGray;
        }

        private void Red_MouseEnter(object sender, MouseEventArgs e)
        {
            BackgroundGrid.Background = Brushes.Red;
        }

        private void Blue_MouseEnter(object sender, MouseEventArgs e)
        {
            BackgroundGrid.Background = Brushes.Blue;
        }

        private void Green_MouseEnter(object sender, MouseEventArgs e)
        {
            BackgroundGrid.Background = Brushes.Green;
        }

        private void Yellow_MouseEnter(object sender, MouseEventArgs e)
        {
            BackgroundGrid.Background = Brushes.Green;
        }

        private void SetColorToGray(object sender, RoutedEventArgs e)
        {
            BackgroundGrid.Background = Brushes.Gray;
        }
    }
}