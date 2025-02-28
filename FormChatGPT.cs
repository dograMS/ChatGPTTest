using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatGPTTest
{
    public partial class FormChatGPT : Form
    {
        private const string OpenAI_ApiUrl = "https://api.openai.com/v1/chat/completions";
        private const string OpenAI_ApiKey = "Your-API-Key"; // Replace with your OpenAI API Key

        public FormChatGPT()
        {
            InitializeComponent();
            InitializeWebView();
        }
        private async void InitializeWebView()
        {
            await webViewGPT.EnsureCoreWebView2Async();
            webViewGPT.CoreWebView2.NavigateToString("<h2>ChatGPT Response Will Appear Here...</h2>");
        }
        private void SetStatusMessage(string message)
        {
            toolStripStatusLabel1.Text = message;
        }

        private async void buttonAsk_Click(object sender, EventArgs e)
        {
            try
            {
                SetStatusMessage("Please Wait..");
                string userMessage = textBoxQuery.Text.Trim();
                if (string.IsNullOrEmpty(userMessage)) return;

                string chatResponse = await GetChatGPTResponse(userMessage);
                string htmlResponse = $"<h2>User:</h2><p>{userMessage}</p><h2>ChatGPT:</h2><p>{chatResponse}</p>";

                webViewGPT.CoreWebView2.NavigateToString(htmlResponse);
                SetStatusMessage("Done..");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private async Task<string> GetChatGPTResponse(string message)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {OpenAI_ApiKey}");

                var request = new
                {
                    model = "gpt-4o-mini",
                    messages = new[] { new { role = "user", content = message } }
                };

                var response = await client.PostAsJsonAsync(OpenAI_ApiUrl, request);
                var result = await response.Content.ReadAsStringAsync();

                var jsonDoc = JsonDocument.Parse(result);
                var content = jsonDoc.RootElement
                    .GetProperty("choices")[0]
                    .GetProperty("message")
                    .GetProperty("content")
                    .GetString();

                return content ?? "Error: No response";
            }
        }
    }
   
}
