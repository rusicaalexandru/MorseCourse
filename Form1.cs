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
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using Intercom.Core;
using RestSharp;

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
        private void buttonTest_Click(object sender, EventArgs e) //button for tests
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

        //------------------------------------------------------------------------------------------------Translate
        //------------------------------------------------------------------------------------------------Info

        //------------------------------------------------------------------------------------------------Info
        //------------------------------------------------------------------------------------------------Tests
        private void buttonStartTest_Click(object sender, EventArgs e) // start button on test tab
        {
            var ownResponse = ownClient.GetStringAsync(url).Result;
            Rootobject obj = JsonConvert.DeserializeObject<Rootobject>(ownResponse);
            //labelForTeste.Text = obj.data[3].sentence;

            //To Do ============================
            //simpler version of test, only one test
            //https://randomwordgenerator.com/sentence.php to  parse it and get random sentencies - (rand)
            //register resultats in a database
            //To Do ============================
            //clear preview test
            Test.score = 0;
            Test.wrong = 0;
            Test.skiped = 0;
            //------------------

            if (numericUpDownExercises.Value <= 0 || numericUpDownExercises.Value > 10) //set min and max amount of exercises (10 mox, to not overload PC)
            {
                numericUpDownExercises.Value = 1;
            }
            for (int i = 0; i < numericUpDownExercises.Value; i++) //create test form
            {
                //new Test("translate this");// input strig to translate (it applies to each test)
                Random rnd = new Random();
                new Test(obj.data[rnd.Next(obj.data.Length)].sentence);// input strig to translate (it applies to each test)
            }
        }
        //------------------------------------------------------------------------------------------------Tests
        //------------------------------------------------------------------------------------------------HTMLPACK

        //------------------------------------------------------------------------------------------------HTMLPACK

    }


}
