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
            toonAantalKoekjes(koekjesAantal);
        }
        public void toonAantalKoekjes(int aantal)
        {
            Mw.Title = $"score:{aantal}";
            lblScore.Content = $"score: {aantal}";
        }
        private void ImgKoekje_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ImgKoekje.Width = 50;
            koekjesAantal++;
            toonAantalKoekjes(koekjesAantal);
        }

        private void ImgKoekje_MouseUp(object sender, MouseButtonEventArgs e)
        {
            ImgKoekje.Width = 70;
           
        }
    }
}
