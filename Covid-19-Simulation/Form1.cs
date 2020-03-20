using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace Covid_19_Simulation
{
  


    public  struct Config
    {
        public static int ballSize=7;
        public static int speed=1;
        public static int timeToLive = 400;
        public static int time=0;
        public static int normalCount = 0;
        public static int infectedCount = 0;
        public static int recoveredCount = 0;
        public static int deadMax = -1;
        public static int noPopulation = 0;
        public static int noInfected = 0;
    }
    public partial class Form1 : Form
    {
        
        //private data
        Random rnd = new Random();
        Bitmap btm;
        Graphics g;
        Graphics scg;
        int[] socialDistance=new int[0];
        public Form1()
        {
            InitializeComponent();
        }
        List<Ball> ball = new List<Ball>();
        private void addPeopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //for create graphics
            btm = new Bitmap(panel1.Width, panel1.Height);
            g = Graphics.FromImage(btm);
            scg = this.panel1.CreateGraphics();

            Config.noPopulation = Convert.ToInt32(Interaction.InputBox("Enter the number of population \n Ratio (1:100000)", "Input Box", "200", -1, -1));
           
           //add population (we will represent each people by ball) 
            for (int i = 0; i < Config.noPopulation; i++)
            {
                ball.Add(new Ball()
                {
                rect = new Rectangle(rnd.Next(panel1.Width), rnd.Next(panel1.Height), Config.ballSize, Config.ballSize),
                X_Direction = getMoveDirection(),
                Y_Direction = getMoveDirection(),
                normal = true,
                TTL = Config.timeToLive
                });
            }

            //the timer used for animate balls
            mainTimer.Start();
            
            chart1.Titles.Clear();
            chart1.Titles.Add("Covid-19 infection over time");

        }
        private void addInfectedPeopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Config.noInfected = Convert.ToInt32(Interaction.InputBox("Enter the number of infected people", "Input Box", "1", -1, -1));
            
            for (int i = 0; i < Config.noInfected; i++)
            {
                ball.Add(new Ball()
                {
                    rect = new Rectangle(rnd.Next(panel1.Width), rnd.Next(panel1.Height), Config.ballSize, Config.ballSize),
                    X_Direction = getMoveDirection(),
                    Y_Direction = getMoveDirection(),
                    infected = true,
                    TTL = Config.timeToLive
                });
            }

            negativeTimer.Start();
        }
        private void addSocialDistanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int socialRatio = Convert.ToInt32(Interaction.InputBox("Enter the ratio of social distancing", "Input Box", "10", -1, -1));

            int numberOfStop = Config.noPopulation - Config.noPopulation / socialRatio;

            socialDistance = new int[numberOfStop];

            for (int i = 0; i < socialDistance.Length; i++)
            {
                socialDistance[i] = i;
            }
        }
        void draw()
        {
            g.Clear(Color.White);
            int idx = 0;
            foreach (var bal in ball)
            {
                idx++;
                drawBall(bal);
                if (bal.dead) { continue; }
                if (socialDistance.Length > 0&&socialDistance.Length>idx) { if (idx == socialDistance[idx]) { continue; } }
                if (bal.rect.X >= panel1.Width-Config.ballSize) { bal.X_Direction *= -1; };
                if (bal.rect.X <= Config.ballSize) { bal.X_Direction *= -1; };
                if (bal.rect.Y >= panel1.Height-Config.ballSize) { bal.Y_Direction *= -1; };
                if (bal.rect.Y <=Config.ballSize) { bal.Y_Direction *= -1; };

                bal.rect = new Rectangle(bal.rect.X + bal.X_Direction, bal.rect.Y + bal.Y_Direction, Config.ballSize,Config.ballSize);
            }
            check();
            scg.DrawImage(btm, 0, 0, this.panel1.Width, this.panel1.Height);
            
        }
        void drawBall(Ball ball)
        {
            if (ball.normal){ g.FillEllipse(Brushes.Gray, ball.rect); }
            if (ball.infected) { g.FillEllipse(Brushes.Red, ball.rect); }
            if (ball.recovered) { g.FillEllipse(Brushes.Orange, ball.rect); }
            if (ball.dead) { g.FillEllipse(Brushes.Black, ball.rect); }

        }
        void check()
        {
            Config.normalCount = 0;
            Config.infectedCount = 0;
            Config.recoveredCount = 0;
            for (int i = 0; i < ball.Count; i++)
            {
                if (ball[i].normal) { Config.normalCount++; }
                if (ball[i].infected||ball[i].recovered||ball[i].dead) { Config.infectedCount++; }
                if (ball[i].infected)
                {
                    ball[i].TTL -= 1;
                    for (int j = 0; j < ball.Count; j++)
                    {
                        if (ball[j].normal)
                        {
                            if (ball[i].rect.IntersectsWith(ball[j].rect))
                            {
                                ball[j].infected = true;
                                ball[j].normal = false;
                            }
                        }
                    }
                    //recovered
                    if (ball[i].TTL <= 0)
                    {
                        ball[i].infected = false;
                        ball[i].recovered = true;
                    }
                }
                if (ball[i].recovered) { Config.recoveredCount++; }
            }
        }
        void dead()
        {
                List<int> infectedIdx = new List<int>();
            int deadCount = 0;

                for (int i = 0; i < ball.Count; i++)
                {
                    if (ball[i].dead) { deadCount++; }
                    if (ball[i].infected) { infectedIdx.Add(i); }
                }
                int idx = Config.deadMax-deadCount;
                while (idx > 0)
                {
                    int id = rnd.Next(infectedIdx.Count);
                    id = infectedIdx[id];
                    ball[id].infected = false;
                    ball[id].dead = true;
                    idx--;
                }
           
        }
        int getMoveDirection()
        {
            if (rnd.Next(100) >= 50)
            {
                return -1 * Config.speed;
            }

            return 1 * Config.speed;
        }
        private void negativeTimer_Tick(object sender, EventArgs e)
        {

            Config.time++;
            int infectedCount = 0;
            int deadCount;

            foreach (var bal in ball)
            {

                if (bal.infected)
                {
                    infectedCount++;
                }

            }

            deadCount = Convert.ToInt32(infectedCount * (2.0 / 100.0));
            if (deadCount > Config.deadMax) { Config.deadMax = deadCount; dead(); }
            chart1.Series["Normal"].Points.AddXY(Config.time, Config.normalCount);
            chart1.Series["Infected"].Points.AddXY(Config.time, Config.infectedCount);
            chart1.Series["Recovered"].Points.AddXY(Config.time, Config.recoveredCount);
            chart1.Series["Dead"].Points.AddXY(Config.time, Config.deadMax);

            chart1.Series["Normal"].LegendText = "Normal (" + Config.normalCount.ToString() + ")";
            chart1.Series["Infected"].LegendText = "Infected (" + Config.infectedCount.ToString() + ")";
            chart1.Series["Recovered"].LegendText = "Recovered (" + Config.recoveredCount.ToString() + ")";
            chart1.Series["Dead"].LegendText = "Dead (" + Config.deadMax.ToString() + ")";

            lbl_InfectedPercentage.Text = "Infection percentage: " + Math.Round(((double)Config.infectedCount / (double)(Config.noPopulation + Config.noInfected)) * 100.0, 2).ToString() + "%";

            if (infectedCount <= 0)
            {
                draw();
                mainTimer.Stop();
                negativeTimer.Stop();
            }

        }
        private void mainTimer_Tick(object sender, EventArgs e)
        {

            draw();

            if (Config.noInfected>0)
            {
                

            }





        }
    }
}
