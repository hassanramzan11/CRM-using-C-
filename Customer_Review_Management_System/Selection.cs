using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customer_Review_Management_System
{
	public partial class Selection : Form
	{
		public Selection()
		{
			InitializeComponent();
		}

		private void Selection_Load(object sender, EventArgs e)
		{

		}

		private void add_Click(object sender, EventArgs e)
		{
			Product main = new Product();
			main.Show();
			this.Hide();
		}

		private void dlt_Click(object sender, EventArgs e)
		{
			Delete delete = new Delete();
			delete.Show();
			this.Hide();
		}

		private void bck_Click(object sender, EventArgs e)
		{
			Login lgn = new Login();
			lgn.Show();
			this.Hide();
		}

		private void update_Click(object sender, EventArgs e)
		{
			Update upd = new Update();
			upd.Show();
			this.Hide();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			AllReviews A1=new AllReviews();
			A1.Show();
			this.Hide();
		}
	}
}
