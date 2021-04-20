using MorseCourse.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Media;
// to do :
// play button ..
// Tests X
// online X
// tutorial X

namespace MorseCourse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e) // on load
        {

        }
        //------------------------------------------------------------------------------------------------Translate
        private void buttonTest_Click(object sender, EventArgs e) //button for tests
        {

        }

        private void buttonTranslateToMorse_Click(object sender, EventArgs e) //translate to morse
        {
            textBoxOutputMorse.Text = Translate.translateToMorse(textBoxInputText.Text.ToLower());
        }

        private void buttonTranslateToText_Click(object sender, EventArgs e) //translate to text
        {
            textBoxOutputText.Text = Translate.translateToText(textBoxInputMorse.Text);
        }

        private void buttonClearTextTr_Click(object sender, EventArgs e) //clear output (morse)
        {
            textBoxOutputMorse.Text = string.Empty;
        }

        private void buttonClearMorseTr_Click(object sender, EventArgs e) //clear output (text)
        {
            textBoxOutputText.Text = string.Empty;
        }

        //------------------------------------------------------------------------------------------------Translate
        //------------------------------------------------------------------------------------------------Info

        //------------------------------------------------------------------------------------------------Info
        //------------------------------------------------------------------------------------------------Tests
        private void buttonStartTest_Click(object sender, EventArgs e)
        {
            //numericUpDownExercises;
            //labelTest.Text = Convert.ToString(numericUpDownExercises.Value);
            //https://randomwordgenerator.com/sentence.php to  parse it and get random sentencies
            for (int i = 0; i < numericUpDownExercises.Value; i++)
            {
                Test test1 = new Test();// inserted nr of exercises and the average length

            }
            //use for for amount of exercises,
            //create and open form
            //after pressing continue on form : form closes and creates another one with another word in it

        }

        //------------------------------------------------------------------------------------------------Tests

    }
}
