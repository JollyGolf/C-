/*
 * Created by SharpDevelop.
 * User: Никита
 * Date: 17.10.2017
 * Time: 10:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TrySix
{
	public partial class MainForm : Form
	{
		int[] p = new int[4];
		bool Dozvil;
		public MainForm()
		{
			InitializeComponent();
			
		}
		void MainFormLoad(object sender, EventArgs e)
		{
		comboBox1.Text = "Select Figure";
		button1.Text = "Paint figure!";
		button2.Text = "Refresh!";
        string [] Fig = { "Rectangle","Circle","Ellipse"};
        pictureBox1.BackColor = Color.Yellow;
        comboBox1.Items.AddRange(Fig);
		}
		void Button1Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "") { }
            else
            {
                p[0] = Convert.ToInt32(textBox1.Text);
                p[1] = Convert.ToInt32(textBox2.Text);
                p[2] = Convert.ToInt32(textBox3.Text);
                p[3] = Convert.ToInt32(textBox4.Text);
                pictureBox1.Refresh();
                Brush brush1 = Brushes.Blue;
                Graphics g = pictureBox1.CreateGraphics();

                switch (comboBox1.SelectedIndex)
                {
                    case 0: g.FillRectangle(brush1, p[0], p[1], p[2], p[3]); break;
                    case 1: g.FillEllipse(brush1, p[0], p[1], p[2], p[3]); break;
                    case 2: g.FillEllipse(brush1, p[0], p[1], p[2], p[3]); break;

                }
            }
		}
		void Button2Click(object sender, EventArgs e)
		{
			Graphics t = pictureBox2.CreateGraphics();
            t.Clear(SystemColors.Window);
		}
		void PictureBox2MouseDown(object sender, MouseEventArgs e)
		{
			Dozvil = true;
		}
		void PictureBox2MouseUp(object sender, MouseEventArgs e)
		{
			Dozvil = false;
		}
		void PictureBox2MouseMove(object sender, MouseEventArgs e)
		{
			Graphics t = pictureBox2.CreateGraphics();
            Brush brush2 = Brushes.Black;
            if (Dozvil == true)
            {
                t.FillEllipse(brush2, e.X, e.Y, 5, 5);
            }
		}
	}
}
