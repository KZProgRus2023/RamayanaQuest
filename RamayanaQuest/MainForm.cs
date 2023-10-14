using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RamayanaQuest
{
    public partial class MainForm : Form
    {
        private int score;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            score = 0;
            lblScore.Text = $"Score: {score}";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void btnAnswer1_Click(object sender, EventArgs e)
        {

        }

        private void btnAnswer3_Click(object sender, EventArgs e)
        {

        }

        private void btnAnswer2_Click(object sender, EventArgs e)
        {

        }
    }
}
