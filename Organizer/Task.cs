using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizer
{
    /// <summary>
    /// Класс, содержащий в себе информацию о задаче
    /// </summary>
    class Task
    {
        private string _name;
        private DateTime _dateAndTime;

        public string GetName { get { return _name; } }
        public DateTime GetDateAndTime { get { return _dateAndTime; } }

        public Task(string name, DateTime dateAndTime)
        {
            this._name = name;
            this._dateAndTime = dateAndTime;
        }

        public override string ToString()
        {
            return _dateAndTime.ToShortDateString() + " " + _dateAndTime.ToShortTimeString() + " " + _name;
        }
    }
}
