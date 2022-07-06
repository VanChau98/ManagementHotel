using ManagementHotel.Views;
using ManagementHotel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Controls;

namespace ManagementHotel.ViewModels
{
    public class MainViewModel: BaseViewModel
    {

        private string _username;
        public string username { get => _username; set { _username = value; OnPropertyChanged(); } }

        private string _password;
        public string password { get => _password; set { _password = value;OnPropertyChanged(); } }


        public ICommand loginCommand { get; set; }
        public ICommand PasswordChangedCommand { get; set; }

        public MainViewModel()
        {
            loginCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                if (p == null)
                    return;
               // var checking = DataProvider.Ins.DB.Accounts.Where(x => x.Username == username && x.Password == password).Count();
                Account acc = DataProvider.Ins.DB.Accounts.Where(x => x.Username == username && x.Password == password).FirstOrDefault();

                if (acc == null)
                {
                    MessageBox.Show("Username or Password wrong!");
                    return;
                }
                else
                {
                   
                    if (acc.Role == "Manager")
                    {
                        ManagerWindow mw = new ManagerWindow();
                        p.Visibility = Visibility.Collapsed;
                        mw.ShowDialog();

                        username = "";
                        password = "";

                        p.Visibility = Visibility.Visible;

                    }

                    if (acc.Role == "Receptionist")
                    {
                        ReceptionistWindow rw = new ReceptionistWindow();
                        p.Visibility = Visibility.Collapsed;
                        rw.ShowDialog();

                        username = "";
                        password = "";

                        p.Visibility = Visibility.Visible;
                    }
                    if (acc.Role == "Staff")
                    {
                        EmployerWindow ew = new EmployerWindow();
                        p.Visibility = Visibility.Collapsed;
                        ew.ShowDialog();

                        username = "";
                        password = "";

                        p.Visibility = Visibility.Visible;
                    }
                }
            });

            PasswordChangedCommand = new RelayCommand<PasswordBox>((p) => { return true; }, (p) => { password = p.Password; });
        }

       
    }
}
