﻿using CommunityToolkit.Maui.Converters;
using System.Globalization;

namespace MauiBuberBreakfast.Converters
{
    internal class DateTimeToBreakfastDayConverter : BaseConverter<object, string>
    {
        public override string DefaultConvertReturnValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override object DefaultConvertBackReturnValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override object ConvertBackTo(string value, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public override string ConvertFrom(object value, CultureInfo culture)
        {
            DateTime dateTime = (DateTime)value;

            return (dateTime.Date - DateTime.Today).TotalDays switch
            {
                0 => "Today",
                1 => "Tomorrow",
                _ => $"{dateTime.DayOfWeek}, {dateTime.Day}.`{dateTime.Month}"
            };
        }
    }
}
