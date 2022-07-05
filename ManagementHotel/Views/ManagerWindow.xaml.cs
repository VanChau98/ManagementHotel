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

namespace ManagementHotel.Views
{
    /// <summary>
    /// Interaction logic for ManagerWindow.xaml
    /// </summary>
    public partial class ManagerWindow : Window
    {
        public ManagerWindow()
        {
            InitializeComponent();
        }

        private void ListViewMenu_SelectionChanged(object sender, RoutedEventArgs e)
        {
            int index = ListViewMenu.SelectedIndex;
            customer.Visibility = Visibility.Hidden;
            room.Visibility = Visibility.Hidden;
            service.Visibility = Visibility.Hidden;
            statistics.Visibility = Visibility.Hidden;

            switch(index)
            {
                case 0:
                    customer.Visibility = Visibility.Visible;
                    break;
                case 1:
                    room.Visibility = Visibility.Visible;
                    break;
                case 2:
                    service.Visibility = Visibility.Visible;
                    break;
                case 3:
                    statistics.Visibility = Visibility.Visible;
                    break;
            }
        }
    }
}
