using ManagementHotel.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementHotel.ViewModels.ReceptionistVM
{
    public class ServiceViewModel: BaseViewModel
    {
        private ObservableCollection<Service> _ListService;
        public ObservableCollection<Service> ListService { get => _ListService; set { _ListService = value; OnPropertyChanged(); } }


        public ServiceViewModel()
        {
            ListService = new ObservableCollection<Service>(DataProvider.Ins.DB.Services);
        }
    }
}
