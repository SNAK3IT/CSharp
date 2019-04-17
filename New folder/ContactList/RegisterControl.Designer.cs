namespace ContactList
{
    partial class RegisterControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterControl));
            this.reg_img = new System.Windows.Forms.PictureBox();
            this.label_repeat = new System.Windows.Forms.Label();
            this.repeatpassreg = new System.Windows.Forms.TextBox();
            this.emailreg = new System.Windows.Forms.TextBox();
            this.label_email = new System.Windows.Forms.Label();
            this.usernemreg = new System.Windows.Forms.TextBox();
            this.label_username = new System.Windows.Forms.Label();
            this.label_pass = new System.Windows.Forms.Label();
            this.registerbtn = new System.Windows.Forms.Button();
            this.passreg = new System.Windows.Forms.TextBox();
            this.sendtologin = new System.Windows.Forms.LinkLabel();
            this.have_acc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.reg_img)).BeginInit();
            this.SuspendLayout();
            // 
            // reg_img
            // 
            this.reg_img.BackColor = System.Drawing.Color.Transparent;
            this.reg_img.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reg_img.BackgroundImage")));
            this.reg_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reg_img.Location = new System.Drawing.Point(193, 48);
            this.reg_img.Name = "reg_img";
            this.reg_img.Size = new System.Drawing.Size(166, 164);
            this.reg_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.reg_img.TabIndex = 14;
            this.reg_img.TabStop = false;
            // 
            // label_repeat
            // 
            this.label_repeat.AutoSize = true;
            this.label_repeat.BackColor = System.Drawing.Color.Transparent;
            this.label_repeat.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_repeat.ForeColor = System.Drawing.Color.CadetBlue;
            this.label_repeat.Location = new System.Drawing.Point(122, 478);
            this.label_repeat.Name = "label_repeat";
            this.label_repeat.Size = new System.Drawing.Size(306, 32);
            this.label_repeat.TabIndex = 23;
            this.label_repeat.Text = "Repetir palavra-passe";
            // 
            // repeatpassreg
            // 
            this.repeatpassreg.BackColor = System.Drawing.Color.White;
            this.repeatpassreg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.repeatpassreg.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repeatpassreg.ForeColor = System.Drawing.Color.CadetBlue;
            this.repeatpassreg.Location = new System.Drawing.Point(79, 514);
            this.repeatpassreg.Margin = new System.Windows.Forms.Padding(5);
            this.repeatpassreg.MaxLength = 255;
            this.repeatpassreg.Name = "repeatpassreg";
            this.repeatpassreg.PasswordChar = '*';
            this.repeatpassreg.Size = new System.Drawing.Size(392, 28);
            this.repeatpassreg.TabIndex = 22;
            this.repeatpassreg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // emailreg
            // 
            this.emailreg.BackColor = System.Drawing.Color.White;
            this.emailreg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailreg.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailreg.ForeColor = System.Drawing.Color.CadetBlue;
            this.emailreg.Location = new System.Drawing.Point(79, 351);
            this.emailreg.Margin = new System.Windows.Forms.Padding(5);
            this.emailreg.MaxLength = 255;
            this.emailreg.Name = "emailreg";
            this.emailreg.Size = new System.Drawing.Size(392, 28);
            this.emailreg.TabIndex = 20;
            this.emailreg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.BackColor = System.Drawing.Color.Transparent;
            this.label_email.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.ForeColor = System.Drawing.Color.CadetBlue;
            this.label_email.Location = new System.Drawing.Point(232, 315);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(87, 32);
            this.label_email.TabIndex = 21;
            this.label_email.Text = "Email";
            // 
            // usernemreg
            // 
            this.usernemreg.BackColor = System.Drawing.Color.White;
            this.usernemreg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernemreg.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernemreg.ForeColor = System.Drawing.Color.CadetBlue;
            this.usernemreg.Location = new System.Drawing.Point(79, 268);
            this.usernemreg.Margin = new System.Windows.Forms.Padding(5);
            this.usernemreg.MaximumSize = new System.Drawing.Size(392, 40);
            this.usernemreg.MaxLength = 255;
            this.usernemreg.Name = "usernemreg";
            this.usernemreg.Size = new System.Drawing.Size(392, 28);
            this.usernemreg.TabIndex = 12;
            this.usernemreg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.BackColor = System.Drawing.Color.Transparent;
            this.label_username.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.ForeColor = System.Drawing.Color.CadetBlue;
            this.label_username.Location = new System.Drawing.Point(145, 232);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(261, 32);
            this.label_username.TabIndex = 17;
            this.label_username.Text = "Nome de utilizador";
            // 
            // label_pass
            // 
            this.label_pass.AutoSize = true;
            this.label_pass.BackColor = System.Drawing.Color.Transparent;
            this.label_pass.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pass.ForeColor = System.Drawing.Color.CadetBlue;
            this.label_pass.Location = new System.Drawing.Point(174, 397);
            this.label_pass.Name = "label_pass";
            this.label_pass.Size = new System.Drawing.Size(203, 32);
            this.label_pass.TabIndex = 16;
            this.label_pass.Text = "Palavra-passe";
            // 
            // registerbtn
            // 
            this.registerbtn.BackColor = System.Drawing.Color.CadetBlue;
            this.registerbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.registerbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerbtn.FlatAppearance.BorderSize = 0;
            this.registerbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(189)))), ((int)(((byte)(191)))));
            this.registerbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerbtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.registerbtn.Location = new System.Drawing.Point(196, 568);
            this.registerbtn.Name = "registerbtn";
            this.registerbtn.Size = new System.Drawing.Size(158, 46);
            this.registerbtn.TabIndex = 15;
            this.registerbtn.Text = "Registar";
            this.registerbtn.UseVisualStyleBackColor = false;
            this.registerbtn.Click += new System.EventHandler(this.registerbtn_Click);
            // 
            // passreg
            // 
            this.passreg.BackColor = System.Drawing.Color.White;
            this.passreg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passreg.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passreg.ForeColor = System.Drawing.Color.CadetBlue;
            this.passreg.Location = new System.Drawing.Point(79, 433);
            this.passreg.Margin = new System.Windows.Forms.Padding(5);
            this.passreg.MaxLength = 255;
            this.passreg.Name = "passreg";
            this.passreg.PasswordChar = '*';
            this.passreg.Size = new System.Drawing.Size(392, 28);
            this.passreg.TabIndex = 13;
            this.passreg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sendtologin
            // 
            this.sendtologin.ActiveLinkColor = System.Drawing.Color.DarkCyan;
            this.sendtologin.AutoSize = true;
            this.sendtologin.BackColor = System.Drawing.Color.Transparent;
            this.sendtologin.DisabledLinkColor = System.Drawing.Color.Transparent;
            this.sendtologin.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendtologin.LinkColor = System.Drawing.Color.CadetBlue;
            this.sendtologin.Location = new System.Drawing.Point(298, 626);
            this.sendtologin.Name = "sendtologin";
            this.sendtologin.Size = new System.Drawing.Size(42, 20);
            this.sendtologin.TabIndex = 18;
            this.sendtologin.TabStop = true;
            this.sendtologin.Text = "Login";
            this.sendtologin.VisitedLinkColor = System.Drawing.Color.Transparent;
            this.sendtologin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.sendtologin_LinkClicked);
            // 
            // have_acc
            // 
            this.have_acc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.have_acc.AutoSize = true;
            this.have_acc.BackColor = System.Drawing.Color.Transparent;
            this.have_acc.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.have_acc.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.have_acc.Location = new System.Drawing.Point(204, 626);
            this.have_acc.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.have_acc.Name = "have_acc";
            this.have_acc.Size = new System.Drawing.Size(96, 20);
            this.have_acc.TabIndex = 19;
            this.have_acc.Text = "Já tenho conta";
            // 
            // RegisterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.Controls.Add(this.reg_img);
            this.Controls.Add(this.label_repeat);
            this.Controls.Add(this.repeatpassreg);
            this.Controls.Add(this.emailreg);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.usernemreg);
            this.Controls.Add(this.have_acc);
            this.Controls.Add(this.sendtologin);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.label_pass);
            this.Controls.Add(this.registerbtn);
            this.Controls.Add(this.passreg);
            this.Name = "RegisterControl";
            this.Size = new System.Drawing.Size(550, 694);
            ((System.ComponentModel.ISupportInitialize)(this.reg_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox reg_img;
        private System.Windows.Forms.Label label_repeat;
        private System.Windows.Forms.TextBox repeatpassreg;
        private System.Windows.Forms.TextBox emailreg;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.TextBox usernemreg;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_pass;
        private System.Windows.Forms.Button registerbtn;
        private System.Windows.Forms.TextBox passreg;
        private System.Windows.Forms.LinkLabel sendtologin;
        private System.Windows.Forms.Label have_acc;
    }
}
