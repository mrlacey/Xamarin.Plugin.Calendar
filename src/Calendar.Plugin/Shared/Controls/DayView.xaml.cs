using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Plugin.Calendar.Models;

namespace Xamarin.Plugin.Calendar.Controls
{
    /// <summary>
    /// Internal class used by Xamarin.Plugin.Calendar
    /// </summary>
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DayView : ContentView
    {
        internal DayView()
        {
            InitializeComponent();
        }

        private void OnTapped(object sender, EventArgs e)
        {
            if (BindingContext is DayModel dayModel && !dayModel.IsDisabled && dayModel.IsVisible)
            {
                switch (dayModel.SelectionType)
                {
                    case Enums.SelectionType.Day:
                    case Enums.SelectionType.Range:
                        dayModel.IsSelected = true;
                        dayModel.DayTappedCommand?.Execute(dayModel.Date);
                        break;

                    case Enums.SelectionType.FlexRange:
                        // trigger something to get the MonthDaysView to refresh
                        dayModel.ForceFlexRangeRecount++;
                        break;

                    case Enums.SelectionType.None:
                        break;
                }
                ////dayModel.IsSelected = !dayModel.IsSelected;
                ////dayModel.DayTappedCommand?.Execute(dayModel.Date);
            }
        }
    }
}