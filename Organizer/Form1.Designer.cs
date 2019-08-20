namespace Organizer
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addTaskBut = new System.Windows.Forms.Button();
            this.nameOfTask = new System.Windows.Forms.TextBox();
            this.time = new System.Windows.Forms.TextBox();
            this.toDoList = new System.Windows.Forms.ListBox();
            this.accomplishBut = new System.Windows.Forms.Button();
            this.accomplishedList = new System.Windows.Forms.ListBox();
            this.deleteBut = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.clearAccompBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calendar
            // 
            this.calendar.Location = new System.Drawing.Point(12, 96);
            this.calendar.MaxSelectionCount = 1;
            this.calendar.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.calendar.Name = "calendar";
            this.calendar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Наименование задачи:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Время (чч:мм):";
            // 
            // addTaskBut
            // 
            this.addTaskBut.Location = new System.Drawing.Point(61, 270);
            this.addTaskBut.Name = "addTaskBut";
            this.addTaskBut.Size = new System.Drawing.Size(75, 23);
            this.addTaskBut.TabIndex = 4;
            this.addTaskBut.Text = "Добавить";
            this.addTaskBut.UseVisualStyleBackColor = true;
            this.addTaskBut.Click += new System.EventHandler(this.addTaskBut_Click);
            // 
            // nameOfTask
            // 
            this.nameOfTask.Location = new System.Drawing.Point(12, 25);
            this.nameOfTask.Name = "nameOfTask";
            this.nameOfTask.Size = new System.Drawing.Size(164, 20);
            this.nameOfTask.TabIndex = 5;
            // 
            // time
            // 
            this.time.Location = new System.Drawing.Point(12, 64);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(81, 20);
            this.time.TabIndex = 6;
            // 
            // toDoList
            // 
            this.toDoList.FormattingEnabled = true;
            this.toDoList.Location = new System.Drawing.Point(198, 25);
            this.toDoList.Name = "toDoList";
            this.toDoList.Size = new System.Drawing.Size(193, 238);
            this.toDoList.TabIndex = 7;
            // 
            // accomplishBut
            // 
            this.accomplishBut.Location = new System.Drawing.Point(198, 270);
            this.accomplishBut.Name = "accomplishBut";
            this.accomplishBut.Size = new System.Drawing.Size(75, 23);
            this.accomplishBut.TabIndex = 8;
            this.accomplishBut.Text = "Выполнить";
            this.accomplishBut.UseVisualStyleBackColor = true;
            this.accomplishBut.Click += new System.EventHandler(this.accomplishBut_Click);
            // 
            // accomplishedList
            // 
            this.accomplishedList.FormattingEnabled = true;
            this.accomplishedList.Location = new System.Drawing.Point(419, 25);
            this.accomplishedList.Name = "accomplishedList";
            this.accomplishedList.Size = new System.Drawing.Size(193, 238);
            this.accomplishedList.TabIndex = 9;
            // 
            // deleteBut
            // 
            this.deleteBut.Location = new System.Drawing.Point(316, 270);
            this.deleteBut.Name = "deleteBut";
            this.deleteBut.Size = new System.Drawing.Size(75, 23);
            this.deleteBut.TabIndex = 10;
            this.deleteBut.Text = "Удалить";
            this.deleteBut.UseVisualStyleBackColor = true;
            this.deleteBut.Click += new System.EventHandler(this.deleteBut_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Действующие задачи";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(416, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Выполненные задачи";
            // 
            // clearAccompBut
            // 
            this.clearAccompBut.Location = new System.Drawing.Point(510, 270);
            this.clearAccompBut.Name = "clearAccompBut";
            this.clearAccompBut.Size = new System.Drawing.Size(102, 23);
            this.clearAccompBut.TabIndex = 13;
            this.clearAccompBut.Text = "Очистить список";
            this.clearAccompBut.UseVisualStyleBackColor = true;
            this.clearAccompBut.Click += new System.EventHandler(this.clearAccompBut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 305);
            this.Controls.Add(this.clearAccompBut);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.deleteBut);
            this.Controls.Add(this.accomplishedList);
            this.Controls.Add(this.accomplishBut);
            this.Controls.Add(this.toDoList);
            this.Controls.Add(this.time);
            this.Controls.Add(this.nameOfTask);
            this.Controls.Add(this.addTaskBut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calendar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Органайзер";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calendar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addTaskBut;
        private System.Windows.Forms.TextBox nameOfTask;
        private System.Windows.Forms.TextBox time;
        private System.Windows.Forms.ListBox toDoList;
        private System.Windows.Forms.Button accomplishBut;
        private System.Windows.Forms.ListBox accomplishedList;
        private System.Windows.Forms.Button deleteBut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button clearAccompBut;
    }
}

