﻿using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AnalogClockViewModel 
{
    public class AnalogClockViewModel : INotifyPropertyChanged
    {
        private int seconds, minutes, hours;
        public AnalogClockViewModel()
        {
            seconds = minutes = hours = 0;

        }
       
        private DateTime time;
        public DateTime Time
        {
            get { return time; }
            set {   time = value;
                    setAngles();
                    NotifyPropertyChanged();

                }

        }

        private double angleHours;
        public double AngleHours
        {
            protected get { return angleHours; }
            set
            {
                angleHours = value;
                NotifyPropertyChanged();
            }
        }

        private double angleMinutes;
        public double AngleMinutes
        {
            protected get { return angleMinutes; }
            set
            {
                angleMinutes = value;
                NotifyPropertyChanged();
            }
        }

        private double angleSeconds;
        public double AngleSeconds
        {
            protected get { return angleSeconds; }
            set
            {
                angleSeconds = value;
                NotifyPropertyChanged();
            }
        }




        private void setAngles()
        {


            
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
