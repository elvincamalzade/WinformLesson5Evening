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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //UserControl1 userControl1 = new UserControl1();
            //this.Controls.Add(userControl1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            var result=form2.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                form2.Close();
                this.Show();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Send data by Constructor 1 version
            //Form2 form = new Form2(textBox1.Text);
            //form.ShowDialog();


            //Send Data by Method 2 version
            //Form2 form = new Form2();

            //form.MyText = textBox1.Text;
            //form.ShowDialog();


            //Send data by ShowDialog 3 version

            //Form2 form = new Form2();

            //User user = new User
            //{
            //    Username = usernameTxtb.Text,
            //    Password = passwordTxtb.Text
            //};

            //form.ShowDialog(user);



            //FROM CHILD TO PARENT


            //Form2 form = new Form2();
            //if (form.ShowDialog() == DialogResult.OK)
            //{
            //    textBox1.Text = form.MyText;
            //}



            Form2 form = new Form2();
            form.Show();
        }
    }
}
