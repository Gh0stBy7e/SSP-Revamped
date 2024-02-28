using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Self_Study_Planner
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            labelBoot.ForeColor = Color.Green;
            labelBoot.Text = "Planner last booted at " + (DateTime.Now);
        }

        private void entryAdd_Click(object sender, EventArgs e)
        {
            entryLst.Items.Add(entryInput.Text);
        }

        private void entryDel_Click(object sender, EventArgs e)
        {
            entryLst.Items.RemoveAt(entryLst.SelectedIndex);
        }

        private void entryMod_Click(object sender, EventArgs e)
        {
            if (entryLst.SelectedIndex != -1)
            {
                entryLst.Items[entryLst.SelectedIndex] = entryInput.Text;
                if (entryInput.Text.Length == 0)
                {
                    entryLst.Items.RemoveAt(entryLst.SelectedIndex);
                }
            }
        }
    }
}
