﻿namespace Xamarin.Plugin.Calendar.Enums
{
    /// <summary>
    /// Set type of event selection on calendar
    /// </summary>
    public enum SelectionType
    {
        /// <summary>
        /// Default selection of one date at a time. 
        /// </summary>
        Day,
        /// <summary>
        /// Selection of range of dates using start and end date.
        /// </summary>
        Range,
        None,
        FlexRange,
    }
}
