using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CustomerFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            var name = textBoxName.Text;
            var date = dateTimePicker.Value.ToString("yyyy-MM-dd");
            var phoneNumber = textBoxTelNummer.Text;

            var tokens = new string[] { name, date, phoneNumber };

            File.WriteAllText(saveFileDialog1.FileName, string.Join(";", tokens));

            

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
