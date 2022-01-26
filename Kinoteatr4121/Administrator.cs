using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kinoteatr4121
{
    public partial class Administrator : Form
    {
        private SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-JSJGVJUO;Initial Catalog=KINOKASSA;Integrated Security=True");
        static int x = 3, y = 3;
        string fileText = null, dir = null, photo = null;
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
        Label label1 = new Label
        {
            AutoSize = false,
            Font = new Font("Malgun Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
            Location = new Point(x, y += 52),
            Text = "Дата:"
        };
        DateTimePicker txtDate = new DateTimePicker
        {
            AutoSize = true,
            Font = new Font("Malgun Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
            Location = new Point(x, y += 23)
        };
        Label label2 = new Label
        {
            AutoSize = false,
            Font = new Font("Malgun Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
            Location = new Point(x, y += 28),
            Text = "Время:"
        };
        ComboBox txtTime = new ComboBox
        {
            AutoSize = false,
            Font = new Font("Malgun Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
            Location = new Point(x, y += 23)
        };
        Label label3 = new Label
        {
            AutoSize = false,
            Font = new Font("Malgun Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
            Location = new Point(x, y += 28),
            Text = "Фильм:"
        };
        TextBox txtFilm = new TextBox
        {
            AutoSize = true,
            MinimumSize = new Size(300, 20),
            Font = new Font("Malgun Gothic", 11.8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
            Location = new Point(x, y += 23)
        };
        Label label4 = new Label
        {
            AutoSize = false,
            Font = new Font("Malgun Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
            Location = new Point(x, y += 28),
            Text = "Зал:"
        };
        ComboBox txtHall = new ComboBox
        {
            AutoSize = false,
            Font = new Font("Malgun Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
            Location = new Point(x, y += 23),
        };
        Label label5 = new Label
        {
            AutoSize = false,
            Font = new Font("Malgun Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
            Location = new Point(x, y += 28),
            Text = "Цена:"
        };
        TextBox txtPrice = new TextBox
        {
            AutoSize = true,
            MinimumSize = new Size(100, 20),
            Font = new Font("Malgun Gothic", 11.8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
            Location = new Point(x, y += 23)
        };
        PictureBox pictureBox = new PictureBox
        {
            Image = Properties.Resources.NoImage,
            SizeMode = PictureBoxSizeMode.Zoom,
            Location = new Point(x, y += 30),
            Name = "picPoster",
            Size = new Size(200, 200)
        };
        DB db = new DB();
        public Administrator()
        {
            InitializeComponent();
        }

        private void btnSession_Click(object sender, EventArgs e)
        {
            AddSessions();
        }

        public void AddSessions()
        {
            panelMain.Controls.Add(btnCreateSession);
            btnCreateSession.Click += new EventHandler(this.btnCreateSession_Click);
            panelMain.Controls.Add(btnDelSession);
            btnDelSession.Click += new EventHandler(this.btnDelSession_Click);
            panelMain.Controls.Add(label1);
            panelMain.Controls.Add(txtDate);
            panelMain.Controls.Add(label2);
            txtTime.Items.AddRange(new object[] {
            "9:00",
            "11:00",
            "13:00",
            "15:00",
            "17:00",
            "19:00",
            "21:00"});
            panelMain.Controls.Add(txtTime);
            panelMain.Controls.Add(label3);
            panelMain.Controls.Add(txtFilm);
            panelMain.Controls.Add(label4);
            txtHall.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            panelMain.Controls.Add(txtHall);
            panelMain.Controls.Add(label5);
            panelMain.Controls.Add(txtPrice);
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
            btnPoster.Click += new EventHandler(this.btnPoster_Click);
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
            btnConfirm.Click += new EventHandler(this.btnConfirm_Click);
        }
        void Add_User(string date, string time, string film, string hall, string price, string photo)
        {
            try
            {
                con.Open();
                SqlCommand command2 = con.CreateCommand();
                command2.CommandText = "INSERT INTO [Sessions] VALUES (@date, @time, @film, @hall, @price, @photo)";
                command2.Parameters.AddWithValue("@date", date);
                command2.Parameters.AddWithValue("@time", time);
                command2.Parameters.AddWithValue("@film", film);
                command2.Parameters.AddWithValue("@hall", hall);
                command2.Parameters.AddWithValue("@price", price);
                command2.Parameters.AddWithValue("@photo", photo);
                command2.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtFilm.Text == null || txtHall.Text == null || txtPrice.Text == null || txtTime.Text == null) MessageBox.Show("Заполните все поля!");
            else
            {
                if(photo != null)
                {
                    if(!File.Exists(Environment.CurrentDirectory + photo))
                    {
                        try
                        {
                            File.Copy(dir + $@"\{fileText}", Environment.CurrentDirectory + photo);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error: {ex}");
                        }
                    }
                    string myDate = txtDate.Value.ToString("yyyy.MM.dd");
                    Add_User(myDate, txtTime.Text, txtFilm.Text, txtHall.Text, txtPrice.Text, photo);
                    MessageBox.Show("Успех!");
                }
                if (photo == null)
                {
                    string myDate = txtDate.Value.ToString("yyyy.MM.dd");
                    Add_User(myDate, txtTime.Text, txtFilm.Text, txtHall.Text, txtPrice.Text, "not poster");
                    MessageBox.Show("Успех!");
                }
            }
        }

        private void btnPoster_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Images(*.jpg)|*.jpg|Images(*.png)|*.png|All files(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            string fileName = openFileDialog1.FileName;
            fileText = Path.GetFileName(openFileDialog1.FileName);
            dir = Path.GetDirectoryName(openFileDialog1.FileName);
            pictureBox.Image = Image.FromFile(openFileDialog1.FileName);
            photo = $@"\images\{fileText}";
        }

        private void btnDelSession_Click(object sender, EventArgs e)
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
