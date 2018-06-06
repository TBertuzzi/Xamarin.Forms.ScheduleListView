using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;


namespace Xamarin.Forms.ScheduleListView
{
    public class Schedule
    {
        public Color Status { get; set; } = Color.White;
        public DateFormatSchedule Date { get; set; }  
        public DateFormatSchedule Hour { get; set; }
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";


        public string FormattedDate
        {
            get
            {
                if (Date == null)
                    Date = new DateFormatSchedule();

                return Date.Date.ToString(Date.Format);
            }
        }

        public string FormattedHour
        {
            get
            {
                if (Hour == null)
                    Hour = new DateFormatSchedule();

                return Hour.Date.ToString(Date.Format);
            }
        }
    }
}
