using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace dragonBallBudokai_projeto
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			nave.Parent = pictureBox1;
		}
		void Button1Click(object sender, EventArgs e)
		{
			nave.Left +=50;
			if (nave.Left > 816) 
			{
				pictureBox1.Load("Fundo2.png");
				nave.Left = 0;
			}
		}
		void Button2Click(object sender, EventArgs e)
		{
			nave.Left -=50;
		}
		void Button3Click(object sender, EventArgs e)
		{
			nave.Top -=10;
		}
		void Button4Click(object sender, EventArgs e)
		{
			nave.Top +=10;
		}
		
	}
}
