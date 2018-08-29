using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.ScheduleListView;

namespace ScheduleListViewSample.ViewModel
{
   public class MainViewModel : INotifyPropertyChanged
    {
        #region Property

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(storage, value))
            {
                return false;
            }

            storage = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        #endregion

         public ObservableCollection<Schedule> Schedules { get;}

        public MainViewModel()
        {
            Schedules = new ObservableCollection<Schedule>();

          
            Schedule schedule = new Schedule
            {
                Date = new DateFormatSchedule(DateTime.Now,"MM/dd"),
                Hour = new DateFormatSchedule(DateTime.Now, "HH:mm"),
                Title = "Sample 1",
                Description = "This a 1 sample. bla bla bla bla bla bla " +
                    "bla bla bla bla,bla bla bla bla bla bla bla bla bla bla",
                Status = Color.Green
            };

            Schedules.Add(schedule);

            schedule  = new Schedule
            {
                Date = new DateFormatSchedule(DateTime.Now.AddDays(1), "MM/dd"),
                Hour = new DateFormatSchedule(DateTime.Now.AddDays(1), "HH:mm"),
                Title = "Sample 2",
                Description = "This a 2 sample",
                Status = Color.Green
            };

            Schedules.Add(schedule);

            int max = 30;
            for (int i = 3; i < max; i++)
            {
                schedule = new Schedule
                {
                    Date = new DateFormatSchedule(DateTime.Now.AddDays(i), "MM/dd"),
                    Hour = new DateFormatSchedule(DateTime.Now.AddDays(i), "HH:mm"),
                    Title = $"Sample {i}",
                    Description = $"This a {i} sample",
                    Status = i % 2 == 0 ? Color.Green : Color.Red
                };

                Schedules.Add(schedule);
            }


           


        }
    }
}
