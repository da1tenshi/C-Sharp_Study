using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            textBox1.Text = AksonBank();
        }

        private string AksonBank()
        {
            System.Net.WebClient wc = new System.Net.WebClient() ;
            String Response = wc.DownloadString("http://aksonbank.ru");
            String Rate = System.Text.RegularExpressions.Regex.Match(Response, @"id=""conv0""value=""([0-9]+\.[0-9]+)""").Groups[1].Value;
            return "AsconBank" + Rate +"p. \r\n";
        }
    }
}
