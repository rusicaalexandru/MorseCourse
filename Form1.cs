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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonTranslateToMorse_Click(object sender, EventArgs e)
        {
            textBoxOutputMorse.Text = Translate.translateToMorse(textBoxInputText.Text.ToLower());
        }

        private void buttonTranslateToText_Click(object sender, EventArgs e)
        {
            textBoxOutputText.Text = Translate.translateToText(textBoxInputMorse.Text.ToLower());
        }

        private void buttonClearTextTr_Click(object sender, EventArgs e)
        {
            textBoxOutputMorse.Text = string.Empty;
        }

        private void buttonClearMorseTr_Click(object sender, EventArgs e)
        {
            textBoxOutputText.Text = string.Empty;
        }
    }
}
