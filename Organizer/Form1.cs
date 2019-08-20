using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Organizer
{
    public partial class Form1 : Form
    {
        // Список невыполненных задач
        TasksList toDoTasks;
        // Списко выполненных задач
        TasksList accomplishedTasks;
        // Имя файла для сохранения невыполненных задач
        string toDoFile;
        // Имя файла для сохранения выполненных задач
        string accompFile;

        public Form1()
        {
            InitializeComponent();
            toDoTasks = new TasksList();
            accomplishedTasks = new TasksList();
            toDoFile = "toToFile.txt";
            accompFile = "accmpFile.txt";
        }

        private void addTaskBut_Click(object sender, EventArgs e)
        {
            if (nameOfTask.Text != "")
            {
                if (Checker.checkTime(time.Text))
                {
                    DateTime cd = calendar.SelectionStart;
                    DateTime taskDateAndTime = new DateTime(cd.Year, cd.Month, cd.Day, int.Parse(time.Text.Substring(0, 2)), int.Parse(time.Text.Substring(3, 2)), 0);
                    if (taskDateAndTime > DateTime.Now)
                    {
                        toDoTasks.AddTask(nameOfTask.Text, taskDateAndTime);
                        nameOfTask.Clear();
                        time.Clear();
                        refreshList(1);
                    }
                    else
                        MessageBox.Show("Невозможно назначить задачу в прошом!", "Ошибка ввода...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Неправильно задано время!", "Ошибка ввода...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Название задачи не должно быть пустым!", "Ошибка ввода...", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void refreshList(int listNum)
        {
            if (listNum == 1)
            {
                toDoList.Items.Clear();
                foreach (string task in toDoTasks.GetTasksList())
                    toDoList.Items.Add(task);
            }
            if (listNum == 2)
            {
                accomplishedList.Items.Clear();
                foreach (string task in accomplishedTasks.GetTasksList())
                    accomplishedList.Items.Add(task);
            }
        }

        private void accomplishBut_Click(object sender, EventArgs e)
        {
            if (toDoTasks.Count > 0)
            {
                if (toDoList.SelectedIndex >= 0)
                {
                    Task accomplishingTask = toDoTasks.AccompTask(toDoList.SelectedIndex);
                    accomplishedTasks.AddTask(accomplishingTask.GetName, accomplishingTask.GetDateAndTime);
                    refreshList(1);
                    refreshList(2);
                }
                else
                    MessageBox.Show("Задача не выбрана!", "Ошибка выполнения...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Список задач пуст!", "Ошибка выполнения...", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void deleteBut_Click(object sender, EventArgs e)
        {
            if (toDoTasks.Count > 0)
            {
                if (toDoList.SelectedIndex >= 0)
                {
                    toDoTasks.DeleteTask(toDoList.SelectedIndex);
                    refreshList(1);
                }
                else
                    MessageBox.Show("Задача не выбрана!", "Ошибка выполнения...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Список задач пуст!", "Ошибка выполнения...", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader read;

            if (File.Exists(toDoFile))
            {
                read = new StreamReader(toDoFile);

                while (!read.EndOfStream)
                {
                    string taskString = read.ReadLine();
                    string[] taskArr = taskString.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    DateTime date = Convert.ToDateTime(taskArr[0] + ' ' + taskArr[1]);
                    taskString = taskArr[2];
                    for (int i = 3; i < taskArr.Length; i++)
                        taskString += ' ' + taskArr[i];
                    toDoTasks.AddTask(taskString, date);
                }
                read.Close();
                refreshList(1);
            }

            if (File.Exists(accompFile))
            {
                read = new StreamReader(accompFile);

                while (!read.EndOfStream)
                {
                    string taskString = read.ReadLine();
                    string[] taskArr = taskString.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    DateTime date = Convert.ToDateTime(taskArr[0] + ' ' + taskArr[1]);
                    taskString = taskArr[2];
                    for (int i = 3; i < taskArr.Length; i++)
                        taskString += ' ' + taskArr[i];
                    accomplishedTasks.AddTask(taskString, date);
                }
                read.Close();
                refreshList(2);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter write;

            write = new StreamWriter(toDoFile, false);

            foreach (string task in toDoList.Items)
                write.WriteLine(task);
            write.Close();

            write = new StreamWriter(accompFile, false);

            foreach (string task in accomplishedList.Items)
                write.WriteLine(task);
            write.Close();
        }

        private void clearAccompBut_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < accomplishedTasks.Count; i++)
            {
                accomplishedTasks.DeleteTask();
                refreshList(2);
            }
        }
    }
}
