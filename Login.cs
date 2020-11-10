using System;
using System.Windows.Forms;

namespace Forms_ControlWork
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminPanel am = new AdminPanel();
            string[] lines = System.IO.File.ReadAllLines(@"E:\c# 2semestr\Forms_ControlWork\bin\Debug\admin.txt");
            String username = lines[0];
            String password = lines[1];
            bool userExist = false;

            if ((username == this.TxLog.Text) && (password == this.TxPass.Text))
            {
                userExist = true;
                MessageBox.Show("You successfully login\n" + MessageBoxButtons.OK);
                am.Show();
                this.Hide();
                am.FormClosing += Login_FormClosing;
            }
            if (userExist == false)
            {
                MessageBox.Show("Bad login or password, try again\n" + MessageBoxButtons.OK);
                this.TxLog.Clear();
                this.TxPass.Clear();
            }

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }
    }
}
