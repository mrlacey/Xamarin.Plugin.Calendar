﻿using Rg.Plugins.Popup.Services;
using SampleApp.Model;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace SampleApp.ViewModels
{
    public class CalendarRangePickerPopupViewModel : BasePageViewModel
    {
        private DateTime _maximumDate = DateTime.Today.AddYears(1);

        private DateTime _minimumDate = DateTime.Today.AddYears(-1);

        private DateTime _monthYear = DateTime.Today;

        private DateTime? _selectedStartDate = DateTime.Today.AddDays(-5);
        private DateTime? _selectedEndDate = DateTime.Today.AddDays(5);

        public event Action<CalendarRangePickerResult> Closed;

        public ICommand CancelCommand => new Command(async () =>
        {
            Closed?.Invoke(new CalendarRangePickerResult() { IsSuccess = false });
            await PopupNavigation.Instance.PopAsync();
        });

        public ICommand ClearCommand => new Command(() =>
                {
                    SelectedEndDate = null;
                    SelectedStartDate = null;
                });

        public DateTime MaximumDate
        {
            get => _maximumDate;
            set => SetProperty(ref _maximumDate, value);
        }

        public DateTime MinimumDate
        {
            get => _minimumDate;
            set => SetProperty(ref _minimumDate, value);
        }

        public DateTime MonthYear
        {
            get => _monthYear;
            set => SetProperty(ref _monthYear, value);
        }

        public DateTime? SelectedStartDate 
        {
            get => _selectedStartDate; 
            set => SetProperty(ref _selectedStartDate, value); 
        }

        public DateTime? SelectedEndDate
        {
            get => _selectedEndDate;
            set => SetProperty(ref _selectedEndDate, value);
        }

        public ICommand SuccessCommand => new Command(async () =>
            {
                Closed?.Invoke(new CalendarRangePickerResult()
                {
                    IsSuccess = true,
                    SelectedStartDate = SelectedStartDate,
                    SelectedEndDate = SelectedEndDate
                });
                await PopupNavigation.Instance.PopAsync();
            });
    }
}
