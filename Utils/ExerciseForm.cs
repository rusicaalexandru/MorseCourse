using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MorseCourse.Utils
{
    public partial class ExerciseForm : Form
    {
        public ExerciseForm()
        {
            InitializeComponent();
        }

        private void buttonAnswer_Click(object sender, EventArgs e)
        {
            string pcTranslate = Translate.translateToMorse(richTextBoxTest.Text); //(text)
            // fix validation, (makes unnecesarry to add ' ' at the end of the answer in order to validate corectly)
            if (textBoxAnswer.Text[textBoxAnswer.Text.Length - 1] != ' ')
            {
                textBoxAnswer.Text += ' ';
            }
            if (pcTranslate == textBoxAnswer.Text) // verification of the answer
            {
                Test.score++;
                MessageBox.Show("right");
            }
            else
            {
                Test.wrong++;
                MessageBox.Show("wrong");
            }
            //this.Close();
        }
    }
}
