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
    public class ServiceViewModel: BaseViewModel
    {
        private ObservableCollection<Service> _ListService;
        public ObservableCollection<Service> ListService { get => _ListService; set { _ListService = value; OnPropertyChanged(); } }

        private ObservableCollection<string> _MyItemsService;
        public ObservableCollection<string> MyItemsService { get => _MyItemsService; set { _MyItemsService = value; OnPropertyChanged(); } }

        private Service _SelectedItem;
        public Service SelectedItem
        {
            get => _SelectedItem;
            set
            {
                _SelectedItem = value;
                OnPropertyChanged();
                if (SelectedItem != null)
                {
                    Name = SelectedItem.Name;
                    Price = SelectedItem.Price;
                }
            }
        }

        private string _Name;
        public string Name { get => _Name; set { _Name = value; OnPropertyChanged(); } }

        private string _SearchName;
        public string SearchName { get => _SearchName; set { _SearchName = value; OnPropertyChanged(); } }


        private int? _Price;
        public int? Price { get => _Price; set { _Price = value; OnPropertyChanged(); } }



        public ICommand SearchCommand { get; set; }
        public ICommand AddCommand { get; set; }
        public ICommand UpdateCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand ListCommand { get; set; }

        void ComboBoxService(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            List<string> items = new List<string>();
            for (int i = 0; i < ListService.Count(); i++)
            {
                items.Add(ListService[i].Name.ToString());
            }
            foreach (string fullname in items.Distinct())
            {
                MyItemsService.Add(fullname);
            }
        }


        public ServiceViewModel()
        {
            ListService = new ObservableCollection<Service>(DataProvider.Ins.DB.Services);
            MyItemsService = new ObservableCollection<string>();
            ComboBoxService(null, null);
            ListService.CollectionChanged += ComboBoxService;




            AddCommand = new RelayCommand<object>((p) =>
            {

                if (string.IsNullOrEmpty(Name) || Price == null)
                    return false;

                return true;
            }, (p) =>
            {
                var service = new Service() { Name = Name, Price = Price};
                DataProvider.Ins.DB.Services.Add(service);
                DataProvider.Ins.DB.SaveChanges();
                MessageBox.Show("Add successful", "info", MessageBoxButton.OK);
                ListService.Add(service);

                //Reset form
                Name = "";
                Price = null;
            });

            UpdateCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedItem == null)
                    return false;
                return true;
            }, (p) =>
            {

                var service = DataProvider.Ins.DB.Services.Where(x => x.Name == SelectedItem.Name).SingleOrDefault();
                service.Name = Name;
                service.Price = Price;
                DataProvider.Ins.DB.SaveChanges();
            });

            DeleteCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedItem == null)
                    return false;

                return true;
            }, (p) =>
            {
                var service = DataProvider.Ins.DB.Services.Where(x => x.Name == SelectedItem.Name).SingleOrDefault();
                DataProvider.Ins.DB.Services.Remove(service);
                DataProvider.Ins.DB.SaveChanges();
                ListService.Remove(service);
            });

            SearchCommand = new RelayCommand<object>((p) =>
            {
                if (SearchName == "")
                {
                    ListService = new ObservableCollection<Service>(DataProvider.Ins.DB.Services);
                }
                return true;
            }, (p) =>
            {
                ListService = new ObservableCollection<Service>(DataProvider.Ins.DB.Services.Where(x => x.Name == SearchName));
            });

            ListCommand = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                ListService = new ObservableCollection<Service>(DataProvider.Ins.DB.Services);
            });
        }
    }
}
