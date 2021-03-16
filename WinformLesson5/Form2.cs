using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformLesson5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();



        }
        public string MyText { get; set; }
        public Form2(string message)
        {
            InitializeComponent();
            label1.Text = message;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = MyText;
        }

        public DialogResult ShowDialog(User user)
        {
            label2.Text = user.Username;
            label3.Text = user.Password;
            return ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            this.DialogResult = DialogResult.OK;
            MyText = textBox1.Text;
        }
    }
}
