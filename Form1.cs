using MorseCourse.Utils;
using System;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading;
using System.Threading.Tasks;

namespace MorseCourse
{
    public partial class Form1 : Form
    {
        private const string url = "https://randomwordgenerator.com/json/sentences.json";//get exercises
        HttpClient ownClient = new HttpClient();
        private bool stopPlaying = false;
        public Form1()
        {
            InitializeComponent();
        }
        private async void Form1_Load(object sender, EventArgs e) // on load
        {
            //await secret();
        }
        private void buttonTest_Click(object sender, EventArgs e) //----------------button for tests
        {

        }
        //------------------------------------------------------------------------------------------------Translate

        private void buttonTranslateToMorse_Click(object sender, EventArgs e) //translate to morse
        {
            string text = Translate.translateToMorse(textBoxInputText.Text);
            if (text.Length > 10)
            {
                new TranslatedForm(Translate.translateToMorse(textBoxInputText.Text)).Show();
                textBoxOutputMorse.Text = Translate.translateToMorse(textBoxInputText.Text);

            }
            else
            {
                textBoxOutputMorse.Text = Translate.translateToMorse(textBoxInputText.Text);//i used coment to chech if it works properly /*.ToLower()*/
            }
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
        private void buttonReport_Click(object sender, EventArgs e)
        {
            new ReportForm().Show();// open send report form
        }
        //---------------------------------------------------------------------

        //------------------------------------------------------------------------------------------------Translate
        //------------------------------------------------------------------------------------------------Sounds
        private async void buttonPlayMorseSound1_Click(object sender, EventArgs e)
        {
            await toSound(textBoxOutputMorse.Text);
            stopPlaying = true; //make the prew sound to stop before start another

        }
        private void buttonStopSound1_Click(object sender, EventArgs e)
        {
            stopPlaying = true; //make the sound to stop
        }
        //------------------------------------------------------------------------------------------------Sounds
        //------------------------------------------------------------------------------------------------Tests
        private void buttonStartTest_Click(object sender, EventArgs e) // start button on test tab
        {
            string ownResponse = ownClient.GetStringAsync(url).Result;
            DB_JSON_TESTS obj = JsonConvert.DeserializeObject<DB_JSON_TESTS>(ownResponse);

            int amountExercises = Convert.ToInt32(numericUpDownExercises.Value);

            //---------clear last test data
            Test.score = 0;
            Test.wrong = 0;
            Test.skiped = 0;
            //------------------
            if (amountExercises <= 0 || amountExercises > 10) //set min and max amount of exercises (10 mox, to not overload PC)
            {
                amountExercises = 1;
            }
            for (int i = 0; i < amountExercises; i++) //create test form
            {
                //new Test("Secvența de cod pentru testarea cunoștințelor este prezentată în continuare");// input strig to translate (it applies to each test)
                new Test(obj.data[new Random().Next(obj.data.Length)].sentence.Trim(',', '.', '!', '?', '`', ';', ':'));// input strig to translate (it applies to each test)
            }
            Test.id++;
            dataGridView1.Rows.Add(Test.id, amountExercises, Test.score, Test.wrong, Test.skiped, Test.score + (Test.wrong * 0 + Test.skiped * 0) / amountExercises + " %");
        }

        //------------------------------------------------------------------------------------------------Tests
        private Task toSound(string text)
        {
            int freq = 500;
            int duration = 150;
            return Task.Factory.StartNew(() =>
            {

                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == '.')
                    {
                        Console.Beep(freq, duration);//sound for dots
                    }
                    else if (text[i] == '-')
                    {
                        Console.Beep(freq, duration * 3);//sound for lines

                    }
                    else if (text[i] == ' ')
                    {
                        Thread.Sleep(500);//no sound for blank space
                    }
                }
            });
        }
        private Task secret()
        {
            return Task.Factory.StartNew(() =>
            {
                Console.Beep(784, 150);
                Thread.Sleep(300);
                Console.Beep(784, 150);
                Thread.Sleep(300);
                Console.Beep(932, 150);
                Thread.Sleep(150);
                Console.Beep(1047, 150);
                Thread.Sleep(150);
                Console.Beep(784, 150);
                Thread.Sleep(300);
                Console.Beep(784, 150);
                Thread.Sleep(300);
                Console.Beep(699, 150);
                Thread.Sleep(150);
                Console.Beep(740, 150);
                Thread.Sleep(150);
                Console.Beep(784, 150);
                Thread.Sleep(300);
                Console.Beep(784, 150);
                Thread.Sleep(300);
                Console.Beep(932, 150);
                Thread.Sleep(150);
                Console.Beep(1047, 150);
                Thread.Sleep(150);
                Console.Beep(784, 150);
                Thread.Sleep(300);
                Console.Beep(784, 150);
                Thread.Sleep(300);
                Console.Beep(699, 150);
                Thread.Sleep(150);
                Console.Beep(740, 150);
                Thread.Sleep(150);
                Console.Beep(932, 150);
                Console.Beep(784, 150);
                Console.Beep(587, 1200);
                Thread.Sleep(75);
                Console.Beep(932, 150);
                Console.Beep(784, 150);
                Console.Beep(554, 1200);
                Thread.Sleep(75);
                Console.Beep(932, 150);
                Console.Beep(784, 150);
                Console.Beep(523, 1200);
                Thread.Sleep(150);
                Console.Beep(466, 150);
                Console.Beep(523, 150);
            });
        }
    }
}
