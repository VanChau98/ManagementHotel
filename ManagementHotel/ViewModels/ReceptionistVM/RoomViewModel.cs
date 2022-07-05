using ManagementHotel.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ManagementHotel.ViewModels.ReceptionistVM
{
    public class RoomViewModel: BaseViewModel
    {
        private ObservableCollection<Room> _ListRoom;
        public ObservableCollection<Room> ListRoom { get => _ListRoom; set { _ListRoom = value; OnPropertyChanged(); } }

        private string _status;
        public string status { get => _status; set { _status = value; OnPropertyChanged(); } }


        public ICommand SearchingCommand { get; set; }

        public RoomViewModel()
        {
            ListRoom = new ObservableCollection<Room>(DataProvider.Ins.DB.Rooms);

            SearchingCommand = new RelayCommand<object>((p) =>
            {
                if (status == "")
                {
                    ListRoom = new ObservableCollection<Room>(DataProvider.Ins.DB.Rooms);
                    return false;
                }
                return true;
            }, (p) =>
            {
                ListRoom = new ObservableCollection<Room>(DataProvider.Ins.DB.Rooms.Where(x => x.Status.Contains(status)));
            });

        }
    }
}
