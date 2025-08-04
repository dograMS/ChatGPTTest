using System.Windows.Forms;

namespace ChatGPTTest
{
    partial class FormChatGPT
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChatGPT));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.webViewGPT = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.buttonNew = new System.Windows.Forms.Button();
            this.textBoxQuery = new System.Windows.Forms.TextBox();
            this.buttonAsk = new System.Windows.Forms.Button();
            this.buttonProperties = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newChatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webViewGPT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();

            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.splitContainer1.Panel1.Controls.Add(this.webViewGPT);
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(1458, 692);
            this.splitContainer1.SplitterDistance = 615;
            this.splitContainer1.TabIndex = 1;

            this.webViewGPT.AllowExternalDrop = true;
            this.webViewGPT.CreationProperties = null;
            this.webViewGPT.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webViewGPT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webViewGPT.Location = new System.Drawing.Point(0, 0);
            this.webViewGPT.Name = "webViewGPT";
            this.webViewGPT.Size = new System.Drawing.Size(1458, 615);
            this.webViewGPT.TabIndex = 1;
            this.webViewGPT.ZoomFactor = 1D;
            this.webViewGPT.Click += new System.EventHandler(this.webViewGPT_Click);

            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            this.splitContainer2.Panel2.Controls.Add(this.buttonProperties);
            this.splitContainer2.Size = new System.Drawing.Size(1458, 32);
            this.splitContainer2.SplitterDistance = 1380;
            this.splitContainer2.TabIndex = 0;

            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer4);
            this.splitContainer3.Panel2.Controls.Add(this.buttonAsk);
            this.splitContainer3.Size = new System.Drawing.Size(1380, 32);
            this.splitContainer3.SplitterDistance = 1235;
            this.splitContainer3.TabIndex = 0;

            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Panel1.Controls.Add(this.buttonNew);
            this.splitContainer4.Panel2.Controls.Add(this.textBoxQuery);
            this.splitContainer4.Size = new System.Drawing.Size(1235, 32);
            this.splitContainer4.SplitterDistance = 55;
            this.splitContainer4.TabIndex = 0;

            this.buttonNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNew.FlatAppearance.BorderSize = 0;
            this.buttonNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(255, 77, 77);  // Hover red
            this.buttonNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(204, 0, 0);   // Pressed red
            this.buttonNew.BackColor = System.Drawing.Color.FromArgb(232, 17, 35); // Primary red
            this.buttonNew.ForeColor = System.Drawing.Color.White;
            this.buttonNew.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNew.Location = new System.Drawing.Point(0, 0);
            this.buttonNew.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(55, 32);
            this.buttonNew.TabIndex = 2;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = false;  // Important to show BackColor
            this.buttonNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);


            this.textBoxQuery.BackColor = System.Drawing.Color.FromArgb(245, 245, 250); // Subtle off-white
            this.textBoxQuery.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30); // Dark gray text
            this.textBoxQuery.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxQuery.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.textBoxQuery.Location = new System.Drawing.Point(0, 0);
            this.textBoxQuery.Multiline = true;
            this.textBoxQuery.Name = "textBoxQuery";
            this.textBoxQuery.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxQuery.Size = new System.Drawing.Size(1174, 32);
            this.textBoxQuery.TabIndex = 2;
            this.textBoxQuery.TextChanged += new System.EventHandler(this.textBoxQuery_TextChanged);
            this.textBoxQuery.Padding = new Padding(8, 4, 8, 4);  // Optional: if you wrap it in a panel
            this.textBoxQuery.AcceptsReturn = true;
            this.textBoxQuery.AcceptsTab = true;


            this.buttonAsk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAsk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAsk.FlatAppearance.BorderSize = 0;
            this.buttonAsk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(0, 120, 215); // Hover color
            this.buttonAsk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(0, 84, 153); // Click color
            this.buttonAsk.BackColor = System.Drawing.Color.FromArgb(0, 102, 204); // Primary blue
            this.buttonAsk.ForeColor = System.Drawing.Color.White;
            this.buttonAsk.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAsk.Location = new System.Drawing.Point(0, 0);
            this.buttonAsk.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAsk.Name = "buttonAsk";
            this.buttonAsk.Size = new System.Drawing.Size(139, 32);
            this.buttonAsk.TabIndex = 1;
            this.buttonAsk.Text = "Ask";
            this.buttonAsk.UseVisualStyleBackColor = false;  // Required for BackColor to show
            this.buttonAsk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAsk.Click += new System.EventHandler(this.buttonAsk_Click_1);


            this.buttonProperties.AutoSize = true;
            this.buttonProperties.ContextMenuStrip = this.contextMenuStrip1;
            this.buttonProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonProperties.Location = new System.Drawing.Point(0, 0);
            this.buttonProperties.Name = "buttonProperties";
            this.buttonProperties.Size = new System.Drawing.Size(72, 32);
            this.buttonProperties.TabIndex = 2;
            this.buttonProperties.Text = "...";
            this.buttonProperties.UseVisualStyleBackColor = true;
            this.buttonProperties.Click += new System.EventHandler(this.buttonProperties_Click);

            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.newChatToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(161, 36);

            this.newChatToolStripMenuItem.Name = "newChatToolStripMenuItem";
            this.newChatToolStripMenuItem.Size = new System.Drawing.Size(160, 32);
            this.newChatToolStripMenuItem.Text = "New Chat";
            this.newChatToolStripMenuItem.Click += new System.EventHandler(this.newChatToolStripMenuItem_Click);

            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 32);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1458, 39);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "Status Message..";

            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(210, 32);
            this.toolStripStatusLabel1.Text = "Status Message...";

            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1458, 692);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FormChatGPT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChatGPT | OpenAI API | Chat Browser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webViewGPT)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private Microsoft.Web.WebView2.WinForms.WebView2 webViewGPT;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Button buttonAsk;
        private System.Windows.Forms.Button buttonProperties;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newChatToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.TextBox textBoxQuery;
    }
}
