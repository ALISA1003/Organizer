using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizer
{
    /// <summary>
    /// Класс для работы со списком задач
    /// </summary>
    class TasksList
    {
        private List<Task> tasks;

        public TasksList()
        {
            tasks = new List<Task>();
        }
        
        public int Count { get { return tasks.Count; } }

        public void AddTask(string taskName, DateTime taskDateAndTime)
        {
            int addAfter = 0, i = 0;
            while (i < tasks.Count && taskDateAndTime < tasks[i].GetDateAndTime)
            {
                addAfter = i;
                i++;
            }

            tasks.Insert(addAfter, new Task(taskName, taskDateAndTime));
        }

        public void DeleteTask()
        {
            tasks.RemoveAt(0);
        }

        public void DeleteTask(int index)
        {
            tasks.RemoveAt(index);
        }

        public Task AccompTask(int index)
        {
            Task temp = tasks[index];
            tasks.RemoveAt(index);
            return temp;
        }

        public IEnumerable<string> GetTasksList()
        {
            string[] tasksList = new string[tasks.Count];

            for (int i = 0; i < tasks.Count; i++)
                tasksList[i] = tasks[i].ToString();

            return tasksList;
        }
    }
}
