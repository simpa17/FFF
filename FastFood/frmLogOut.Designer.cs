namespace FastFood
{
    partial class frmLogOut
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnNoClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnYesClose = new Guna.UI2.WinForms.Guna2Button();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.guna2Panel1);
            this.panel1.Controls.Add(this.btnNoClose);
            this.panel1.Controls.Add(this.btnYesClose);
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 191);
            this.panel1.TabIndex = 6;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Cornsilk;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(461, 18);
            this.guna2Panel1.TabIndex = 4;
            // 
            // btnNoClose
            // 
            this.btnNoClose.BorderRadius = 8;
            this.btnNoClose.CheckedState.Parent = this.btnNoClose;
            this.btnNoClose.CustomImages.Parent = this.btnNoClose;
            this.btnNoClose.FillColor = System.Drawing.Color.Cornsilk;
            this.btnNoClose.Font = new System.Drawing.Font("Ubuntu Mono", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoClose.ForeColor = System.Drawing.Color.Maroon;
            this.btnNoClose.HoverState.Parent = this.btnNoClose;
            this.btnNoClose.Location = new System.Drawing.Point(279, 120);
            this.btnNoClose.Name = "btnNoClose";
            this.btnNoClose.PressedColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNoClose.ShadowDecoration.Parent = this.btnNoClose;
            this.btnNoClose.Size = new System.Drawing.Size(93, 44);
            this.btnNoClose.TabIndex = 3;
            this.btnNoClose.Text = "No";
            this.btnNoClose.Click += new System.EventHandler(this.btnNoClose_Click);
            // 
            // btnYesClose
            // 
            this.btnYesClose.BorderRadius = 8;
            this.btnYesClose.CheckedState.Parent = this.btnYesClose;
            this.btnYesClose.CustomImages.Parent = this.btnYesClose;
            this.btnYesClose.FillColor = System.Drawing.Color.Cornsilk;
            this.btnYesClose.Font = new System.Drawing.Font("Ubuntu Mono", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYesClose.ForeColor = System.Drawing.Color.Maroon;
            this.btnYesClose.HoverState.Parent = this.btnYesClose;
            this.btnYesClose.Location = new System.Drawing.Point(93, 120);
            this.btnYesClose.Name = "btnYesClose";
            this.btnYesClose.PressedColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnYesClose.ShadowDecoration.Parent = this.btnYesClose;
            this.btnYesClose.Size = new System.Drawing.Size(93, 44);
            this.btnYesClose.TabIndex = 2;
            this.btnYesClose.Text = "Yes";
            this.btnYesClose.Click += new System.EventHandler(this.btnYesClose_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Cornsilk;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Cornsilk;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 54;
            this.iconPictureBox1.Location = new System.Drawing.Point(24, 45);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(57, 54);
            this.iconPictureBox1.TabIndex = 1;
            this.iconPictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ubuntu Mono", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(87, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Do you want to log out?";
            // 
            // frmLogOut
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(466, 193);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogOut";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnNoClose;
        private Guna.UI2.WinForms.Guna2Button btnYesClose;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label1;
    }
}