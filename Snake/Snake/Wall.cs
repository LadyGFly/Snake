using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    class Wall:IMake
    {
        #region 字段
        int _posX;
        int _posY;
        Control _pBwall;

        public Control PBwall { get => _pBwall; set => _pBwall = value; }
        public int PosX { get => _posX; set => _posX = value; }
        public int PosY { get => _posY; set => _posY = value; }
        #endregion

        public void Make(Random random)
        {
            this._posX = random.Next(0, 300);
            this._posY = random.Next(0, 300);
            this.PBwall.Location = new System.Drawing.Point(this._posX, this._posY);
            this._pBwall.Visible = true;
        }

        public void cancel()
        {
            this._pBwall.Visible = false;
        }
    }
}
