using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;


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

        public void AutoSav()
        {
            string lognm = "studylog.txt";
            string[] writelog = new string[EntryLst.Items.Count];

            for (int i = 0; i < EntryLst.Items.Count; i++)
            {
                writelog[i] = EntryLst.Items[i].ToString();
            }

            File.WriteAllLines(lognm, writelog);
        }

        private void EntryAdd_Click(object sender, EventArgs e)
        {

            if(EntryInput.Text.Length > 0) // Fix IsNotNullThing.. i fixed it :3 - peeblyweeb
            {        
                EntryLst.Items.Add(EntryInput.Text + " " + (DateTime.Now));
            }
            else
            {
                MessageBox.Show("Empty input found, please revalidate entry.");
            }
            AutoSav();
        }

        private void EntryDel_Click(object sender, EventArgs e)
        {
            EntryLst.Items.RemoveAt(EntryLst.SelectedIndex);
            AutoSav();
        }

        private void EntryLoad_Click(object sender, EventArgs e)
        {

            string lognm = "studylog.txt";
            string[] readlog = new string[EntryLst.Items.Count];

            for (int i = 0; i < EntryLst.Items.Count; i++)
            {
                readlog[i] = File.ReadAllText(lognm);
            }
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

        /* private void EntrySav_Click(object sender, EventArgs e)
           {
            string lognm = "studylog.txt";
            string[] writelog = new string[EntryLst.Items.Count];

            for (int i = 0; i < EntryLst.Items.Count; i++)
            {
                writelog[i] = EntryLst.Items[i].ToString();
            }

            File.WriteAllLines(lognm, writelog);
           } */

        private void Form1_Load(object sender, EventArgs e)
        {
            string lognm = "studylog.txt";

            // Check if the file exists, if not, create one.
            if (!File.Exists(lognm))
            {
                File.Create(lognm).Close();
            }

            // Read all lines from the log file into a string array.
            string[] readlog = File.ReadAllLines(lognm);

            // Clear the current items in EntryLst and add items from readlog.
            EntryLst.Items.Clear();
            foreach (var line in readlog)
            {
                EntryLst.Items.Add(line);
            }

            // Show a message that the log file has been loaded successfully.
            MessageBox.Show(lognm + " has been loaded successfully! at: " + DateTime.Now);
        }

        private void bootLabel_Click(object sender, EventArgs e)
        {
            bootLabel.Text = string.Empty;
        }
    }
}
