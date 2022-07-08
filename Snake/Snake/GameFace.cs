using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class GameFace : Form
    {
        public static GameFace gameFace; //静态调用gameFace
        Snake snake = new Snake();
        Door doorIn = new Door();
        Door doorOut = new Door();
        Wall wall = new Wall();
        Food food = new Food();
        Random random = new Random();
        IMake imake;
        int score = 0;
        public GameFace()
        {
            InitializeComponent();
            gameFace = this;
        }

        /// <summary>
        /// 点击Home按钮返回开始界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartFace startFace = new StartFace();
            startFace.Show();
        }
        //定义一个判断当前按钮是暂停还是继续游戏的变量(false为继续，true为暂停)
        bool fal = false;
        /// <summary>
        /// 切换暂停和继续按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox2_Click(object sender, EventArgs e)
        {   
            if(fal==false)
            {
                timer1.Enabled = false;
                this.pictureBox2.Image = Properties.Resources.Play;
                fal = true;
            }
            else
            {
                timer1.Enabled = true;
                this.pictureBox2.Image = Properties.Resources.Pause;
                fal = false;
            }
        }

        private void GameFace_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// 点击结束按钮时结束游戏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btOver_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// 加载游戏界面时的操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameFace_Load(object sender, EventArgs e)
        {


            //生成传送门
            doorIn.PBDoorIn = this.pBDoorIn;
            doorIn.createDoorIn(random);
            
            doorOut.PBDoorOut = this.pBDoorOut;
            doorOut.createDoorOut(random);

            //生成墙
            wall.PBwall = this.pBWall;
            imake = wall;
            imake.Make(random);


            //生成蛇
            snake.PBSnakeHead = this.pBSnakeHead;
            snake.SnakeMove();
            snake.Panelend = this.panelEnd;
            snake.Timer = this.timer1;


            //生成食物
            food.PBfood = this.pBfood;
            imake = food;
            imake.Make(random);
           

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            snake.SnakeMove();
            if (Math.Abs(snake.headposX - doorIn.DoorX) < 30 && Math.Abs(snake.headposY - doorIn.DoorY) < 30)
            {
                 snake.trans(doorOut.DoorX, doorOut.DoorY);
            }
               
            lbPoint.Text = lbScore.Text;
            if (Math.Abs(snake.headposX - wall.PosX) < 28 && Math.Abs(snake.headposY - wall.PosY) < 28)
            {
                snake.TriggerWall();
            }

            if(Math.Abs(snake.headposX - food.PosX)<30 && Math.Abs(snake.headposY - food.PosY) < 30)
            {
                imake = food;
                food.cancel();
                score += 5;
                this.lbScore.Text = score.ToString();
                imake.Make(random);

                //刷新墙和门的位置
                imake = wall;
                imake.cancel();
                imake.Make(random);
                doorIn.cancelDoorIn();
                doorOut.cancelDoorOut();
                doorIn.createDoorIn(random);
                doorOut.createDoorOut(random);
                
            }
        }

        private void GameFace_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                snake.key = 1;
            }
            if(e.KeyCode == Keys.A)
            {
                snake.key = 2;
            }
            if(e.KeyCode == Keys.S)
            {
                snake.key = 3;
            }
            if(e.KeyCode == Keys.D)
            {
                snake.key = 4;
            }
        }
    }
}
