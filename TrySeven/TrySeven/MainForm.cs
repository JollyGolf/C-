/*
 * Created by SharpDevelop.
 * User: Никита
 * Date: 17.10.2017
 * Time: 10:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data;​​
using System.Drawing.Drawing2D;​​
using System.Text;​
using System.Windows.Forms;

namespace TrySeven
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			pen_for_draw.StartCap = pen_for_draw.EndCap=System.Drawing.Drawing2D.LineCap.Round;​
		}
		Bitmap bmp_for_draw;​
        Point start_point;​
        bool dozvil;
		Pen pen_for_draw = new Pen(Color.Black,4);​
        string full_name_of_image;
		void MainFormLoad(object sender, EventArgs e)
		{
			this.Text = "Edit image";​
            button1.Text = "View";​
            button2.Text = "Save";​
            button3.Text = "Refresh";
			Font = new System.Drawing.Font("Times New Roman",15,FontStyle.Italic);
			button4.Text = "Write";​
		}
		void Button1Click(object sender, EventArgs e)
		{
			OpenFileDialog open_dialog = new OpenFileDialog();​
            open_dialog.Filter = "Image Files(*.BMP,*.JPG,*.GIF,*.PNG)|*.bmp,*.jpg,*.gif,*.png|All Files(*.*)|*.*";​
            open_dialog.Filter = "Image Files(All Files(*.*)|*.*";​​
            if(open_dialog.ShowDialog()==DialogResult.OK)​
            {
				​try​
                {​
                    full_name_of_image = open_dialog.FileName;​
                    bmp_for_draw = new Bitmap(open_dialog.FileName);​
					this.pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;​
                    pictureBox1.Image = bmp_for_draw;​
                    pictureBox1.Invalidate();​
                }​
                catch​
                {​
  					DialogResult result = MessageBox.Show("It's impossible to open selected file");​
                }​
            }​
		}
		void Button2Click(object sender, EventArgs e)
		{
			if(pictureBox1.Image!=null)​
			{​
   				string format = full_name_of_image.Substring(full_name_of_image.Length-4,4);​
    			SaveFileDialog savedialog = new SaveFileDialog();​
    			savedialog.Title = "Зберегти як ...";​
    			savedialog.OverwritePrompt = true;​
    			savedialog.CheckFileExists = true;​
    			savedialog.ShowHelp = true;​
    			savedialog.Filter = "Image Files(All Files(*.*)|*.*";
				if(savedialog.ShowDialog()==DialogResult.OK)​
    			{​
        			try​
        			{​
 						bmp_for_draw.Save(savedialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);​​
        			}​
        			catch​
        			{​
            			MessageBox.Show("It's impossible to save image");​
        			}​
    			}​
			}​​
		}
		void Button3Click(object sender, EventArgs e)
		{
			Graphics g = pictureBox1.CreateGraphics();​
            g.Clear(SystemColors.Window);​
		}
		void PictureBox1MouseMove(object sender, MouseEventArgs e)
		{
			if(e.Button==MouseButtons.Left)​
			{​
    			using(Graphics g=Graphics.FromImage(pictureBox1.Image))​
    			{​
              		g.DrawLine(pen_for_draw,start_point,e.Location);​
         			start_point = e.Location;​
        			pictureBox1.Invalidate();​
   				}​
			}​
        }
		void PictureBox1MouseUp(object sender, MouseEventArgs e)
		{
			if(e.Button==MouseButtons.Left)​
            {​
                dozvil = false;​
            }​
		}
		void Button4Click(object sender, EventArgs e)
		{
			string text = String.Format("{0}",textBox1.Text);​
            Brush brushOne = new SolidBrush(Color.DarkRed);​
            Graphics g = pictureBox2.CreateGraphics();​
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;​
            g.DrawString(text,Font,brushOne,150,50);​
		}​
	}
}
