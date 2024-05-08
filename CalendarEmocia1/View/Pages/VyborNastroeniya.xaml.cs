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

namespace CalendarEmocia1.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для VyborNastroeniya.xaml
    /// </summary>
    public partial class VyborNastroeniya : Page
    {
        DateTime date = DateTime.Now;
        public VyborNastroeniya(DateTime date)
        {
            InitializeComponent();
            Dni.Text = date.ToString("dd MMMM yyyy г.");
            DataContext = new VyborNastroeniaViewModel();
        }

        private void perexod()
        {
            VozvratKCalendaru.Content = new Stranica30Day();
        }
        private void ReturnVCalendar(object sender, RoutedEventArgs e)
        {
            perexod();
        }

        private void SaveAndExit(object sender, RoutedEventArgs e)
        {
            perexod();
        }
    }
}
