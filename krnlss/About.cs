using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace krnlss
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void SourceCreatorLabel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discordapp.com/users/769317112602034177");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCObungL0NYOc5kPUPB3ADKg");
        }

        private void About_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are already viewing the credits page.", "Already Viewing");
        }
    }
}
