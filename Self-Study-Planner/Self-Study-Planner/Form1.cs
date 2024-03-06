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

        /*protected override void OnLoad(EventArgs e)
        {

        }*/
        private void EntryAdd_Click(object sender, EventArgs e)
        {
            EntryLst.Items.Add(EntryInput.Text + " " + (DateTime.Now));
        }

        private void EntryDel_Click(object sender, EventArgs e)
        {
            EntryLst.Items.RemoveAt(EntryLst.SelectedIndex);
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

        private void EntrySav_Click(object sender, EventArgs e)
        {
            string lognm = "studylog.txt";
            string[] writelog = new string[EntryLst.Items.Count];

            for (int i = 0; i < EntryLst.Items.Count; i++)
            {
                writelog[i] = EntryLst.Items[i].ToString();
            }

            File.WriteAllLines(lognm, writelog);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string lognm = "studylog.txt";
            // Call the base class's OnLoad method
            base.OnLoad(e);

            string[] readlog = new string[EntryLst.Items.Count];

            for (int i = 0; i < EntryLst.Items.Count; i++)
            {
                EntryLst.Items.Insert(Convert.ToInt32(lognm), EntryLst); //Err. No1 ("fill the EntryLst one item at a time and you're good to go!")
                readlog[i] = File.ReadAllText(lognm);                    //Err. No2
                MessageBox.Show(lognm + " has been loaded successfully! at: " + (DateTime.Now));
            }

            //check if file exists, if not, create one.
            if (lognm.EndsWith(".txt"))
            {
                // file exists
                
            }
            else
            {
                // file doesn't exist
                // create new file??
            }

            // Additional logic can be implemented here
        }
    }
}
