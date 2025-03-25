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
    public partial class anaForm : Form
    {
        public anaForm(user findUser)
        {
            InitializeComponent();
            textBoxName.Text = findUser.name;
            textBoxLastname.Text = findUser.lastname;
            textBoxUsername.Text = findUser.username;
            textBoxUsername.Enabled = false;
            textBoxPassword.Text = findUser.password;
            textBoxLong.Text = findUser.aciklama;
            guncellebtn.Tag = findUser.ıd;

        }

        private void anaForm_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textLastname_Click(object sender, EventArgs e)
        {

        }

        private void guncellebtn_Click(object sender, EventArgs e)
        {
            //Button btnGuncelleYakala = (Button)sender; // btnGuncelle yakalamak için 1. yol
            int btnGuncelleID = (int)guncellebtn.Tag;
            int index = sanalDatabase.kullaniciTablo.FindIndex(i => i.ıd == btnGuncelleID);
            sanalDatabase.kullaniciTablo[index].name = textBoxName.Text;
            sanalDatabase.kullaniciTablo[index].lastname = textBoxLastname.Text;
            sanalDatabase.kullaniciTablo[index].password = textBoxPassword.Text;
            sanalDatabase.kullaniciTablo[index].aciklama = textBoxLong.Text;

        }
    }
}
