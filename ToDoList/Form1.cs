using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            string task = txtTask.Text.Trim();

            if (string.IsNullOrWhiteSpace(task))
            {
                MessageBox.Show("Enter a task first.");
                return;
            }

            bool duplicateExists = false;
            foreach (var item in listBox1.Items)
            {
                if (item.ToString().Equals(task, StringComparison.OrdinalIgnoreCase))
                {
                    duplicateExists = true;
                    break;
                }
            }

            if (duplicateExists)
            {
                MessageBox.Show("This task already exists.");
                txtTask.Clear();
                return;
            }

            listBox1.Items.Add(task);
            txtTask.Clear();
        }

        private void txtTask_TextChanged(object sender, EventArgs e) { }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) { }

        private void delete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Select a task to delete.");
                return;
            }

            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void complete_Click(object sender, EventArgs e)
        {
            var selectedItem = listBox1.SelectedItem;
            if (selectedItem is string item && !item.StartsWith("✔ "))
            {
                listBox1.Items[listBox1.SelectedIndex] = "✔ " + item;
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("No tasks to save.");
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                sfd.Title = "Choose location to save tasks";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        File.WriteAllLines(sfd.FileName, listBox1.Items.Cast<string>());
                        MessageBox.Show($"Tasks saved to '{sfd.FileName}'.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error saving tasks: {ex.Message}");
                    }
                }
            }
        }

        private void LoadL_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                ofd.Title = "Select a file to load tasks";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        listBox1.Items.Clear();
                        string[] lines = File.ReadAllLines(ofd.FileName);
                        foreach (string line in lines)
                            listBox1.Items.Add(line);

                        MessageBox.Show($"Tasks loaded from '{ofd.FileName}'.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading tasks: {ex.Message}");
                    }
                }
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("No tasks to clear.");
                return;
            }

            if (MessageBox.Show("Are you sure you want to clear all tasks?",
                "Confirm Clear", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                listBox1.Items.Clear();
            }
        }
    }
}
