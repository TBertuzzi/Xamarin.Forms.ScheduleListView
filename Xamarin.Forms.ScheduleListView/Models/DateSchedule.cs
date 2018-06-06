using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin.Forms.ScheduleListView
{
    public class DateFormatSchedule
    {
        public DateTime Date { get; set; }
        public string Format { get; set; }

        public string FormattedDate
        {
            get
            {
                return Date.ToString(Format);
            }
        }

        public DateFormatSchedule()
        {
            Date = DateTime.Now;
            Format = "MM/dd";
        }

        public DateFormatSchedule(DateTime date, string format)
        {
            Date = date;
            Format = format;
        }
    }
}
