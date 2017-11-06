/*
 * Created by SharpDevelop.
 * User: Никита
 * Date: 05.11.2017
 * Time: 16:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TryEight
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		void ListBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			textBox1.Text = listBox1.SelectedItem.ToString();
		}
		void Button1Click(object sender, EventArgs e)
		{
			string a = textBox2.Text;
			if (a == "") {
				MessageBox.Show("string - empty");
			}
			else {
				listBox1.Items.Add(a);
			}
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			int k = listBox1.Items.Count;
			textBox3.Text = k.ToString();
			System.Type w = listBox1.Items.GetType();
  			textBox4.Text = w.ToString();
  			int n = listBox1.Items.IndexOf("hello");
            textBox5.Text = n.ToString();
            string q = textBox6.Text;
            listBox1.Items.Insert(8, q);
		}
		void Button3Click(object sender, EventArgs e)
		{
			string r = textBox7.Text;
			listBox1.Items.Remove(r);
			int y = 8;
           	listBox1.Items.RemoveAt(y);
           	textBox8.Text = y.ToString();
		}
		void Button4Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
		}
		void Button5Click(object sender, EventArgs e)
		{
			string[] numbers ={"One","Two","Three","Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten" };
            listBox1.Items.AddRange(numbers);
		}
	}
}