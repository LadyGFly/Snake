using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Snake
{
    class Food:IMake
    {
        PictureBox _pBfood;
        int posX;
        int posY;

        public PictureBox PBfood { get => _pBfood; set => _pBfood = value; }
        public int PosX { get => posX; set => posX = value; }
        public int PosY { get => posY; set => posY = value; }


        //食物消失
        public void cancel()
        {
            this._pBfood.Visible = false;
        }

        //生成食物
        public void Make(Random random)
        {
            this.posX = random.Next(0, 300);
            this.posY = random.Next(0, 300);
            this.PBfood.Location = new System.Drawing.Point(this.posX, this.posY);
            this._pBfood.Visible = true;
        }
    }
}
