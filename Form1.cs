using MorseCourse.Utils;
using System;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;


namespace MorseCourse
{
    public partial class Form1 : Form
    {
        private const string url = "https://randomwordgenerator.com/json/sentences.json";
        HttpClient ownClient = new HttpClient();

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) // on load
        {

        }
        private void buttonTest_Click(object sender, EventArgs e) //----------------button for tests
        {

        }
        //------------------------------------------------------------------------------------------------Translate

        private void buttonTranslateToMorse_Click(object sender, EventArgs e) //translate to morse
        {
            textBoxOutputMorse.Text = Translate.translateToMorse(textBoxInputText.Text);//i used coment to chech if it works properly /*.ToLower()*/
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
            new ReportForm().Show();
        }
        //---------------------------------------------------------------------
        private void buttonPlayMorseSound1_Click(object sender, EventArgs e)
        {

        }

        //------------------------------------------------------------------------------------------------Translate
        //------------------------------------------------------------------------------------------------Tests
        private void buttonStartTest_Click(object sender, EventArgs e) // start button on test tab
        {
            string ownResponse = ownClient.GetStringAsync(url).Result;
            DB_JSON_TESTS obj = JsonConvert.DeserializeObject<DB_JSON_TESTS>(ownResponse);

            int amountExercises = Convert.ToInt32(numericUpDownExercises.Value);

            //---------clear preview test data
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
                //new Test("Hello");// input strig to translate (it applies to each test)
                new Test(obj.data[new Random().Next(obj.data.Length)].sentence.Trim(',', '.', '!', '?', '`'));// input strig to translate (it applies to each test)
            }
            Test.id++;
            dataGridView1.Rows.Add(Test.id, amountExercises, Test.score, Test.wrong, Test.skiped, Test.score + (Test.wrong * 0 + Test.skiped * 0) / amountExercises + " %");
        }

        //------------------------------------------------------------------------------------------------Tests
    }
}
