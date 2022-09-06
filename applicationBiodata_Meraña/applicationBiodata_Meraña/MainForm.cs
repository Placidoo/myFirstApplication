
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace applicationBiodata_Meraña
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
			
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
			MessageBox.Show("My name is Joed Michael C. Meraña");
		}
		void Button2Click(object sender, EventArgs e)
		{
			MessageBox.Show("I am a Male.");
		}
		void Button3Click(object sender, EventArgs e)
		{
			MessageBox.Show("I am 19 years old.");
		}
		void Button4Click(object sender, EventArgs e)
		{
			MessageBox.Show("I live in Pangil Laguna, Philippines.");
		}
		void Button5Click(object sender, EventArgs e)
		{
			MessageBox.Show("I am currently taking Bachelor of Science in Computer Science 1A.");
		}
	}
}
