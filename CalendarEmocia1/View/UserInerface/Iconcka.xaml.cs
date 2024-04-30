using CalendarEmocia1.View.Pages;
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

namespace CalendarEmocia1.View.UserInerface
{
    /// <summary>
    /// Логика взаимодействия для Iconcka.xaml
    /// </summary>
    public partial class Iconcka : UserControl
    {
        public string Icon { get; set; }
        DateTime date1 = DateTime.Now;
        public Iconcka(DateTime date)
        {
            InitializeComponent();
            DataContext = this;
            date1 = date;
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ((Application.Current.MainWindow as MainWindow).FrameStranica31Day.Content as Stranica30Day).VyborKakoiTiSegodnya.Content = new VyborNastroeniya(date1);

        }

        private void KnopkaDate_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            ContextMenu contextMenu = new ContextMenu();

            MenuItem viewItem = new MenuItem { Header = "Просмотреть" };
            MenuItem clearItem = new MenuItem { Header = "Очистить" };

            contextMenu.Items.Add(viewItem);
            contextMenu.Items.Add(clearItem);

            viewItem.Click += ViewItem_Click;
            contextMenu.IsOpen = true;


        }

        private void ViewItem_Click(object sender, RoutedEventArgs e)
        {
            ((Application.Current.MainWindow as MainWindow).FrameStranica31Day.Content as Stranica30Day).VyborKakoiTiSegodnya.Content = new VyborNastroeniya(date1);
        }
    }
}
