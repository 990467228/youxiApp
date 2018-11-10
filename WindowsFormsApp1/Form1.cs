using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private youxiControl youxiConttrol = new youxiControl();
        private youxiNext youxiNext = new youxiNext();
        private youxiScore youxiScore = new youxiScore();
        public Form1()
        {
            InitializeComponent();
            youxiConttrol.Top = menuStrip1.Height + 2;
            youxiConttrol.Left = 2;
            youxiConttrol.Parent = this;
            youxiNext.Top = youxiConttrol.Top;
            youxiNext.Left = youxiConttrol.Left + youxiConttrol.Width + 4;
            youxiConttrol.youxiNext = youxiNext;
            youxiScore.Parent = this;
            youxiScore.Top = youxiNext.Top + youxiNext.Height + 4;
            youxiScore.Left = youxiNext.Left;
            youxiConttrol.youxiScore = youxiScore;
            style1toolStripMenuItem.Image = imageList1.Images[0];
            style2toolStripMenuItem.Image = imageList2.Images[0];
            style3toolStripMenuItem.Image = imageList3.Images[0];
            youxiConttrol.progressBar = progressBarreview;
            openFileDialog1.FileName = Path.GetDirectoryName(Application.ExecutablePath) + @"\simple.trf";
            saveFileDialog1.FileName = Path.GetDirectoryName(Application.ExecutablePath) + @"\simple.trf";
        }

        private void trackBarspeed_Scroll(object sender, EventArgs e)
        {
            //youxiConttrol.reviewSpeed = trackBarReviewSpeed.Value;
        }

        private void buttonreview_Click(object sender, EventArgs e)
        {
            youxiConttrol.Review(true, false);
        }

        private void buttonload_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;
            if (!File.Exists(openFileDialog1.FileName)) return;
            youxiControl.LoadFromFile(openFileDialog1.FileName);
        }

        private void buttonsave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;
            if (Path.GetExtension(saveFileDialog1.FileName) == string.Empty)
                saveFileDialog1.FileName = Path.ChangeExtension(saveFileDialog1.FileName, ".trf");
            //youxiControl.SaveToFile(saveFileDialog1.FileName);
        }

        private void buttonreplay_Click(object sender, EventArgs e)
        {
            //youxiConttrol.Replay(true, false);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void replaytoolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonreplay_Click(buttonreplay, new EventArgs());
        }

        private void savetoolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonsave_Click(buttonsave, new EventArgs());
        }

        private void loadtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonload_Click(buttonload, new EventArgs());
        }

        private void reviewtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonreview_Click(buttonreview, new EventArgs());
        }

        private void exittoolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void keyBoardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("左移：Left、A\r\n右移：Right、D\r\n下移：Down、S\r\n变换：Up、W\r\n变化：Back、F\r\n直下：Space、J、Enter", "按键说明");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("俄罗斯方块\r\n设计：wech\r\n日期：2018-11-04\r\n联系：XXXXXXXXXXX", "关于本程序");
        }

        private void styletoolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sender == style1toolStripMenuItem)
                youxiConttrol.imageList = imageList1;
            else if (sender == style2toolStripMenuItem)
                youxiConttrol.imageList = imageList2;
            else if (sender == style3toolStripMenuItem)
                youxiConttrol.imageList = imageList3;
        }

        private void replayextendtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            youxiConttrol.Replay(true, true);
        }
    }
}
