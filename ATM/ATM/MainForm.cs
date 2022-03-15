using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class MainForm : Form
    {
        public string userName;
        public string Userid;
        public MainForm(string name, string userid)
        {
            InitializeComponent();
            userName = name;
            Userid = userid;

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            label1.Text = userName;
        }
    }
}
