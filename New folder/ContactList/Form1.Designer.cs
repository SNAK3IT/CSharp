namespace ContactList
{
    partial class Login_Area
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Area));
            this.vers = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.regcon = new ContactList.RegisterControl();
            this.logcon = new ContactList.LoginControl();
            this.SuspendLayout();
            // 
            // vers
            // 
            this.vers.AutoSize = true;
            this.vers.BackColor = System.Drawing.Color.LightCyan;
            this.vers.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vers.ForeColor = System.Drawing.Color.CadetBlue;
            this.vers.Location = new System.Drawing.Point(483, 629);
            this.vers.Name = "vers";
            this.vers.Size = new System.Drawing.Size(46, 16);
            this.vers.TabIndex = 3;
            this.vers.Text = "teste";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightCyan;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(414, 629);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Versão : ";
            // 
            // regcon
            // 
            this.regcon.BackColor = System.Drawing.Color.LightCyan;
            this.regcon.ForeColor = System.Drawing.Color.White;
            this.regcon.Location = new System.Drawing.Point(-10, -22);
            this.regcon.Name = "regcon";
            this.regcon.Size = new System.Drawing.Size(550, 694);
            this.regcon.TabIndex = 2;
            // 
            // logcon
            // 
            this.logcon.BackColor = System.Drawing.Color.LightCyan;
            this.logcon.Location = new System.Drawing.Point(-7, -18);
            this.logcon.Name = "logcon";
            this.logcon.Size = new System.Drawing.Size(550, 694);
            this.logcon.TabIndex = 0;
            // 
            // Login_Area
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(530, 651);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vers);
            this.Controls.Add(this.regcon);
            this.Controls.Add(this.logcon);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login_Area";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONTACTSLY";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LoginControl logcon;
        private RegisterControl regcon;
        private System.Windows.Forms.Label vers;
        private System.Windows.Forms.Label label1;
    }
}

