using Microsoft.Win32;
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
        private const string RegistryPath = "Software\\KTS InfoTech\\ChatGptTest";
        private const string OpenAI_ApiUrl = "https://api.openai.com/v1/chat/completions";
        private const string OpenAI_ApiModel = "gpt-4o-mini";
        public ApiSettings m_OpenApiSettings ;

        public FormChatGPT()
        {
            InitializeComponent();
            InitializeWebView();
            m_OpenApiSettings = LoadApiSettingsFromRegistry();  

        }
        
        private async void InitializeWebView()
        {
            await webViewGPT.EnsureCoreWebView2Async();
            
        }
        private void SetStatusMessage(string message)
        {
            toolStripStatusLabel1.Text = message;
        }

        public ApiSettings LoadApiSettingsFromRegistry()
        {
            ApiSettings settings = new ApiSettings("ChatGPT | OpenAPI", OpenAI_ApiUrl, OpenAI_ApiModel, "");
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(RegistryPath))
                {
                    if (key != null)
                    {
                        settings.ApiLLMName = key.GetValue("ApiLLMName") as string;
                        settings.ApiKey = key.GetValue("ApiKey") as string;
                        settings.ApiUrl = key.GetValue("ApiUrl") as string;
                        settings.AiModel = key.GetValue("AiModel") as string;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading API settings: {ex.Message}");
            }
            return settings;
        }
        public void SaveApiSettingsToRegistry(ApiSettings settings)
        {
            try
            {
                using (RegistryKey key = Registry.CurrentUser.CreateSubKey(RegistryPath))
                {
                    if (key != null)
                    {
                        key.SetValue("ApiLLMName", settings.ApiLLMName ?? "");
                        key.SetValue("ApiKey", settings.ApiKey ?? "");
                        key.SetValue("ApiUrl", settings.ApiUrl ?? "");
                        key.SetValue("AiModel", settings.AiModel ?? "");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving API settings: {ex.Message}");
            }
        }

        private async Task<string> GetChatGPTResponse(string message)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {m_OpenApiSettings.ApiKey}");

                var request = new
                {
                    model = m_OpenApiSettings.AiModel,
                    messages = new[] { new { role = "user", content = message } }
                };

                var response = await client.PostAsJsonAsync(m_OpenApiSettings.ApiUrl, request);
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

        private void buttonProperties_Click(object sender, EventArgs e)
        {
            FormLLMSettings Settings = new FormLLMSettings(m_OpenApiSettings);
            if (Settings.ShowDialog() == DialogResult.OK)
            {
                m_OpenApiSettings = Settings.GetApiSettings();
                SaveApiSettingsToRegistry(m_OpenApiSettings);
            }
        }

        private void newChatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webViewGPT.ExecuteScriptAsync("document.body.innerHTML = '';");
        }

        private async void buttonAsk_Click_1(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(m_OpenApiSettings.ApiKey))
                {
                    MessageBox.Show("Please set the API Key", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                SetStatusMessage("Please Wait..");
                string userMessage = textBoxQuery.Text.Trim();
                if (string.IsNullOrEmpty(userMessage)) return;

                string chatResponse = await GetChatGPTResponse(userMessage);
                string htmlResponse = $"<h3>User:</h3><p>{userMessage}</p><h3>ChatGPT:</h3><p>{chatResponse.Replace("\n", "<br>")}</p>";

                await webViewGPT.ExecuteScriptAsync($@"document.body.innerHTML += `{htmlResponse}`");

                SetStatusMessage("Done..");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
       
}
