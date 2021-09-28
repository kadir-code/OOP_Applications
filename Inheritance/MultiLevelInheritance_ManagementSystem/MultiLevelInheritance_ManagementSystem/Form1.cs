using MultiLevelInheritance_ManagementSystem.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiLevelInheritance_ManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void CleanTextBox(GroupBox groupBox)
        {
            foreach (Control item in groupBox.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = string.Empty;
                }
            }
        }
        Department department = new Department();
        Person person = new Person();

        void CreatePerson()
        {
            person.FullName = textBox1.Text;
            person.DepartmentOfWork = textBox2.Text;
            person.Salary = Convert.ToInt32(textBox3.Text);

        }
        void CreateDepartmentTool()
        {
            person.FullName = textBox1.Text;
            person.DepartmentOfWork = textBox2.Text;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == String.Empty)
            {
                CreateDepartmentTool();
                MessageBox.Show($"Information :\n{department.ShowInformation()}");
            }
            else
            {
                CreatePerson();
                MessageBox.Show($"Information :\n{person.ShowInformation()}");

            }
            CleanTextBox(groupBox1);
        }
    }
}
