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
        string translate;
        public ExerciseForm(string toTranslate)
        {
            InitializeComponent();
            translate = toTranslate;
        }
        private void ExerciseForm_Load(object sender, EventArgs e)
        {
            richTextBoxTest.Text = translate;//Sentence to translate
        }

        private void buttonAnswer_Click(object sender, EventArgs e)
        {
            string rightTranslate = Translate.translateToMorse(richTextBoxTest.Text); //(text)
            // fix validation, (makes unnecesarry to add ' ' at the end of the answer in order to validate corectly)
            if (textBoxAnswer.Text != string.Empty)
            {
                if (textBoxAnswer.Text[textBoxAnswer.Text.Length - 1] != ' ')
                {
                    textBoxAnswer.Text += ' ';
                }
            }
            if (textBoxAnswer.Text == string.Empty)
            {
                MessageBox.Show("At least try");
            }
            else if (rightTranslate == textBoxAnswer.Text) // verification of the answer
            {
                Test.score++;
                MessageBox.Show("right");
                this.Close();
            }
            else
            {
                Test.wrong++;
                MessageBox.Show("wrong");
                this.Close();
            }
        }
        private void buttonSkip_Click(object sender, EventArgs e)
        {
            Test.skiped++;
            this.Close();
        }
    }
}
