﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace ffmpeg_gui
{
    public partial class Title : Form
    {
        public Title()
        {
            InitializeComponent();
        }

        private void 離開ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Title_Load(object sender, EventArgs e)
        {
            listBox1.Width = (this.Width - 20);
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
        }

        private void 繁體中文ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("zh-TW");
        }
    }
}
