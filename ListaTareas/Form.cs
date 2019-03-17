using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaTareas
{
    public partial class Form : System.Windows.Forms.Form
    {
        //Propiedades
        private readonly TaskManager _taskManager;

        //Constructor
        public Form()
        {
            InitializeComponent();
            _taskManager = new TaskManager(checkedListBox, taskTextBox);
            checkedListBox.CheckOnClick = true;
        }

        //Events
        private void addTaskButton_Click(object sender, EventArgs e)
        {
            _taskManager.AddTask(taskTextBox.Text);
        }

        private void taskTextBox_ReturnPressed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Return)
            {
                _taskManager.AddTask(taskTextBox.Text);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            _taskManager.SaveTasks();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            _taskManager.OpenTasks();
        }

        private void clearTasksButton_Click(object sender, EventArgs e)
        {
            _taskManager.ClearCompleted();
        }

    }
}
