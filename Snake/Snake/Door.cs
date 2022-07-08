using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Snake
{
    class Door
    {
        #region 字段
        int _doorX;
        int _doorY;
        Control _pBDoorIn;
        Control _pBDoorOut;

        public Control PBDoorIn { get => _pBDoorIn; set => _pBDoorIn = value; }
        public Control PBDoorOut { get => _pBDoorOut; set => _pBDoorOut = value; }
        public int DoorX { get => _doorX; set => _doorX = value; }
        public int DoorY { get => _doorY; set => _doorY = value; }
        #endregion

        //创建门
        public void createDoorIn(Random random)
        {
            this._doorX = random.Next(0, 200);
            this._doorY = random.Next(0, 200);
            this._pBDoorIn.Location = new System.Drawing.Point(this._doorX, this._doorY);
            this._pBDoorIn.Visible = true;
        }
        //取消入口门
        public void cancelDoorIn()
        {
            this._pBDoorIn.Visible = false;
        }
        //创建出口门
        public void createDoorOut(Random random)
        {
            this._doorX = random.Next(200, 350);
            this._doorY = random.Next(200, 350);
            this._pBDoorOut.Location = new System.Drawing.Point(this._doorX, this._doorY);
            this._pBDoorOut.Visible = true;
        }
        //取消入口门
        public void cancelDoorOut()
        {
            this._pBDoorOut.Visible = false;
        }
    }
}
