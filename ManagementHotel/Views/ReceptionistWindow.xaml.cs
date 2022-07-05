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
    /// Interaction logic for ReceptionistWindow.xaml
    /// </summary>
    public partial class ReceptionistWindow : Window
    {
        public ReceptionistWindow()
        {
            InitializeComponent();
        }

        private void ReceptionistMenu_SelectionChanged(object sender, RoutedEventArgs e)
        {
            int index = ReceptionistMenu.SelectedIndex;
            booking.Visibility = Visibility.Hidden;
            room.Visibility = Visibility.Hidden;
            service.Visibility = Visibility.Hidden;
            exportOrder.Visibility = Visibility.Hidden;

            switch (index)
            {
                case 0:
                    booking.Visibility = Visibility.Visible;
                    break;
                case 1:
                    room.Visibility = Visibility.Visible;
                    break;
                case 2:
                    service.Visibility = Visibility.Visible;
                    break;
                case 3:
                    exportOrder.Visibility = Visibility.Visible;
                    break;
            }
        }
    }
}
