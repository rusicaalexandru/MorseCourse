using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCourse.Utils
{
    public class Test
    {
        public static int score = 0;
        public static int wrong = 0;
        public static int skiped = 0;
        public Test(string toTranslate)
        {
            /*ExerciseForm ex = */
            new ExerciseForm(toTranslate).ShowDialog();
            //ex.ShowDialog(); //instead of show, it waits until the form is closed
        }
    }
}
