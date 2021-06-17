using System;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Plugin.Calendar.Enums;

namespace Xamarin.Plugin.Calendar.Models
{
    internal class DayModel : BindableBase<DayModel>
    {
        public DateTime Date
        {
            get => GetProperty<DateTime>();
            set => SetProperty(value)
                    .Notify(nameof(BackgroundColor),
                            nameof(BackgroundBrush),
                            nameof(OutlineColor));
        }

        public bool IsRowStart
        {
            get => GetProperty<bool>();
            set => SetProperty(value).Notify(nameof(LeftOuterBackground));
        }

        public bool IsRowEnd
        {
            get => GetProperty<bool>();
            set => SetProperty(value).Notify(nameof(RightOuterBackground));
        }

        public double DayViewSize
        {
            get => IsThisMonth ? GetProperty<double>() : 0;
            set => SetProperty(value);
        }

        public float DayViewCornerRadius
        {
            get => GetProperty<float>();
            set => SetProperty(value);
        }

        public Style DaysLabelStyle
        {
            get => GetProperty(Device.Styles.BodyStyle);
            set => SetProperty(value);
        }

        public ICommand DayTappedCommand
        {
            get => GetProperty<ICommand>();
            set => SetProperty(value);
        }

        public bool HasEvents
        {
            get => GetProperty<bool>();
            set => SetProperty(value)
                    .Notify(nameof(IsEventDotVisible),
                            nameof(BackgroundEventIndicator),
                            nameof(BackgroundFullEventColor));
        }

        public bool IsThisMonth
        {
            get => GetProperty<bool>();
            set => SetProperty(value)
                    .Notify(nameof(TextColor),
                            nameof(IsVisible),
                            nameof(DayViewSize));
        }

        public SelectionType SelectionType
        {
            get => GetProperty(SelectionType.None);
            set => SetProperty(value);
        }

        public bool IsSelected
        {
            get => GetProperty<bool>();
            set => SetProperty(value)
                    .Notify(nameof(TextColor),
                            nameof(BackgroundColor),
                            nameof(BackgroundBrush),
                            nameof(OutlineColor),
                            nameof(EventColor),
                            nameof(DotColor),
                            nameof(BackgroundFullEventColor));
        }

        public int ForceFlexRangeRecount
        {
            get => GetProperty<int>();
            set => SetProperty(value);
        }

        public FlexRangeSectionType FlexRangeSectionType
        {
            get => GetProperty(FlexRangeSectionType.None);
            set => SetProperty(value)
                    .Notify(nameof(BackgroundBrush),
                            nameof(LeftOuterBackground),
                            nameof(RightOuterBackground));
        }

        public bool IsFlexSelectionStart
        {
            get => GetProperty<bool>();
            set => SetProperty(value)
                    .Notify(nameof(LeftOuterBackground),
                            nameof(RightOuterBackground));
        }

        public bool IsFlexSelectionEnd
        {
            get => GetProperty<bool>();
            set => SetProperty(value)
                    .Notify(nameof(LeftOuterBackground),
                            nameof(RightOuterBackground));
        }

        public bool OtherMonthIsVisible
        {
            get => GetProperty(true);
            set => SetProperty(value)
                    .Notify(nameof(IsVisible));
        }

        public bool IsDisabled
        {
            get => GetProperty<bool>();
            set => SetProperty(value)
                    .Notify(nameof(TextColor));
        }

        public Color SelectedTextColor
        {
            get => GetProperty(Color.White);
            set => SetProperty(value)
                    .Notify(nameof(TextColor));
        }

        public Color SelectedTodayTextColor
        {
            get => GetProperty(Color.Transparent);
            set => SetProperty(value)
                    .Notify(nameof(TextColor));
        }

        public Color OtherMonthColor
        {
            get => GetProperty(Color.Silver);
            set => SetProperty(value)
                    .Notify(nameof(TextColor));
        }

        public Color DeselectedTextColor
        {
            get => GetProperty(Color.Default);
            set => SetProperty(value)
                    .Notify(nameof(TextColor));
        }

        public Color SelectedBackgroundColor
        {
            get => GetProperty(Color.FromHex("#2196F3"));
            set => SetProperty(value)
                    .Notify(nameof(BackgroundColor));
        }

        public Color DeselectedBackgroundColor
        {
            get => GetProperty(Color.Transparent);
            set => SetProperty(value)
                    .Notify(nameof(BackgroundColor));
        }

        public EventIndicatorType EventIndicatorType
        {
            get => GetProperty(EventIndicatorType.BottomDot);
            set => SetProperty(value)
                    .Notify(nameof(IsEventDotVisible),
                            nameof(BackgroundEventIndicator),
                            nameof(BackgroundColor),
                            nameof(BackgroundBrush));
        }

        public Color EventIndicatorColor
        {
            get => GetProperty(Color.FromHex("#FF4081"));
            set => SetProperty(value)
                    .Notify(nameof(EventColor),
                            nameof(BackgroundColor),
                            nameof(BackgroundFullEventColor),
                            nameof(BackgroundBrush));
        }

        public Color EventIndicatorSelectedColor
        {
            get => GetProperty(SelectedBackgroundColor);
            set => SetProperty(value)
                    .Notify(nameof(EventColor),
                            nameof(BackgroundColor),
                            nameof(BackgroundFullEventColor),
                            nameof(BackgroundBrush));
        }

        public Color EventIndicatorTextColor
        {
            get => GetProperty(DeselectedTextColor);
            set => SetProperty(value);
        }

        public Color EventIndicatorSelectedTextColor
        {
            get => GetProperty(SelectedTextColor);
            set => SetProperty(value);
        }

        public Color TodayOutlineColor
        {
            get => GetProperty(Color.FromHex("#FF4081"));
            set => SetProperty(value)
                    .Notify(nameof(OutlineColor));
        }

        public Color TodayTextColor
        {
            get => GetProperty(Color.Transparent);
            set => SetProperty(value)
                    .Notify(nameof(TextColor));
        }

        public Color TodayFillColor
        {
            get => GetProperty(Color.Transparent);
            set => SetProperty(value)
                    .Notify(nameof(BackgroundColor));
        }

        public Color DisabledColor
        {
            get => GetProperty(Color.FromHex("#ECECEC"));
            set => SetProperty(value);
        }

        public Brush BackgroundOverride
        {
            get => GetProperty<Brush>();
            set => SetProperty(value)
                    .Notify(nameof(BackgroundBrush));
        }

        public Brush FlexRangeEndBrush
        {
            get => GetProperty<Brush>();
            set => SetProperty(value)
                    .Notify(nameof(BackgroundBrush));
        }

        public Brush FlexRangeMiddleBrush
        {
            get => GetProperty<Brush>();
            set => SetProperty(value)
                    .Notify(nameof(BackgroundBrush));
        }

        public Brush TransparentGradientBrush
        {
            get => GetProperty<Brush>();
            set => SetProperty(value)
                    .Notify(nameof(LeftOuterBackground), nameof(RightOuterBackground));
        }

        public bool IsEventDotVisible => HasEvents && (EventIndicatorType == EventIndicatorType.BottomDot || EventIndicatorType == EventIndicatorType.TopDot);

        public FlexDirection EventLayoutDirection => (HasEvents && EventIndicatorType == EventIndicatorType.TopDot) ? FlexDirection.ColumnReverse : FlexDirection.Column;

        public bool BackgroundEventIndicator => HasEvents && EventIndicatorType == EventIndicatorType.Background;

        public Color BackgroundFullEventColor => HasEvents && EventIndicatorType == EventIndicatorType.BackgroundFull
                                               ? EventColor
                                               : Color.Default;

        public Color EventColor => IsSelected
                                 ? EventIndicatorSelectedColor
                                 : EventIndicatorColor;

        public Color DotColor
        {
            get
            {
                if (SelectionType == SelectionType.FlexRange)
                {
                    // TODO: get the proper colors from XAML?
                    return FlexRangeSectionType == FlexRangeSectionType.End
                        ? Color.White
                        : Color.Green;
                }
                else
                {
                    return EventIndicatorColor;
                }
            }
        }

        public Color OutlineColor => IsToday && !IsSelected
                                   ? TodayOutlineColor
                                   : Color.Transparent;

        public Color BackgroundColor
        {
            get
            {
                if (!IsVisible || SelectionType == SelectionType.None) return DeselectedBackgroundColor;

                if (SelectionType == SelectionType.FlexRange)
                {
                    return DeselectedBackgroundColor;
                }

                //return FlexRangeSectionType switch
                //{
                //    (FlexRangeSectionType.None) => DeselectedBackgroundColor,
                //    (FlexRangeSectionType.Middle) => Color.HotPink,
                //    (FlexRangeSectionType.End) => Color.Chartreuse
                //};

                return (IsThisMonth, BackgroundEventIndicator, IsSelected, IsToday) switch
                {
                    (true, true, false, _) => EventIndicatorColor,
                    (true, true, true, _) => EventIndicatorSelectedColor,
                    (true, false, true, _) => SelectedBackgroundColor,
                    (true, false, false, true) => TodayFillColor,
                    (_, _, _, _) => DeselectedBackgroundColor
                };
            }
        }

        public Brush BackgroundBrush
        {
            get
            {
                if (IsThisMonth
                 && HasEvents
                 && SelectionType == SelectionType.None
                 && BackgroundEventIndicator
                 && BackgroundOverride != null)
                {
                    return BackgroundOverride;
                }
                else if (SelectionType == SelectionType.FlexRange && IsVisible)
                {
                    if (FlexRangeSectionType == FlexRangeSectionType.End
                      && FlexRangeEndBrush != null)
                    {
                        return FlexRangeEndBrush;
                    }
                    else if (FlexRangeSectionType == FlexRangeSectionType.Middle)
                    {
                        // Workaround for not being able to change a LinearGradientBrush with a SolidColorBrush
                        // https://github.com/xamarin/Xamarin.Forms/issues/13417
                        return FlexRangeMiddleBrush;
                    }
                }

                return new SolidColorBrush(BackgroundColor);
            }
        }

        public Brush RightOuterBackground
        {
            get
            {
                return IsRowEnd || !IsVisible
                    ? TransparentGradientBrush
                    : FlexRangeSectionType == FlexRangeSectionType.Middle
                        ? FlexRangeMiddleBrush
                        : FlexRangeSectionType == FlexRangeSectionType.End
                        && IsFlexSelectionStart
                        && !IsFlexSelectionEnd
                            ? FlexRangeMiddleBrush
                            : TransparentGradientBrush;
            }
        }

        public Brush LeftOuterBackground
        {
            get
            {
                return IsRowStart || !IsVisible
                    ? TransparentGradientBrush
                    : FlexRangeSectionType == FlexRangeSectionType.Middle
                        ? FlexRangeMiddleBrush
                        : FlexRangeSectionType == FlexRangeSectionType.End
                        && IsFlexSelectionEnd
                        && !IsFlexSelectionStart
                            ? FlexRangeMiddleBrush
                            : TransparentGradientBrush;
            }
        }

        public Color TextColor
        {
            get
            {
                if (!IsVisible) return OtherMonthColor;

                return (IsDisabled, IsSelected, HasEvents, IsThisMonth, IsToday) switch
                {
                    (true, _, _, _, _) => DisabledColor,
                    (false, true, false, true, true) => SelectedTodayTextColor == Color.Transparent ? SelectedTextColor : SelectedTodayTextColor,
                    (false, true, false, true, false) => SelectedTextColor,
                    (false, true, true, true, _) => EventIndicatorSelectedTextColor,
                    (false, false, true, true, _) => EventIndicatorTextColor,
                    (false, false, _, false, _) => OtherMonthColor,
                    (false, false, false, true, true) => TodayTextColor == Color.Transparent ? DeselectedTextColor : TodayTextColor,
                    (false, false, false, true, false) => DeselectedTextColor,
                    (_, _, _, _, _) => Color.Default
                };
            }
        }

        public bool IsVisible => IsThisMonth || OtherMonthIsVisible;

        private bool IsToday
            => Date.Date == DateTime.Today;
    }
}
