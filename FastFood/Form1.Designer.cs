namespace FastFood
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSignIn = new Guna.UI2.WinForms.Guna2Button();
            this.iconUsername = new FontAwesome.Sharp.IconPictureBox();
            this.iconShowPass = new FontAwesome.Sharp.IconPictureBox();
            this.iconCloseForm = new FontAwesome.Sharp.IconPictureBox();
            this.lblWrongPasword = new System.Windows.Forms.Label();
            this.panelWrongPass = new Guna.UI2.WinForms.Guna2Panel();
            this.lblEnterPass = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconShowPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCloseForm)).BeginInit();
            this.panelWrongPass.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Pacifico", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(647, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 116);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(534, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.Transparent;
            this.txtUsername.BorderColor = System.Drawing.Color.Maroon;
            this.txtUsername.BorderRadius = 5;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.Parent = this.txtUsername;
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FillColor = System.Drawing.Color.Cornsilk;
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.FocusedState.Parent = this.txtUsername;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.HoverState.Parent = this.txtUsername;
            this.txtUsername.Location = new System.Drawing.Point(667, 244);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceholderText = "";
            this.txtUsername.SelectedText = "";
            this.txtUsername.ShadowDecoration.Parent = this.txtUsername;
            this.txtUsername.Size = new System.Drawing.Size(244, 36);
            this.txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.BorderColor = System.Drawing.Color.Maroon;
            this.txtPassword.BorderRadius = 5;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.Parent = this.txtPassword;
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FillColor = System.Drawing.Color.Cornsilk;
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.FocusedState.Parent = this.txtPassword;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.HoverState.Parent = this.txtPassword;
            this.txtPassword.Location = new System.Drawing.Point(667, 327);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.SelectedText = "";
            this.txtPassword.ShadowDecoration.Parent = this.txtPassword;
            this.txtPassword.Size = new System.Drawing.Size(244, 36);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Cornsilk;
            this.label3.Location = new System.Drawing.Point(539, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password:";
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.Transparent;
            this.btnSignIn.BorderColor = System.Drawing.Color.Cornsilk;
            this.btnSignIn.BorderRadius = 8;
            this.btnSignIn.BorderThickness = 2;
            this.btnSignIn.CheckedState.Parent = this.btnSignIn;
            this.btnSignIn.CustomImages.Parent = this.btnSignIn;
            this.btnSignIn.FillColor = System.Drawing.Color.Maroon;
            this.btnSignIn.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.ForeColor = System.Drawing.Color.White;
            this.btnSignIn.HoverState.Parent = this.btnSignIn;
            this.btnSignIn.Location = new System.Drawing.Point(647, 425);
            this.btnSignIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.ShadowDecoration.Parent = this.btnSignIn;
            this.btnSignIn.Size = new System.Drawing.Size(163, 46);
            this.btnSignIn.TabIndex = 5;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // iconUsername
            // 
            this.iconUsername.BackColor = System.Drawing.Color.Cornsilk;
            this.iconUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.iconUsername.ForeColor = System.Drawing.Color.Maroon;
            this.iconUsername.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconUsername.IconColor = System.Drawing.Color.Maroon;
            this.iconUsername.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconUsername.IconSize = 30;
            this.iconUsername.Location = new System.Drawing.Point(872, 249);
            this.iconUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconUsername.Name = "iconUsername";
            this.iconUsername.Size = new System.Drawing.Size(35, 30);
            this.iconUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconUsername.TabIndex = 6;
            this.iconUsername.TabStop = false;
            // 
            // iconShowPass
            // 
            this.iconShowPass.BackColor = System.Drawing.Color.Cornsilk;
            this.iconShowPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.iconShowPass.ForeColor = System.Drawing.Color.Maroon;
            this.iconShowPass.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.iconShowPass.IconColor = System.Drawing.Color.Maroon;
            this.iconShowPass.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconShowPass.IconSize = 30;
            this.iconShowPass.Location = new System.Drawing.Point(872, 332);
            this.iconShowPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconShowPass.Name = "iconShowPass";
            this.iconShowPass.Size = new System.Drawing.Size(32, 30);
            this.iconShowPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconShowPass.TabIndex = 7;
            this.iconShowPass.TabStop = false;
            this.iconShowPass.Click += new System.EventHandler(this.iconShowPass_Click);
            // 
            // iconCloseForm
            // 
            this.iconCloseForm.BackColor = System.Drawing.Color.Transparent;
            this.iconCloseForm.ForeColor = System.Drawing.Color.Cornsilk;
            this.iconCloseForm.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconCloseForm.IconColor = System.Drawing.Color.Cornsilk;
            this.iconCloseForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCloseForm.IconSize = 38;
            this.iconCloseForm.Location = new System.Drawing.Point(938, 12);
            this.iconCloseForm.Name = "iconCloseForm";
            this.iconCloseForm.Size = new System.Drawing.Size(44, 38);
            this.iconCloseForm.TabIndex = 8;
            this.iconCloseForm.TabStop = false;
            this.iconCloseForm.Click += new System.EventHandler(this.iconCloseForm_Click);
            // 
            // lblWrongPasword
            // 
            this.lblWrongPasword.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblWrongPasword.AutoSize = true;
            this.lblWrongPasword.BackColor = System.Drawing.Color.Transparent;
            this.lblWrongPasword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblWrongPasword.Font = new System.Drawing.Font("Montserrat Medium", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrongPasword.ForeColor = System.Drawing.Color.DarkRed;
            this.lblWrongPasword.Location = new System.Drawing.Point(24, 1);
            this.lblWrongPasword.Name = "lblWrongPasword";
            this.lblWrongPasword.Padding = new System.Windows.Forms.Padding(4);
            this.lblWrongPasword.Size = new System.Drawing.Size(257, 44);
            this.lblWrongPasword.TabIndex = 9;
            this.lblWrongPasword.Text = "Wrong username or password. \r\nPlease try again.";
            this.lblWrongPasword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWrongPasword.Visible = false;
            this.lblWrongPasword.Click += new System.EventHandler(this.lblWrongPasword_Click);
            // 
            // panelWrongPass
            // 
            this.panelWrongPass.BackColor = System.Drawing.Color.Transparent;
            this.panelWrongPass.BorderColor = System.Drawing.Color.Maroon;
            this.panelWrongPass.BorderRadius = 7;
            this.panelWrongPass.BorderThickness = 5;
            this.panelWrongPass.Controls.Add(this.lblEnterPass);
            this.panelWrongPass.Controls.Add(this.lblWrongPasword);
            this.panelWrongPass.FillColor = System.Drawing.Color.WhiteSmoke;
            this.panelWrongPass.Location = new System.Drawing.Point(567, 376);
            this.panelWrongPass.Name = "panelWrongPass";
            this.panelWrongPass.ShadowDecoration.Parent = this.panelWrongPass;
            this.panelWrongPass.Size = new System.Drawing.Size(337, 51);
            this.panelWrongPass.TabIndex = 10;
            this.panelWrongPass.Visible = false;
            // 
            // lblEnterPass
            // 
            this.lblEnterPass.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblEnterPass.AutoSize = true;
            this.lblEnterPass.BackColor = System.Drawing.Color.Transparent;
            this.lblEnterPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEnterPass.Font = new System.Drawing.Font("Montserrat Medium", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterPass.ForeColor = System.Drawing.Color.DarkRed;
            this.lblEnterPass.Location = new System.Drawing.Point(5, 13);
            this.lblEnterPass.Name = "lblEnterPass";
            this.lblEnterPass.Padding = new System.Windows.Forms.Padding(4);
            this.lblEnterPass.Size = new System.Drawing.Size(308, 26);
            this.lblEnterPass.TabIndex = 10;
            this.lblEnterPass.Text = "Please enter username and password";
            this.lblEnterPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEnterPass.Visible = false;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnSignIn;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(994, 608);
            this.Controls.Add(this.panelWrongPass);
            this.Controls.Add(this.iconCloseForm);
            this.Controls.Add(this.iconShowPass);
            this.Controls.Add(this.iconUsername);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(994, 608);
            this.MinimumSize = new System.Drawing.Size(994, 608);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            ((System.ComponentModel.ISupportInitialize)(this.iconUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconShowPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCloseForm)).EndInit();
            this.panelWrongPass.ResumeLayout(false);
            this.panelWrongPass.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnSignIn;
        private FontAwesome.Sharp.IconPictureBox iconUsername;
        private FontAwesome.Sharp.IconPictureBox iconShowPass;
        private FontAwesome.Sharp.IconPictureBox iconCloseForm;
        private System.Windows.Forms.Label lblWrongPasword;
        private Guna.UI2.WinForms.Guna2Panel panelWrongPass;
        private System.Windows.Forms.Label lblEnterPass;
    }
}

