using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Collections;

namespace Snake
{
    class Snake
    {
        public int headposX=394;//头的位置
        public int headposY=188;
        public int velocity = 5;//速度
        int n = 1; //身体的长度
        int bodyX; //身体的坐标
        int bodyY;
        ArrayList bodys;
        PictureBox _pBSnakeHead;
        Panel _panelend;
        public int key=0;
        Timer _timer;
        public PictureBox PBSnakeHead { get => _pBSnakeHead; set => _pBSnakeHead = value; }
        public Panel Panelend { get => _panelend; set => _panelend = value; }
        public Timer Timer { get => _timer; set => _timer = value; }

        //蛇出生
        public void snakeBorn()
        {
            PBSnakeHead.Image = Properties.Resources.sh02;
            PBSnakeHead.Location = new System.Drawing.Point(headposX, headposY);
        }

        //蛇移动
        public void SnakeMove()
        {
            PBSnakeHead.Image = null;
            if(key == 0)
            {
                headposX = headposX + velocity;
                bodyX = bodyX + velocity;
                snakeBorn();
            }
            if(key == 1)
            {
                headposY = headposY - velocity;
                bodyY = bodyY - velocity;
                snakeBorn();
            }
            if(key == 2)
            {
                headposX = headposX - velocity;
                bodyX = bodyX - velocity;
                snakeBorn();
            }
            if (key == 3)
            {
                headposY = headposY + velocity;
                bodyY = bodyY + velocity;
                snakeBorn();
            }
            if (key == 4)
            {
                headposX = headposX + velocity;
                bodyX = bodyX + velocity;
                snakeBorn();
            }
        }

        //蛇传送
        public void trans(int DoorOutX,int DoorOutY)
        {
         
            headposX = DoorOutX;
            headposY = DoorOutY;
        }

        public void Grow(Graphics g)
        {
            if (key == 0 || key == 2)
            {
                bodyX = headposX + n * this.PBSnakeHead.Width;
                bodyY = headposY;
            }
            if (key == 1)
            {
                bodyX = headposX;
                bodyY = headposY + n * this.PBSnakeHead.Height;
            }
            if (key == 3)
            {
                bodyX = this.headposX;
                bodyY = this.headposY - n * this.PBSnakeHead.Height;
            }
            if (key == 4)
            {
                bodyX = this.headposX - n * this.PBSnakeHead.Width;
                bodyY = this.headposY;
            }
            Brush brush = new SolidBrush(Color.Red);
            g.FillEllipse(brush, bodyX, bodyY, 20, 20);
            n++;
        }

        //撞到墙死亡
        public void TriggerWall()
        {
            this._timer.Enabled = false;
            this._panelend.Visible = true;
        }
    }
}
