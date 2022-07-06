using ManagementHotel.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ManagementHotel.ViewModels.ReceptionistVM.BookingVM
{
    public class AddServiceViewModel: BaseViewModel
    {
        private ObservableCollection<Room> _ListRoom;
        public ObservableCollection<Room> ListRoom { get => _ListRoom; set { _ListRoom = value; OnPropertyChanged(); } }

        private ObservableCollection<BookingService> _ListService;
        public ObservableCollection<BookingService> ListService { get => _ListService; set { _ListService = value; OnPropertyChanged(); } }

        private string _Name;
        public string Name { get => _Name; set { _Name = value; OnPropertyChanged(); } }

        private ObservableCollection<String> _MyItemRoom;
        public ObservableCollection<String> MyItemRoom { get => _MyItemRoom; set { _MyItemRoom = value; OnPropertyChanged(); } }

        public ICommand AddServiceCommand { get; set; }


        void ComboBoxRoom(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            List<string> items = new List<string>();
            for (int i = 0; i < ListRoom.Count(); i++)
            {
                items.Add(ListRoom[i].Name.ToString());
            }
            foreach (string RoomName in items.Distinct())
            {
                MyItemRoom.Add(RoomName);
            }
        }

        public AddServiceViewModel()
        {
            ListRoom = new ObservableCollection<Room>(DataProvider.Ins.DB.Rooms);
            MyItemRoom = new ObservableCollection<string>();
            ComboBoxRoom(null, null);
            ListRoom.CollectionChanged += ComboBoxRoom;

            ListService = new ObservableCollection<BookingService>(DataProvider.Ins.DB.BookingServices);

            AddServiceCommand = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {

            });
        }
    }
}
