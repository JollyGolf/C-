/*
 * Created by SharpDevelop.
 * User: Никита
 * Date: 25.09.2017
 * Time: 20:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TryTwo
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		void Button1Click(object sender, EventArgs e)
		{
			Label1.Text = textBox1.Text;
		}
		private void textBox_1TextChanged(object sender, EventArgs e) 
		{
		}
		private void Form1_Load(object sender, EventArgs e) 
		{
			Label1.Text = "";
		}
		private void label1_Click(object sender, EventArgs e){
			
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			this.Text = "WOW!";
			label2.TextAlign = ContentAlignment.MiddleCenter;
			label2.Text = "Hover ERROR!";
			this.Text = "Example programming tooltip";
			Label3.Text = "Before click the button - input your name";
			button2.Text = "After input your name - click to me";
			toolTip1.SetToolTip(textBox2, "this stroke - for your name");
			toolTip1.IsBalloon = true;
		}
		void Label2MouseHover(object sender, EventArgs e)
		{
			label2.TextAlign = ContentAlignment.MiddleCenter;
			label2.ForeColor = Color.Blue;
			label2.Text = "REMEMBER ERROR!";
			MessageBox.Show("TextTextTextTextText","Wow, wth?",MessageBoxButtons.OK,MessageBoxIcon.Error);
		}
		void Button2Click(object sender, EventArgs e)
		{
			MessageBox.Show("Hello, "+textBox2.Text);
		}
	}
}
