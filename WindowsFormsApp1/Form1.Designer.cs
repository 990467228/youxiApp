namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonreplay = new System.Windows.Forms.Button();
            this.buttonsave = new System.Windows.Forms.Button();
            this.buttonload = new System.Windows.Forms.Button();
            this.buttonreview = new System.Windows.Forms.Button();
            this.trackBarspeed = new System.Windows.Forms.TrackBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keyBoardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replaytoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replayextendtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savetoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reviewtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exittoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.styletoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.style1toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.style2toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.style3toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.progressBarreview = new System.Windows.Forms.ProgressBar();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarspeed)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonreplay
            // 
            this.buttonreplay.Location = new System.Drawing.Point(290, 240);
            this.buttonreplay.Name = "buttonreplay";
            this.buttonreplay.Size = new System.Drawing.Size(75, 23);
            this.buttonreplay.TabIndex = 0;
            this.buttonreplay.Text = "重新开始";
            this.buttonreplay.UseVisualStyleBackColor = true;
            this.buttonreplay.Click += new System.EventHandler(this.buttonreplay_Click);
            // 
            // buttonsave
            // 
            this.buttonsave.Location = new System.Drawing.Point(290, 284);
            this.buttonsave.Name = "buttonsave";
            this.buttonsave.Size = new System.Drawing.Size(75, 23);
            this.buttonsave.TabIndex = 1;
            this.buttonsave.Text = "保存";
            this.buttonsave.UseVisualStyleBackColor = true;
            this.buttonsave.Click += new System.EventHandler(this.buttonsave_Click);
            // 
            // buttonload
            // 
            this.buttonload.Location = new System.Drawing.Point(290, 327);
            this.buttonload.Name = "buttonload";
            this.buttonload.Size = new System.Drawing.Size(75, 23);
            this.buttonload.TabIndex = 2;
            this.buttonload.Text = "载入";
            this.buttonload.UseVisualStyleBackColor = true;
            this.buttonload.Click += new System.EventHandler(this.buttonload_Click);
            // 
            // buttonreview
            // 
            this.buttonreview.Location = new System.Drawing.Point(290, 416);
            this.buttonreview.Name = "buttonreview";
            this.buttonreview.Size = new System.Drawing.Size(75, 23);
            this.buttonreview.TabIndex = 3;
            this.buttonreview.Text = "Re&View";
            this.buttonreview.UseVisualStyleBackColor = true;
            this.buttonreview.Click += new System.EventHandler(this.buttonreview_Click);
            // 
            // trackBarspeed
            // 
            this.trackBarspeed.Location = new System.Drawing.Point(290, 365);
            this.trackBarspeed.Maximum = 15;
            this.trackBarspeed.Minimum = 1;
            this.trackBarspeed.Name = "trackBarspeed";
            this.trackBarspeed.Size = new System.Drawing.Size(75, 45);
            this.trackBarspeed.TabIndex = 4;
            this.trackBarspeed.Value = 1;
            this.trackBarspeed.Scroll += new System.EventHandler(this.trackBarspeed_Scroll);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(382, 25);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.replaytoolStripMenuItem,
            this.replayextendtoolStripMenuItem,
            this.savetoolStripMenuItem,
            this.loadtoolStripMenuItem,
            this.reviewtoolStripMenuItem,
            this.exittoolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.fileToolStripMenuItem.Text = "文件";
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.styletoolStripMenuItem});
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.optionToolStripMenuItem.Text = "设置选项";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.keyBoardToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.helpToolStripMenuItem.Text = "游戏帮助";
            // 
            // keyBoardToolStripMenuItem
            // 
            this.keyBoardToolStripMenuItem.Name = "keyBoardToolStripMenuItem";
            this.keyBoardToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.keyBoardToolStripMenuItem.Text = "操作键";
            this.keyBoardToolStripMenuItem.Click += new System.EventHandler(this.keyBoardToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "关于";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // replaytoolStripMenuItem
            // 
            this.replaytoolStripMenuItem.Name = "replaytoolStripMenuItem";
            this.replaytoolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.replaytoolStripMenuItem.Text = "重新开始";
            this.replaytoolStripMenuItem.Click += new System.EventHandler(this.replaytoolStripMenuItem_Click);
            // 
            // replayextendtoolStripMenuItem
            // 
            this.replayextendtoolStripMenuItem.Name = "replayextendtoolStripMenuItem";
            this.replayextendtoolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.replayextendtoolStripMenuItem.Text = "继续开始";
            this.replayextendtoolStripMenuItem.Click += new System.EventHandler(this.replayextendtoolStripMenuItem_Click);
            // 
            // savetoolStripMenuItem
            // 
            this.savetoolStripMenuItem.Name = "savetoolStripMenuItem";
            this.savetoolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.savetoolStripMenuItem.Text = "保存";
            this.savetoolStripMenuItem.Click += new System.EventHandler(this.savetoolStripMenuItem_Click);
            // 
            // loadtoolStripMenuItem
            // 
            this.loadtoolStripMenuItem.Name = "loadtoolStripMenuItem";
            this.loadtoolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadtoolStripMenuItem.Text = "载入";
            this.loadtoolStripMenuItem.Click += new System.EventHandler(this.loadtoolStripMenuItem_Click);
            // 
            // reviewtoolStripMenuItem
            // 
            this.reviewtoolStripMenuItem.Name = "reviewtoolStripMenuItem";
            this.reviewtoolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reviewtoolStripMenuItem.Text = "review";
            this.reviewtoolStripMenuItem.Click += new System.EventHandler(this.reviewtoolStripMenuItem_Click);
            // 
            // exittoolStripMenuItem
            // 
            this.exittoolStripMenuItem.Name = "exittoolStripMenuItem";
            this.exittoolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exittoolStripMenuItem.Text = "exit";
            this.exittoolStripMenuItem.Click += new System.EventHandler(this.exittoolStripMenuItem_Click);
            // 
            // styletoolStripMenuItem
            // 
            this.styletoolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.style1toolStripMenuItem,
            this.style2toolStripMenuItem,
            this.style3toolStripMenuItem});
            this.styletoolStripMenuItem.Name = "styletoolStripMenuItem";
            this.styletoolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.styletoolStripMenuItem.Text = "style";
            this.styletoolStripMenuItem.Click += new System.EventHandler(this.styletoolStripMenuItem_Click);
            // 
            // style1toolStripMenuItem
            // 
            this.style1toolStripMenuItem.Name = "style1toolStripMenuItem";
            this.style1toolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.style1toolStripMenuItem.Text = "style1";
            // 
            // style2toolStripMenuItem
            // 
            this.style2toolStripMenuItem.Name = "style2toolStripMenuItem";
            this.style2toolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.style2toolStripMenuItem.Text = "style2";
            // 
            // style3toolStripMenuItem
            // 
            this.style3toolStripMenuItem.Name = "style3toolStripMenuItem";
            this.style3toolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.style3toolStripMenuItem.Text = "style3";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // progressBarreview
            // 
            this.progressBarreview.Location = new System.Drawing.Point(0, 459);
            this.progressBarreview.Name = "progressBarreview";
            this.progressBarreview.Size = new System.Drawing.Size(382, 23);
            this.progressBarreview.TabIndex = 6;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "036bcd4dece42b788e9c0f48bd6f6a66.jpg");
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "3383247befa06301a1dbff3b3aa5697f.jpg");
            // 
            // imageList3
            // 
            this.imageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList3.ImageStream")));
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList3.Images.SetKeyName(0, "fc76214c3a2607f335748aef508da7e9.jpg");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 482);
            this.Controls.Add(this.progressBarreview);
            this.Controls.Add(this.trackBarspeed);
            this.Controls.Add(this.buttonreview);
            this.Controls.Add(this.buttonload);
            this.Controls.Add(this.buttonsave);
            this.Controls.Add(this.buttonreplay);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarspeed)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonreplay;
        private System.Windows.Forms.Button buttonsave;
        private System.Windows.Forms.Button buttonload;
        private System.Windows.Forms.Button buttonreview;
        private System.Windows.Forms.TrackBar trackBarspeed;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replaytoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replayextendtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savetoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reviewtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exittoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem styletoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem style1toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem style2toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem style3toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keyBoardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ProgressBar progressBarreview;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ImageList imageList3;
    }
}

