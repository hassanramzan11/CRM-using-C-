using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customer_Review_Management_System
{
	public partial class AllReviews : Form
	{
		public AllReviews()
		{
			InitializeComponent();
		}

		private void ReviewTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}

		private void AllReviews_Load(object sender, EventArgs e)
		{
			string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=\"EAD Project DB\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				string query = "SELECT Product_Key, Product_Name FROM Product ";

				using (SqlCommand command = new SqlCommand(query, connection))
				{
					using (SqlDataAdapter adapter = new SqlDataAdapter(command))
					{
						DataTable dataTable = new DataTable();
						adapter.Fill(dataTable);

						review_grid1.DataSource = dataTable;
					}
				}
			}
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				string query = "SELECT * FROM CustomerReviews ";

				using (SqlCommand command = new SqlCommand(query, connection))
				{
					using (SqlDataAdapter adapter = new SqlDataAdapter(command))
					{
						DataTable dataTable = new DataTable();
						adapter.Fill(dataTable);

						review_grid.DataSource = dataTable;
					}
				}

			}

		}

		private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
		{

		}


		private void button1_Click_1(object sender, EventArgs e)
		{
			Selection slect = new Selection();
			slect.Show();
			this.Hide();
		}
	}
}
