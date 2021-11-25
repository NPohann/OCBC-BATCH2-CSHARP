using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginSystem
{
    public partial class Form1 : Form
    {
        config db = new config();
        public Form1()
        {
            InitializeComponent();
            db.Connect("userdata");
        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.ExecuteSelect("SELECT * from `user_info` where username='" + textBox1.Text + "' and password= '" + textBox2.Text + "'");

            if (db.Count() == 1)
            {
                MessageBox.Show("Success, You will login as" + db.Results(0, "names"));
            }
            else
            {
                MessageBox.Show("Wrong username and password combination");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
