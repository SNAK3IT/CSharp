using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactList
{
    public partial class RegisterControl : UserControl
    {
        public RegisterControl()
        {
            InitializeComponent();
        }
        private void registerbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(usernemreg.Text) && !string.IsNullOrEmpty(emailreg.Text) && !string.IsNullOrEmpty(passreg.Text) && !string.IsNullOrEmpty(repeatpassreg.Text))
                {
                    if (!CheckPassword())
                    {
                        DialogResult res = new DialogResult();
                        this.passreg.ForeColor = System.Drawing.Color.Red;
                        this.repeatpassreg.ForeColor = System.Drawing.Color.Red;
                        res = MessageBox.Show("A Palavra-Passes não coinsidem!");
                        if (res == DialogResult.OK)
                        {
                            this.passreg.ForeColor = System.Drawing.Color.CadetBlue;
                            this.repeatpassreg.ForeColor = System.Drawing.Color.CadetBlue;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Não Obrigatorio preencher todos os campos!","Campos obrigatorios",MessageBoxButtons.OK,MessageBoxIcon.Exclamation,MessageBoxDefaultButton.Button1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sendtologin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.SendToBack();
        }
        public bool CheckPassword()
        {
            if (this.passreg.Text != this.repeatpassreg.Text)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
