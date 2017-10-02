using GuessNumberLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessNumberGui
{
    

    public partial class GuessNumberForm : Form
    {
        private GuessNumber _game = new GuessNumber();

        public GuessNumberForm()
        {
            InitializeComponent();
        }

        private void btnRunGame_Click(object sender, EventArgs e)
        {
            _game.Guess(int.Parse(textGuess.Text));
            lblResult.Text = _game.Feedback;
        }

        private void GuessNumberForm_Load(object sender, EventArgs e)
        {
            lblResult.Text = _game.Feedback;
        }
    }
}
