using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactList
{
    public partial class Login_Area : Form
    {
        public Login_Area()
        {
            InitializeComponent();
            this.regcon.SendToBack();
            this.vers.Text = Properties.Settings.Default.v.ToString();
        }
    }
}
