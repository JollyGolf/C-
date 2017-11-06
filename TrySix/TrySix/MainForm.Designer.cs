/*
 * Created by SharpDevelop.
 * User: Никита
 * Date: 17.10.2017
 * Time: 10:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TrySix
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.PictureBox pictureBox2;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button2 = new System.Windows.Forms.Button();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(8, 201);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(439, 34);
			this.button1.TabIndex = 0;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(8, 9);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(238, 186);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(252, 9);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(195, 21);
			this.comboBox1.TabIndex = 2;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(272, 68);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(70, 20);
			this.textBox1.TabIndex = 3;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(369, 68);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(70, 20);
			this.textBox2.TabIndex = 4;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(272, 112);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(70, 20);
			this.textBox3.TabIndex = 5;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(369, 112);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(70, 20);
			this.textBox4.TabIndex = 6;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panel1.Location = new System.Drawing.Point(0, 241);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(462, 21);
			this.panel1.TabIndex = 7;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(1, 521);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(446, 35);
			this.button2.TabIndex = 8;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Location = new System.Drawing.Point(8, 268);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(439, 247);
			this.pictureBox2.TabIndex = 9;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox2MouseDown);
			this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox2MouseMove);
			this.pictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox2MouseUp);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(452, 568);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.button1);
			this.Name = "MainForm";
			this.Text = "TrySix";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
