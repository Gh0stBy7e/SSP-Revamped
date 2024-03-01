using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace Self_Study_Planner
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            labelBoot.ForeColor = Color.GreenYellow;
            labelBoot.Text = "Planner last booted at " + (DateTime.Now);
        }

        private void EntryAdd_Click(object sender, EventArgs e)
        {
            EntryLst.Items.Add(EntryInput.Text + " " + (DateTime.Now));
        }

        private void EntryDel_Click(object sender, EventArgs e)
        {
            EntryLst.Items.RemoveAt(EntryLst.SelectedIndex);
        }

        private void EntryMod_Click(object sender, EventArgs e)
        {
            if (EntryLst.SelectedIndex != -1)
            {
                EntryLst.Items[EntryLst.SelectedIndex] = EntryInput.Text + " " + (DateTime.Now);
                if (EntryInput.Text.Length == 0)
                {
                    EntryLst.Items.RemoveAt(EntryLst.SelectedIndex);
                }
            }
        }

        private void EntrySav_Click(object sender, EventArgs e)
        {
            string[] writelog = new string[EntryLst.Items.Count];

            for (int i = 0; i < EntryLst.Items.Count; i++)
            {
                writelog[i] = EntryLst.Items[i].ToString();
            }

            File.WriteAllLines("studylog.txt", writelog);
        }

        private void EntryLoad_Click(object sender, EventArgs e)
        {
            string[] readlog = new string[EntryLst.Items.Count];

            for(int i = 0; i < EntryLst.Items.Count;i++) 
            {
                readlog[i] = File.ReadAllText("studylog.txt");
            }
        }
    }
}
