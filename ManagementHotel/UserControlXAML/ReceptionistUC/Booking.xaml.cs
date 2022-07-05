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

namespace ManagementHotel.UserControlXAML.ReceptionistUC
{
    /// <summary>
    /// Interaction logic for Booking.xaml
    /// </summary>
    public partial class Booking : UserControl
    {
        public Booking()
        {
            InitializeComponent();
        }

        private void BookingMenu_SelectionChanged(object sender, RoutedEventArgs e)
        {
            int index = BookingMenu.SelectedIndex;
            addService.Visibility = Visibility.Hidden;

            switch (index)
            {
                case 0:
                    addCustomer.Visibility = Visibility.Visible;
                    break;
                case 1:
                    addService.Visibility = Visibility.Visible;
                    break;
            }
        }
    }
}
