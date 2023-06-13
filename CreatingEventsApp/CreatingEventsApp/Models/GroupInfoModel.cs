using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingEventsApp.Models
{
    public class GroupInfoModel : ObservableObject
    {
        private string _groupNumber;
        public string GroupNumber 
        {
            get { return _groupNumber; }
            set { OnPropertyChanged(ref _groupNumber, value); }
        }

        private string _place;
        public string Place
        {
            get { return _place; }
            set { OnPropertyChanged(ref _place, value); }
        }

        private string _lastLession;
        public string LastLession
        {
            get { return _lastLession; }
            set { OnPropertyChanged(ref _lastLession, value); }
        }

        private string _teacherFullName;
        public string TeacherFullName
        {
            get { return _teacherFullName; }
            set { OnPropertyChanged(ref _teacherFullName, value); }
        }

        private string _cabinet;
        public string Cabinet
        {
            get { return _cabinet; }
            set { OnPropertyChanged(ref _cabinet, value); }
        }

        private string _lastLessionTime;
        public string LastLessionTime
        {
            get { return _lastLessionTime; }
            set { OnPropertyChanged(ref _lastLessionTime, value); }
        }

        private string _elderFullName;
        public string ElderFullName
        {
            get { return _elderFullName; }
            set { OnPropertyChanged(ref _elderFullName, value); }
        }

        private string _telephoneNumber;
        public string TelephoneNumber
        {
            get { return _telephoneNumber; }
            set { OnPropertyChanged(ref _telephoneNumber, value); }
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set { OnPropertyChanged(ref _email, value); }
        }

        private string _vk;
        public string Vk
        {
            get { return _vk; }
            set { OnPropertyChanged(ref _vk, value); }
        }

        private string _telegram;
        public string Telegram
        {
            get { return _telegram; }
            set { OnPropertyChanged(ref _telegram, value); }
        }
    }
}
