using AppModel;
using shitAPp.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace shitAPp.ViewModel
{
    public class MainViewModel:ViewModelBase
    {
        public ObservableCollection<Friend> Friends { get; set; }
        
        private Friend _selectedFriend;
        
        private IAppDataService _appDataService;

        public MainViewModel(IAppDataService appDataService)
        {
            Friends = new ObservableCollection<Friend>();
            _appDataService = appDataService;
        }
        
       
        public void Load()
        {
            var friends = _appDataService.GetAll();
            Friends.Clear();
            foreach(var friend in friends)
            {
                Friends.Add(friend);
            }
        }
        public Friend SelectedFriend
        {
            get { return _selectedFriend; }
            set { _selectedFriend = value;
                OnPropertyChanged();
            }
        }

      
    }



}
