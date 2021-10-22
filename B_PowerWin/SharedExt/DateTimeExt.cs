using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;

namespace B_PowerWin.SharedExt
{
    public static class DateTimeExt
    {
        public static int DayID(this DateTime _DateTime)
        {
            if(_DateTime != null)
            {
                int ret = (((_DateTime.Year * 100) + _DateTime.Month) * 100) + _DateTime.Day;
                return ret;
            }
            else
            {
                return 0;
            }
        }

        public static DateTime CurrentMonthStart(this DateTime _DateTime)
        {
            if (_DateTime != null)
            {
                int currentYear = DateTime.Today.Year;
                int currentMonth = DateTime.Today.Month;
                int startDay = 1;
                DateTime ret = new DateTime(currentYear, currentMonth, startDay);
                return ret;
            }
            else
            {
                return DateTime.Today;
            }
        }
        public static DateTime CurrentMonthEnd(this DateTime _DateTime)
        {
            if (_DateTime != null)
            {
                int currentYear = DateTime.Today.Year;
                int currentMonth = DateTime.Today.Month;
                int endtDay = DateTime.DaysInMonth(currentYear, currentMonth);
                DateTime ret = new DateTime(currentYear, currentMonth, endtDay);
                return ret;
            }
            else
            {
                return DateTime.Today;
            }
        }
        public static DateTime NowFromDB(this DateTime _DateTime,ObjectContext _db)
        {
            
            return Convert.ToDateTime(_db.CreateQuery<DateTime> ("select CURRENT_TIMESTAMP"));
        }

    }
}
