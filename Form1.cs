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


namespace MorseCourse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void buttonTest_Click(object sender, EventArgs e) //button for tests
        {

        }

        private void Form1_Load(object sender, EventArgs e) // on load
        {

        }

        private void buttonTranslateToMorse_Click(object sender, EventArgs e) //translate to morse
        {
            textBoxOutputMorse.Text = Translate.translateToMorse(textBoxInputText.Text.ToLower());
        }

        private void buttonTranslateToText_Click(object sender, EventArgs e) //translate to text
        {
            textBoxOutputText.Text = Translate.translateToText(textBoxInputMorse.Text + " ".ToLower()); // + " " - removes necesety to add blank space at the end of morce code to translate
        }

        private void buttonClearTextTr_Click(object sender, EventArgs e) //clear output (morse)
        {
            textBoxOutputMorse.Text = string.Empty;
        }

        private void buttonClearMorseTr_Click(object sender, EventArgs e) //clear output (text)
        {
            textBoxOutputText.Text = string.Empty;
        }
    }
}
