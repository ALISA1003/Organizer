using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizer
{
    /// <summary>
    /// Класс для проверки правильности формата времени
    /// </summary>
    class Checker
    {
        public static bool checkTime(string time)
        {
            if (time.Length != 5)
                return false;

            int hours = int.Parse(time.Substring(0, 2));
            if (hours > 23 && hours < 0)
                return false;

            int minutes = int.Parse(time.Substring(3, 2));
            if (minutes >= 60 || minutes < 0)
                return false;

            if (time[2] != ':')
                return false;

            return true;
        }
    }
}
