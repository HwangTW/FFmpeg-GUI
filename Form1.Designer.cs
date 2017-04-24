namespace ffmpeg_gui
{
    partial class Title
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Title));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.File = new System.Windows.Forms.ToolStripDropDownButton();
            this.開啟檔案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開啟目錄ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清除所有檔案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.離開ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.about = new System.Windows.Forms.ToolStripDropDownButton();
            this.原始碼ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.協助翻譯ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.授權條款資訊ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.關於FFmpegGUIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.location = new System.Windows.Forms.ToolStripDropDownButton();
            this.繁體中文ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.output2 = new System.Windows.Forms.Label();
            this.output1 = new System.Windows.Forms.Label();
            this.output3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.about,
            this.location});
            this.statusStrip1.Name = "statusStrip1";
            // 
            // File
            // 
            resources.ApplyResources(this.File, "File");
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.開啟檔案ToolStripMenuItem,
            this.開啟目錄ToolStripMenuItem,
            this.清除所有檔案ToolStripMenuItem,
            this.toolStripSeparator1,
            this.離開ToolStripMenuItem});
            this.File.Name = "File";
            // 
            // 開啟檔案ToolStripMenuItem
            // 
            resources.ApplyResources(this.開啟檔案ToolStripMenuItem, "開啟檔案ToolStripMenuItem");
            this.開啟檔案ToolStripMenuItem.Name = "開啟檔案ToolStripMenuItem";
            // 
            // 開啟目錄ToolStripMenuItem
            // 
            resources.ApplyResources(this.開啟目錄ToolStripMenuItem, "開啟目錄ToolStripMenuItem");
            this.開啟目錄ToolStripMenuItem.Name = "開啟目錄ToolStripMenuItem";
            // 
            // 清除所有檔案ToolStripMenuItem
            // 
            resources.ApplyResources(this.清除所有檔案ToolStripMenuItem, "清除所有檔案ToolStripMenuItem");
            this.清除所有檔案ToolStripMenuItem.Name = "清除所有檔案ToolStripMenuItem";
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // 離開ToolStripMenuItem
            // 
            resources.ApplyResources(this.離開ToolStripMenuItem, "離開ToolStripMenuItem");
            this.離開ToolStripMenuItem.Name = "離開ToolStripMenuItem";
            this.離開ToolStripMenuItem.Click += new System.EventHandler(this.離開ToolStripMenuItem_Click);
            // 
            // about
            // 
            resources.ApplyResources(this.about, "about");
            this.about.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.原始碼ToolStripMenuItem,
            this.協助翻譯ToolStripMenuItem,
            this.toolStripSeparator2,
            this.授權條款資訊ToolStripMenuItem,
            this.關於FFmpegGUIToolStripMenuItem});
            this.about.Name = "about";
            // 
            // 原始碼ToolStripMenuItem
            // 
            resources.ApplyResources(this.原始碼ToolStripMenuItem, "原始碼ToolStripMenuItem");
            this.原始碼ToolStripMenuItem.Name = "原始碼ToolStripMenuItem";
            // 
            // 協助翻譯ToolStripMenuItem
            // 
            resources.ApplyResources(this.協助翻譯ToolStripMenuItem, "協助翻譯ToolStripMenuItem");
            this.協助翻譯ToolStripMenuItem.Name = "協助翻譯ToolStripMenuItem";
            // 
            // toolStripSeparator2
            // 
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            // 
            // 授權條款資訊ToolStripMenuItem
            // 
            resources.ApplyResources(this.授權條款資訊ToolStripMenuItem, "授權條款資訊ToolStripMenuItem");
            this.授權條款資訊ToolStripMenuItem.Name = "授權條款資訊ToolStripMenuItem";
            // 
            // 關於FFmpegGUIToolStripMenuItem
            // 
            resources.ApplyResources(this.關於FFmpegGUIToolStripMenuItem, "關於FFmpegGUIToolStripMenuItem");
            this.關於FFmpegGUIToolStripMenuItem.Name = "關於FFmpegGUIToolStripMenuItem";
            // 
            // location
            // 
            resources.ApplyResources(this.location, "location");
            this.location.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.繁體中文ToolStripMenuItem});
            this.location.Name = "location";
            // 
            // 繁體中文ToolStripMenuItem
            // 
            resources.ApplyResources(this.繁體中文ToolStripMenuItem, "繁體中文ToolStripMenuItem");
            this.繁體中文ToolStripMenuItem.Name = "繁體中文ToolStripMenuItem";
            // 
            // listBox1
            // 
            resources.ApplyResources(this.listBox1, "listBox1");
            this.listBox1.AllowDrop = true;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Name = "listBox1";
            // 
            // output2
            // 
            resources.ApplyResources(this.output2, "output2");
            this.output2.Name = "output2";
            // 
            // output1
            // 
            resources.ApplyResources(this.output1, "output1");
            this.output1.Name = "output1";
            // 
            // output3
            // 
            resources.ApplyResources(this.output3, "output3");
            this.output3.Name = "output3";
            // 
            // comboBox1
            // 
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1")});
            this.comboBox1.Name = "comboBox1";
            // 
            // comboBox2
            // 
            resources.ApplyResources(this.comboBox2, "comboBox2");
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            resources.GetString("comboBox2.Items"),
            resources.GetString("comboBox2.Items1")});
            this.comboBox2.Name = "comboBox2";
            // 
            // Title
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.output3);
            this.Controls.Add(this.output1);
            this.Controls.Add(this.output2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Title";
            this.Load += new System.EventHandler(this.Title_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripDropDownButton File;
        private System.Windows.Forms.ToolStripMenuItem 開啟檔案ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 開啟目錄ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清除所有檔案ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 離開ToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton about;
        private System.Windows.Forms.ToolStripMenuItem 原始碼ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 協助翻譯ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 授權條款資訊ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 關於FFmpegGUIToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label output2;
        private System.Windows.Forms.Label output1;
        private System.Windows.Forms.Label output3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ToolStripDropDownButton location;
        private System.Windows.Forms.ToolStripMenuItem 繁體中文ToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

