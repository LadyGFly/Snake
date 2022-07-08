
namespace Snake
{
    partial class GameFace
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btOver = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbScore = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelEnd = new System.Windows.Forms.Panel();
            this.lbPoint = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDie = new System.Windows.Forms.Label();
            this.pBWall = new System.Windows.Forms.PictureBox();
            this.pBDoorOut = new System.Windows.Forms.PictureBox();
            this.pBDoorIn = new System.Windows.Forms.PictureBox();
            this.pBSnakeHead = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pBfood = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelEnd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBDoorOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBDoorIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSnakeHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBfood)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btOver);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbScore);
            this.panel1.Controls.Add(this.lb1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 426);
            this.panel1.TabIndex = 0;
            // 
            // btOver
            // 
            this.btOver.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btOver.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btOver.Location = new System.Drawing.Point(28, 348);
            this.btOver.Name = "btOver";
            this.btOver.Size = new System.Drawing.Size(95, 47);
            this.btOver.TabIndex = 4;
            this.btOver.Text = "结束游戏";
            this.btOver.UseVisualStyleBackColor = false;
            this.btOver.Click += new System.EventHandler(this.btOver_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Snake.Properties.Resources.Play;
            this.pictureBox2.Location = new System.Drawing.Point(92, 245);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(61, 56);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Snake.Properties.Resources.Home;
            this.pictureBox1.Location = new System.Drawing.Point(7, 245);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScore.Location = new System.Drawing.Point(85, 109);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(38, 40);
            this.lbScore.TabIndex = 1;
            this.lbScore.Text = "0";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb1.Location = new System.Drawing.Point(3, 121);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(82, 24);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "得分：";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pBfood);
            this.panel2.Controls.Add(this.panelEnd);
            this.panel2.Controls.Add(this.pBWall);
            this.panel2.Controls.Add(this.pBDoorOut);
            this.panel2.Controls.Add(this.pBDoorIn);
            this.panel2.Controls.Add(this.pBSnakeHead);
            this.panel2.Location = new System.Drawing.Point(187, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(817, 426);
            this.panel2.TabIndex = 1;
            // 
            // panelEnd
            // 
            this.panelEnd.Controls.Add(this.lbPoint);
            this.panelEnd.Controls.Add(this.label1);
            this.panelEnd.Controls.Add(this.lbDie);
            this.panelEnd.Location = new System.Drawing.Point(249, 122);
            this.panelEnd.Name = "panelEnd";
            this.panelEnd.Size = new System.Drawing.Size(313, 160);
            this.panelEnd.TabIndex = 4;
            this.panelEnd.Visible = false;
            // 
            // lbPoint
            // 
            this.lbPoint.AutoSize = true;
            this.lbPoint.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbPoint.Location = new System.Drawing.Point(209, 108);
            this.lbPoint.Name = "lbPoint";
            this.lbPoint.Size = new System.Drawing.Size(25, 25);
            this.lbPoint.TabIndex = 2;
            this.lbPoint.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(75, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "最终得分：";
            // 
            // lbDie
            // 
            this.lbDie.AutoSize = true;
            this.lbDie.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDie.ForeColor = System.Drawing.Color.Chocolate;
            this.lbDie.Location = new System.Drawing.Point(120, 47);
            this.lbDie.Name = "lbDie";
            this.lbDie.Size = new System.Drawing.Size(63, 30);
            this.lbDie.TabIndex = 0;
            this.lbDie.Text = "死亡";
            // 
            // pBWall
            // 
            this.pBWall.Image = global::Snake.Properties.Resources.wall;
            this.pBWall.Location = new System.Drawing.Point(249, 310);
            this.pBWall.Name = "pBWall";
            this.pBWall.Size = new System.Drawing.Size(46, 48);
            this.pBWall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBWall.TabIndex = 3;
            this.pBWall.TabStop = false;
            // 
            // pBDoorOut
            // 
            this.pBDoorOut.Image = global::Snake.Properties.Resources.DoorOut;
            this.pBDoorOut.Location = new System.Drawing.Point(589, 98);
            this.pBDoorOut.Name = "pBDoorOut";
            this.pBDoorOut.Size = new System.Drawing.Size(45, 48);
            this.pBDoorOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBDoorOut.TabIndex = 2;
            this.pBDoorOut.TabStop = false;
            // 
            // pBDoorIn
            // 
            this.pBDoorIn.Image = global::Snake.Properties.Resources.DoorIn;
            this.pBDoorIn.Location = new System.Drawing.Point(116, 146);
            this.pBDoorIn.Name = "pBDoorIn";
            this.pBDoorIn.Size = new System.Drawing.Size(27, 66);
            this.pBDoorIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBDoorIn.TabIndex = 1;
            this.pBDoorIn.TabStop = false;
            // 
            // pBSnakeHead
            // 
            this.pBSnakeHead.Image = global::Snake.Properties.Resources.sh02;
            this.pBSnakeHead.Location = new System.Drawing.Point(394, 188);
            this.pBSnakeHead.Name = "pBSnakeHead";
            this.pBSnakeHead.Size = new System.Drawing.Size(36, 35);
            this.pBSnakeHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBSnakeHead.TabIndex = 0;
            this.pBSnakeHead.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pBfood
            // 
            this.pBfood.Image = global::Snake.Properties.Resources.icecream_10;
            this.pBfood.Location = new System.Drawing.Point(635, 288);
            this.pBfood.Name = "pBfood";
            this.pBfood.Size = new System.Drawing.Size(53, 53);
            this.pBfood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBfood.TabIndex = 5;
            this.pBfood.TabStop = false;
            // 
            // GameFace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "GameFace";
            this.Text = "GameFace";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameFace_FormClosing);
            this.Load += new System.EventHandler(this.GameFace_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameFace_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panelEnd.ResumeLayout(false);
            this.panelEnd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBDoorOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBDoorIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSnakeHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBfood)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pBSnakeHead;
        private System.Windows.Forms.Button btOver;
        public System.Windows.Forms.PictureBox pBDoorIn;
        public System.Windows.Forms.PictureBox pBDoorOut;
        public System.Windows.Forms.PictureBox pBWall;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbPoint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbDie;
        public System.Windows.Forms.Panel panelEnd;
        public System.Windows.Forms.PictureBox pBfood;
    }
}