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
    public partial class StartFace : Form
    {
        Snake snakehead = new Snake();

        public StartFace()
        {
            InitializeComponent();
            //snakehead.Move(head1);
        }

        private void Go_Click(object sender, EventArgs e)
        {
            this.Hide();
            //登录
            Logic logic = new Logic();
            logic.Show();
        }

        private void head1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            
        }

        private void StartFace_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
