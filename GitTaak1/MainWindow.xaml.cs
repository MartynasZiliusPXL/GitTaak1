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

namespace GitTaak1
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

        private void Film1_Click(object sender, MouseButtonEventArgs e)
        {
            titelLabel.Content = "Dune: Part Two";
            beschrijvingTextBlock.Text = "Paul Atreides unites with Chani and the Fremen while seeking revenge against the conspirators who destroyed his family.";
        }

        private void Film2_Click(object sender, MouseButtonEventArgs e)
        {
            titelLabel.Content = "Furiosa: A Mad Max Saga";
            beschrijvingTextBlock.Text = "The origin story of renegade warrior Furiosa before her encounter and teamup with Mad Max.";
        }

        private void Film3_Click(object sender, MouseButtonEventArgs e)
        {
            titelLabel.Content = "The Substance";
            beschrijvingTextBlock.Text = "A fading celebrity decides to use a black-market drug, a cell-replicating substance that temporarily creates a younger, better version of herself.";
        }
    }
}