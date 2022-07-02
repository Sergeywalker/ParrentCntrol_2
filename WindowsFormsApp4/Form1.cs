using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        bool whiteStop = true;
        bool blackStop = true;
        public Form1()
        {
            InitializeComponent();
        }

        

        private void buttonWhite_Click(object sender, EventArgs e)
        {
            if (textBoxWhite.Text != "")
            {
                Whitelist.Items.Add(textBoxWhite.Text);
                textBoxWhite.Text = "";
            }
        }

        private void buttonStartWhite_Click(object sender, EventArgs e)
        {
            ProcessStart();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            blackStop = true;
            whiteStop = true;
        }
        
        async void ProcessStart()
        {
            if (Whitelist.Items != null && whiteStop)
            {
                whiteStop = false;
                while (!whiteStop)
                {
                    foreach (var listItem in Whitelist.Items)
                    {
                        int processCount = 0;
                        foreach (var item in Process.GetProcessesByName(listItem.ToString()))
                        {
                            processCount++;
                        }
                        if (processCount == 0)
                        {
                            try
                            {
                                Process.Start(listItem.ToString());
                            }
                            catch (Exception)
                            {


                            }
                        }
                    }
                    await Task.Delay(1000);
                }
            }
        }


        private void buttonDellWhite_Click(object sender, EventArgs e)
        {
            if (Whitelist.SelectedIndex >= 0) { Whitelist.Items.RemoveAt(Whitelist.SelectedIndex); }
        }

        private void buttonStopBlack_Click(object sender, EventArgs e)
        {
            blackStop = true;
        }

        private void buttonStopWhite_Click(object sender, EventArgs e)
        {
            whiteStop = true;
        }


    }
}