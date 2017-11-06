/*
 * Created by SharpDevelop.
 * User: Никита
 * Date: 03.10.2017
 * Time: 10:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TryFive
{
	public partial class MainForm : Form
	{
		int[]p = new int[4];
		int[]c = new int[6];
		int[]d = new int[4];
		bool dozvil = false;
		public MainForm()
		{
			InitializeComponent();
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			this.Text = "Paint the stroke";
			label3.Text="Input x and y";
			button1.Text="Paint this!";
			this.Text="Paint Triangle!";
			label6.Text="Input Coordinates three line";
			button2.Text="Paint";
			this.Text="Paint elips";
			label7.Text="Input Coordinates angles";
			button3.Text="Paint";
		}
		void Button1Click(object sender, EventArgs e)
		{
			p[0]=Convert.ToInt32(textBox1.Text);​
            p[1] = Convert.ToInt32(textBox2.Text);​
            p[2] = Convert.ToInt32(textBox3.Text);​
            p[3] = Convert.ToInt32(textBox4.Text);​
            pictureBox1.Refresh();​
		}
		void PictureBox1Paint(object sender, PaintEventArgs e)
		{
			pictureBox1.BackColor = Color.Blue;
			Pen pen1 = new Pen(Color.White);​
            e.Graphics.DrawLine(pen1,p[0],p[1],p[2],p[3]);​
		}
		void Button2Click(object sender, EventArgs e)
		{
			c[0] = Convert.ToInt32(textBox5.Text);​
            c[1] = Convert.ToInt32(textBox6.Text);​
            c[2] = Convert.ToInt32(textBox7.Text);​
            c[3] = Convert.ToInt32(textBox8.Text);​
            c[4] = Convert.ToInt32(textBox9.Text);​
            c[5] = Convert.ToInt32(textBox10.Text);​
            dozvil = true;​
            pictureBox2.Refresh();​
		}
		void PictureBox2Paint(object sender, PaintEventArgs e)
		{
			pictureBox2.BackColor = Color.YellowGreen;
			if (dozvil == true)​
            {​
                Pen pen2=new Pen(Color.Black);​
                e.Graphics.DrawLine(pen2,c[0],c[1],c[2], c[3]);​
                Pen pen3 = new Pen(Color.Red);​
                e.Graphics.DrawLine(pen3,c[2],c[3],c[4], c[5]);​
                Pen pen4 = new Pen(Color.White);​
                e.Graphics.DrawLine(pen4,c[4],c[5],c[0], c[1]);​
            }​
		}
		void Button3Click(object sender, EventArgs e)
		{
			d[0] = Convert.ToInt32(textBox11.Text);​
            d[1] = Convert.ToInt32(textBox12.Text);​
            d[2] = Convert.ToInt32(textBox13.Text);​
            d[3] = Convert.ToInt32(textBox14.Text);​
            pictureBox3.Refresh();​
		}
		void PictureBox3Paint(object sender, PaintEventArgs e)
		{
			pictureBox3.BackColor = Color.Yellow;​
            Pen pen5 = new Pen(Color.Red);​
            pen5.Width = 3;​
            e.Graphics.DrawEllipse(pen5,d[0],d[1],d[2],d[3]);​
		}
	}
}
