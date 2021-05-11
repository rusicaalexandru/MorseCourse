namespace MorseCourse.Utils
{
    public class Test
    {
        public static int id = 0;
        public static int score = 0;
        public static int wrong = 0;
        public static int skiped = 0;
        public Test(string toTranslate)
        {
            new ExerciseForm(toTranslate).ShowDialog();//ShowDialog instead of show, it waits until the form is closed
        }
    }
}
