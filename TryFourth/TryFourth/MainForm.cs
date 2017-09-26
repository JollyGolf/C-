/*
 * Created by SharpDevelop.
 * User: Никита
 * Date: 26.09.2017
 * Time: 10:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TryFourth
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			this.Text = "Calculate ∛";
			label1.Text = "∛";
			label2.Text = "Input number and click the button";
			this.Text = "Only number!";
			label1.Text = "Input only number!";
			button2.Text="Calculate!";
			label4.Text = "x^2+ ";​
            label5.Text = "X +";​
            label6.Text = "=0";​
            label7.Text = "Введіть коефіцієнти a b c";​
            label8.Text = "";​
            label9.Text = "";​
            label10.Text = "";​
		}
		void Button1Click(object sender, EventArgs e)
		{
			label2.Text = "Input the number";
			string s;
			double x, y;
			try {
				s = textBox1.Text;
				x = Convert.ToDouble(s);
			}
			catch(FormatException) {
			      	label3.Text = "Input only number!";
			      	return;
			      }
			      y = Math.Pow(x,1.0/3.0);
			      label3.Text = '='+y.ToString();
		}
		void TextBox2KeyPress(object sender, KeyPressEventArgs e)
		{
			if(char.IsDigit(e.KeyChar) == true) return;
			if(e.KeyChar ==(char)Keys.Back) return;
			if(e.KeyChar==',') return;
			e.Handled = true;
		}
		void TextBox5KeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsDigit(e.KeyChar) == true) return;​
            if (e.KeyChar == (char)Keys.Back) return;​
            if (e.KeyChar == ',') return;​
            e.Handled = true;​
		}
		void TextBox6KeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsDigit(e.KeyChar) == true) return;​
            if (e.KeyChar == (char)Keys.Back) return;​
            if (e.KeyChar == ',') return;​
            e.Handled = true;​​
		}
		void TextBox7KeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsDigit(e.KeyChar) == true) return;​
            if (e.KeyChar == (char)Keys.Back) return;​
            if (e.KeyChar == ',') return;​
            e.Handled = true;​​
		}
		void Button2Click(object sender, EventArgs e)
		{
			double a, b, c;​
            string s;​
            s = textBox5.Text;​
            a = Convert.ToDouble(s);​
            s = textBox4.Text;​
            b = Convert.ToDouble(s);​
            s = textBox3.Text;​
            c = Convert.ToDouble(s);
			double y, z, f, m, k, D=0;​
            if (a == 0) { MessageBox.Show("If a==0 result empty!");​ }​
            D = b * b - 4 * a * c;​
            if (D >= 0) {​
                y = (-b + Math.Sqrt(D)) / (2 * a);​
                z = (-b - Math.Sqrt(D)) / (2 * a);​
                label8.Text = String.Format("SQRT:x1={0} x2={1}", y, z);​
                label9.Text = String.Format("D={0}", D);
			}
			else {​
            f = -1 * D;​
            k=Math.Sqrt(f)/(2*a);​
            m=(-b)/(2*a);​
			label9.Text = String.Format("x1={0,5:F3}+{1,5:F3}*i x2={2,5:F3}-{3,5:F3}*i", m, k , m, k);​
			label10.Text = String.Format("D={0}",   D);​
            }​​​​
		}
	}
}
