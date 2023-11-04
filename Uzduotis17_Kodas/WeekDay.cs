using System;


namespace Uzduotis17_Kodas
{
    public class WeekDay
    {
    public static string GetDayOfWeek()
        {
            DateTime today = DateTime.Today;
            string day = today.DayOfWeek.ToString();
            return day;
        }
    }
}
