using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnimatorNS;
using MetroFramework.Forms;

namespace SmartBrowser
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser1.DocumentCompleted += WebBrowser1_DocumentCompleted;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("osk.exe");   
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            animator2.HideSync(panel2);
            ShowPage("https://www.uol.com.br");
            animator2.ShowSync(panel2);
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            animator2.HideSync(panel3);
            ShowPage("http://g1.globo.com/");
            animator2.ShowSync(panel3);
        }

        private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            animator1.MaxAnimationTime = 3000;
            animator1.TimeStep = 0.02F;
            animator1.ShowSync(panel1);
        }

        private void ShowPage(string url)
        {
            animator1.Hide(panel1);
            webBrowser1.Navigate(url);
            animator1.TimeStep = 0.02F;
        }
    }
}
