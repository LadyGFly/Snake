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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "" && textBox2.Text.Trim() != ""
                && comboBox1.Text.Trim() != "" && textBox3.Text.Trim() != "")
            {
                try
                {
                    //数据库连接字符串ser 
                    string connString = "Data Source=LAPTOP-RNL3U0EV;Initial Catalog=贪吃蛇用户数据库;User ID=sa;Password=123456";
                    SqlConnection connection = new SqlConnection(connString);//创建connection对象
                    string username = textBox1.Text.Trim();  //取出账号
                    string sex = comboBox1.Text.Trim();  //取出性别
                    connection.Open();
                    //查询UserInfo中是否存在该用户
                    string sql1 = "select username from UserInfo where username = '" + username+"'";
                    SqlCommand sqlCommand1 = new SqlCommand(sql1, connection);
                    SqlDataReader sqlDataReader1 = sqlCommand1.ExecuteReader();
                    if (!sqlDataReader1.HasRows)
                    {
                        string sql3 = "insert into UserInfo (username,PassWord ,Sex, userBirthday,UserMobile) " +
                                      "values (@username, @userpassword,@sex,@userBirthday,@usermobile)";
                        SqlCommand command = new SqlCommand(sql3, connection);
                        SqlParameter sqlParameter = new SqlParameter("@username", textBox1.Text);
                        command.Parameters.Add(sqlParameter);
                        sqlParameter = new SqlParameter("@userpassword", EncryptWithMD5(textBox2.Text));
                        command.Parameters.Add(sqlParameter);
                        sqlParameter = new SqlParameter("@sex", comboBox1.Text);
                        command.Parameters.Add(sqlParameter);
                        sqlParameter = new SqlParameter("@usermobile", textBox3.Text);
                        command.Parameters.Add(sqlParameter);
                        sqlParameter = new SqlParameter("@userBirthday", dateTimePicker1.Value);
                        command.Parameters.Add(sqlParameter);
                        sqlDataReader1.Close();
                        //打开数据库连接
                        command.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("注册成功");
                        this.Hide();
                        Logic logic = new Logic();
                        logic.Show();
                    }
                    else
                    {
                        MessageBox.Show("该用户已经存在");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
               MessageBox.Show("请将信息填写完整！");
            }
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Logic logic = new Logic();
            logic.Show();
        }
    }
}
