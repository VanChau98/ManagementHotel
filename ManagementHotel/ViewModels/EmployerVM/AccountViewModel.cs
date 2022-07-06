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
    public class AccountViewModel:BaseViewModel
    {
        private ObservableCollection<Account> _ListAccount;
        public ObservableCollection<Account> ListAccount { get => _ListAccount; set { _ListAccount = value; OnPropertyChanged(); } }

        private ObservableCollection<string> _MyItemsAccount;
        public ObservableCollection<string> MyItemsAccount { get => _MyItemsAccount; set { _MyItemsAccount = value; OnPropertyChanged(); } }

        private ObservableCollection<User> _ListUser;
        public ObservableCollection<User> ListUser { get => _ListUser; set { _ListUser = value; OnPropertyChanged(); } }

        private ObservableCollection<string> _MyItemsUser;
        public ObservableCollection<string> MyItemsUser { get => _MyItemsAccount; set { _MyItemsAccount = value; OnPropertyChanged(); } }

        private Account _SelectedItem;
        public Account SelectedItem
        {
            get => _SelectedItem;
            set
            {
                _SelectedItem = value;
                OnPropertyChanged();
            }
        }

        private string _Fullname;
        public string Fullname { get => _Fullname; set { _Fullname = value; OnPropertyChanged(); } }

        private string _UserFullname;
        public string UserFullname { get => _UserFullname; set { _UserFullname = value; OnPropertyChanged(); } }

        private string _Username;
        public string Username { get => _Username; set { _Username = value; OnPropertyChanged(); } }

        private string _Password;
        public string Password { get => _Password; set { _Password = value; OnPropertyChanged(); } }

        private string _Role;
        public string Role { get => _Role; set { _Role = value; OnPropertyChanged(); } }


        public ICommand SearchCommand { get; set; }
        public ICommand AddCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand ListCommand { get; set; }

        void ComboBoxAccount(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            List<string> items = new List<string>();
            for (int i = 0; i < ListAccount.Count(); i++)
            {
                var userid = ListAccount[i].UserID;
                var user = DataProvider.Ins.DB.Users.Where(x => x.Id == userid).SingleOrDefault();
                items.Add(user.Fullname.ToString());
            }
            foreach (string fullname in items.Distinct())
            {
                MyItemsAccount.Add(fullname);
            }
        }

        void ComboBoxUser(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            List<string> items = new List<string>();
            for (int i = 0; i < ListUser.Count(); i++)
            {
                items.Add(ListUser[i].Fullname.ToString());
            }
            foreach (string fullname in items.Distinct())
            {
                MyItemsAccount.Add(fullname);
            }
        }


        public AccountViewModel()
        {
            ListAccount = new ObservableCollection<Account>(DataProvider.Ins.DB.Accounts);
            MyItemsAccount = new ObservableCollection<string>();
            ComboBoxAccount(null, null);
            ListAccount.CollectionChanged += ComboBoxAccount;




            AddCommand = new RelayCommand<object>((p) =>
            {

                if (string.IsNullOrEmpty(UserFullname) || string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password) ||
                    string.IsNullOrEmpty(Role))
                    return false;

                return true;
            }, (p) =>
            {
                var user = DataProvider.Ins.DB.Users.Where(x => x.Fullname == Fullname).SingleOrDefault();
                var account = new Account() { UserID = user.Id, Username = Username, Password = Password, Role = Role };
                DataProvider.Ins.DB.Accounts.Add(account);
                DataProvider.Ins.DB.SaveChanges();
                MessageBox.Show("Add successful", "info", MessageBoxButton.OK);
                ListAccount.Add(account);

                //Reset form
                Fullname = "";
                Username = "";
                Password = "";
                Role = "";
            });

            DeleteCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedItem == null)
                    return false;

                return true;
            }, (p) =>
            {
                var account = DataProvider.Ins.DB.Accounts.Where(x => x.Username == SelectedItem.Username).SingleOrDefault();
                DataProvider.Ins.DB.Accounts.Remove(account);
                DataProvider.Ins.DB.SaveChanges();
                ListAccount.Remove(account);
            });

            SearchCommand = new RelayCommand<object>((p) =>
            {
                if (UserFullname == "")
                {
                    ListAccount = new ObservableCollection<Account>(DataProvider.Ins.DB.Accounts);
                }
                return true;
            }, (p) =>
            {
                var user = DataProvider.Ins.DB.Users.Where(x => x.Fullname == UserFullname).SingleOrDefault();
                ListAccount = new ObservableCollection<Account>(DataProvider.Ins.DB.Accounts.Where(x => x.UserID == user.Id));
            });
            ListCommand = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                ListAccount = new ObservableCollection<Account>(DataProvider.Ins.DB.Accounts);
            });
        }
    }
}
