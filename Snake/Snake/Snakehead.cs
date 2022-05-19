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
        public int step;
        private int x, y;
        private int headposX;//头的位置
        private int headposY;

        public float velocity = 0.35f;//速度

        void Start()
        {
            //InvokeRepeating("Move", 0, velocity);
            x = 0;
            y = step;
        }

        private void KeyDown(object sender, KeyEventArgs e)
        {
            string key = Console.ReadKey().Key.ToString();
            if (key == " " && mainui.Instance.ispause == false && isdied == false)//暂停时不能使用
            {
                //暂停
            }
            if (Input.GetKeyUp(KeyCode.Space) && mainui.Instance.ispause == false && isdied == false)
            {
                //停止暂停
            }

            if (key == "w" && y != -step && mainui.Instance.ispause == false && isdied == false)//不能向下
            {
                x = 0;
                y = step;
            }
            if (key == "s" && y != step && mainui.Instance.ispause == false && isdied == false)
            {
                x = 0;
                y = -step;
            }
            if (key == "a" && x != step && mainui.Instance.ispause == false && isdied == false)
            {
                y = 0;
                x = -step;
            }
            if (key == "d" && x != -step && mainui.Instance.ispause == false && isdied == false)
            {
                //gameObject.transform.localRotation = Quaternion.Euler(0, 0, -90);
                y = 0;
                x = step;
            }
        }

        void Move(PictureBox head1)
        {          
            //头移动
            headposX = head1.Location.X;
            headposY = head1.Location.Y;
            
        }

        void Grow()
        {
            
        }

        void Died()
        {
            
        }

        void TriggerBody()
        {
            //死亡
        }
    }
}
