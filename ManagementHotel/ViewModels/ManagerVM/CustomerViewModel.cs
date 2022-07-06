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
    public class CustomerViewModel: BaseViewModel
    {
        private ObservableCollection<Customer> _ListCustomer;
        public ObservableCollection<Customer> ListCustomer { get => _ListCustomer; set { _ListCustomer = value; OnPropertyChanged(); } }

        private ObservableCollection<string> _MyItemsCustomer;
        public ObservableCollection<string> MyItemsCustomer { get => _MyItemsCustomer; set { _MyItemsCustomer = value; OnPropertyChanged(); } }

        private Customer _SelectedItem;
        public Customer SelectedItem
        {
            get => _SelectedItem;
            set
            {
                _SelectedItem = value;
                OnPropertyChanged();
                if (SelectedItem != null)
                {
                    Fullname = SelectedItem.Fullname;
                    Cmnd = SelectedItem.Cmnd;
                    Gender = SelectedItem.Gender;
                    Phone = SelectedItem.Phone;
                    Address = SelectedItem.Address;
                }
            }
        }

        private string _Fullname;
        public string Fullname { get => _Fullname; set { _Fullname = value; OnPropertyChanged(); } }

        private string _SearchFullname;
        public string SearchFullname { get => _SearchFullname; set { _SearchFullname = value; OnPropertyChanged(); } }

        private string _Gender;
        public string Gender { get => _Gender; set { _Gender = value; OnPropertyChanged(); } }

        private string _Phone;
        public string Phone { get => _Phone; set { _Phone = value; OnPropertyChanged(); } }

        private string _Address;
        public string Address { get => _Address; set { _Address = value; OnPropertyChanged(); } }

        private string _Cmnd;
        public string Cmnd { get => _Cmnd; set { _Cmnd = value; OnPropertyChanged(); } }


        public ICommand SearchCommand { get; set; }
        public ICommand AddCommand { get; set; }
        public ICommand UpdateCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand ListCommand { get; set; }

        void ComboBoxCustomer(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            List<string> items = new List<string>();
            for (int i = 0; i < ListCustomer.Count(); i++)
            {
                items.Add(ListCustomer[i].Fullname.ToString());
            }
            foreach (string fullname in items.Distinct())
            {
                MyItemsCustomer.Add(fullname);
            }
        }


        public CustomerViewModel()
        {
            ListCustomer = new ObservableCollection<Customer>(DataProvider.Ins.DB.Customers);
            MyItemsCustomer = new ObservableCollection<string>();
            ComboBoxCustomer(null, null);
            ListCustomer.CollectionChanged += ComboBoxCustomer;




            AddCommand = new RelayCommand<object>((p) =>
            {

                if (string.IsNullOrEmpty(Fullname) || string.IsNullOrEmpty(Gender) || string.IsNullOrEmpty(Phone) ||
                    string.IsNullOrEmpty(Address)||string.IsNullOrEmpty(Cmnd))
                    return false;

                return true;
            }, (p) =>
            {
                var customer = new Customer() { Fullname = Fullname, Gender = Gender,Cmnd=Cmnd, Phone = Phone, Address = Address };
                DataProvider.Ins.DB.Customers.Add(customer);
                DataProvider.Ins.DB.SaveChanges();
                MessageBox.Show("Add successful", "info", MessageBoxButton.OK);
                ListCustomer.Add(customer);

                //Reset lại form thêm nhân viên
                Fullname = "";
                Gender = "";
                Cmnd = "";
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

                var customer = DataProvider.Ins.DB.Customers.Where(x => x.Fullname == SelectedItem.Fullname).SingleOrDefault();
                customer.Fullname = Fullname;
                customer.Gender = Gender;
                customer.Cmnd = Cmnd;
                customer.Phone = Phone;
                customer.Address = Address;
                DataProvider.Ins.DB.SaveChanges();
            });

            DeleteCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedItem == null)
                    return false;

                return true;
            }, (p) =>
            {
                var customer = DataProvider.Ins.DB.Customers.Where(x => x.Fullname == SelectedItem.Fullname).SingleOrDefault();
                DataProvider.Ins.DB.Customers.Remove(customer);
                DataProvider.Ins.DB.SaveChanges();
                ListCustomer.Remove(customer);
            });

            SearchCommand = new RelayCommand<object>((p) =>
            {
                if (Fullname == "")
                {
                    ListCustomer = new ObservableCollection<Customer>(DataProvider.Ins.DB.Customers);
                }
                return true;
            }, (p) =>
            {
                ListCustomer = new ObservableCollection<Customer>(DataProvider.Ins.DB.Customers.Where(x => x.Fullname == SearchFullname));
            });

            ListCommand = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                ListCustomer = new ObservableCollection<Customer>(DataProvider.Ins.DB.Customers);
            });
        }
    }
}
