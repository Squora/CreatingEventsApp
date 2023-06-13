using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingEventsApp.Models
{
    public class EventInfoModel : ObservableObject
    {
        private string _eventName;
        public string EventName
        {
            get { return _eventName; }
            set { OnPropertyChanged(ref _eventName, value); }
        }

        private string _organizer;
        public string Organizer
        {
            get { return _organizer; }
            set { OnPropertyChanged(ref _organizer, value); }
        }

        private string _description;
        public string Description
        {
            get { return _description; }
            set { OnPropertyChanged(ref _description, value); }
        }

        private string _location;
        public string Location
        {
            get { return _location; }
            set { OnPropertyChanged(ref _location, value); }
        }

        private string _startTime;
        public string StartTime
        {
            get { return _startTime; }
            set { OnPropertyChanged(ref _startTime, value); }
        }

        private string _endTime;
        public string EndTime
        {
            get { return _endTime; }
            set { OnPropertyChanged(ref _endTime, value); }
        }
    }
}
