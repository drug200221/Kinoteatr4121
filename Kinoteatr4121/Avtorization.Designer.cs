
namespace Kinoteatr4121
{
    partial class Avtorization
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_log = new System.Windows.Forms.TextBox();
            this.txt_pas = new System.Windows.Forms.TextBox();
            this.btn_reg = new System.Windows.Forms.Button();
            this.btn_sign = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_remember = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_log
            // 
            this.txt_log.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_log.Location = new System.Drawing.Point(256, 145);
            this.txt_log.Name = "txt_log";
            this.txt_log.Size = new System.Drawing.Size(287, 29);
            this.txt_log.TabIndex = 0;
            this.txt_log.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_log.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_log_KeyDown);
            // 
            // txt_pas
            // 
            this.txt_pas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_pas.Location = new System.Drawing.Point(256, 191);
            this.txt_pas.Name = "txt_pas";
            this.txt_pas.Size = new System.Drawing.Size(287, 29);
            this.txt_pas.TabIndex = 1;
            this.txt_pas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_pas.UseSystemPasswordChar = true;
            this.txt_pas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_log_KeyDown);
            // 
            // btn_reg
            // 
            this.btn_reg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_reg.Location = new System.Drawing.Point(256, 226);
            this.btn_reg.Name = "btn_reg";
            this.btn_reg.Size = new System.Drawing.Size(142, 36);
            this.btn_reg.TabIndex = 3;
            this.btn_reg.Text = "регистрация";
            this.btn_reg.UseVisualStyleBackColor = true;
            // 
            // btn_sign
            // 
            this.btn_sign.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_sign.Location = new System.Drawing.Point(401, 226);
            this.btn_sign.Name = "btn_sign";
            this.btn_sign.Size = new System.Drawing.Size(142, 36);
            this.btn_sign.TabIndex = 2;
            this.btn_sign.Text = "вход";
            this.btn_sign.UseVisualStyleBackColor = true;
            this.btn_sign.Click += new System.EventHandler(this.btn_sign_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(366, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "КиноКайф";
            // 
            // btn_remember
            // 
            this.btn_remember.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_remember.AutoSize = true;
            this.btn_remember.BackColor = System.Drawing.Color.Transparent;
            this.btn_remember.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_remember.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_remember.Location = new System.Drawing.Point(418, 274);
            this.btn_remember.Name = "btn_remember";
            this.btn_remember.Size = new System.Drawing.Size(125, 22);
            this.btn_remember.TabIndex = 2;
            this.btn_remember.Text = "Забыли пароль?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Kinoteatr4121.Properties.Resources.w512h5121339361119cinema;
            this.pictureBox1.Location = new System.Drawing.Point(256, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Avtorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kinoteatr4121.Properties.Resources._21;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btn_remember);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_sign);
            this.Controls.Add(this.btn_reg);
            this.Controls.Add(this.txt_pas);
            this.Controls.Add(this.txt_log);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Avtorization";
            this.Text = "Авторизация";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_log;
        private System.Windows.Forms.TextBox txt_pas;
        private System.Windows.Forms.Button btn_reg;
        private System.Windows.Forms.Button btn_sign;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label btn_remember;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

