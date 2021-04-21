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
        bool answer;
        private void buttonAnswer_Click(object sender, EventArgs e)
        {
            if (answer)//evaluate the answer
            {
                Test.score++;
            }
            else
            {
                Test.wrong++;
            }
        }
    }
}
