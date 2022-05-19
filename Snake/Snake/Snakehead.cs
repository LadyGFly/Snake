using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    class Snakehead
    {
        private int headposX;//头的位置
        private int headposY;
        public float velocity = 0.35f;//速度


        public void GetKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)//暂停时不能使用
            {
                //暂停
            }
            /*if (Input.GetKeyUp(KeyCode.Space) && mainui.Instance.ispause == false && isdied == false)
            {
                //停止暂停
            }*/
            if (e.KeyCode == Keys.W)//不能向下
            {
                //向上移动
            }
            if (e.KeyCode == Keys.S)
            {

            }
            if (e.KeyCode == Keys.A)
            {

            }
            if (e.KeyCode == Keys.D)
            {

            }
        }

        public void BodyMove()
        {          
            
        }

        void Grow()
        {
            
        }

        void Died()
        {
            
        }

        void TriggerBody()
        {
            //碰到身体死亡
        }
    }
}
