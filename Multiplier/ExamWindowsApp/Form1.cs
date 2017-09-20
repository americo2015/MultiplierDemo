using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamLib;

namespace ExamWindowsApp
{
    public partial class Form1 : Form
    {
        private Exam anExam = new Exam("CSharp");

        public Form1()
        {
            InitializeComponent();

        }

        private void btnAssign_Click(object sender, EventArgs e) 
        {
            //  Crea una instancia de la clase Student con el nombre del estudiante que esta en el textbox
            Student student = new Student(textStudentName.Text);
            anExam.Assign(student); // llama al metodo Assign y envia el nombre del estudiante al diccionario
            comboBoxStudentList.Items.Add(student); // agrega el nombre del estudiante a la combobox.
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void btnBetyg_Click(object sender, EventArgs e)
        {
            anExam.Grade((Student)comboBoxStudentList.SelectedItem,
                comboBoxGrade.SelectedItem.ToString());
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            var gradeCountDictionary = anExam.GenerateStatistics();
            var ig = gradeCountDictionary["IG"];
            var g = gradeCountDictionary["G"];
            var vg = gradeCountDictionary["VG"];

            lblG.Text = $"G: {g}";
            lblIg.Text = $"IG: {ig}";
            lblVg.Text = $"VG: {vg}";
        }
    }
}
