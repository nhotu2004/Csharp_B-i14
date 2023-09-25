using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Csharp_Bài14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void picsmall_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picbig, "Click me");
        }

        private void picbig_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picsmall, "Click me");
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            lblMessage.Text = txtName.Text + " : " + txtMessage.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMessage.Clear();
            txtName.Clear();
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            lblMessage.ForeColor = Color.Red;
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            lblMessage.ForeColor = Color.Green;
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            lblMessage.ForeColor = Color.Blue;
        }

        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            lblMessage.ForeColor = Color.Black;
        }

        private void chkvisible_CheckedChanged(object sender, EventArgs e)
        {
            lblMessage.Visible = chkvisible.Checked;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picbig_Click(object sender, EventArgs e)
        {
            picbig.Visible = false;
            picsmall.Visible = true;
        }

        private void picsmall_Click(object sender, EventArgs e)
        {
            picbig.Visible = true;
            picsmall.Visible = false;
        }
    }
}
