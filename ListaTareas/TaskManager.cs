using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace ListaTareas
{
    public class TaskManager
    {
        //Props
        private readonly CheckedListBox _checkedListBox;
        private readonly TextBox _textBox;
        private FolderBrowserDialog _folderBrowserDialog;
        public string Task { get; set; }
        private string _path;
        private string _line;
        private int _counter;

        //Ctors - Bring checkedListBox and textbox as a Dependency
        public TaskManager(CheckedListBox checkedListBox, TextBox textBox)
        {
            _checkedListBox = checkedListBox;
            _textBox = textBox;
        }

        //Methods
        public void AddTask(string task)
        {
            if (task != "")
            {
                _checkedListBox.Items.Add(task);
                _textBox.Text = "";
                _textBox.Focus();
            }
            else
            {
                MessageBox.Show("Please specify a task.");
            }
        }

        public void SaveTasks()
        {
            _folderBrowserDialog = new FolderBrowserDialog();
            var result = _folderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                _path = _folderBrowserDialog.SelectedPath + "\\Tasks.txt";
       
                if (!File.Exists(_path))
                {
                    // Create a file to write to.
                    var sw = File.CreateText(_path);

                    CheckedListBox.ObjectCollection tasks = _checkedListBox.Items;

                    foreach (var task in tasks)
                    {
                        sw.WriteLine(task.ToString());
                    }
                    sw.Close();
                }
            }
        }

        public void OpenTasks()
        {
            _folderBrowserDialog = new FolderBrowserDialog();
            var result = _folderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                _path = _folderBrowserDialog.SelectedPath + "\\Tasks.txt";

                if (File.Exists(_path))
                {
                    // Open file and write to task list
                   var sr = new StreamReader(_path);

                    while ((_line = sr.ReadLine()) != null)
                    {
                        AddTask(_line);
                        _counter++;
                    }
                    sr.Close();
                }
            }
        }

        public void ClearCompleted()


        {
            //Iterate through list and remove checked indexes
            while (_checkedListBox.CheckedItems.Count > 0)
            {
                _checkedListBox.Items.Remove(_checkedListBox.CheckedItems[0]);
            }
        }
    }
}