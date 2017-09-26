/*
 * Created by SharpDevelop.
 * User: Никита
 * Date: 18.09.2017
 * Time: 20:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TryOne
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		void Button1Click(object sender, EventArgs e)
		{
			int x1 = 0;
			int y1 = 0;
			int x2 = 0;
			int y2 = 0;
			int Size = 0;
			int typeStyle = 0;
			if (!int.TryParse(textBox1.Text, out x1)) { MessageBox.Show("неправильное значение x1"); return; }
			if (!int.TryParse(textBox2.Text, out y1)) { MessageBox.Show("неправильное значение y1"); return; }
			if (!int.TryParse(textBox3.Text, out x2)) { MessageBox.Show("неправильное значение x2"); return; }
			if (!int.TryParse(textBox4.Text, out y2)) { MessageBox.Show("неправильное значение y2"); return; }
			if (!int.TryParse(comboBox1.Text, out Size)) { MessageBox.Show("неправильное значение Size"); return; }
			if (!int.TryParse(comboBox2.Text, out typeStyle)) { MessageBox.Show("неправильное значение typeStyle"); return; }
			Bitmap bmp = new Bitmap (pictureBox1.Width, pictureBox1.Height);
			Graphics graph = Graphics.FromImage(bmp);
			Pen pen = new Pen (Color.Red, Size);
			if (typeStyle == 1) { pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash; }
			if (typeStyle == 2) { pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot; }
			if (typeStyle == 3) { pen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot; }
			if (typeStyle == 4) { pen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot; }
			if (typeStyle == 5) { pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid; }
			Brush brushRec = Brushes.Blue;
			Brush brushEll = Brushes.Blue;
			graph.DrawRectangle(pen, x1, y1, x2, y2);
			graph.FillRectangle(Brushes.DarkBlue, x1, y1, x2, y2);
			graph.DrawEllipse(pen, x1, y1, x2, y2);
			graph.FillEllipse(Brushes.DarkMagenta, x1, y1, x2, y2);
			pictureBox1.Image = bmp;
		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
		void Button2Click(object sender, EventArgs e)
		{
		  string realTimeDate = DateTime.Now.ToString("dd MMMM yyyy | HH:mm:ss");
	      MessageBox.Show("Developer: Zhigamovsky Nikita" + "\n" + "Group: IN-53-7/1" + "\n" + "Practical Work: 1" + "\n" + "Date Time: " + realTimeDate);
		}
		void Button3Click(object sender, EventArgs e)
		{
			    Graphics g = pictureBox2.CreateGraphics();
    			int countX = pictureBox2.Width;
    			int countY = pictureBox2.Height/2;
    			PointF[] ptf = new PointF[countX];
    			// число волн
    			int countWave = 10;
    			// Очистим PictureBox
    			g.Clear(pictureBox2.BackColor);
    			for (int i = 0; i < countX; i++)
    			{
        			ptf[i].X = i;
        			ptf[i].Y= (float)(((countY / 2) * (1 - Math.Sin(i * countWave * Math.PI / (countX - 1)))));
    			}
    		g.DrawLines(Pens.Black, ptf);
    		g.Dispose();
		}
	}
}
