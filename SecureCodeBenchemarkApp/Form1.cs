using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecureCodeBenchemarkApp
{
    public partial class Form1 : Form
    {
        List<Creature> creatures = new List<Creature>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void saveAndSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            creatures.Clear();
            FileManager fm = new FileManager();

            creatures = fm.LoadCreatures();

            if (creatures == null)
            { MessageBox.Show("Eoor loading Creatures", "File IO Error"); }

            else
            {
                lbxCreatures.Items.Clear();
                lbxCreatures.Items.AddRange(creatures.ToArray());
            }
        }

        private void btnAZ_Click(object sender, EventArgs e)
        {
            Filter cFilter = new Filter();

            creatures = cFilter.SortAZ(creatures);

            lbxCreatures.Items.Clear();
            lbxCreatures.Items.AddRange(creatures.ToArray());
        }

        private void btnZA_Click(object sender, EventArgs e)
        {
            Filter cFilter = new Filter();

            creatures = cFilter.SortZA(creatures);

            lbxCreatures.Items.Clear();
            lbxCreatures.Items.AddRange(creatures.ToArray());

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Creature> results = new List<Creature>();
            Filter cFilter = new Filter();

            string terms = tbxSearch.Text;

            results = cFilter.Search(creatures, terms);

            lbxSearchResults.Items.Clear();
            lbxSearchResults.Items.AddRange(results.ToArray());

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                FileManager fm = new FileManager();

                Creature c = (Creature)lbxSearchResults.SelectedItem;

                string filename = c.CreatureName + c.Age + c.Owner + ".txt";

                bool result = fm.SaveCreatures(c, filename);

                if (result == false)
                {
                    MessageBox.Show("Eoor Saving Creature", "File IO Error");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("View File?", "Save Success", MessageBoxButtons.YesNo);

                    if (dr.Equals(DialogResult.Yes))
                    {
                        System.Diagnostics.Process.Start(filename);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please select a creature", "Error");
            }
        }

        private void IbxSearchResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Creature c = (Creature)lbxSearchResults.SelectedItem;

                txbName.Text = c.CreatureName;
                txbAge.Text = c.Age.ToString();
                txbOwner.Text = c.Owner;
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }


            }

        private void lbxCreatures_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

    
}
