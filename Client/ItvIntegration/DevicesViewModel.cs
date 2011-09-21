﻿using System.Collections.ObjectModel;
using System.ComponentModel;
using FiresecClient;

namespace ItvIntegration
{
    public class DevicesViewModel : INotifyPropertyChanged
    {
        public void Initialize()
        {
            bool result = FiresecManager.Connect("adm", "");
            if (result == false)
                return;

            Devices = new ObservableCollection<DeviceViewModel>();
            foreach (var deviceState in FiresecManager.DeviceStates.DeviceStates)
            {
                var deviceViewModel = new DeviceViewModel(deviceState);
                Devices.Add(deviceViewModel);
            }
        }

        public ObservableCollection<DeviceViewModel> Devices { get; set; }

        DeviceViewModel _selectedDevice;
        public DeviceViewModel SelectedDevice
        {
            get { return _selectedDevice; }
            set
            {
                _selectedDevice = value;
                OnPropertyChanged("StateType");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }
}
