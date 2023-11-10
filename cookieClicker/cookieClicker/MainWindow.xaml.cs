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

namespace cookieClicker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //initialize int variable voor het bijhouden,tonen en optellen van aantal klicks 
        int koekjesAantal;
        public MainWindow()
        {
            InitializeComponent();
            Mw.Title = $"score:{koekjesAantal}";
            lblScore.Content = $"score: {koekjesAantal}";
        }

        private void imgKoekje_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void ImgKoekje_MouseUp(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
