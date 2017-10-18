using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PracticeLib;

namespace PracticeApp
{
    public partial class Form1 : Form
    {
        public DateTime birthDate;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
         }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //var birthDate = dateBirth.Value.ToString("yyyy-MM-dd");
            var birthDate = dateBirth.Value;
            var name = txtName.Text;
            var phone = txtPhoneNumber.Text;
            
            //Skapa ny objekt och skickar parametrar till FullText metoden som returnerar konverterade text
            // i variable convertedText
            var practice = new Practice();
            var convertedText = practice.FullText(birthDate, name, phone);

            saveFileDialog1.ShowDialog();

            
            File.AppendAllText(saveFileDialog1.FileName, convertedText);
            
        }

        private void btnConvert_Click(object sender, EventArgs e) 
        {
            openFileDialog1.ShowDialog();

            var fileContent = File.ReadAllText(openFileDialog1.FileName);

            string[] words = fileContent.Split(';');
            
            DateTime dt = Convert.ToDateTime(words[0]);
            
            var age = (DateTime.Now.Year - dt.Year);

            var textPart = $"{words[1]} är {age} år gammal och har telfonnummer {words[2]}";

            saveFileDialog2.ShowDialog();

            File.AppendAllText(saveFileDialog2.FileName, textPart);
        }
    }
}
