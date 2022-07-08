using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace Snake
{
    public partial class Logic : Form
    {
        public Logic()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = tBName.Text.Trim();  //取出用户名
            string password = EncryptWithMD5(tBpw.Text.Trim());  //取出密码并加密
            string myConnString = "Data Source=LAPTOP-RNL3U0EV;Initial Catalog=贪吃蛇用户数据库;User ID=sa;Password=123456";
            SqlConnection sqlConnection = new SqlConnection(myConnString);  //实例化连接对象
            sqlConnection.Open();
            string sql = "select username,PassWord from UserInfo where username = '" + username + "' and PassWord = '" + password + "'";
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                this.Hide();
                GameFace gameFace = new GameFace();
                gameFace.Show();
            }
            else
            {
                MessageBox.Show("账号密码有误，登录失败！");
                return;
            }
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartFace startFace = new StartFace();
            startFace.Show();
        }

        private void Logic_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.Show();
        }
        //密码加密方法
        private string EncryptWithMD5(string source)
        {
            byte[] sor = Encoding.UTF8.GetBytes(source);
            MD5 md5 = MD5.Create();
            byte[] result = md5.ComputeHash(sor);
            StringBuilder strbul = new StringBuilder(40);
            for (int i = 0; i < result.Length; i++)
            {
                strbul.Append(result[i].ToString("x2"));//加密结果"x2"结果为32位,"x3"结果为48位,"x4"结果为64位
            }
            return strbul.ToString();
        }
    }
}
