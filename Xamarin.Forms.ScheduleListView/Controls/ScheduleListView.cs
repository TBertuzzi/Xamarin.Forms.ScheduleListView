using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.ScheduleListView.Selectors;

namespace Xamarin.Forms.ScheduleListView
{
    public class ScheduleListView : ListView
    {
        private readonly StackLayout _control = new StackLayout()
        { Orientation = StackOrientation.Vertical };

        public ScheduleListView()
        {
            this.ItemTemplate = new ScheduleDataTemplateSelector();
            this.HasUnevenRows = true;
            this.SeparatorVisibility = SeparatorVisibility.Default;

        }
    }
}
