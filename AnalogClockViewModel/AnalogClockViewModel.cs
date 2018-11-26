using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AnalogClockViewModel 
{
    public class AnalogClockViewModel : INotifyPropertyChanged
    {
        public AnalogClockViewModel()
        {

        }
        private DateTime time;
        public DateTime Time
        {
            get { return time; }
            set {   time = value;
                NotifyPropertyChanged();
                }

        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
