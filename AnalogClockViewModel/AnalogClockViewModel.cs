using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ViewModel 
{
    public class AnalogClockViewModel : INotifyPropertyChanged
    {
        const double degPerSecond = 360 / 60;
        const double degPerMinute = 360 / 60;
        const double degPerHour = 360 / 12;
        const double secsPerMin = 60.0;
        const double minPerHr = 60.0;

        double  seconds, minutes, hours;
        public AnalogClockViewModel()
        {
            seconds = minutes = hours = 0;
            Time = DateTime.Now;

        }
       
        private DateTime time;
        public DateTime Time
        {
            get { return time; }
            set {   time = value;
                    setAngles();
                   // NotifyPropertyChanged();
                }
        }

        private double angleHours;
        public double AngleHours
        {
            get { return angleHours; }
            set
            {
                angleHours = value;
                NotifyPropertyChanged();
            }
        }

        private double angleMinutes;
        public double AngleMinutes
        {
            get { return angleMinutes; }
            protected set
            {
                angleMinutes = value;
                NotifyPropertyChanged();
            }
        }

        private double angleSeconds;
        public double AngleSeconds
        {
            get { return angleSeconds; }
            protected set
            {
                angleSeconds = value;
                NotifyPropertyChanged();
            }
        }


        public double Seconds {        get { return    seconds; }
                            private set {           seconds = value;
                AngleSeconds = seconds *  degPerSecond;
                                                    NotifyPropertyChanged(); 
                                        } 
                            }

        public double Minutes
        {
            get { return minutes; }
            private set
            {
                minutes = value;
                AngleMinutes = minutes * degPerMinute + (seconds/60)*degPerMinute;
                NotifyPropertyChanged();
            }
        }

        
        public double Hours
        {
            get { return hours; }
            private set
            {
                hours = value;
                AngleHours = hours * degPerHour + (minutes/minPerHr)* degPerHour + (seconds*degPerHour)/(secsPerMin*minPerHr) ;
                NotifyPropertyChanged();
            }
        }

        private void setAngles()
        {
            Seconds = time.Second;
            Minutes = time.Minute;
            Hours   = time.Hour;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
