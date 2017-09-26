/*
 * Created by SharpDevelop.
 * User: Никита
 * Date: 25.09.2017
 * Time: 20:49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TryThird
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			this.Text = "Initial";
			label2.Text = textBox1.Text;
			this.Text = "Write the password";
			textBox2.PasswordChar='*';
			textBox2.TextAlign = HorizontalAlignment.Center;
			button2.Text = "WRITE";
			this.Text = "Photo";
			label3.Text = "";
			comboBox1.Text = "List";
		}
		void Button1Click(object sender, EventArgs e)
		{
			label2.Text = textBox1.Text;
		}
		void Button2Click(object sender, EventArgs e)
		{
			MessageBox.Show(textBox2.Text, "You write ");
		}
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (comboBox1.SelectedIndex) {
					case 0:pictureBox4.Image = Image.FromFile("d:\\Img\\photo.jpg");
					label3.Text = "Photo numb 1";
					break;
					case 1:pictureBox4.Image = Image.FromFile("d:\\Img\\photo2.png");
					label3.Text = "Photo numb 2";
					break;
					case 2:pictureBox4.Image = Image.FromFile("d:\\Img\\photo3.jpg");
					label3.Text = "Photo numb 3";
					break;
					case 3:pictureBox4.Image = Image.FromFile("d:\\Img\\photo4.png");
					label3.Text = "Photo numb 4";
					break;
			}
		}
	}
}
