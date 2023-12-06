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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(texta.Text, out int a);
            int.TryParse(textb.Text, out int b);
            ergebnis.Text = Mathe.plus(a, b).ToString();
        }

        private void mal_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(texta.Text, out int a);
            int.TryParse(textb.Text, out int b);
            ergebnis.Text = Mathe.mal(a, b).ToString();
        }

        private void geteilt_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(texta.Text, out int a);
            int.TryParse(textb.Text, out int b);
            ergebnis.Text = Mathe.geteilt(a, b).ToString();
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(texta.Text, out int a);
            int.TryParse(textb.Text, out int b);
            ergebnis.Text = Mathe.minus(a, b).ToString();
        }
    }
}