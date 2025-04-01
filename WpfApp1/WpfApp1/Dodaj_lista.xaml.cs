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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Logika interakcji dla klasy Dodaj_lista.xaml
    /// </summary>
    public partial class Dodaj_lista : Window
    {
        public Dodaj_lista()
        {
            InitializeComponent();
        }

        private void btn_anuluj(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btn_dodaj(object sender, RoutedEventArgs e)
        {
            var rnd = new Random();
            MainWindow mainWindow = new MainWindow();
            var p_imie = imie.Text;
            var p_nazwisko = nazwisko.Text;
            var p_pesel = pesel.Text;
            mainWindow.listview.Items.Add(new { m_nID = rnd.Next(), m_srtName = "adasd", m_strSname = "Mango", m_strPESEL = "099877676"});
            Close();
        }
    }
}
