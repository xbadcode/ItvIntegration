﻿using System;
using FiresecAPI;
using FiresecAPI.Models;
using FiresecClient.Itv;

namespace ItvIntegration
{
	public class ZoneViewModel : BaseViewModel
	{
        public ZoneViewModel(ZoneState zoneState)
        {
            ZoneState = zoneState;
            _stateType = zoneState.StateType;
            ItvManager.ZoneStateChanged += new Action<ZoneState>(OnZoneStateChanged);
            No = zoneState.Zone.No;
            Name = zoneState.Zone.Name;
        }

        void OnZoneStateChanged(ZoneState zoneState)
		{
            if (ZoneState == zoneState)
			{
				StateType = ZoneState.StateType;
			}
		}

		public ZoneState ZoneState { get; private set; }
        public int No { get; private set; }
		public string Name { get; private set; }

		StateType _stateType;
		public StateType StateType
		{
			get { return _stateType; }
			set
			{
				_stateType = value;
				OnPropertyChanged("StateType");
			}
		}
	}
}