using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace ListTest
{
    
    public partial class Form1 : Form
    {
        List<string> students = new List<string>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            students.Add(inputBox.Text);
            inputBox.Text = "";
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            originalOutput.Text = "Original Order\n**************\n";

            for (int i = 0; i < students.Count(); i++)
            {
                originalOutput.Text += $"{students[i]}\n";
            }

            sortOutput.Text = "Sorted Order\n**************\n";

            students.Sort();

            for (int i = 0; i < students.Count(); i++)
            {
                sortOutput.Text += $"{students[i]}\n";
            }

            reverseOutput.Text = "Reverse Order\n**************\n";

            students.Reverse();

            for (int i = 0; i < students.Count(); i++)
            {
                reverseOutput.Text += $"{students[i]}\n";
            }

        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            string name = inputBox.Text;

            if (students.Contains(name))
            {
                originalOutput.Text = "item removed";
                sortOutput.Text = "";
                reverseOutput.Text = "";

                students.Remove(name);
            }
            else
            {
                originalOutput.Text = "item not found";
                sortOutput.Text = "";
                reverseOutput.Text = "";
            }

            inputBox.Text = "";
        }
    }
}
