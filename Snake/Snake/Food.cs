using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Food
    {
        //生成食物

        public void Makefood()
        {
            //普通食物
        }

        void MakeReward()
        {
            //神秘礼物
        }

        void MakeReward()
        {
            //陷阱
        }

        void TriggerFood()
        {
            //食物自身消失  
            //+5分
            //生成一个新食物
            //每次有百分之二十的概率生成神秘礼物/陷阱
        }

        void TriggerReward()
        {
            //神秘礼物自身消失  
            //+10~20分
        }

        void TriggerDemage()
        {
            //陷阱自身消失  
            //-15分
        }
    }
}
