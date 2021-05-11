using System;
using System.Net;
using System.Windows.Forms;

namespace MorseCourse.Utils
{
    public partial class ReportForm : Form
    {
        private void ReportForm_Load(object sender, EventArgs e)
        {

        }
        public ReportForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBoxReport.Text != string.Empty)
            {
                TelegramSendMessage("1800285503:AAEvxDNxiw1vD0a2GtJ_aN-gRgDjG2A9XoY", "1028090772", richTextBoxReport.Text);

            }
            this.Close();
        }
        public string TelegramSendMessage(string apilToken, string destID, string text)
        {
            string urlString = $"https://api.telegram.org/bot{apilToken}/sendMessage?chat_id={destID}&text={text}";

            WebClient webclient = new WebClient();

            return webclient.DownloadString(urlString);
        }

    }
}
