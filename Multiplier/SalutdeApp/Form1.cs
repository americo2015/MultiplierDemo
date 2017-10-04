using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalutdeApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            var prefix = "";
            var name = txtName.Text;
            var lastName = txtLastName.Text;
            var perNummer = txtPerNummer.Text;
            perNummer = perNummer.Substring(9, 1);
            var number = Int32.Parse(perNummer);

            var modulus = number % 2;

            if(modulus == 0)
            {
                prefix = "Fröken ";
            } else if(modulus == 1)
            {
                prefix = "Herr ";
            }

            lblMessage.Text = $"{prefix} {name} {lastName}"; 


        }
    }
}
