using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

public class youxiNext : Control
{
    internal void Update(youxiControl youxiControl)
    {
        throw new NotImplementedException();
    }
}

public class youxiScore : Control
{
    internal void Update(youxiControl youxiControl)
    {
        throw new NotImplementedException();
    }
}

public class youxiControl : Control
{
    private const int rowCount = 21;                  //行数
    private const int colCount = 11;                  //列数
    private int brickWidth = 16;                      //小块宽度
    private int brickHeight = 16;                     //小块高度
    private Bitmap backBitmap;                        //背景图片
    private List<List<List<Point>>> brickTemplets = new List<List<List<Point>>>();      //方块模板【模板序号，朝向】
    private byte[,] points = new byte[colCount, rowCount];      //点阵
    private byte brickIndex = 0;                      //模板序号
    private byte facingIndex = 0;                     //当前变化号 
    private Point brickPoint = new Point();           //方块的位子
    private byte afterBrickIndex = 0;                 //下一模板序号
    private byte afterFacingIndex = 0;                //下一变化号
    private System.Windows.Forms.Timer Timer;         //控制下落的定时器
    private int lines;                                //消行数
    private Random random = new Random();             //随机数
    private int level;                                //当前速度
    private int score;                                //当前成绩
    // 下落速度，数值表示每次下落的时间差，以毫秒为单位
    private int[] speeds = new int[] { 700, 500, 400, 300, 320, 320, 100, 80, 70, 60, 50 };
    //每次消除行所增加的积分
    private int[] scoress = new int[] { 0001, 0100, 0300, 0500, 1000, 3200 };
    private bool playing = false;                     //玩家是否在游戏
    private int stepIndex = -1;
    private bool reviewing = false;
    private Thread threadReview = null;
    private int reviewSpeed = 1;
    private List<StepInfo> StepInfos = new List<StepInfo>();
    private int lastRecordTime = 0;
    private bool recordMode = false;
    private bool extended = false;
    public ImageList imageList;                      //方块素材
    public youxiNext youxiNext;                      //下一方块的显示控件
    public youxiScore youxiScore;                    //显示控件
    public ProgressBar progressBar;
    public int Lines { get { return lines; } }
    public int Score { get { return score; } }
    public enum BrickOperates
    {
        boMoveLeft = 0,
        boMoveRight = 0,
        boMoveDown = 0,
        boMoveBottom = 0,
        boTurnLeft = 0,
        boTurnRight = 0
    }
    public void Review(bool v1, bool v2)
    {
        if (threadReview != null)
        {
            threadReview.Abort();
            threadReview = null;
        }
        Timer.Enabled = false;
        reviewing = true;
        playing = true;
        Clear();
        level = 0;
        score = 0;
        lines = 0;
        stepIndex = 0;
        NextStep();
        NextStep();
        if (progressBar != null)
            progressBar.Maximum = StepInfos.Count;
        threadReview = new Thread(new ThreadStart(DoReview));
        threadReview.Start();
    }

    private void DoReview()
    {
        while(reviewing)
        {
            if (stepIndex < 0 || stepIndex >= StepInfos.Count)
            {
                reviewing = false;
                break;
            }
            Thread.Sleep((int)((double)StepInfos[stepIndex].timeTick / reviewSpeed));
            if (!reviewing) break;

            Invoke(new EventHandler(DoInvoke));
        }
        Invoke(new EventHandler(DoInvoke)); ;
        threadReview = null;
    }

    private void DoInvoke(object sender, EventArgs e)
    {
        throw new NotImplementedException();
    }

    private void NextStep()
    {
        throw new NotImplementedException();
    }

    public void Replay(bool ARecordMode, bool AExtended)
    {
        if (threadReview != null)
        {
            threadReview.Abort();
            threadReview = null;
        }
        if (AExtended != extended)
        {
            NewTemplets(AExtended);
        }
        reviewing = false;
        playing = true;
        recordMode = ARecordMode;
        Clear();
        StepInfos.Clear();
        afterBrickIndex = (byte)random.Next(brickTemplets.Count);
        afterFacingIndex = (byte)random.Next(brickTemplets[afterBrickIndex].Count);
        if (youxiNext != null) youxiNext.Update(this);
        if (recordMode && !reviewing)
        {
            StepInfos.Add(new StepInfo(0, 0, afterBrickIndex, afterFacingIndex));
            lastRecordTime = Environment.TickCount;
        }
        level = 0;
        score = 0;
        lines = 0;
        stepIndex = -1;
        if (progressBar != null) progressBar.Value = 0;
        NextBrick();
        Timer.Interval = speeds[level];
        Timer.Enabled = true;
        if (youxiScore != null) youxiScore.Update(this);
        if (CanFocus) Focus();
    }

    private void NextBrick()
    {
        throw new NotImplementedException();
    }

    private void Clear()
    {
        throw new NotImplementedException();
    }

    private void NewTemplets(bool aExtended)
    {
        throw new NotImplementedException();
    }


    public class StepInfo
    {
        internal double timeTick;

        public StepInfo(int v1, int v2, byte afterBrickIndex, byte afterFacingIndex)
        {
        }
    }
    public void LoadFromFile(string fileName)
    {
        if (!File.Exists(fileName)) return;
        FileStream vFileSteam = new FileStream(fileName, FileMode.Open, FileAccess.Read);
        LoadFromSteam(vFileSteam);
        vFileSteam.Close();
    }
    /// 从流中载入玩家操作记录
    /// 
    /// </summary>
    /// <param name="vFileSteam"></param>
    private void LoadFromSteam(FileStream ASteam)
    {
        if (ASteam == null) return;
        byte[] vBuffer = new byte[3];
        if ()
    }
}
