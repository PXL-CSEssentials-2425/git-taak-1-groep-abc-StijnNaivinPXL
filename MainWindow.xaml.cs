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

        public MainWindow()
        {
            InitializeComponent();
            Red.MouseEnter += Red_MouseEnter;
            Red.MouseLeftButtonDown += Red_TextInfo;
            Red.MouseLeave += SetColorToGray;
            Blue.MouseEnter += Blue_MouseEnter;
            Blue.MouseLeftButtonDown += Blue_TextInfo;
            Blue.MouseLeave += SetColorToGray;
            Yellow.MouseEnter += Yellow_MouseEnter;
            Yellow.MouseLeftButtonDown += Yellow_TextInfo;
            Yellow.MouseLeave += SetColorToGray;
            Green.MouseEnter += Green_MouseEnter;
            Green.MouseLeftButtonDown += Green_TextInfo;
            Green.MouseLeave += SetColorToGray;
        }

        private void Red_TextInfo(object sender, MouseEventArgs e)
        {
            KleurenCodeTxt.Text = "#FF0000";
            InformatieTxt.Text = "Rood is de kleur van warmte.";
        }

        private void Yellow_TextInfo(object sender, MouseEventArgs e)
        {
            KleurenCodeTxt.Text = "#FFFF00";
            InformatieTxt.Text = "Geel is de kleur van levenslust";
        }

        private void Blue_TextInfo(object sender, MouseEventArgs e)
        {
            KleurenCodeTxt.Text = "#0000FF";
            InformatieTxt.Text = "Blauw is de kleur van intelligentie";
        }

        private void Green_TextInfo(object sender, MouseEventArgs e)
        {
            KleurenCodeTxt.Text = "#008000";
            InformatieTxt.Text = "Groen is de kleur van genezing";
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