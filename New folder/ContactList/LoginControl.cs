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
    public partial class LoginControl : UserControl
    {
        // Carregar para uma lista os user apartir da BaseDados
        //private List<user> users = new List<user>;
        public LoginControl()
        {
            InitializeComponent();
        }

        private void registerlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.SendToBack();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
