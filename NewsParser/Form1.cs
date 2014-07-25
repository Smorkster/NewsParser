
using System;
using System.Drawing;
using System.Windows.Forms;

namespace NewsParser
{
	public partial class Form1 : Form
	{
		public Form1(string s)
		{
			InitializeComponent();
			label1.Text = s;
		}
	}
}
