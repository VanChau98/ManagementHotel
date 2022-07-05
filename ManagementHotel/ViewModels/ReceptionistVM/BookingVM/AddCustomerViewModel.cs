using ManagementHotel.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ManagementHotel.ViewModels.ReceptionistVM.BookingVM
{
    public class AddCustomerViewModel: BaseViewModel
    {

        private ObservableCollection<Room> _ListRoom;
        public ObservableCollection<Room> ListRoom { get => _ListRoom; set { _ListRoom = value; OnPropertyChanged(); } }

        private string _Cmnd;
        public string Cmnd { get => _Cmnd; set { _Cmnd = value; OnPropertyChanged(); } }

        private string _Fullname;
        public string Fullname { get => _Fullname; set { _Fullname = value; OnPropertyChanged(); } }

        private string _Phone;
        public string Phone { get => _Phone; set { _Phone = value; OnPropertyChanged(); } }

        private string _Gender;
        public string Gender { get => _Gender; set { _Gender = value; OnPropertyChanged(); } }

        private string _Address;
        public string Address { get => _Address; set { _Address = value; OnPropertyChanged(); } }


        //Choose room
        private string _Name;
        public string Name { get => _Name; set { _Name = value; OnPropertyChanged(); } }
        
        private string _TimeUsed;
        public string TimeUsed { get => _TimeUsed; set { _TimeUsed = value; OnPropertyChanged(); } }

        private DateTime _Checkin;
        public DateTime Checkin { get => _Checkin; set { _Checkin = value; OnPropertyChanged(); } }




        private ObservableCollection<String> _MyItemRoom;
        public ObservableCollection<String> MyItemRoom { get => _MyItemRoom; set { _MyItemRoom = value; OnPropertyChanged(); } }

        public ICommand SaveCommand { get; set; }

        void ComboBoxRoom(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            List<string> items = new List<string>();
            for (int i=0;i<ListRoom.Count();i++)
            {
                items.Add(ListRoom[i].Name.ToString());
            }
            foreach (string RoomName in items.Distinct())
            {
                MyItemRoom.Add(RoomName);
            }
        }


        public AddCustomerViewModel()
        {
            ListRoom = new ObservableCollection<Room>(DataProvider.Ins.DB.Rooms);
            MyItemRoom = new ObservableCollection<string>();
            ComboBoxRoom(null, null);
            ListRoom.CollectionChanged += ComboBoxRoom;


            SaveCommand = new RelayCommand<object>((p) =>
            {

                if (string.IsNullOrEmpty(Cmnd) || string.IsNullOrEmpty(Fullname) || string.IsNullOrEmpty(Phone) ||
                string.IsNullOrEmpty(Gender) || string.IsNullOrEmpty(Address) || string.IsNullOrEmpty(Name) ||
                string.IsNullOrEmpty(TimeUsed) || Checkin == null)
                    return false;
                return true;
            }, (p) =>
            {
                // Add customer
                var customer = new Customer() { Fullname = Fullname, Cmnd = Cmnd, Phone = Phone, Gender = Gender, Address = Address };
                DataProvider.Ins.DB.Customers.Add(customer);
                DataProvider.Ins.DB.SaveChanges();

                // Update status room
                var room = DataProvider.Ins.DB.Rooms.Where(x => x.Name == Name).SingleOrDefault();
                room.Status = "Using";

                //Booking
                var customerID = DataProvider.Ins.DB.Customers.Where(x => x.Fullname == Fullname).SingleOrDefault();
                var booking = new Booking() { CustomerID = customerID.Id, RoomID = room.Id, Checkin = Checkin, TimeUsed = TimeUsed, UserID = 1 };
                DataProvider.Ins.DB.Bookings.Add(booking);

                DataProvider.Ins.DB.SaveChanges();

                MessageBox.Show("Booking Successful", "info", MessageBoxButton.OK);

                //Reset booking 
                Cmnd = "";
                Fullname = "";
                Phone = "";
                Gender = "";
                Address = "";
                Name = "";
                TimeUsed = "";

            });



        }

    }
}
