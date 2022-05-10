using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MorseCourse
{
    public partial class TranslatedForm : Form
    {
        public TranslatedForm(string arg)
        {
            InitializeComponent();
            richTextBox1.Text = arg;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
