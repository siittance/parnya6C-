using CalendarEmocia1.ViewModel;
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
    /// Логика взаимодействия для EmociyaChill.xaml
    /// </summary>
    public partial class EmociyaChill : UserControl
    {
        public EmociyaChill()
        {
            InitializeComponent();
            DataContext = new VyborNastroeniaViewModel();
        }
    }
}
