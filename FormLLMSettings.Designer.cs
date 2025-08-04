namespace ChatGPTTest
{
    partial class FormLLMSettings
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLLMSettings));
            this.groupBoxLLM = new System.Windows.Forms.GroupBox();
            this.textBoxAIModel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxApiKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxApiUrl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLLMName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBoxLLM.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxLLM
            // 
            this.groupBoxLLM.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxLLM.Controls.Add(this.textBoxAIModel);
            this.groupBoxLLM.Controls.Add(this.label4);
            this.groupBoxLLM.Controls.Add(this.textBoxApiKey);
            this.groupBoxLLM.Controls.Add(this.label3);
            this.groupBoxLLM.Controls.Add(this.textBoxApiUrl);
            this.groupBoxLLM.Controls.Add(this.label2);
            this.groupBoxLLM.Controls.Add(this.textBoxLLMName);
            this.groupBoxLLM.Controls.Add(this.label1);
            this.groupBoxLLM.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.groupBoxLLM.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.groupBoxLLM.Location = new System.Drawing.Point(30, 30);
            this.groupBoxLLM.Name = "groupBoxLLM";
            this.groupBoxLLM.Size = new System.Drawing.Size(1100, 400);
            this.groupBoxLLM.TabIndex = 0;
            this.groupBoxLLM.TabStop = false;
            this.groupBoxLLM.Text = "LLM API Configuration";
            // 
            // textBoxAIModel
            // 
            this.textBoxAIModel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxAIModel.Location = new System.Drawing.Point(200, 180);
            this.textBoxAIModel.Multiline = true;
            this.textBoxAIModel.Name = "textBoxAIModel";
            this.textBoxAIModel.Size = new System.Drawing.Size(850, 35);
            this.textBoxAIModel.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.Location = new System.Drawing.Point(30, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 30);
            this.label4.Text = "AI Model:";
            // 
            // textBoxApiKey
            // 
            this.textBoxApiKey.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxApiKey.Location = new System.Drawing.Point(200, 240);
            this.textBoxApiKey.Multiline = true;
            this.textBoxApiKey.Name = "textBoxApiKey";
            this.textBoxApiKey.PasswordChar = '*';
            this.textBoxApiKey.Size = new System.Drawing.Size(850, 70);
            this.textBoxApiKey.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(30, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 30);
            this.label3.Text = "API Key:";
            // 
            // textBoxApiUrl
            // 
            this.textBoxApiUrl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxApiUrl.Location = new System.Drawing.Point(200, 120);
            this.textBoxApiUrl.Multiline = true;
            this.textBoxApiUrl.Name = "textBoxApiUrl";
            this.textBoxApiUrl.Size = new System.Drawing.Size(850, 35);
            this.textBoxApiUrl.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(30, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 30);
            this.label2.Text = "API URL:";
            // 
            // textBoxLLMName
            // 
            this.textBoxLLMName.Enabled = false;
            this.textBoxLLMName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxLLMName.Location = new System.Drawing.Point(200, 60);
            this.textBoxLLMName.Multiline = true;
            this.textBoxLLMName.Name = "textBoxLLMName";
            this.textBoxLLMName.Size = new System.Drawing.Size(850, 35);
            this.textBoxLLMName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(30, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 30);
            this.label1.Text = "LLM Name:";
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(870, 450);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(120, 45);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.Location = new System.Drawing.Point(1010, 450);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(120, 45);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // FormLLMSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1170, 530);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBoxLLM);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLLMSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LLM API Settings";
            this.groupBoxLLM.ResumeLayout(false);
            this.groupBoxLLM.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLLM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxApiUrl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLLMName;
        private System.Windows.Forms.TextBox textBoxApiKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox textBoxAIModel;
        private System.Windows.Forms.Label label4;
    }
}
