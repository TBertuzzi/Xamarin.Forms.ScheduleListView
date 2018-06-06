using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.ScheduleListView.Controls;

namespace Xamarin.Forms.ScheduleListView.Selectors
{
    public class ScheduleDataTemplateSelector : DataTemplateSelector
    {
        private readonly DataTemplate scheduleTemplate = new DataTemplate(typeof(ScheduleViewCell));

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            if(!(item is Schedule schedule))
                return null;

            return scheduleTemplate;
        }
    }
}
