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
    public partial class Form1 : Form
    {
        Snakehead snakehead = new Snakehead();

        public Form1()
        {
            InitializeComponent();
            //snakehead.Move(head1);
        }

        private void Go_Click(object sender, EventArgs e)
        {
            Go.Visible = false;
        }

        private void head1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            
        }



        
    }
}
