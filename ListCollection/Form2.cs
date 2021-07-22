using Kalıtım.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListCollection
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        List<Teacher> teachers = new List<Teacher>();
        private void button1_Click(object sender, EventArgs e)
        {
            //base class özelliklerini atadık öğretmene 
            Teacher teacher = new Teacher(txtUsername.Text, txtSifre.Text);
            teacher.branch = txtBrans.Text;

            teachers.Add(teacher);
            txtUsername.Text = "";
            txtSifre.Text = "";
            txtBrans.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Teacher ogretmen in teachers)
            {
                listBox1.Items.Add("Kullanıcı adı: " +ogretmen.userName + 
                    " branş adı : " +ogretmen.branch);
            }
        }

       
    }
}
