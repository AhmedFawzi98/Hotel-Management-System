namespace HotelManagementAF.UI
{
    partial class Login
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
            metroSetControlBox1 = new MetroSetControlBox();
            LblLogin = new MetroSetLabel();
            txtboxUserName = new MetroSetTextBox();
            txtboxPassword = new MetroSetTextBox();
            lblCopyright = new MetroSetLabel();
            btnLogin = new MetroSetButton();
            SuspendLayout();
            // 
            // metroSetControlBox1
            // 
            metroSetControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            metroSetControlBox1.CloseHoverBackColor = Color.FromArgb(183, 40, 40);
            metroSetControlBox1.CloseHoverForeColor = Color.White;
            metroSetControlBox1.CloseNormalForeColor = Color.Gray;
            metroSetControlBox1.DisabledForeColor = Color.Silver;
            metroSetControlBox1.IsDerivedStyle = true;
            metroSetControlBox1.Location = new Point(685, 5);
            metroSetControlBox1.MaximizeBox = true;
            metroSetControlBox1.MaximizeHoverBackColor = Color.FromArgb(238, 238, 238);
            metroSetControlBox1.MaximizeHoverForeColor = Color.Gray;
            metroSetControlBox1.MaximizeNormalForeColor = Color.Gray;
            metroSetControlBox1.MinimizeBox = true;
            metroSetControlBox1.MinimizeHoverBackColor = Color.FromArgb(238, 238, 238);
            metroSetControlBox1.MinimizeHoverForeColor = Color.Gray;
            metroSetControlBox1.MinimizeNormalForeColor = Color.Gray;
            metroSetControlBox1.Name = "metroSetControlBox1";
            metroSetControlBox1.Size = new Size(100, 25);
            metroSetControlBox1.Style = MetroSet_UI.Enums.Style.Dark;
            metroSetControlBox1.StyleManager = null;
            metroSetControlBox1.TabIndex = 0;
            metroSetControlBox1.Text = "metroSetControlBox1";
            metroSetControlBox1.ThemeAuthor = "Narwin";
            metroSetControlBox1.ThemeName = "MetroDark";
            // 
            // LblLogin
            // 
            LblLogin.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblLogin.IsDerivedStyle = true;
            LblLogin.Location = new Point(15, 42);
            LblLogin.Name = "LblLogin";
            LblLogin.Size = new Size(142, 42);
            LblLogin.Style = MetroSet_UI.Enums.Style.Dark;
            LblLogin.StyleManager = null;
            LblLogin.TabIndex = 1;
            LblLogin.Text = "Welcome!";
            LblLogin.ThemeAuthor = "Narwin";
            LblLogin.ThemeName = "MetroDark";
            // 
            // txtboxUserName
            // 
            txtboxUserName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtboxUserName.AutoCompleteCustomSource = null;
            txtboxUserName.AutoCompleteMode = AutoCompleteMode.None;
            txtboxUserName.AutoCompleteSource = AutoCompleteSource.None;
            txtboxUserName.BorderColor = Color.FromArgb(110, 110, 110);
            txtboxUserName.DisabledBackColor = Color.FromArgb(80, 80, 80);
            txtboxUserName.DisabledBorderColor = Color.FromArgb(109, 109, 109);
            txtboxUserName.DisabledForeColor = Color.FromArgb(109, 109, 109);
            txtboxUserName.Font = new Font("Microsoft Sans Serif", 10F);
            txtboxUserName.HoverColor = Color.FromArgb(65, 177, 225);
            txtboxUserName.Image = null;
            txtboxUserName.IsDerivedStyle = true;
            txtboxUserName.Lines = null;
            txtboxUserName.Location = new Point(257, 118);
            txtboxUserName.MaxLength = 32767;
            txtboxUserName.Multiline = false;
            txtboxUserName.Name = "txtboxUserName";
            txtboxUserName.ReadOnly = false;
            txtboxUserName.Size = new Size(287, 50);
            txtboxUserName.Style = MetroSet_UI.Enums.Style.Dark;
            txtboxUserName.StyleManager = null;
            txtboxUserName.TabIndex = 1;
            txtboxUserName.TabStop = false;
            txtboxUserName.TextAlign = HorizontalAlignment.Left;
            txtboxUserName.ThemeAuthor = "Narwin";
            txtboxUserName.ThemeName = "MetroDark";
            txtboxUserName.UseSystemPasswordChar = false;
            txtboxUserName.WatermarkText = "user name";
            // 
            // txtboxPassword
            // 
            txtboxPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtboxPassword.AutoCompleteCustomSource = null;
            txtboxPassword.AutoCompleteMode = AutoCompleteMode.None;
            txtboxPassword.AutoCompleteSource = AutoCompleteSource.None;
            txtboxPassword.BorderColor = Color.FromArgb(110, 110, 110);
            txtboxPassword.DisabledBackColor = Color.FromArgb(80, 80, 80);
            txtboxPassword.DisabledBorderColor = Color.FromArgb(109, 109, 109);
            txtboxPassword.DisabledForeColor = Color.FromArgb(109, 109, 109);
            txtboxPassword.Font = new Font("Microsoft Sans Serif", 10F);
            txtboxPassword.HoverColor = Color.FromArgb(65, 177, 225);
            txtboxPassword.Image = null;
            txtboxPassword.IsDerivedStyle = true;
            txtboxPassword.Lines = null;
            txtboxPassword.Location = new Point(257, 200);
            txtboxPassword.MaxLength = 32767;
            txtboxPassword.Multiline = false;
            txtboxPassword.Name = "txtboxPassword";
            txtboxPassword.ReadOnly = false;
            txtboxPassword.Size = new Size(287, 50);
            txtboxPassword.Style = MetroSet_UI.Enums.Style.Dark;
            txtboxPassword.StyleManager = null;
            txtboxPassword.TabIndex = 2;
            txtboxPassword.TabStop = false;
            txtboxPassword.TextAlign = HorizontalAlignment.Left;
            txtboxPassword.ThemeAuthor = "Narwin";
            txtboxPassword.ThemeName = "MetroDark";
            txtboxPassword.UseSystemPasswordChar = true;
            txtboxPassword.WatermarkText = "password";
            // 
            // lblCopyright
            // 
            lblCopyright.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblCopyright.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCopyright.IsDerivedStyle = true;
            lblCopyright.Location = new Point(623, 422);
            lblCopyright.Name = "lblCopyright";
            lblCopyright.Size = new Size(182, 21);
            lblCopyright.Style = MetroSet_UI.Enums.Style.Dark;
            lblCopyright.StyleManager = null;
            lblCopyright.TabIndex = 2;
            lblCopyright.Text = "© Dev. By -  Ahmed Fawzi";
            lblCopyright.ThemeAuthor = "Narwin";
            lblCopyright.ThemeName = "MetroDark";
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnLogin.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            btnLogin.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            btnLogin.DisabledForeColor = Color.Gray;
            btnLogin.Font = new Font("Microsoft Sans Serif", 10F);
            btnLogin.HoverBorderColor = Color.FromArgb(95, 207, 255);
            btnLogin.HoverColor = Color.FromArgb(95, 207, 255);
            btnLogin.HoverTextColor = Color.White;
            btnLogin.IsDerivedStyle = true;
            btnLogin.Location = new Point(345, 267);
            btnLogin.Name = "btnLogin";
            btnLogin.NormalBorderColor = Color.FromArgb(65, 177, 225);
            btnLogin.NormalColor = Color.FromArgb(65, 177, 225);
            btnLogin.NormalTextColor = Color.White;
            btnLogin.PressBorderColor = Color.FromArgb(35, 147, 195);
            btnLogin.PressColor = Color.FromArgb(35, 147, 195);
            btnLogin.PressTextColor = Color.White;
            btnLogin.Size = new Size(111, 33);
            btnLogin.Style = MetroSet_UI.Enums.Style.Dark;
            btnLogin.StyleManager = null;
            btnLogin.TabIndex = 3;
            btnLogin.TabStop = false;
            btnLogin.Text = "Log In";
            btnLogin.ThemeAuthor = "";
            btnLogin.ThemeName = "";
            btnLogin.Click += btnLogin_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogin);
            Controls.Add(lblCopyright);
            Controls.Add(txtboxPassword);
            Controls.Add(txtboxUserName);
            Controls.Add(LblLogin);
            Controls.Add(metroSetControlBox1);
            MinimumSize = new Size(800, 450);
            Name = "Login";
            Style = MetroSet_UI.Enums.Style.Dark;
            TextColor = Color.White;
            ThemeName = "MetroDark";
            Load += Login_Load;
            ResumeLayout(false);
        }

        #endregion

        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private MetroSet_UI.Controls.MetroSetLabel LblLogin;
        private MetroSet_UI.Controls.MetroSetTextBox txtboxPassword;
        private MetroSet_UI.Controls.MetroSetTextBox txtboxUserName;
        private MetroSet_UI.Controls.MetroSetLabel lblCopyright;
        private MetroSet_UI.Controls.MetroSetButton btnLogin;
    }
}