using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string userName = txtBoxUsername.Text;
            string userPassword = txtBoxPassword.Text;

            user findUser = sanalDatabase.kullaniciTablo.Find(i => i.username == userName && i.password == userPassword);

            if(findUser != null)
            {
                anaForm _anaform = new anaForm(findUser);
                _anaform.Show();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı bilgileri","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void txtBoxUsername_Enter(object sender, EventArgs e)
        {
            TextBox t1 = (TextBox)sender;
            t1.BackColor = Color.Yellow;
        }

        private void txtBoxUsername_Leave(object sender, EventArgs e)
        {
            TextBox t1 = (TextBox)sender;
            t1.BackColor = Color.White;
        }

        private void txtBoxPassword_Enter(object sender, EventArgs e)
        {
            TextBox t1 = (TextBox)sender;
            t1.BackColor = Color.Yellow;
        }

        private void txtBoxPassword_Leave(object sender, EventArgs e)
        {
            TextBox t1 = (TextBox)sender;
            t1.BackColor = Color.White;
        }
    }
}
