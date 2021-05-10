using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telegram.Bot;

namespace MorseCourse.Utils
{
    public partial class ReportForm : Form
    {
        // private static readonly TelegramBotClient Bot = new TelegramBotClient("1800285503:AAEvxDNxiw1vD0a2GtJ_aN-gRgDjG2A9XoY");

        private void ReportForm_Load(object sender, EventArgs e)
        {
            //Bot.StartReceiving();
            //Bot.OnMessage += Bot_OnMessage;
        }
        public ReportForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Bot.StopReceiving();
            TelegramSendMessage("1800285503:AAEvxDNxiw1vD0a2GtJ_aN-gRgDjG2A9XoY", "1028090772", richTextBoxReport.Text);
            this.Close();
        }
        public string TelegramSendMessage(string apilToken, string destID, string text)
        {
            string urlString = $"https://api.telegram.org/bot{apilToken}/sendMessage?chat_id={destID}&text={text}";

            WebClient webclient = new WebClient();

            return webclient.DownloadString(urlString);
        }
        //private static void Bot_OnMessage(object sender, Telegram.Bot.Args.MessageEventArgs e)
        //{
        //if (e.Message.Type == Telegram.Bot.Types.Enums.MessageType.Text)
        //{
        //Bot.SendTextMessageAsync("1028090772", "Help :{");
        //Console.WriteLine(e.Message.Chat.Id);
        //}
        //}
    }
}
