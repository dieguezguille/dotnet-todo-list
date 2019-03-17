using System;
using System.Windows.Forms;

namespace ListaTareas
{
    partial class Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.taskTextBox = new System.Windows.Forms.TextBox();
            this.addTaskButton = new System.Windows.Forms.Button();
            this.clearTasksButton = new System.Windows.Forms.Button();
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.taskLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // taskTextBox
            // 
            resources.ApplyResources(this.taskTextBox, "taskTextBox");
            this.taskTextBox.Name = "taskTextBox";
            this.taskTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.taskTextBox_ReturnPressed);
            // 
            // addTaskButton
            // 
            resources.ApplyResources(this.addTaskButton, "addTaskButton");
            this.addTaskButton.Name = "addTaskButton";
            this.addTaskButton.UseVisualStyleBackColor = true;
            this.addTaskButton.Click += new System.EventHandler(this.addTaskButton_Click);
            // 
            // clearTasksButton
            // 
            resources.ApplyResources(this.clearTasksButton, "clearTasksButton");
            this.clearTasksButton.Name = "clearTasksButton";
            this.clearTasksButton.UseVisualStyleBackColor = true;
            this.clearTasksButton.Click += new System.EventHandler(this.clearTasksButton_Click);
            // 
            // checkedListBox
            // 
            this.checkedListBox.FormattingEnabled = true;
            resources.ApplyResources(this.checkedListBox, "checkedListBox");
            this.checkedListBox.Name = "checkedListBox";
            // 
            // taskLabel
            // 
            resources.ApplyResources(this.taskLabel, "taskLabel");
            this.taskLabel.Name = "taskLabel";
            // 
            // saveButton
            // 
            resources.ApplyResources(this.saveButton, "saveButton");
            this.saveButton.Name = "saveButton";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // openButton
            // 
            resources.ApplyResources(this.openButton, "openButton");
            this.openButton.Name = "openButton";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // Form
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.taskLabel);
            this.Controls.Add(this.checkedListBox);
            this.Controls.Add(this.clearTasksButton);
            this.Controls.Add(this.addTaskButton);
            this.Controls.Add(this.taskTextBox);
            this.Name = "Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox taskTextBox;
        private System.Windows.Forms.Button addTaskButton;
        private System.Windows.Forms.Button clearTasksButton;
        private System.Windows.Forms.CheckedListBox checkedListBox;
        private System.Windows.Forms.Label taskLabel;
        private Button saveButton;
        private Button openButton;
    }
}

