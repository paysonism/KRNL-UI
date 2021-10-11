using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sxlib.Specialized;
using sxlib;
using System.IO;
using System.Diagnostics;

namespace krnlss
{
    public partial class krnlss : Form
    {
        public krnlss()
        {
            InitializeComponent();
        }



        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aboutUI = new About();
            aboutUI.ShowDialog();
        }

        private void killRobloxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process[] runningProcesses = Process.GetProcesses();
            foreach (Process process in runningProcesses)
            {
                // now check the modules of the process
                foreach (ProcessModule module in process.Modules)
                {
                    if (module.FileName.Equals("RobloxPlayerLauncher.exe"))
                    {
                        process.Kill();
                    }
                    else
                    {
                        MessageBox.Show("No Roblox Processes Found!", "Error!");
                  }
                }
            }
        }

        private void ScriptView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            fastColoredTextBox1.Text = File.ReadAllText($"./scripts/{ScriptView.SelectedNode}");
        }

        private void Injectbtn_Click(object sender, EventArgs e)
        {
            Functions.Lib.Attach();
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
        }

        private void Openbtn_Click(object sender, EventArgs e)
        {
            if (Functions.OpenFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.fastColoredTextBox1.Text = File.ReadAllText(Functions.OpenFile.FileName);
                }
                catch (Exception Error)
                {
                    MessageBox.Show("Error loading script!" + Error.Message);
                }
            }
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            this.fastColoredTextBox1.Text = "";
        }

        private void Executebtn_Click(object sender, EventArgs e)
        {
            string script = this.fastColoredTextBox1.Text;
            Functions.Lib.Execute(script);
        }

        private void ScriptHub_Betabtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Script Hub is in the Development Page and some features may not work.", "Development Feature");
            ScriptHub ScriptHub = new ScriptHub();
            ScriptHub.ShowDialog();
        }

        private void scriptHubToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gamesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void scriptHubToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Script Hub In Development, click the space inbetween the Inject & Save File Buttons to test the beta version.", "Development Notice");
        }

        private void krnlss_Load(object sender, EventArgs e)
        {
            MessageBox.Show("KRNL UI for Synapse X Made By [YT]P-DennyGaming#0001", "Credits");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            About aboutUI = new About();
            aboutUI.ShowDialog();
        }

        private void injectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Functions.Lib.Attach();
        }
    }
}
