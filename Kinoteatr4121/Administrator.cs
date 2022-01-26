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
    public partial class Administrator : Form
    {
        int x = 3, y = 3;
        public Administrator()
        {
            InitializeComponent();
        }

        private void btnSession_Click(object sender, EventArgs e)
        {
            AddSessions();
        }

        private void AddSessions()
        {
            Button btnCreateSession = new Button
            {
                AutoSize = true,
                BackColor = Color.LightGreen,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Malgun Gothic", 11.8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                Location = new Point(x, y),
                MinimumSize = new Size(250, 50),
                Text = "Добавить сеанс"
            };
            panelMain.Controls.Add(btnCreateSession);
            btnCreateSession.Click += new EventHandler(this.btnCreateSession_Click);
            Button btnDelSession = new Button
            {
                AutoSize = true,
                BackColor = Color.LightGray,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Malgun Gothic", 11.8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                Location = new Point(x, y += 54),
                MinimumSize = new Size(250, 50),
                Text = "Удалить/Изменить сеанс"
            };
            panelMain.Controls.Add(btnDelSession);
            btnDelSession.Click += new EventHandler(this.btnDelSession);
            Label label1 = new Label
            {
                AutoSize = false,
                Font = new Font("Malgun Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                Location = new Point(x, y += 52),
                Text = "Дата:"
            };
            panelMain.Controls.Add(label1);
            DateTimePicker dateTime = new DateTimePicker
            {
                AutoSize = true,
                Font = new Font("Malgun Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                Location = new Point(x, y += 23)
            };
            panelMain.Controls.Add(dateTime);
            Label label2 = new Label
            {
                AutoSize = false,
                Font = new Font("Malgun Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                Location = new Point(x, y += 28),
                Text = "Время:"
            };
            panelMain.Controls.Add(label2);
            ComboBox comboBox1 = new ComboBox
            {
                AutoSize = false,
                Font = new Font("Malgun Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                Location = new Point(x, y += 23)
            };
            comboBox1.Items.AddRange(new object[] {
            "9:00",
            "11:00",
            "13:00",
            "15:00",
            "17:00",
            "19:00",
            "21:00"});
            panelMain.Controls.Add(comboBox1);
            Label label3 = new Label
            {
                AutoSize = false,
                Font = new Font("Malgun Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                Location = new Point(x, y += 28),
                Text = "Фильм:"
            };
            panelMain.Controls.Add(label3);
            TextBox textBox1 = new TextBox
            {
                AutoSize = true,
                MinimumSize = new Size(300, 20),
                Font = new Font("Malgun Gothic", 11.8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                Location = new Point(x, y += 23)
            };
            panelMain.Controls.Add(textBox1);
            Label label4 = new Label
            {
                AutoSize = false,
                Font = new Font("Malgun Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                Location = new Point(x, y += 28),
                Text = "Зал:"
            };
            panelMain.Controls.Add(label4);
            ComboBox comboBox2 = new ComboBox
            {
                AutoSize = false,
                Font = new Font("Malgun Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                Location = new Point(x, y += 23),
            };
            comboBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            panelMain.Controls.Add(comboBox2);
            Label label5 = new Label
            {
                AutoSize = false,
                Font = new Font("Malgun Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                Location = new Point(x, y += 28),
                Text = "Цена:"
            };
            panelMain.Controls.Add(label5);
            TextBox textBox2 = new TextBox
            {
                AutoSize = true,
                MinimumSize = new Size(100, 20),
                Font = new Font("Malgun Gothic", 11.8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                Location = new Point(x, y += 23)
            };
            panelMain.Controls.Add(textBox2);
            PictureBox pictureBox = new PictureBox
            {
                Image = Properties.Resources.NoImage,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Location = new Point(x, y += 28),
                Size = new Size(200, 200)
            };
            panelMain.Controls.Add(pictureBox);
            Button btnPoster = new Button
            {
                AutoSize = true,
                BackColor = Color.LightGray,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Malgun Gothic", 8.8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                Location = new Point(x, y += 203),
                MinimumSize = new Size(200, 13),
                Text = "Выбрать постер"
            };
            panelMain.Controls.Add(btnPoster);
            Button btnConfirm = new Button
            {
                AutoSize = true,
                BackColor = Color.LightGreen,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Malgun Gothic", 11.8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                Location = new Point(x, y += 30),
                MinimumSize = new Size(250, 50),
                Text = "Подтвердить"
            };
            panelMain.Controls.Add(btnConfirm);
        }

        private void btnDelSession(object sender, EventArgs e)
        {
            MessageBox.Show("gjmuk");
        }

        private void Administrator_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnCreateSession_Click(object sender, EventArgs e)
        {
            MessageBox.Show("gjmuk");
        }
    }
}
