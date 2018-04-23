using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraTabbedMdi;
using DevExpress.XtraEditors;

namespace WindowsFormsApplication24
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			for ( int i = 0; i < 4; i++ )
			{
				XtraForm xtraForm = new XtraForm();
				xtraForm.Text = "Doc " + (i + 1);
				xtraForm.MdiParent = this;
				xtraForm.Show();
			}
		}
	}
}