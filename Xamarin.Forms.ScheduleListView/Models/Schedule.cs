using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin.Forms.ScheduleListView
{
    public class Schedule
    {
        public Color Status { get; set; }
        public DateTime Date { get; set; }
        public DateTime Hour { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        internal string FormattedDate
        {
            get
            {
                if (Date == null)
                    Date = new DateTime();

                return Date.ToShortDateString();
            }
        }

        internal string FormattedHour
        {
            get
            {
                if (Date == null)
                    Date = new DateTime();

                return Date.ToShortTimeString();
            }
        }
    }
}
