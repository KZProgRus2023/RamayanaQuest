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
    public partial class Answer1 : Form
    {
        public Answer1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "Это правильый ответ";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "Это ложь";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "Это ложь";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "Это ложь";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "Это ложь";
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "Это ложь";
        }

        private void label2_Click(object sender, EventArgs e)
        {
         
        }

        private void btnAnswer2_Click(object sender, EventArgs e)
        {
            Answer2 answer = new Answer2();
            answer.Show();
        }
    }

    internal class OnClick : RadioButton
    {
    }
}
