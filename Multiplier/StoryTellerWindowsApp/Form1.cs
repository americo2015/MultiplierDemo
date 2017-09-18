using StoryTellerLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoryTellerWindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTellStory_Click(object sender, EventArgs e)
        {
            try
            {
                StoryTeller storyteller = new StoryTeller();
                textStory.Text = storyteller.TellSory(
                    txtNameOfChild.Text,
                    Convert.ToInt32(numAgeOfChild.Value),
                    checkBoxScary.Checked
                );
            } catch (InvalidOperationException ex)
            {
                MessageBox.Show("Kan inte berätta storyn för dig.");
            } finally
            {

            }
            
        }
    }
}
