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

namespace ManagementHotel.UserControlXAML.ManagerUC
{
    /// <summary>
    /// Interaction logic for Statistics.xaml
    /// </summary>
    public partial class Statistics : UserControl
    {
        public Statistics()
        {
            InitializeComponent();
        }

        private void TypeStatistics_SelectionChanged(object sender, RoutedEventArgs e)
        {
            int index = TypeStatistics.SelectedIndex;
            inday.Visibility = Visibility.Hidden;
            inmonth.Visibility = Visibility.Hidden;
            inquater.Visibility = Visibility.Hidden;
            inyear.Visibility = Visibility.Hidden;

            switch(index)
            {
                case 0:
                    inday.Visibility = Visibility.Visible;
                    break;
                case 1:
                    inmonth.Visibility = Visibility.Visible;
                    break;
                case 2:
                    inquater.Visibility = Visibility.Visible;
                    break;
                case 3:
                    inyear.Visibility = Visibility.Visible;
                    break;
            }
        }
    }
}
