using ManagementHotel.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ManagementHotel.ViewModels.EmployerVM
{
    public class EmployeeViewModel: BaseViewModel
    {
        private ObservableCollection<User> _ListUser;
        public ObservableCollection<User> ListUser { get => _ListUser; set { _ListUser = value; OnPropertyChanged(); } }

        private ObservableCollection<string> _MyItemsUser;
        public ObservableCollection<string> MyItemsUser { get => _MyItemsUser; set { _MyItemsUser = value; OnPropertyChanged(); } }

        private User _SelectedItem;
        public User SelectedItem
        {
            get => _SelectedItem;
            set
            {
                _SelectedItem = value;
                OnPropertyChanged();
                if (SelectedItem != null)
                {
                    Fullname = SelectedItem.Fullname;
                    Gender = SelectedItem.Gender;
                    Phone = SelectedItem.Phone;
                    Address = SelectedItem.Address;
                }
            }
        }

        private string _Fullname;
        public string Fullname { get => _Fullname; set { _Fullname = value; OnPropertyChanged(); } }

        private string _Gender;
        public string Gender { get => _Gender; set { _Gender = value; OnPropertyChanged(); } }

        private string _Phone;
        public string Phone { get => _Phone; set { _Phone = value; OnPropertyChanged(); } }

        private string _Address;
        public string Address { get => _Address; set { _Address = value; OnPropertyChanged(); } }


        public ICommand SearchCommand { get; set; }
        public ICommand AddCommand { get; set; }
        public ICommand UpdateCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand ListCommand { get; set; }

        void ComboBoxEmployee(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            List<string> items = new List<string>();
            for (int i = 0; i < ListUser.Count(); i++)
            {
                items.Add(ListUser[i].Fullname.ToString());
            }
            foreach (string fullname in items.Distinct())
            {
                MyItemsUser.Add(fullname);
            }
        }


        public EmployeeViewModel()
        {
            ListUser = new ObservableCollection<User>(DataProvider.Ins.DB.Users);
            MyItemsUser = new ObservableCollection<string>();
            ComboBoxEmployee(null, null);
            ListUser.CollectionChanged += ComboBoxEmployee;




            AddCommand = new RelayCommand<object>((p) =>
            {

                if (string.IsNullOrEmpty(Fullname) || string.IsNullOrEmpty(Gender) || string.IsNullOrEmpty(Phone) ||
                    string.IsNullOrEmpty(Address) )
                    return false;

                return true;
            }, (p) =>
            {
                var user = new User() { Fullname = Fullname, Gender = Gender, Phone = Phone, Address = Address};
                DataProvider.Ins.DB.Users.Add(user);
                DataProvider.Ins.DB.SaveChanges();
                MessageBox.Show("Add successful", "info", MessageBoxButton.OK);
                ListUser.Add(user);

                //Reset lại form thêm nhân viên
                Fullname = "";
                Gender = "";
                Phone = "";
                Address = "";
            });

            UpdateCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedItem == null)
                    return false;
                return true;
            }, (p) =>
            {

                var user = DataProvider.Ins.DB.Users.Where(x => x.Fullname == SelectedItem.Fullname).SingleOrDefault();
                user.Fullname = Fullname;
                user.Gender = Gender;
                user.Phone = Phone;
                user.Address = Address;
                DataProvider.Ins.DB.SaveChanges();
            });

            DeleteCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedItem == null)
                    return false;

                return true;
            }, (p) =>
            {
                var user = DataProvider.Ins.DB.Users.Where(x => x.Fullname == SelectedItem.Fullname).SingleOrDefault();
                DataProvider.Ins.DB.Users.Remove(user);
                DataProvider.Ins.DB.SaveChanges();
                ListUser.Remove(user);
            });

            SearchCommand = new RelayCommand<object>((p) =>
            {
                if (Fullname == "")
                {
                    ListUser = new ObservableCollection<User>(DataProvider.Ins.DB.Users);
                }
                return true;
            }, (p) =>
            {
                ListUser = new ObservableCollection<User>(DataProvider.Ins.DB.Users.Where(x => x.Fullname == Fullname));
            });
            ListCommand = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                ListUser = new ObservableCollection<User>(DataProvider.Ins.DB.Users);
            });
        }


    }
}
