using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatGPTTest
{
    public partial class FormChatGPT : Form
    {
        private bool m_bFirstTime = true;
        private const string RegistryPath = "Software\\KTS InfoTech\\ChatGptTest";
        private const string OpenAI_ApiUrl = "https://api.openai.com/v1/chat/completions";
        private const string OpenAI_ApiModel = "gpt-4o-mini";
        public ApiSettings m_OpenApiSettings ;
        private List<object> conversationHistory = new List<object>();

        public FormChatGPT()
        {
            InitializeComponent();
            InitializeWebView();
            m_OpenApiSettings = LoadApiSettingsFromRegistry();  

        }
        
        private async void InitializeWebView()
        {
            try
            {
                await webViewGPT.EnsureCoreWebView2Async();
                LoadOpeningImage();
            }catch(Exception ex){
                MessageBox.Show("Exception: " + ex.Message + 
                    "\n" + 
                    "Note: Update build configuration to x86\n"
                    );
                
            }

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
                var apiKey = m_OpenApiSettings.ApiKey.Trim();
                 client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");


                // Append the new message to history
                conversationHistory.Add(new { role = "user", content = message });

                var request = new
                {
                    model = m_OpenApiSettings.AiModel,
                    messages = conversationHistory
                };

                var response = await client.PostAsJsonAsync(m_OpenApiSettings.ApiUrl, request);
                var result = await response.Content.ReadAsStringAsync();

                var jsonDoc = JsonDocument.Parse(result);

                
                var content = jsonDoc.RootElement
                    .GetProperty("choices")[0]
                    .GetProperty("message")
                    .GetProperty("content")
                    .GetString();

                if (!string.IsNullOrEmpty(content))
                {
                    // Append the AI response to history
                    conversationHistory.Add(new { role = "assistant", content = content });
                }

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
            NewChat();
        }
        private void NewChat()
        {
            webViewGPT.ExecuteScriptAsync("document.body.innerHTML = '';");
            webViewGPT.NavigateToString("<html><body></body></html>");
            conversationHistory.Clear();
            
        }

        
        private async void buttonAsk_Click_1(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(m_OpenApiSettings.ApiKey))
                {
                    MessageBox.Show("Please set the API Key", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (m_bFirstTime)
                {
                    NewChat();
                    m_bFirstTime = false;
                }
                SetStatusMessage("Please Wait..");

                string userMessage = textBoxQuery.Text.Trim();
                textBoxQuery.Text = "";
                if (string.IsNullOrEmpty(userMessage)) return;

                string chatResponse = await GetChatGPTResponse(userMessage);
                chatResponse = Regex.Replace(chatResponse, @"\*\*(.*?)\*\*", "<b>$1</b>");
                chatResponse = Regex.Replace(chatResponse, @"### (.*)", "<h4>$1</h4>");

                // Wrap message in a div with a unique class
                string htmlResponse = $@"
                    <style>
                    @keyframes fadeSlideIn {{
                        0% {{
                            opacity: 0;
                            transform: translateY(30px);
                        }}
                        100% {{
                            opacity: 1;
                            transform: translateY(0);
                        }}
                    }}
                    </style>

                    <div style='
                        display: flex;
                        flex-direction: column;
                        padding: 10px 20px;
                        position: relative;
                        z-index: 1;
                        width: 60%;
                        box-sizing: border-box;
                        justify-content: center;
                        margin-left: auto;
                        margin-right: auto;
                    '>

                        <div style='
                            max-width: 80%;
                            padding: 8px 14px;
                            margin: 8px 0;
                            border-radius: 12px;
                            font-size: 15px;
                            line-height: 1.4;
                            box-shadow: 0 2px 6px rgba(0,0,0,0.1);
                            word-wrap: break-word;
                            background-color: rgba(255,255,255, 0.9);
                            align-self: flex-end;
                            color: #000;
                            border-top-right-radius: 0;
                            animation: fadeSlideIn 0.4s ease forwards;
                            opacity: 0;
                        '>
                            <p style='margin: 0;'>{userMessage}</p>
                        </div>

                        <div style='
                            max-width: 50%;
                            padding: 8px 14px;
                            margin: 8px 0;
                            border-radius: 12px;
                            font-size: 15px;
                            line-height: 1.4;
                            box-shadow: 0 2px 6px rgba(0,0,0,0.1);
                            word-wrap: break-word;
                            background-color: rgba(0, 200, 255, 0.1);
                            border-left: 4px solid #00c8ff;
                            align-self: flex-start;
                            color: #333;
                            border-top-left-radius: 0;
                            animation: fadeSlideIn 0.4s ease forwards;
                            opacity: 0;
                        '>
                            <p style='margin: 0;'>{chatResponse.Replace("\n", "<br>")}</p>
                        </div>

                    </div>";
                // Append the new content
                await webViewGPT.ExecuteScriptAsync($@"document.body.innerHTML += `{htmlResponse}`");

                // Scroll to the last chat message
                await webViewGPT.ExecuteScriptAsync(@"
            setTimeout(() => {
                let messages = document.getElementsByClassName('chat-message');
                if (messages.length > 0) {
                    messages[messages.length - 1].scrollIntoView({ behavior: 'smooth', block: 'start' });
                }
            }, 100);"); // Delay added to ensure DOM updates

                SetStatusMessage("Done..");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ChatResponse Error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void buttonNew_Click(object sender, EventArgs e)
        {
            NewChat();
            LoadOpeningImage();
            textBoxQuery.Text = "";
        }

        private void LoadOpeningImage()
        {
            string base64Image = ConvertBitmapToBase64(ConvertResourceImageToBitmap(Properties.Resources.AI_Chat_Browser));
            string htmlContent = $@"
                <html>
                <head>
                    <style>
                        @keyframes gradientMove {{
                            0% {{ background-position: 0% 50%; }}
                            50% {{ background-position: 100% 50%; }}
                            100% {{ background-position: 0% 50%; }}
                        }}

                        html, body {{
                            margin: 0;
                            height: 100%;
                            overflow: hidden;
                        }}

                        #background-layer {{
                            position: fixed;
                            top: 0;
                            left: 0;
                            width: 100%;
                            height: 100%;
                            z-index: 0;
                            background: linear-gradient(135deg, #d9afd9, #97d9e1);
                            background-size: 400% 400%;
                            animation: gradientMove 20s ease infinite;
                        }}

                        #particles-js {{
                            position: fixed;
                            top: 0;
                            left: 0;
                            width: 100%;
                            height: 100%;
                            z-index: 1;
                        }}

                        #content {{
                            position: relative;
                            z-index: 2;
                            display: flex;
                            flex-direction: column;
                            align-items: center;
                            justify-content: center;
                            height: 100%;
                        }}
                    </style>
                </head>
                <body>
                    <div id='background-layer'></div>
                    <div id='particles-js'></div>

                    <div id='content'>
                       <img src='data:image/jpeg;base64,{base64Image}' alt='Opening Image'
                             style='
                                 max-width: 80%;
                                 max-height: 80%;
                                 border-radius: 20px;
                                 box-shadow: 0 8px 20px rgba(0,0,0,0.2);
                                 z-index: 2;
                             ' />
                         <p style='
                            margin-top: 20px;
                            font-size: 18px;
                            color: #ffffff;
                            background-color: rgba(0,0,0,0.4);
                            padding: 8px 16px;
                            border-radius: 12px;
                            backdrop-filter: blur(6px);
                            text-align: center;
                            z-index: 2;
                        '>
                            Welcome to Your Personal AI Assistant
                        </p>
                    </div>

                    <script src='https://cdn.jsdelivr.net/npm/particles.js'></script>
                    <script>
                        particlesJS('particles-js', {{
                            particles: {{
                                number: {{ value: 30 }},
                                size: {{ value: 6 }},
                                color: {{ value: '#ffffff' }},
                                line_linked: {{
                                    enable: true,
                                    distance: 150,
                                    color: '#ffffff',
                                    opacity: 0.4,
                                    width: 1
                                }},
                                move: {{
                                    speed: 2
                                }}
                            }},
                            interactivity: {{
                                events: {{
                                    onhover: {{ enable: true, mode: 'repulse' }},
                                    onclick: {{ enable: true, mode: 'push' }}
                                }}
                            }}
                        }});
                    </script>
                </body>
                </html>";




            webViewGPT.NavigateToString(htmlContent);
            m_bFirstTime = true;
        }



        private Bitmap ConvertResourceImageToBitmap(byte[] imageBytes)
        {
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                return new Bitmap(ms);
            }
        }

        private string ConvertBitmapToBase64(Bitmap image)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    using (Bitmap clone = new Bitmap(image))  // Clone the bitmap to avoid GDI+ issues
                    {
                        clone.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                    return Convert.ToBase64String(ms.ToArray());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error converting image: " + ex.Message);
                return string.Empty;
            }
        }

        private void webViewGPT_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBoxQuery_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
       

