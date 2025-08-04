using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatGPTTest
{
    public partial class FormLLMSettings: Form
    {
        ApiSettings m_ApiSettings;
        public FormLLMSettings(ApiSettings Settings, bool bEnableName=false,bool bEnableURL=false,bool bEnableModel=false)
        {
            InitializeComponent();
            m_ApiSettings= Settings;
            textBoxLLMName.Text = Settings.ApiLLMName;
            textBoxApiUrl.Text = Settings.ApiUrl;
            textBoxApiKey.Text = Settings.ApiKey;
            textBoxAIModel.Text = Settings.AiModel;
            textBoxLLMName.Enabled = bEnableName;
            textBoxApiUrl.Enabled = bEnableURL;
            textBoxAIModel.Enabled = bEnableModel;

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            SetApiSettings();
            this.Close();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SetApiSettings()
        {
            m_ApiSettings.ApiLLMName = textBoxLLMName.Text;
            m_ApiSettings.ApiUrl = textBoxApiUrl.Text;
            m_ApiSettings.ApiKey = textBoxApiKey.Text;
            m_ApiSettings.AiModel = textBoxAIModel.Text;
        }
        internal ApiSettings GetApiSettings()
        {
            return m_ApiSettings;

        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                Color.WhiteSmoke, Color.Gainsboro, LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void groupBoxLLM_Enter(object sender, EventArgs e)
        {

        }
    }
}
