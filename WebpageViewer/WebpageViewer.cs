using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebpageViewer
{
    public partial class WebpageViewer : Form
    {
        public WebpageViewer()
        {
            InitializeComponent();
        }

        public bool IsValid { get; private set; }

       

        /// <summary>
        /// It is very important to note that exceptions can only be caught in this way because the FetchWebPage method returns a result; the text of the web page.
        /// It is possible to create an async method of type void that does not return a value.
        /// These are, however, to be avoided as there is no way of catching any exceptions that they generate.
        /// The only async void methods that a program should contain are the event handlers themselves, such as the Button_Click method in Listing 1-33.
        /// Even a method that just performs an action should return a status value so that exceptions can be caught and dealt with.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void LoadButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(UrlTextBox.Text.Trim()))
            {
                #region Listing 1-33
                try
                {
                    ResultTextBox.Text = await FetchWebPage(UrlTextBox.Text);
                    CommentLabel.ForeColor = Color.Green;
                    CommentLabel.Text = "Success";
                }
                #endregion

                catch (Exception ex)
                {
                    CommentLabel.ForeColor = Color.Red;
                    CommentLabel.Text = ex.Message;
                    ResultTextBox.Text = string.Empty;
                }
            }
            else
            {
                IsValid = false;
                UrlTextBox.BackColor = Color.LightSalmon;
                UrlTextBox.Text = "Please Enter a Fucking URL.";
            }
        }

        private void UrlTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (!IsValid)
            {
                UrlTextBox.BackColor = Color.White;
                UrlTextBox.Text = string.Empty;
                IsValid = true;
            }
            
        }

        private async Task<string> FetchWebPage(string url)
        {
            HttpClient httpClient = new HttpClient();
            return await httpClient.GetStringAsync(url);
        }

        private async Task<IEnumerable<string>> FetchWebPages(string[] urls)
        {
            var tasks = new List<Task<string>>();
            foreach (string url in urls)
            {
                tasks.Add(FetchWebPage(url));
            }

            return await Task.WhenAll(tasks);
        }
    }
}
