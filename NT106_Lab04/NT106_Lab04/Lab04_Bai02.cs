using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using HtmlAgilityPack;
using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace NT106_Lab04
{
    public partial class Lab04_Bai02 : Form
    {
        public Lab04_Bai02()
        {
            InitializeComponent();
        }

        private string getSource(string URL)
        {
            try
            {
                HtmlWeb web = new HtmlWeb();
                HtmlAgilityPack.HtmlDocument content = new HtmlAgilityPack.HtmlDocument();
                content = web.Load(URL);
                string s = content.Text;
                return s;
            }
            catch
            {
                return "URL không tồn tại!";
            }
        }

        private void Post(string url)
        {
            try
            {
                // Create a request using a URL that can receive a post.
                WebRequest request = WebRequest.Create(url);
                // Set the Method property of the request to POST.
                request.Method = "POST";

                // Create POST data and convert it to a byte array.
                string postData = "This is a test that posts this string to a Web server.";
                byte[] byteArray = Encoding.UTF8.GetBytes(postData);

                // Set the ContentType property of the WebRequest.
                request.ContentType = "application/x-www-form-urlencoded";
                // Set the ContentLength property of the WebRequest.
                request.ContentLength = byteArray.Length;

                // Get the request stream.
                Stream dataStream = request.GetRequestStream();
                // Write the data to the request stream.
                dataStream.Write(byteArray, 0, byteArray.Length);
                // Close the Stream object.
                dataStream.Close();

                // Get the response.
                WebResponse response = request.GetResponse();
                // Display the status.


                // Get the stream containing content returned by the server.
                // The using block ensures the stream is automatically closed.
                using (dataStream = response.GetResponseStream())
                {
                    // Open the stream using a StreamReader for easy access.
                    StreamReader reader = new StreamReader(dataStream);
                    // Read the content.
                    string responseFromServer = reader.ReadToEnd();
                    // Display the content.
                    rtxResponse.Text = responseFromServer;
                }

                // Close the response.
                response.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            if (getSource(txtURL.Text) == "URL không tồn tại!")
            {
                MessageBox.Show("URL không tồn tại!");
            }
            else
                Post(txtURL.Text);
        }


        private void txtContent_MouseClick(object sender, MouseEventArgs e)
        {
            txtContent.Text = null;
        }

        private void txtURL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnPost.PerformClick();
            }
        }
    }
}
