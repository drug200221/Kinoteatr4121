using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kinoteatr4121
{
    public partial class Avtorization : Form
    {
        DB db = new DB();
        public Avtorization()
        {
            InitializeComponent();
        }

        private void btn_sign_Click(object sender, EventArgs e)
        {
            Sign_in();
        }
        private void Sign_in()
        {
            if (txt_log.Text == "" || txt_pas.Text == "")
                MessageBox.Show("Заполните все поля");
            else
            {
                string role = db.ReturnFromDB(
                    "SELECT Role FROM Users WHERE [Login]='" + txt_log.Text + "' AND [Password]=N'" + txt_pas.Text + "'");
                if (role == "0")
                {
                    Administrator ad = new Administrator();
                    this.Hide();
                    ad.Show();
                }
                else if (role == "1")
                {
                    KinoKife kk = new KinoKife();
                    this.Hide();
                    kk.Show();
                }
                else MessageBox.Show("Неверный логин или пароль");
            }
        }

        private void txt_log_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) Sign_in();
        }
    }
}
