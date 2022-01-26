
namespace Kinoteatr4121
{
    partial class Administrator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowP = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTicket = new System.Windows.Forms.Button();
            this.btnSession = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.flowP.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowP
            // 
            this.flowP.Controls.Add(this.panel1);
            this.flowP.Controls.Add(this.panelMain);
            this.flowP.Location = new System.Drawing.Point(0, 1);
            this.flowP.Margin = new System.Windows.Forms.Padding(4);
            this.flowP.Name = "flowP";
            this.flowP.Size = new System.Drawing.Size(1799, 897);
            this.flowP.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTicket);
            this.panel1.Controls.Add(this.btnSession);
            this.panel1.Controls.Add(this.btnUsers);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 894);
            this.panel1.TabIndex = 0;
            // 
            // btnTicket
            // 
            this.btnTicket.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTicket.Location = new System.Drawing.Point(5, 129);
            this.btnTicket.Margin = new System.Windows.Forms.Padding(4);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Size = new System.Drawing.Size(237, 52);
            this.btnTicket.TabIndex = 0;
            this.btnTicket.Text = "Продажа билетов";
            this.btnTicket.UseVisualStyleBackColor = false;
            // 
            // btnSession
            // 
            this.btnSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSession.Location = new System.Drawing.Point(5, 70);
            this.btnSession.Margin = new System.Windows.Forms.Padding(4);
            this.btnSession.Name = "btnSession";
            this.btnSession.Size = new System.Drawing.Size(237, 52);
            this.btnSession.TabIndex = 0;
            this.btnSession.Text = "Сеанс";
            this.btnSession.UseVisualStyleBackColor = true;
            this.btnSession.Click += new System.EventHandler(this.btnSession_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Location = new System.Drawing.Point(5, 11);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(4);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(237, 52);
            this.btnUsers.TabIndex = 0;
            this.btnUsers.Text = "Пользователи";
            this.btnUsers.UseVisualStyleBackColor = true;
            // 
            // panelMain
            // 
            this.panelMain.Location = new System.Drawing.Point(258, 3);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1530, 881);
            this.panelMain.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 823);
            this.Controls.Add(this.flowP);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1400, 870);
            this.Name = "Administrator";
            this.Text = "Administrator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Administrator_FormClosing);
            this.flowP.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnTicket;
        private System.Windows.Forms.Button btnSession;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}