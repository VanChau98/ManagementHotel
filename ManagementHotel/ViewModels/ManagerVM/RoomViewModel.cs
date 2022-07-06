using ManagementHotel.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ManagementHotel.ViewModels.ManagerVM
{
    public class RoomViewModel: BaseViewModel
    {
        private ObservableCollection<Room> _ListRoom;
        public ObservableCollection<Room> ListRoom { get => _ListRoom; set { _ListRoom = value; OnPropertyChanged(); } }

        private ObservableCollection<string> _MyItemsRoom;
        public ObservableCollection<string> MyItemsRoom { get => _MyItemsRoom; set { _MyItemsRoom = value; OnPropertyChanged(); } }

        private Room _SelectedItem;
        public Room SelectedItem
        {
            get => _SelectedItem;
            set
            {
                _SelectedItem = value;
                OnPropertyChanged();
                if (SelectedItem != null)
                {
                    Name = SelectedItem.Name;
                    TypeRoom = SelectedItem.TypeRoom;
                    Price = SelectedItem.Price;
                    Status = SelectedItem.Status;
                }
            }
        }

        private string _Name;
        public string Name { get => _Name; set { _Name = value; OnPropertyChanged(); } }

        private string _SearchName;
        public string SearchName { get => _SearchName; set { _SearchName = value; OnPropertyChanged(); } }

        private string _TypeRoom;
        public string TypeRoom { get => _TypeRoom; set { _TypeRoom = value; OnPropertyChanged(); } }

        private int? _Price;
        public int? Price { get => _Price; set { _Price = value; OnPropertyChanged(); } }

        private string _Status;
        public string Status { get => _Status; set { _Status = value; OnPropertyChanged(); } }


        public ICommand SearchCommand { get; set; }
        public ICommand AddCommand { get; set; }
        public ICommand UpdateCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand ListCommand { get; set; }

        void ComboBoxRoom(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            List<string> items = new List<string>();
            for (int i = 0; i < ListRoom.Count(); i++)
            {
                items.Add(ListRoom[i].Name.ToString());
            }
            foreach (string fullname in items.Distinct())
            {
                MyItemsRoom.Add(fullname);
            }
        }


        public RoomViewModel()
        {
            ListRoom = new ObservableCollection<Room>(DataProvider.Ins.DB.Rooms);
            MyItemsRoom = new ObservableCollection<string>();
            ComboBoxRoom(null, null);
            ListRoom.CollectionChanged += ComboBoxRoom;




            AddCommand = new RelayCommand<object>((p) =>
            {

                if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(TypeRoom) || Price == null ||
                    string.IsNullOrEmpty(Status) )
                    return false;

                return true;
            }, (p) =>
            {
                var room = new Room() { Name = Name, TypeRoom = TypeRoom, Price = Price, Status = Status };
                DataProvider.Ins.DB.Rooms.Add(room);
                DataProvider.Ins.DB.SaveChanges();
                MessageBox.Show("Add successful", "info", MessageBoxButton.OK);
                ListRoom.Add(room);

                //Reset form
                Name = "";
                TypeRoom = "";
                Price = null;
                Status = "";
            });

            UpdateCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedItem == null)
                    return false;
                return true;
            }, (p) =>
            {

                var room = DataProvider.Ins.DB.Rooms.Where(x => x.Name == SelectedItem.Name).SingleOrDefault();
                room.Name = Name;
                room.TypeRoom = TypeRoom;
                room.Price = Price;
                room.Status = Status;
                DataProvider.Ins.DB.SaveChanges();
            });

            DeleteCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedItem == null)
                    return false;

                return true;
            }, (p) =>
            {
                var room = DataProvider.Ins.DB.Rooms.Where(x => x.Name == SelectedItem.Name).SingleOrDefault();
                DataProvider.Ins.DB.Rooms.Remove(room);
                DataProvider.Ins.DB.SaveChanges();
                ListRoom.Remove(room);
            });

            SearchCommand = new RelayCommand<object>((p) =>
            {
                if (SearchName == "")
                {
                    ListRoom = new ObservableCollection<Room>(DataProvider.Ins.DB.Rooms);
                }
                return true;
            }, (p) =>
            {
                ListRoom = new ObservableCollection<Room>(DataProvider.Ins.DB.Rooms.Where(x => x.Name == SearchName));
            });

            ListCommand = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                ListRoom = new ObservableCollection<Room>(DataProvider.Ins.DB.Rooms);
            });
        }
    }
}
