using ScheduleListViewSample.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.ScheduleListView;

namespace ScheduleListViewSample
{
	public partial class MainPage : ContentPage
	{
       

        public MainPage()
		{
			InitializeComponent();

            this.BindingContext = new MainViewModel();

        }
	}
}
